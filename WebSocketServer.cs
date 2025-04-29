using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.IO;
using Fleck;
using Neurotec.Biometrics;
using Neurotec.Biometrics.Client;
using Neurotec.Devices;
using Neurotec.Images;
using Neurotec.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Neurotec.Samples
{
    public class FingerprintWebSocketServer
    {
        private WebSocketServer _wsServer;
        private List<IWebSocketConnection> _sockets;
        private NBiometricClient _biometricClient;
        private NDeviceManager _deviceManager;
        private FaceRecognition _faceRecognition;

        public FingerprintWebSocketServer(string location = "ws://0.0.0.0:8181")
        {
            _sockets = new List<IWebSocketConnection>();
            _wsServer = new WebSocketServer(location);
            InitializeBiometricClient();
            _faceRecognition = new FaceRecognition();
        }

        private void InitializeBiometricClient()
        {
            _biometricClient = new NBiometricClient();
            _deviceManager = new NDeviceManager();
            _deviceManager.DeviceTypes = NDeviceType.FScanner;
            _deviceManager.Initialize();
        }

        public void Start()
        {
            _wsServer.Start(socket =>
            {
                socket.OnOpen = () =>
                {
                    Console.WriteLine("Client connected");
                    _sockets.Add(socket);
                };

                socket.OnClose = () =>
                {
                    Console.WriteLine("Client disconnected");
                    _sockets.Remove(socket);
                };

                socket.OnMessage = message =>
                {
                    HandleMessage(socket, message);
                };
            });
        }

        private async void HandleMessage(IWebSocketConnection socket, string message)
        {
            try
            {
                var command = JsonConvert.DeserializeObject<WebSocketCommand>(message);
                
                switch (command.Action)
                {
                    case "getScanners":
                        await SendScannersList(socket);
                        break;
                    case "startScan":
                        var scanData = JObject.Parse(JsonConvert.SerializeObject(command.Data));
                        var scannerId = scanData["scannerId"]?.ToString();
                        if (string.IsNullOrEmpty(scannerId))
                        {
                            throw new ArgumentException("scannerId is required");
                        }
                        await StartScanning(socket, scannerId);
                        break;
                    case "stopScan":
                        StopScanning();
                        break;
                    case "compareImages":
                        var imageData = JObject.Parse(JsonConvert.SerializeObject(command.Data));
                        var image1 = imageData["image1"]?.ToString();
                        var image2 = imageData["image2"]?.ToString();
                        if (string.IsNullOrEmpty(image1) || string.IsNullOrEmpty(image2))
                        {
                            throw new ArgumentException("Both image1 and image2 are required");
                        }
                        await CompareImages(socket, image1, image2);
                        break;
                    case "captureFace":
                        await CaptureFace(socket);
                        break;
                    case "compareFaces":
                        var faceData = JObject.Parse(JsonConvert.SerializeObject(command.Data));
                        var face1 = faceData["face1"]?.ToString();
                        var face2 = faceData["face2"]?.ToString();
                        if (string.IsNullOrEmpty(face1) || string.IsNullOrEmpty(face2))
                        {
                            throw new ArgumentException("Both face1 and face2 are required");
                        }
                        await CompareFaces(socket, face1, face2);
                        break;
                }
            }
            catch (Exception ex)
            {
                socket.Send(JsonConvert.SerializeObject(new { error = ex.Message }));
            }
        }

        private async Task CompareImages(IWebSocketConnection socket, string image1Base64, string image2Base64)
        {
            try
            {
                // Convertir les images base64 en NImage
                var image1Bytes = Convert.FromBase64String(image1Base64);
                var image2Bytes = Convert.FromBase64String(image2Base64);

                NImage nImage1, nImage2;
                using (var stream1 = new NBuffer(image1Bytes))
                using (var stream2 = new NBuffer(image2Bytes))
                {
                    nImage1 = NImage.FromMemory(stream1);
                    nImage2 = NImage.FromMemory(stream2);
                }

                // Créer les sujets avec les images
                var subject1 = new NSubject();
                var finger1 = new NFinger { Image = nImage1 };
                subject1.Fingers.Add(finger1);

                var subject2 = new NSubject();
                var finger2 = new NFinger { Image = nImage2 };
                subject2.Fingers.Add(finger2);

                // Configurer le client biométrique pour la comparaison
                _biometricClient.MatchingThreshold = 48;
                _biometricClient.FingersMatchingSpeed = NMatchingSpeed.High;
                _biometricClient.MatchingWithDetails = true; // Important pour obtenir les détails de correspondance

                // Extraire les templates des images
                var status1 = await _biometricClient.CreateTemplateAsync(subject1);
                var status2 = await _biometricClient.CreateTemplateAsync(subject2);

                if (status1 != NBiometricStatus.Ok || status2 != NBiometricStatus.Ok)
                {
                    throw new Exception($"Template extraction failed. Status1: {status1}, Status2: {status2}");
                }

                // Effectuer la comparaison
                var status = await _biometricClient.VerifyAsync(subject1, subject2);

                // Obtenir le score de correspondance
                int score = 0;
                if (status == NBiometricStatus.Ok && subject1.MatchingResults != null && subject1.MatchingResults.Count > 0)
                {
                    score = subject1.MatchingResults[0].Score;
                }

                // Envoyer le résultat
                await socket.Send(JsonConvert.SerializeObject(new
                {
                    action = "compareResult",
                    data = new
                    {
                        score,
                        matched = score >= _biometricClient.MatchingThreshold,
                        status = status.ToString()
                    }
                }));
            }
            catch (Exception ex)
            {
                await socket.Send(JsonConvert.SerializeObject(new { error = ex.Message }));
            }
        }

        private async Task SendScannersList(IWebSocketConnection socket)
        {
            var scanners = new List<object>();
            foreach (var device in _deviceManager.Devices)
            {
                scanners.Add(new { id = device.Id, name = device.DisplayName });
            }
            await socket.Send(JsonConvert.SerializeObject(new { action = "scannersList", data = scanners }));
        }

        private async Task StartScanning(IWebSocketConnection socket, string scannerId)
        {
            var scanner = _deviceManager.Devices.FirstOrDefault(d => d.Id == scannerId);
            
            if (scanner != null)
            {
                _biometricClient.FingerScanner = scanner as NFScanner;
                var subject = new NSubject();
                var finger = new NFinger();
                subject.Fingers.Add(finger);

                finger.PropertyChanged += (sender, args) =>
                {
                    if (args.PropertyName == "Status")
                    {
                        var status = finger.Status;
                        socket.Send(JsonConvert.SerializeObject(new { action = "scanStatus", data = status.ToString() }));
                    }
                };

                var task = _biometricClient.CreateTask(NBiometricOperations.Capture | NBiometricOperations.CreateTemplate, subject);
                await _biometricClient.PerformTaskAsync(task);
                
                if (subject.Status == NBiometricStatus.Ok)
                {
                    var template = subject.GetTemplateBuffer().ToArray();
                    
                    string imageBase64 = null;
                    if (finger.Image != null)
                    {
                        try
                        {
                            string tempFile = Path.GetTempFileName();
                            try
                            {
                                finger.Image.Save(tempFile, NImageFormat.Png);
                                
                                byte[] imageBytes = File.ReadAllBytes(tempFile);
                                imageBase64 = Convert.ToBase64String(imageBytes);
                            }
                            finally
                            {
                                if (File.Exists(tempFile))
                                {
                                    File.Delete(tempFile);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error converting image: {ex.Message}");
                        }
                    }

                    await socket.Send(JsonConvert.SerializeObject(new { 
                        action = "scanComplete", 
                        data = new { 
                            template = Convert.ToBase64String(template),
                            image = imageBase64,
                            quality = finger.Objects[0].Quality,
                            width = finger.Image?.Width ?? 0,
                            height = finger.Image?.Height ?? 0
                        }
                    }));
                }
            }
        }

        private void StopScanning()
        {
            _biometricClient.Cancel();
        }

        private async Task CaptureFace(IWebSocketConnection socket)
        {
            try
            {
                var faceImage = await _faceRecognition.CaptureFace();
                await socket.Send(JsonConvert.SerializeObject(new
                {
                    action = "faceCaptured",
                    data = new
                    {
                        image = faceImage
                    }
                }));
            }
            catch (Exception ex)
            {
                await socket.Send(JsonConvert.SerializeObject(new { error = ex.Message }));
            }
        }

        private async Task CompareFaces(IWebSocketConnection socket, string face1Base64, string face2Base64)
        {
            try
            {
                var matched = await _faceRecognition.CompareFaces(face1Base64, face2Base64);
                await socket.Send(JsonConvert.SerializeObject(new
                {
                    action = "faceCompareResult",
                    data = new
                    {
                        matched
                    }
                }));
            }
            catch (Exception ex)
            {
                await socket.Send(JsonConvert.SerializeObject(new { error = ex.Message }));
            }
        }

        public void Dispose()
        {
            _faceRecognition?.Dispose();
            _deviceManager?.Dispose();
            _biometricClient?.Dispose();
        }
    }

    public class WebSocketCommand
    {
        public string Action { get; set; }
        public JToken Data { get; set; }
    }
} 