using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using Neurotec.Biometrics;
using Neurotec.Biometrics.Client;
using Neurotec.Biometrics.Gui;
using Neurotec.Devices;
using Neurotec.Images;

namespace Neurotec.Samples
{
	public partial class EnrollFromScanner : UserControl
	{
		#region Public constructor

		public EnrollFromScanner()
		{
			InitializeComponent();
		}

		#endregion

		#region Private fields

		private NDeviceManager _deviceManager;
		private NBiometricClient _biometricClient;
		private NSubject _subject;
		private NFinger _subjectFinger;

		#endregion

		#region Public properties

		public NBiometricClient BiometricClient
		{
			get { return _biometricClient; }
			set { _biometricClient = value; }
		}

		#endregion

		#region Private methods

		private void EnableControls(bool capturing)
		{
			scannersListBox.Enabled = !capturing;
			cancelScanningButton.Enabled = capturing;
			scanButton.Enabled = !capturing;
			refreshListButton.Enabled = !capturing;
			var fingerStatus = !capturing && _subjectFinger != null && _subjectFinger.Status == NBiometricStatus.Ok;
			saveImageButton.Enabled = fingerStatus;
			chbShowBinarizedImage.Enabled = fingerStatus;
			saveTemplateButton.Enabled = !capturing && _subject != null && _subject.Status == NBiometricStatus.Ok;
			chbScanAutomatically.Enabled = !capturing;
			forceCaptureButton.Enabled = capturing;
		}

		private void OnEnrollCompleted(NBiometricTask task)
		{
			EnableControls(false);
			NBiometricStatus status = task.Status;

			// Check if extraction was canceled
			if (status == NBiometricStatus.Canceled) return;

			if (status == NBiometricStatus.Ok)
			{
				lblQuality.Text = String.Format("Quality: {0}", _subjectFinger.Objects[0].Quality);
			}
			else
			{
				MessageBox.Show(string.Format("The template was not extracted: {0}.", status), Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
				_subject = null;
				_subjectFinger = null;
				EnableControls(false);
			}
		}

		private void UpdateScannerList()
		{
			scannersListBox.BeginUpdate();
			try
			{
				scannersListBox.Items.Clear();
				if (_deviceManager != null)
				{
					foreach (NDevice item in _deviceManager.Devices)
					{
						scannersListBox.Items.Add(item);
					}
				}
			}
			finally
			{
				scannersListBox.EndUpdate();
			}
		}

		#endregion

		#region Private form events

		private async void ScanButtonClickAsync(object sender, EventArgs e)
		{
			if (_biometricClient.FingerScanner == null)
			{
				MessageBox.Show(@"Please select a scanner from the list.");
			}
			else
			{
				EnableControls(true);
				lblQuality.Text = String.Empty;

				// Create a finger
				_subjectFinger = new NFinger();

				// Set Manual capturing mode if not automatic selected
				if (!chbScanAutomatically.Checked)
				{
					_subjectFinger.CaptureOptions = NBiometricCaptureOptions.Manual;
				}

				// Add finger to the subject and fingerView
				_subject = new NSubject();
				_subject.Fingers.Add(_subjectFinger);
				_subjectFinger.PropertyChanged += OnAttributesPropertyChanged;
				fingerView.Finger = _subjectFinger;
				fingerView.ShownImage = ShownImage.Original;

				// Begin capturing
				_biometricClient.FingersReturnBinarizedImage = true;
				NBiometricTask task = _biometricClient.CreateTask(NBiometricOperations.Capture | NBiometricOperations.CreateTemplate, _subject);
				var performedTask = await _biometricClient.PerformTaskAsync(task);
				OnEnrollCompleted(performedTask);
			}
		}

		private void OnAttributesPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			if (e.PropertyName == "Status")
			{
				BeginInvoke(new Action<NBiometricStatus>(status => lblQuality.Text = status.ToString()), _subjectFinger.Status);
			}
		}

		private void CancelScanningButtonClick(object sender, EventArgs e)
		{
			_biometricClient.Cancel();
		}

		private void RefreshListButtonClick(object sender, EventArgs e)
		{
			UpdateScannerList();
		}

		private void SaveImageButtonClick(object sender, EventArgs e)
		{
			if (_subjectFinger.Status == NBiometricStatus.Ok)
			{
				saveFileDialog.FileName = string.Empty;
				saveFileDialog.Title = @"Save Image File";
				saveFileDialog.Filter = NImages.GetSaveFileFilterString();
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					try
					{
						if (chbShowBinarizedImage.Checked)
						{
							_subjectFinger.BinarizedImage.Save(saveFileDialog.FileName);
						}
						else
						{
							_subjectFinger.Image.Save(saveFileDialog.FileName);
						}
					}
					catch (Exception ex)
					{
						Utils.ShowException(ex);
					}
				}
			}
		}

		private void SaveTemplateButtonClick(object sender, EventArgs e)
		{
			if (_subject.Status == NBiometricStatus.Ok)
			{
				saveFileDialog.FileName = string.Empty;
				saveFileDialog.Filter = string.Empty;
				saveFileDialog.Title = @"Save Template File";
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					try
					{
						// Save template to file
						File.WriteAllBytes(saveFileDialog.FileName, _subject.GetTemplateBuffer().ToArray());
					}
					catch (Exception ex)
					{
						Utils.ShowException(ex);
					}
				}
			}
		}

		private void EnrollFromScannerLoad(object sender, EventArgs e)
		{
			_deviceManager = _biometricClient.DeviceManager;
			UpdateScannerList();
			saveFileDialog.Filter = NImages.GetSaveFileFilterString();
		}

		private void ScannersListBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			_biometricClient.FingerScanner = scannersListBox.SelectedItem as NFScanner;
		}

		private void ChbShowBinarizedImageCheckedChanged(object sender, EventArgs e)
		{
			fingerView.ShownImage = chbShowBinarizedImage.Checked ? ShownImage.Result : ShownImage.Original;
		}

		private void FingerViewMouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right && chbShowBinarizedImage.Enabled)
			{
				chbShowBinarizedImage.Checked = !chbShowBinarizedImage.Checked;
			}
		}

		private void ForceCaptureButtonClick(object sender, EventArgs e)
		{
			_biometricClient.Force();
		}

		#endregion

	}
}
