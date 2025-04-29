using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Neurotec.Biometrics;
using Neurotec.Biometrics.Client;
using Neurotec.Images;

namespace Neurotec.Samples
{
	public partial class SegmentFingerprints : UserControl
	{
		#region Public constructor

		public SegmentFingerprints()
		{
			InitializeComponent();

			openFileDialog.Filter = openFileDialog.Filter = NImages.GetOpenFileFilterString(true, true);

			lbPosition.Items.Add(NFPosition.PlainLeftFourFingers);
			lbPosition.Items.Add(NFPosition.PlainRightFourFingers);
			lbPosition.Items.Add(NFPosition.PlainThumbs);
			lbPosition.Items.Add(NFPosition.LeftLittle);
			lbPosition.Items.Add(NFPosition.LeftRing);
			lbPosition.Items.Add(NFPosition.LeftMiddle);
			lbPosition.Items.Add(NFPosition.LeftIndex);
			lbPosition.Items.Add(NFPosition.LeftThumb);
			lbPosition.Items.Add(NFPosition.RightThumb);
			lbPosition.Items.Add(NFPosition.RightIndex);
			lbPosition.Items.Add(NFPosition.RightMiddle);
			lbPosition.Items.Add(NFPosition.RightRing);
			lbPosition.Items.Add(NFPosition.RightLittle);
			lbPosition.SelectedIndex = 0;
		}

		#endregion

		#region Private fields

		private NBiometricClient _biometricClient;
		private NSubject _subject;
		private NImage _image;

		#endregion

		#region Public properties

		public NBiometricClient BiometricClient
		{
			get { return _biometricClient; }
			set { _biometricClient = value; }
		}

		#endregion

		#region Private form events

		private void ClearSegmentInfo()
		{
			pictureBox1.Image = pictureBox2.Image = pictureBox3.Image = pictureBox4.Image = null;
			lbPosition1.Text = lbPosition2.Text = lbPosition3.Text = lbPosition4.Text = @"Position:";
			lbQuality1.Text = lbQuality2.Text = lbQuality3.Text = lbQuality4.Text = @"Quality:";
			lbClass1.Text = lbClass2.Text = lbClass3.Text = lbClass4.Text = @"Class:";
		}

		private async System.Threading.Tasks.Task SegmentAsync()
		{
			if (_image == null) return;
			_subject = new NSubject();
			var finger = new NFinger { Image = _image };
			_subject.Fingers.Add(finger);
			originalFingerView.Finger = finger;
			finger.Position = (NFPosition)lbPosition.SelectedItem;
			_subject.MissingFingers.Clear();
			foreach (Object o in chlbMissing.CheckedItems)
			{
				_subject.MissingFingers.Add((NFPosition)o);
			}
			_biometricClient.FingersDeterminePatternClass = true;
			_biometricClient.FingersCalculateNfiq = true;
			NBiometricTask task = _biometricClient.CreateTask(NBiometricOperations.Segment | NBiometricOperations.CreateTemplate | NBiometricOperations.AssessQuality, _subject);
			var performedTask = await _biometricClient.PerformTaskAsync(task);
			OnSegmentCompleted(performedTask);
		}

		private void OnSegmentCompleted(NBiometricTask task)
		{
			NBiometricStatus status = task.Status;
			if (task.Error != null) Utils.ShowException(task.Error);
			lblStatus.Text = string.Format("Segmentation status: {0}", status);
			lblStatus.ForeColor = status == NBiometricStatus.Ok ? Color.Green : Color.Red;
			ShowSegments();
			btnSaveImages.Enabled = status == NBiometricStatus.Ok;
		}

		private void ShowSegments()
		{
			int segmentsCount = _subject.Fingers.Count - 1;
			if (segmentsCount > 0 && _subject.Fingers[1].Status == NBiometricStatus.Ok)
			{
				SetSegmentInfo(_subject.Fingers[1], lbPosition1, lbQuality1, lbClass1, pictureBox1);
			}
			if (segmentsCount > 1 && _subject.Fingers[2].Status == NBiometricStatus.Ok)
			{
				SetSegmentInfo(_subject.Fingers[2], lbPosition2, lbQuality2, lbClass2, pictureBox2);
			}
			if (segmentsCount > 2 && _subject.Fingers[3].Status == NBiometricStatus.Ok)
			{
				SetSegmentInfo(_subject.Fingers[3], lbPosition3, lbQuality3, lbClass3, pictureBox3);
			}
			if (segmentsCount > 3 && _subject.Fingers[4].Status == NBiometricStatus.Ok)
			{
				SetSegmentInfo(_subject.Fingers[4], lbPosition4, lbQuality4, lbClass4, pictureBox4);
			}
		}

		private void SetSegmentInfo(NFinger finger, Label position, Label quality, Label patternClass, PictureBox pictureBox)
		{
			NFAttributes attributes = finger.Objects.FirstOrDefault();
			position.Text = @"Position: " + finger.Position;
			if (attributes != null)
			{
				quality.Text = @"Quality: " + attributes.GetAttributeValue(NBiometricAttributeId.Nfiq10);
				patternClass.Text = @"Class: " + attributes.PatternClass;
			}
			pictureBox.Image = finger.Image.ToBitmap();
		}

		private void PrepareForSegment()
		{
			btnSaveImages.Enabled = false;
			lblStatus.Text = String.Empty;
			ClearSegmentInfo();
		}

		private async void OpenButtonClickAsync(object sender, EventArgs e)
		{
			PrepareForSegment();
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					_image = NImage.FromFile(openFileDialog.FileName);
					await SegmentAsync();
				}
				catch (Exception ex)
				{
					Utils.ShowException(ex);
					lblStatus.Text = @"Segmentation status: Error";
				}
			}
		}

		private void LbPositionSelectedIndexChanged(object sender, EventArgs e)
		{
			var position = (NFPosition)lbPosition.SelectedItem;
			chlbMissing.Items.Clear();
			if (!NBiometricTypes.IsPositionSingleFinger(position))
			{
				foreach (NFPosition item in NBiometricTypes.GetPositionAvailableParts(position, null))
				{
					chlbMissing.Items.Add(item);
				}
			}
		}

		private void BtnSaveImagesClick(object sender, EventArgs e)
		{
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					for (int i = 1; i < _subject.Fingers.Count; i++)
					{
						if (_subject.Fingers[i].Status == NBiometricStatus.Ok)
						{
							string name = string.Format("finger{0} {1}{2}", i, _subject.Fingers[i].Position.ToString(), ".png");
							string path = System.IO.Path.Combine(folderBrowserDialog.SelectedPath, name);
							_subject.Fingers[i].Image.Save(path);
						}
					}
				}
				catch (Exception ex)
				{
					Utils.ShowException(ex);
				}
			}
		}

		private async void SegmentButtonClickAsync(object sender, EventArgs e)
		{
			if (_image != null)
			{
				PrepareForSegment();
				await SegmentAsync();
			}
			else MessageBox.Show(string.Format("No image selected!"), Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		#endregion
	}
}
