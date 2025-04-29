namespace Neurotec.Samples
{
	partial class EnrollFromScanner
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.lblQuality = new System.Windows.Forms.Label();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.saveImageButton = new System.Windows.Forms.Button();
			this.panel = new System.Windows.Forms.Panel();
			this.fingerView = new Neurotec.Biometrics.Gui.NFingerView();
			this.cancelScanningButton = new System.Windows.Forms.Button();
			this.refreshListButton = new System.Windows.Forms.Button();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.scanButton = new System.Windows.Forms.Button();
			this.scannersGroupBox = new System.Windows.Forms.GroupBox();
			this.chbScanAutomatically = new System.Windows.Forms.CheckBox();
			this.forceCaptureButton = new System.Windows.Forms.Button();
			this.scannersListBox = new System.Windows.Forms.ListBox();
			this.saveTemplateButton = new System.Windows.Forms.Button();
			this.chbShowBinarizedImage = new System.Windows.Forms.CheckBox();
			this.nViewZoomSlider1 = new Neurotec.Gui.NViewZoomSlider();
			this.licensePanel = new Neurotec.Samples.LicensePanel();
			this.panel.SuspendLayout();
			this.scannersGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblQuality
			// 
			this.lblQuality.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.lblQuality.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblQuality.Location = new System.Drawing.Point(3, 381);
			this.lblQuality.Name = "lblQuality";
			this.lblQuality.Size = new System.Drawing.Size(636, 20);
			this.lblQuality.TabIndex = 13;
			// 
			// saveImageButton
			// 
			this.saveImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.saveImageButton.Enabled = false;
			this.saveImageButton.Location = new System.Drawing.Point(3, 407);
			this.saveImageButton.Name = "saveImageButton";
			this.saveImageButton.Size = new System.Drawing.Size(97, 23);
			this.saveImageButton.TabIndex = 12;
			this.saveImageButton.Text = "Save &Image";
			this.saveImageButton.UseVisualStyleBackColor = true;
			this.saveImageButton.Click += new System.EventHandler(this.SaveImageButtonClick);
			// 
			// panel
			// 
			this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel.Controls.Add(this.fingerView);
			this.panel.Location = new System.Drawing.Point(3, 172);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(636, 206);
			this.panel.TabIndex = 9;
			// 
			// fingerView
			// 
			this.fingerView.BackColor = System.Drawing.SystemColors.Control;
			this.fingerView.BoundingRectColor = System.Drawing.Color.Red;
			this.fingerView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fingerView.Location = new System.Drawing.Point(0, 0);
			this.fingerView.MinutiaColor = System.Drawing.Color.Red;
			this.fingerView.Name = "fingerView";
			this.fingerView.NeighborMinutiaColor = System.Drawing.Color.Orange;
			this.fingerView.ResultImageColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
			this.fingerView.SelectedMinutiaColor = System.Drawing.Color.Magenta;
			this.fingerView.SelectedSingularPointColor = System.Drawing.Color.Magenta;
			this.fingerView.ShownImage = Neurotec.Biometrics.Gui.ShownImage.Result;
			this.fingerView.SingularPointColor = System.Drawing.Color.Red;
			this.fingerView.Size = new System.Drawing.Size(634, 204);
			this.fingerView.TabIndex = 0;
			this.fingerView.TreeColor = System.Drawing.Color.Crimson;
			this.fingerView.TreeMinutiaNumberDiplayFormat = Neurotec.Biometrics.Gui.MinutiaNumberDiplayFormat.DontDisplay;
			this.fingerView.TreeMinutiaNumberFont = new System.Drawing.Font("Arial", 10F);
			this.fingerView.TreeWidth = 2;
			this.fingerView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FingerViewMouseClick);
			// 
			// cancelScanningButton
			// 
			this.cancelScanningButton.Enabled = false;
			this.cancelScanningButton.Location = new System.Drawing.Point(168, 81);
			this.cancelScanningButton.Name = "cancelScanningButton";
			this.cancelScanningButton.Size = new System.Drawing.Size(75, 23);
			this.cancelScanningButton.TabIndex = 11;
			this.cancelScanningButton.Text = "Cancel";
			this.cancelScanningButton.UseVisualStyleBackColor = true;
			this.cancelScanningButton.Click += new System.EventHandler(this.CancelScanningButtonClick);
			// 
			// refreshListButton
			// 
			this.refreshListButton.Location = new System.Drawing.Point(6, 81);
			this.refreshListButton.Name = "refreshListButton";
			this.refreshListButton.Size = new System.Drawing.Size(75, 23);
			this.refreshListButton.TabIndex = 10;
			this.refreshListButton.Text = "Refresh list";
			this.refreshListButton.UseVisualStyleBackColor = true;
			this.refreshListButton.Click += new System.EventHandler(this.RefreshListButtonClick);
			// 
			// scanButton
			// 
			this.scanButton.Location = new System.Drawing.Point(87, 81);
			this.scanButton.Name = "scanButton";
			this.scanButton.Size = new System.Drawing.Size(75, 23);
			this.scanButton.TabIndex = 9;
			this.scanButton.Text = "Scan";
			this.scanButton.UseVisualStyleBackColor = true;
			this.scanButton.Click += new System.EventHandler(this.ScanButtonClickAsync);
			// 
			// scannersGroupBox
			// 
			this.scannersGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.scannersGroupBox.Controls.Add(this.chbScanAutomatically);
			this.scannersGroupBox.Controls.Add(this.forceCaptureButton);
			this.scannersGroupBox.Controls.Add(this.cancelScanningButton);
			this.scannersGroupBox.Controls.Add(this.refreshListButton);
			this.scannersGroupBox.Controls.Add(this.scanButton);
			this.scannersGroupBox.Controls.Add(this.scannersListBox);
			this.scannersGroupBox.Location = new System.Drawing.Point(3, 51);
			this.scannersGroupBox.Name = "scannersGroupBox";
			this.scannersGroupBox.Size = new System.Drawing.Size(636, 115);
			this.scannersGroupBox.TabIndex = 11;
			this.scannersGroupBox.TabStop = false;
			this.scannersGroupBox.Text = "Scanners list";
			// 
			// chbScanAutomatically
			// 
			this.chbScanAutomatically.AutoSize = true;
			this.chbScanAutomatically.Checked = true;
			this.chbScanAutomatically.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbScanAutomatically.Location = new System.Drawing.Point(330, 85);
			this.chbScanAutomatically.Name = "chbScanAutomatically";
			this.chbScanAutomatically.Size = new System.Drawing.Size(115, 17);
			this.chbScanAutomatically.TabIndex = 13;
			this.chbScanAutomatically.Text = "Scan automatically";
			this.chbScanAutomatically.UseVisualStyleBackColor = true;
			// 
			// forceCaptureButton
			// 
			this.forceCaptureButton.Enabled = false;
			this.forceCaptureButton.Location = new System.Drawing.Point(249, 81);
			this.forceCaptureButton.Name = "forceCaptureButton";
			this.forceCaptureButton.Size = new System.Drawing.Size(75, 23);
			this.forceCaptureButton.TabIndex = 12;
			this.forceCaptureButton.Text = "Force";
			this.forceCaptureButton.UseVisualStyleBackColor = true;
			this.forceCaptureButton.Click += new System.EventHandler(this.ForceCaptureButtonClick);
			// 
			// scannersListBox
			// 
			this.scannersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.scannersListBox.Location = new System.Drawing.Point(4, 19);
			this.scannersListBox.Name = "scannersListBox";
			this.scannersListBox.Size = new System.Drawing.Size(626, 56);
			this.scannersListBox.TabIndex = 6;
			this.scannersListBox.SelectedIndexChanged += new System.EventHandler(this.ScannersListBoxSelectedIndexChanged);
			// 
			// saveTemplateButton
			// 
			this.saveTemplateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.saveTemplateButton.Enabled = false;
			this.saveTemplateButton.Location = new System.Drawing.Point(106, 407);
			this.saveTemplateButton.Name = "saveTemplateButton";
			this.saveTemplateButton.Size = new System.Drawing.Size(97, 23);
			this.saveTemplateButton.TabIndex = 10;
			this.saveTemplateButton.Text = "Save t&emplate";
			this.saveTemplateButton.UseVisualStyleBackColor = true;
			this.saveTemplateButton.Click += new System.EventHandler(this.SaveTemplateButtonClick);
			// 
			// chbShowBinarizedImage
			// 
			this.chbShowBinarizedImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.chbShowBinarizedImage.AutoSize = true;
			this.chbShowBinarizedImage.Enabled = false;
			this.chbShowBinarizedImage.Location = new System.Drawing.Point(210, 412);
			this.chbShowBinarizedImage.Name = "chbShowBinarizedImage";
			this.chbShowBinarizedImage.Size = new System.Drawing.Size(129, 17);
			this.chbShowBinarizedImage.TabIndex = 16;
			this.chbShowBinarizedImage.Text = "Show binarized image";
			this.chbShowBinarizedImage.UseVisualStyleBackColor = true;
			this.chbShowBinarizedImage.CheckedChanged += new System.EventHandler(this.ChbShowBinarizedImageCheckedChanged);
			// 
			// nViewZoomSlider1
			// 
			this.nViewZoomSlider1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.nViewZoomSlider1.Location = new System.Drawing.Point(367, 404);
			this.nViewZoomSlider1.Name = "nViewZoomSlider1";
			this.nViewZoomSlider1.Size = new System.Drawing.Size(275, 23);
			this.nViewZoomSlider1.TabIndex = 17;
			this.nViewZoomSlider1.Text = "nViewZoomSlider1";
			this.nViewZoomSlider1.View = this.fingerView;
			// 
			// licensePanel
			// 
			this.licensePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.licensePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.licensePanel.Location = new System.Drawing.Point(3, 0);
			this.licensePanel.Name = "licensePanel";
			this.licensePanel.OptionalComponents = "Images.WSQ";
			this.licensePanel.RequiredComponents = "Biometrics.FingerExtraction,Devices.FingerScanners";
			this.licensePanel.Size = new System.Drawing.Size(639, 45);
			this.licensePanel.TabIndex = 15;
			// 
			// EnrollFromScanner
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.nViewZoomSlider1);
			this.Controls.Add(this.chbShowBinarizedImage);
			this.Controls.Add(this.licensePanel);
			this.Controls.Add(this.lblQuality);
			this.Controls.Add(this.saveImageButton);
			this.Controls.Add(this.panel);
			this.Controls.Add(this.scannersGroupBox);
			this.Controls.Add(this.saveTemplateButton);
			this.Name = "EnrollFromScanner";
			this.Size = new System.Drawing.Size(642, 436);
			this.Load += new System.EventHandler(this.EnrollFromScannerLoad);
			this.panel.ResumeLayout(false);
			this.scannersGroupBox.ResumeLayout(false);
			this.scannersGroupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblQuality;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.Button saveImageButton;
		private System.Windows.Forms.Panel panel;
		private System.Windows.Forms.Button cancelScanningButton;
		private System.Windows.Forms.Button refreshListButton;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.Button scanButton;
		private System.Windows.Forms.GroupBox scannersGroupBox;
		private System.Windows.Forms.ListBox scannersListBox;
		private System.Windows.Forms.Button saveTemplateButton;
		private LicensePanel licensePanel;
		private Neurotec.Biometrics.Gui.NFingerView fingerView;
		private System.Windows.Forms.CheckBox chbShowBinarizedImage;
		private System.Windows.Forms.Button forceCaptureButton;
		private System.Windows.Forms.CheckBox chbScanAutomatically;
		private Neurotec.Gui.NViewZoomSlider nViewZoomSlider1;
	}
}
