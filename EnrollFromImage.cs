using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Neurotec.Biometrics;
using Neurotec.Biometrics.Client;
using Neurotec.Biometrics.Gui;
using Neurotec.Images;

namespace Neurotec.Samples
{
	public partial class EnrollFromImage : UserControl
	{
		#region Public constructor

		public EnrollFromImage()
		{
			InitializeComponent();

			openFileDialog.Filter = NImages.GetOpenFileFilterString(true, true);
			saveFileDialog.Filter = NImages.GetSaveFileFilterString();
		}

		#endregion

		#region Private fields

		private NImage _image;
		private NBiometricClient _biometricClient;
		private NSubject _subject;
		private NFinger _subjectFinger;

		private byte _defaultThreshold;

		#endregion

		#region Public properties

		public NBiometricClient BiometricClient
		{
			get { return _biometricClient; }
			set 
			{
				_biometricClient = value;
				_defaultThreshold = _biometricClient.FingersQualityThreshold;
				thresholdNumericUpDown.Value = _defaultThreshold;
				chbDetectLiveness.Checked = _biometricClient.FingersDetectLiveness;
			}
		}

		#endregion

		#region Private methods

		private async System.Threading.Tasks.Task ExtractFeaturesAsync()
		{
			if (_image == null) return;
			saveImageButton.Enabled = false;
			saveTemplateButton.Enabled = false;
			chbShowBinarizedImage.Enabled = false;

			// Create a finger subject and begin extracting
			_subjectFinger = new NFinger { Image = _image };
			_subject = new NSubject();
			_subject.Fingers.Add(_subjectFinger);
			fingerView2.Finger = _subjectFinger;

			NBiometricStatus status = NBiometricStatus.InternalError;
			try
			{
				status = await _biometricClient.CreateTemplateAsync(_subject);
				if (status != NBiometricStatus.Ok)
				{
					MessageBox.Show(string.Format(@"Extraction failed. Status: {0}", status), Text, MessageBoxButtons.OK);
				}
			}
			catch (Exception ex)
			{
				Utils.ShowException(ex);
			}
			finally
			{
				if (status == NBiometricStatus.Ok)
				{
					lblQuality.Text = string.Format("Quality: {0}", _subjectFinger.Objects.First().Quality);
					saveImageButton.Enabled = true;
					saveTemplateButton.Enabled = true;
					chbShowBinarizedImage.Enabled = true;
				}
				else
				{
					lblQuality.Text = string.Empty;
					fingerView2.Finger = null;
					_subject = null;
					_subjectFinger = null;
				}
			}
		}

		#endregion

		#region Private form events

		private async void OpenButtonClickAsync(object sender, EventArgs e)
		{
			openFileDialog.FileName = null;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					if (_image != null)
					{
						_image.Dispose();
						_image = null;
					}
					lblQuality.Text = string.Empty;
					fingerView1.Finger = null;
					fingerView2.Finger = null;

					extractFeaturesButton.Enabled = false;
					saveImageButton.Enabled = false;
					saveTemplateButton.Enabled = false;

					_image = NImage.FromFile(openFileDialog.FileName);
					var finger = new NFinger { Image = _image };
					fingerView1.Finger = finger;
					extractFeaturesButton.Enabled = true;
					await ExtractFeaturesAsync();
				}
				catch (Exception ex)
				{
					Utils.ShowException(ex);
				}
			}
		}

		private async void ExtractFeaturesButtonClickAsync(object sender, EventArgs e)
		{
			await ExtractFeaturesAsync();
		}

		private void DefaultButtonClick(object sender, EventArgs e)
		{
			thresholdNumericUpDown.Value = _defaultThreshold;
		}

		private void SaveImageButtonClick(object sender, EventArgs e)
		{
			if (_subjectFinger != null)
			{
				saveFileDialog.FileName = string.Empty;
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

		private void ThresholdNumericUpDownValueChanged(object sender, EventArgs e)
		{
			if (_biometricClient != null)
			{
				_biometricClient.FingersQualityThreshold = (byte)thresholdNumericUpDown.Value;
				defaultButton.Enabled = true;
			}
		}

		private void SaveTemplateButtonClick(object sender, EventArgs e)
		{
			if (_subject != null)
			{
				saveFileDialog.FileName = string.Empty;
				saveFileDialog.Filter = string.Empty;
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					try
					{
						File.WriteAllBytes(saveFileDialog.FileName, _subject.GetTemplateBuffer().ToArray());
					}
					catch (Exception ex)
					{
						Utils.ShowException(ex);
					}
				}
			}
		}

		private void EnrollFromImageVisibleChanged(object sender, EventArgs e)
		{
			if (Visible && _biometricClient != null)
			{
				thresholdNumericUpDown.Value = _defaultThreshold;
				thresholdNumericUpDown.Enabled = true;
				defaultButton.Enabled = true;
				_biometricClient.FingersReturnBinarizedImage = true;
			}
		}

		private void ChbShowBinarizedImageCheckedChanged(object sender, EventArgs e)
		{
			fingerView2.ShownImage = chbShowBinarizedImage.Checked ? ShownImage.Result : ShownImage.Original;
		}
		private void ChbDetectLivenessCheckedChanged(object sender, EventArgs e)
		{
			_biometricClient.FingersDetectLiveness = chbDetectLiveness.Checked;
		}

		private void FingerView2MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right && chbShowBinarizedImage.Enabled)
			{
				chbShowBinarizedImage.Checked = !chbShowBinarizedImage.Checked;
			}
		}

		#endregion

	}
}
