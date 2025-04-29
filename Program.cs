using System;
using System.Windows.Forms;
using Neurotec.Licensing;

namespace Neurotec.Samples
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			//=========================================================================
			// TRIAL MODE
			//=========================================================================
			// Below code line determines whether TRIAL is enabled or not. To use purchased licenses, don't use below code line.
			// GetTrialModeFlag() method takes value from "Bin/Licenses/TrialFlag.txt" file. So to easily change mode for all our examples, modify that file.
			// Also you can just set TRUE to "TrialMode" property in code.

			NLicenseManager.TrialMode = Utils.GetTrialModeFlag();

			Console.WriteLine("Trial mode: " + NLicenseManager.TrialMode);

			//=========================================================================

			const string Components = "Biometrics.FingerExtraction,Biometrics.FingerMatching,Devices.FingerScanners,Images.WSQ,Biometrics.FingerSegmentation,Biometrics.FingerQualityAssessmentBase";
			try
			{
				foreach (string component in Components.Split(new [] { ',' }, StringSplitOptions.RemoveEmptyEntries))
				{
					NLicense.ObtainComponents(LicensePanel.Address, LicensePanel.Port, component);
				}

				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);

				// Démarrer le serveur WebSocket
				var wsServer = new FingerprintWebSocketServer();
				wsServer.Start();
				Console.WriteLine("WebSocket server started on ws://0.0.0.0:8181");

				Application.Run(new MainForm());
			}
			catch (Exception ex)
			{
				Utils.ShowException(ex);
			}
		}
	}
}
