namespace Neurotec.Samples
{
	partial class EnrollFromImage
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnrollFromImage));
			this.openButton = new System.Windows.Forms.Button();
			this.defaultButton = new System.Windows.Forms.Button();
			this.lblQuality = new System.Windows.Forms.Label();
			this.fingerView1 = new Neurotec.Biometrics.Gui.NFingerView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.extractFeaturesButton = new System.Windows.Forms.Button();
			this.thresholdNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.ThresholdLabel = new System.Windows.Forms.Label();
			this.fingerView2 = new Neurotec.Biometrics.Gui.NFingerView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.chbShowBinarizedImage = new System.Windows.Forms.CheckBox();
			this.saveTemplateButton = new System.Windows.Forms.Button();
			this.saveImageButton = new System.Windows.Forms.Button();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.nViewZoomSlider1 = new Neurotec.Gui.NViewZoomSlider();
			this.nViewZoomSlider2 = new Neurotec.Gui.NViewZoomSlider();
			this.chbDetectLiveness = new System.Windows.Forms.CheckBox();
			this.licensePanel = new Neurotec.Samples.LicensePanel();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.thresholdNumericUpDown)).BeginInit();
			this.panel1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// openButton
			// 
			this.openButton.Image = ((System.Drawing.Image)(resources.GetObject("openButton.Image")));
			this.openButton.Location = new System.Drawing.Point(3, 3);
			this.openButton.Name = "openButton";
			this.openButton.Size = new System.Drawing.Size(93, 23);
			this.openButton.TabIndex = 0;
			this.openButton.Tag = "Open";
			this.openButton.Text = "Open Image";
			this.openButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.openButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.openButton, "Open Fingerprint Image");
			this.openButton.UseVisualStyleBackColor = true;
			this.openButton.Click += new System.EventHandler(this.OpenButtonClickAsync);
			// 
			// defaultButton
			// 
			this.defaultButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.defaultButton.Enabled = false;
			this.defaultButton.Location = new System.Drawing.Point(528, 3);
			this.defaultButton.Name = "defaultButton";
			this.defaultButton.Size = new System.Drawing.Size(62, 23);
			this.defaultButton.TabIndex = 10;
			this.defaultButton.Text = "Default";
			this.defaultButton.UseVisualStyleBackColor = true;
			this.defaultButton.Click += new System.EventHandler(this.DefaultButtonClick);
			// 
			// lblQuality
			// 
			this.lblQuality.Location = new System.Drawing.Point(3, 3);
			this.lblQuality.Name = "lblQuality";
			this.lblQuality.Size = new System.Drawing.Size(170, 23);
			this.lblQuality.TabIndex = 1;
			// 
			// fingerView1
			// 
			this.fingerView1.BackColor = System.Drawing.SystemColors.Control;
			this.fingerView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.fingerView1.BoundingRectColor = System.Drawing.Color.Red;
			this.fingerView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fingerView1.Location = new System.Drawing.Point(3, 3);
			this.fingerView1.MinutiaColor = System.Drawing.Color.Red;
			this.fingerView1.Name = "fingerView1";
			this.fingerView1.NeighborMinutiaColor = System.Drawing.Color.Orange;
			this.fingerView1.ResultImageColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
			this.fingerView1.SelectedMinutiaColor = System.Drawing.Color.Magenta;
			this.fingerView1.SelectedSingularPointColor = System.Drawing.Color.Magenta;
			this.fingerView1.SingularPointColor = System.Drawing.Color.Red;
			this.fingerView1.Size = new System.Drawing.Size(338, 275);
			this.fingerView1.TabIndex = 3;
			this.fingerView1.TreeColor = System.Drawing.Color.Crimson;
			this.fingerView1.TreeMinutiaNumberDiplayFormat = Neurotec.Biometrics.Gui.MinutiaNumberDiplayFormat.DontDisplay;
			this.fingerView1.TreeMinutiaNumberFont = new System.Drawing.Font("Arial", 10F);
			this.fingerView1.TreeWidth = 2D;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.Controls.Add(this.chbDetectLiveness);
			this.panel2.Controls.Add(this.openButton);
			this.panel2.Controls.Add(this.defaultButton);
			this.panel2.Controls.Add(this.extractFeaturesButton);
			this.panel2.Controls.Add(this.thresholdNumericUpDown);
			this.panel2.Controls.Add(this.ThresholdLabel);
			this.panel2.Location = new System.Drawing.Point(0, 51);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(691, 32);
			this.panel2.TabIndex = 11;
			// 
			// extractFeaturesButton
			// 
			this.extractFeaturesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.extractFeaturesButton.Enabled = false;
			this.extractFeaturesButton.Location = new System.Drawing.Point(595, 3);
			this.extractFeaturesButton.Name = "extractFeaturesButton";
			this.extractFeaturesButton.Size = new System.Drawing.Size(93, 23);
			this.extractFeaturesButton.TabIndex = 2;
			this.extractFeaturesButton.Text = "&Extract Features";
			this.extractFeaturesButton.UseVisualStyleBackColor = true;
			this.extractFeaturesButton.Click += new System.EventHandler(this.ExtractFeaturesButtonClickAsync);
			// 
			// thresholdNumericUpDown
			// 
			this.thresholdNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.thresholdNumericUpDown.Location = new System.Drawing.Point(474, 6);
			this.thresholdNumericUpDown.Name = "thresholdNumericUpDown";
			this.thresholdNumericUpDown.Size = new System.Drawing.Size(48, 20);
			this.thresholdNumericUpDown.TabIndex = 9;
			this.thresholdNumericUpDown.Value = new decimal(new int[] {
            39,
            0,
            0,
            0});
			this.thresholdNumericUpDown.ValueChanged += new System.EventHandler(this.ThresholdNumericUpDownValueChanged);
			// 
			// ThresholdLabel
			// 
			this.ThresholdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ThresholdLabel.AutoSize = true;
			this.ThresholdLabel.Location = new System.Drawing.Point(411, 8);
			this.ThresholdLabel.Name = "ThresholdLabel";
			this.ThresholdLabel.Size = new System.Drawing.Size(57, 13);
			this.ThresholdLabel.TabIndex = 8;
			this.ThresholdLabel.Text = "Threshold:";
			// 
			// fingerView2
			// 
			this.fingerView2.BackColor = System.Drawing.SystemColors.Control;
			this.fingerView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.fingerView2.BoundingRectColor = System.Drawing.Color.Red;
			this.fingerView2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fingerView2.Location = new System.Drawing.Point(347, 3);
			this.fingerView2.MinutiaColor = System.Drawing.Color.Red;
			this.fingerView2.Name = "fingerView2";
			this.fingerView2.NeighborMinutiaColor = System.Drawing.Color.Orange;
			this.fingerView2.ResultImageColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
			this.fingerView2.SelectedMinutiaColor = System.Drawing.Color.Magenta;
			this.fingerView2.SelectedSingularPointColor = System.Drawing.Color.Magenta;
			this.fingerView2.ShownImage = Neurotec.Biometrics.Gui.ShownImage.Result;
			this.fingerView2.SingularPointColor = System.Drawing.Color.Red;
			this.fingerView2.Size = new System.Drawing.Size(338, 275);
			this.fingerView2.TabIndex = 4;
			this.fingerView2.TreeColor = System.Drawing.Color.Crimson;
			this.fingerView2.TreeMinutiaNumberDiplayFormat = Neurotec.Biometrics.Gui.MinutiaNumberDiplayFormat.DontDisplay;
			this.fingerView2.TreeMinutiaNumberFont = new System.Drawing.Font("Arial", 10F);
			this.fingerView2.TreeWidth = 2D;
			this.fingerView2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FingerView2MouseClick);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.chbShowBinarizedImage);
			this.panel1.Controls.Add(this.lblQuality);
			this.panel1.Controls.Add(this.saveTemplateButton);
			this.panel1.Controls.Add(this.saveImageButton);
			this.panel1.Location = new System.Drawing.Point(3, 405);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(685, 29);
			this.panel1.TabIndex = 0;
			// 
			// chbShowBinarizedImage
			// 
			this.chbShowBinarizedImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.chbShowBinarizedImage.AutoSize = true;
			this.chbShowBinarizedImage.Checked = true;
			this.chbShowBinarizedImage.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbShowBinarizedImage.Enabled = false;
			this.chbShowBinarizedImage.Location = new System.Drawing.Point(349, 7);
			this.chbShowBinarizedImage.Name = "chbShowBinarizedImage";
			this.chbShowBinarizedImage.Size = new System.Drawing.Size(129, 17);
			this.chbShowBinarizedImage.TabIndex = 7;
			this.chbShowBinarizedImage.Text = "Show binarized image";
			this.chbShowBinarizedImage.UseVisualStyleBackColor = true;
			this.chbShowBinarizedImage.CheckedChanged += new System.EventHandler(this.ChbShowBinarizedImageCheckedChanged);
			// 
			// saveTemplateButton
			// 
			this.saveTemplateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.saveTemplateButton.Enabled = false;
			this.saveTemplateButton.Location = new System.Drawing.Point(586, 3);
			this.saveTemplateButton.Name = "saveTemplateButton";
			this.saveTemplateButton.Size = new System.Drawing.Size(96, 23);
			this.saveTemplateButton.TabIndex = 6;
			this.saveTemplateButton.Text = "&Save Template";
			this.toolTip.SetToolTip(this.saveTemplateButton, "Save extracted template to file");
			this.saveTemplateButton.UseVisualStyleBackColor = true;
			this.saveTemplateButton.Click += new System.EventHandler(this.SaveTemplateButtonClick);
			// 
			// saveImageButton
			// 
			this.saveImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.saveImageButton.Enabled = false;
			this.saveImageButton.Image = ((System.Drawing.Image)(resources.GetObject("saveImageButton.Image")));
			this.saveImageButton.Location = new System.Drawing.Point(484, 3);
			this.saveImageButton.Name = "saveImageButton";
			this.saveImageButton.Size = new System.Drawing.Size(96, 23);
			this.saveImageButton.TabIndex = 1;
			this.saveImageButton.Text = "Save Image";
			this.saveImageButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.saveImageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.saveImageButton, "Save Binarized Image");
			this.saveImageButton.UseVisualStyleBackColor = true;
			this.saveImageButton.Click += new System.EventHandler(this.SaveImageButtonClick);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.fingerView2, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.fingerView1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.nViewZoomSlider1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.nViewZoomSlider2, 1, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 89);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(688, 310);
			this.tableLayoutPanel1.TabIndex = 15;
			// 
			// nViewZoomSlider1
			// 
			this.nViewZoomSlider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.nViewZoomSlider1.Location = new System.Drawing.Point(3, 284);
			this.nViewZoomSlider1.Name = "nViewZoomSlider1";
			this.nViewZoomSlider1.Size = new System.Drawing.Size(338, 23);
			this.nViewZoomSlider1.TabIndex = 5;
			this.nViewZoomSlider1.Text = "nViewZoomSlider1";
			this.nViewZoomSlider1.View = this.fingerView1;
			// 
			// nViewZoomSlider2
			// 
			this.nViewZoomSlider2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.nViewZoomSlider2.Location = new System.Drawing.Point(347, 284);
			this.nViewZoomSlider2.Name = "nViewZoomSlider2";
			this.nViewZoomSlider2.Size = new System.Drawing.Size(338, 23);
			this.nViewZoomSlider2.TabIndex = 6;
			this.nViewZoomSlider2.Text = "nViewZoomSlider2";
			this.nViewZoomSlider2.View = this.fingerView2;
			// 
			// chbDetectLiveness
			// 
			this.chbDetectLiveness.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.chbDetectLiveness.AutoSize = true;
			this.chbDetectLiveness.Location = new System.Drawing.Point(308, 6);
			this.chbDetectLiveness.Name = "chbDetectLiveness";
			this.chbDetectLiveness.Size = new System.Drawing.Size(103, 17);
			this.chbDetectLiveness.TabIndex = 11;
			this.chbDetectLiveness.Text = "Detect Liveness";
			this.chbDetectLiveness.UseVisualStyleBackColor = true;
			this.chbDetectLiveness.CheckedChanged += new System.EventHandler(this.ChbDetectLivenessCheckedChanged);
			// 
			// licensePanel
			// 
			this.licensePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.licensePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.licensePanel.Location = new System.Drawing.Point(0, 0);
			this.licensePanel.Name = "licensePanel";
			this.licensePanel.OptionalComponents = "Images.WSQ";
			this.licensePanel.RequiredComponents = "Biometrics.FingerExtraction";
			this.licensePanel.Size = new System.Drawing.Size(691, 45);
			this.licensePanel.TabIndex = 14;
			// 
			// EnrollFromImage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.licensePanel);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.Name = "EnrollFromImage";
			this.Size = new System.Drawing.Size(691, 437);
			this.VisibleChanged += new System.EventHandler(this.EnrollFromImageVisibleChanged);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.thresholdNumericUpDown)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button openButton;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.Button defaultButton;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button extractFeaturesButton;
		private System.Windows.Forms.NumericUpDown thresholdNumericUpDown;
		private System.Windows.Forms.Label ThresholdLabel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button saveTemplateButton;
		private System.Windows.Forms.Button saveImageButton;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private LicensePanel licensePanel;
		private Neurotec.Biometrics.Gui.NFingerView fingerView1;
		private Neurotec.Biometrics.Gui.NFingerView fingerView2;
		private System.Windows.Forms.Label lblQuality;
		private System.Windows.Forms.CheckBox chbShowBinarizedImage;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private Neurotec.Gui.NViewZoomSlider nViewZoomSlider1;
		private Neurotec.Gui.NViewZoomSlider nViewZoomSlider2;
		private System.Windows.Forms.CheckBox chbDetectLiveness;
	}
}
