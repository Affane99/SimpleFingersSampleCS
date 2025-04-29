using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Neurotec.Biometrics;
using Neurotec.Biometrics.Client;
using Neurotec.Biometrics.Gui;

namespace Neurotec.Samples
{
	public partial class IdentifyFinger : UserControl
	{
		#region Public constructor

		public IdentifyFinger()
		{
			InitializeComponent();
		}

		#endregion

		#region Private fields

		private NBiometricClient _biometricClient;
		private NSubject _subject;
		private NSubject[] _subjects;
		private NBiometricStatus _enrollStatus = NBiometricStatus.None;

		private byte _defaultThreshold;
		private int _defaultFar;

		#endregion

		#region Public properties

		public NBiometricClient BiometricClient
		{
			get { return _biometricClient; }
			set
			{
				_biometricClient = value;
				_defaultThreshold = _biometricClient.FingersQualityThreshold;
				_defaultFar = _biometricClient.MatchingThreshold;
				thresholdNumericUpDown.Value = _defaultThreshold;
				matchingFarComboBox.Text = Utils.MatchingThresholdToString(_defaultFar);
			}
		}

		#endregion

		#region Private methods

		private void SetMatchingThreshold()
		{
			try
			{
				_biometricClient.MatchingThreshold = Utils.MatchingThresholdFromString(matchingFarComboBox.Text);
				matchingFarComboBox.Text = Utils.MatchingThresholdToString(_biometricClient.MatchingThreshold);
			}
			catch
			{
				matchingFarComboBox.Select();
				MessageBox.Show(@"FAR is not valid", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void OnEnrollCompleted(NBiometricTask task)
		{
			_enrollStatus = task.Status;
			if (task.Status == NBiometricStatus.Ok)
			{
				identifyButton.Enabled = IsSubjectValid(_subject);
			}
			else MessageBox.Show(string.Format("Enrollment failed: {0}", _enrollStatus));
		}

		private void SetDefaultFar()
		{
			matchingFarComboBox.Text = Utils.MatchingThresholdToString(_defaultFar);
			defaultMatchingFARButton.Enabled = false;
			SetMatchingThreshold();
		}

		private bool IsSubjectValid(NSubject subject)
		{
			return subject != null && (subject.Status == NBiometricStatus.Ok
				|| subject.Status == NBiometricStatus.None && subject.GetTemplateBuffer() != null);
		}

		#endregion

		#region Private form events

		private void IdentifyFingerLoad(object sender, EventArgs e)
		{
			fileForIdentificationLabel.Text = string.Empty;
			templatesCountLabel.Text = @"0";

			matchingFarComboBox.BeginUpdate();
			matchingFarComboBox.Items.Add(0.001.ToString("P1"));
			matchingFarComboBox.Items.Add(0.0001.ToString("P2"));
			matchingFarComboBox.Items.Add(0.00001.ToString("P3"));
			matchingFarComboBox.EndUpdate();
			matchingFarComboBox.SelectedIndex = 1;
		}

		private async void OpenTemplatesButtonClickAsync(object sender, EventArgs e)
		{
			identifyButton.Enabled = false;
			_enrollStatus = NBiometricStatus.None;
			_subjects = null;

			templatesCountLabel.Text = @"0";
			openFileDialog.Multiselect = true;
			openFileDialog.FileName = null;
			openFileDialog.Filter = string.Empty;
			openFileDialog.Title = @"Open Templates Files";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					int templatesCount = openFileDialog.FileNames.Length;
					await _biometricClient.ClearAsync();
					_subjects = new NSubject[templatesCount];
					for (int i = 0; i < templatesCount; ++i)
					{
						_subjects[i] = NSubject.FromFile(openFileDialog.FileNames[i]);
						_subjects[i].Id = Path.GetFileName(openFileDialog.FileNames[i]);
					}
					templatesCountLabel.Text = templatesCount.ToString(CultureInfo.InvariantCulture);

					NBiometricTask task = _biometricClient.CreateTask(NBiometricOperations.Enroll, null);
					foreach (NSubject item in _subjects)
					{
						task.Subjects.Add(item);
					}
					var performedTask = await _biometricClient.PerformTaskAsync(task);
					OnEnrollCompleted(performedTask);
				}
				catch (Exception ex)
				{
					Utils.ShowException(ex);
				}
			}
		}

		private async void OpenImageButtonClickAsync(object sender, EventArgs e)
		{
			identifyButton.Enabled = false;
			chbShowBinarizedImage.Enabled = false;
			_subject = null;

			openFileDialog.FileName = null;
			openFileDialog.Filter = string.Empty;
			openFileDialog.Title = @"Open Image File Or Template";

			fingerView.Finger = null;
			fileForIdentificationLabel.Text = string.Empty;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				fileForIdentificationLabel.Text = openFileDialog.FileName;

				// Check if given file is a template
				try
				{
					_subject = NSubject.FromFile(openFileDialog.FileName);
				}
				catch { }

				// If file is not a template, try to load it as image
				if (_subject != null && _subject.Fingers.Count > 0)
				{
					fingerView.Finger = _subject.Fingers[0];
					identifyButton.Enabled = _subjects != null;
				}
				else
				{
					// Create a finger object
					var finger = new NFinger { FileName = openFileDialog.FileName };
					fingerView.Finger = finger;
					// Add the finger to a subject
					_subject = new NSubject();
					_subject.Fingers.Add(finger);

					// Extract the template from the subject
					_biometricClient.FingersReturnBinarizedImage = true;
					NBiometricStatus status = NBiometricStatus.InternalError;
					try
					{
						status = await _biometricClient.CreateTemplateAsync(_subject);
						if (status != NBiometricStatus.Ok)
						{
							MessageBox.Show(string.Format("Template was not extracted: {0}.", status), Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
							identifyButton.Enabled = _subjects != null;
							chbShowBinarizedImage.Enabled = true;
						}
						else
						{
							_subject = null;
							identifyButton.Enabled = false;
						}
					}
				}
			}
		}

		private async void IdentifyButtonClickAsync(object sender, EventArgs e)
		{
			listView.Items.Clear();
			if (_subject != null && _subjects != null && _subjects.Length > 0)
			{
				try
				{
					var status = await _biometricClient.IdentifyAsync(_subject);
					if (status == NBiometricStatus.Ok || status == NBiometricStatus.MatchNotFound)
					{
						// Matching subjects
						foreach (var result in _subject.MatchingResults)
						{
							listView.Items.Add(new ListViewItem(new[] { result.Id, result.Score.ToString(CultureInfo.InvariantCulture) }));
						}
						// Non-matching subjects
						foreach (var subject in _subjects)
						{
							bool isMatchingResult = _subject.MatchingResults.Any(result => subject.Id == result.Id);
							if (!isMatchingResult)
								listView.Items.Add(new ListViewItem(new[] { subject.Id, "0" }));
						}
					}
					else MessageBox.Show(string.Format("Identification failed: {0}", status));
				}
				catch (Exception ex)
				{
					Utils.ShowException(ex);
				}
			}
		}

		private void DefaultButtonClick(object sender, EventArgs e)
		{
			thresholdNumericUpDown.Value = _defaultThreshold;
			defaultButton.Enabled = false;
		}

		private void ThresholdNumericUpDownEnter(object sender, EventArgs e)
		{
			defaultButton.Enabled = true;
		}

		private void MatchingFarComboBoxEnter(object sender, EventArgs e)
		{
			defaultMatchingFARButton.Enabled = true;
		}

		private void DefaultMatchingFarButtonClick(object sender, EventArgs e)
		{
			SetDefaultFar();
		}

		private void IdentifyFingerVisibleChanged(object sender, EventArgs e)
		{
			if (Visible && _biometricClient != null)
			{
				thresholdNumericUpDown.Value = _defaultThreshold;
				thresholdNumericUpDown.Enabled = true;
				defaultButton.Enabled = true;
				SetDefaultFar();
			}
		}

		private void MatchingFarComboBoxLeave(object sender, EventArgs e)
		{
			SetMatchingThreshold();
		}

		private void ThresholdNumericUpDownValueChanged(object sender, EventArgs e)
		{
			if (_biometricClient != null)
			{
				_biometricClient.FingersQualityThreshold = (byte)thresholdNumericUpDown.Value;
				defaultButton.Enabled = true;
			}
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

		#endregion

	}
}
