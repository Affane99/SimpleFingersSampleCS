using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using Neurotec.Biometrics;
using Neurotec.Biometrics.Client;
using Neurotec.Images;
using Neurotec.Devices;
using Neurotec.Licensing;

namespace Neurotec.Samples
{
    public class FaceRecognition
    {
        private NBiometricClient _biometricClient;
        private NDeviceManager _deviceManager;
        private NCamera _camera;

        public FaceRecognition()
        {
            // Activer les licences nécessaires
            const string FaceDetectionComponent = "Biometrics.FaceDetectionBase";
            const string FaceExtractionComponent = "Biometrics.FaceExtraction";
            const string FaceMatchingComponent = "Biometrics.FaceMatching";

            // Obtenir les licences une par une
            if (!NLicense.ObtainComponents("/local", 5000, FaceDetectionComponent))
            {
                throw new Exception("Could not obtain license for face detection");
            }

            if (!NLicense.ObtainComponents("/local", 5000, FaceExtractionComponent))
            {
                throw new Exception("Could not obtain license for face extraction");
            }

            if (!NLicense.ObtainComponents("/local", 5000, FaceMatchingComponent))
            {
                throw new Exception("Could not obtain license for face matching");
            }

            _biometricClient = new NBiometricClient();
            _deviceManager = new NDeviceManager();
            _deviceManager.DeviceTypes = NDeviceType.Camera;
            _deviceManager.Initialize();
        }

        public async Task<string> CaptureFace()
        {
            try
            {
                if (_deviceManager.Devices.Count == 0)
                {
                    throw new Exception("No camera found");
                }

                _camera = _deviceManager.Devices[0] as NCamera;
                if (_camera == null)
                {
                    throw new Exception("Failed to initialize camera");
                }

                var subject = new NSubject();
                var face = new NFace();
                subject.Faces.Add(face);

                // Capture l'image
                var status = await _biometricClient.CaptureAsync(subject);
                if (status != NBiometricStatus.Ok)
                {
                    throw new Exception($"Capture failed: {status}");
                }

                // Sauvegarder l'image dans un fichier temporaire
                string tempFile = Path.GetTempFileName();
                try
                {
                    face.Image.Save(tempFile, NImageFormat.Jpeg);
                    byte[] imageBytes = File.ReadAllBytes(tempFile);
                    return Convert.ToBase64String(imageBytes);
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
                throw new Exception($"Error capturing face: {ex.Message}");
            }
        }

        public async Task<bool> CompareFaces(string face1Base64, string face2Base64)
        {
            try
            {
                // Convertir les images base64 en NImage
                var face1Bytes = Convert.FromBase64String(face1Base64);
                var face2Bytes = Convert.FromBase64String(face2Base64);

                // Créer les sujets avec les images
                var subject1 = new NSubject();
                var face1 = new NFace { FileName = SaveTempImage(face1Bytes) };
                subject1.Faces.Add(face1);

                var subject2 = new NSubject();
                var face2 = new NFace { FileName = SaveTempImage(face2Bytes) };
                subject2.Faces.Add(face2);

                // Configurer le client biométrique pour la comparaison
                _biometricClient.MatchingThreshold = 48;
                _biometricClient.FacesMatchingSpeed = NMatchingSpeed.High;
                _biometricClient.MatchingWithDetails = true;

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

                return score >= _biometricClient.MatchingThreshold;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error comparing faces: {ex.Message}");
            }
        }

        private string SaveTempImage(byte[] imageBytes)
        {
            string tempFile = Path.GetTempFileName();
            File.WriteAllBytes(tempFile, imageBytes);
            return tempFile;
        }

        public void Dispose()
        {
            _camera?.Dispose();
            _deviceManager?.Dispose();
            _biometricClient?.Dispose();
        }
    }
} 