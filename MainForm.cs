using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Neurotec.Biometrics;
using Neurotec.Biometrics.Client;

namespace Neurotec.Samples
{
	public partial class MainForm : Form
	{
		#region Public constructor

		public MainForm()
		{
			InitializeComponent();
		}

		#endregion

		#region Private fields

		private NBiometricClient _biometricClient;

		#endregion

		#region Private form events

		private async void MainFormLoadAsync(object sender, EventArgs e)
		{
			_biometricClient = new NBiometricClient { UseDeviceManager = true, BiometricTypes = NBiometricType.Finger };

			var page = new TabPage("Enroll From Image");
			var enrollFromImage = new EnrollFromImage { Dock = DockStyle.Fill, BiometricClient = _biometricClient };
			page.Controls.Add(enrollFromImage);
			tabControl.TabPages.Add(page);

			page = new TabPage("Enroll From Scanner");
			var enrollFromScanner = new EnrollFromScanner { Dock = DockStyle.Fill, BiometricClient = _biometricClient };
			page.Controls.Add(enrollFromScanner);
			tabControl.TabPages.Add(page);

			page = new TabPage("Identify Finger");
			var identifyFinger = new IdentifyFinger { Dock = DockStyle.Fill, BiometricClient = _biometricClient };
			page.Controls.Add(identifyFinger);
			tabControl.TabPages.Add(page);

			page = new TabPage("Verify Finger");
			var verifyFinger = new VerifyFinger { Dock = DockStyle.Fill, BiometricClient = _biometricClient };
			page.Controls.Add(verifyFinger);
			tabControl.TabPages.Add(page);

			page = new TabPage("Segment Fingers");
			var segmentFingers = new SegmentFingerprints { Dock = DockStyle.Fill, BiometricClient = _biometricClient };
			page.Controls.Add(segmentFingers);
			tabControl.TabPages.Add(page);

			await _biometricClient.InitializeAsync();
		}

		private void TabControlSelecting(object sender, TabControlCancelEventArgs e)
		{
			if (_biometricClient != null)
			{
				_biometricClient.Reset();
				_biometricClient.Cancel();
			}
		}

		private void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			if (_biometricClient != null)
				_biometricClient.Cancel();
		}

		#endregion

	}
}
