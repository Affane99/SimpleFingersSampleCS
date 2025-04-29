namespace Neurotec.Samples
{
	partial class VerifyFinger
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerifyFinger));
			this.templateRightLabel = new System.Windows.Forms.Label();
			this.templateLeftLabel = new System.Windows.Forms.Label();
			this.matchingFarLabel = new System.Windows.Forms.Label();
			this.matchingGroupBox = new System.Windows.Forms.GroupBox();
			this.defaultButton = new System.Windows.Forms.Button();
			this.matchingFarComboBox = new System.Windows.Forms.ComboBox();
			this.templateNameLabel2 = new System.Windows.Forms.Label();
			this.templateNameLabel1 = new System.Windows.Forms.Label();
			this.verifyButton = new System.Windows.Forms.Button();
			this.openImageButton2 = new System.Windows.Forms.Button();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.msgLabel = new System.Windows.Forms.Label();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.openImageButton1 = new System.Windows.Forms.Button();
			this.clearImagesButton = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.fingerView1 = new Neurotec.Biometrics.Gui.NFingerView();
			this.fingerView2 = new Neurotec.Biometrics.Gui.NFingerView();
			this.chbShowBinarizedImage2 = new System.Windows.Forms.CheckBox();
			this.chbShowBinarizedImage1 = new System.Windows.Forms.CheckBox();
			this.nViewZoomSlider1 = new Neurotec.Gui.NViewZoomSlider();
			this.nViewZoomSlider2 = new Neurotec.Gui.NViewZoomSlider();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.licensePanel = new Neurotec.Samples.LicensePanel();
			this.matchingGroupBox.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// templateRightLabel
			// 
			this.templateRightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.templateRightLabel.AutoSize = true;
			this.templateRightLabel.Location = new System.Drawing.Point(120, 485);
			this.templateRightLabel.Name = "templateRightLabel";
			this.templateRightLabel.Size = new System.Drawing.Size(64, 13);
			this.templateRightLabel.TabIndex = 30;
			this.templateRightLabel.Text = "template left";
			// 
			// templateLeftLabel
			// 
			this.templateLeftLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.templateLeftLabel.AutoSize = true;
			this.templateLeftLabel.Location = new System.Drawing.Point(120, 461);
			this.templateLeftLabel.Name = "templateLeftLabel";
			this.templateLeftLabel.Size = new System.Drawing.Size(64, 13);
			this.templateLeftLabel.TabIndex = 29;
			this.templateLeftLabel.Text = "template left";
			// 
			// matchingFarLabel
			// 
			this.matchingFarLabel.AutoSize = true;
			this.matchingFarLabel.Location = new System.Drawing.Point(11, 10);
			this.matchingFarLabel.Name = "matchingFarLabel";
			this.matchingFarLabel.Size = new System.Drawing.Size(78, 13);
			this.matchingFarLabel.TabIndex = 18;
			this.matchingFarLabel.Text = "Matching &FAR:";
			// 
			// matchingGroupBox
			// 
			this.matchingGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.matchingGroupBox.Controls.Add(this.defaultButton);
			this.matchingGroupBox.Controls.Add(this.matchingFarLabel);
			this.matchingGroupBox.Controls.Add(this.matchingFarComboBox);
			this.matchingGroupBox.Location = new System.Drawing.Point(239, 3);
			this.matchingGroupBox.MaximumSize = new System.Drawing.Size(600, 200);
			this.matchingGroupBox.Name = "matchingGroupBox";
			this.matchingGroupBox.Size = new System.Drawing.Size(157, 54);
			this.matchingGroupBox.TabIndex = 32;
			this.matchingGroupBox.TabStop = false;
			// 
			// defaultButton
			// 
			this.defaultButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.defaultButton.Location = new System.Drawing.Point(88, 26);
			this.defaultButton.Name = "defaultButton";
			this.defaultButton.Size = new System.Drawing.Size(63, 23);
			this.defaultButton.TabIndex = 20;
			this.defaultButton.Text = "Default";
			this.defaultButton.UseVisualStyleBackColor = true;
			this.defaultButton.Click += new System.EventHandler(this.DefaultButtonClick);
			// 
			// matchingFarComboBox
			// 
			this.matchingFarComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.matchingFarComboBox.FormattingEnabled = true;
			this.matchingFarComboBox.Location = new System.Drawing.Point(9, 28);
			this.matchingFarComboBox.Name = "matchingFarComboBox";
			this.matchingFarComboBox.Size = new System.Drawing.Size(67, 21);
			this.matchingFarComboBox.TabIndex = 19;
			this.matchingFarComboBox.Leave += new System.EventHandler(this.MatchingFarComboBoxLeave);
			this.matchingFarComboBox.Enter += new System.EventHandler(this.MatchingFarComboBoxEnter);
			// 
			// templateNameLabel2
			// 
			this.templateNameLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.templateNameLabel2.AutoSize = true;
			this.templateNameLabel2.Location = new System.Drawing.Point(3, 485);
			this.templateNameLabel2.Name = "templateNameLabel2";
			this.templateNameLabel2.Size = new System.Drawing.Size(117, 13);
			this.templateNameLabel2.TabIndex = 28;
			this.templateNameLabel2.Text = "Image or template right:";
			// 
			// templateNameLabel1
			// 
			this.templateNameLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.templateNameLabel1.AutoSize = true;
			this.templateNameLabel1.Location = new System.Drawing.Point(3, 461);
			this.templateNameLabel1.Name = "templateNameLabel1";
			this.templateNameLabel1.Size = new System.Drawing.Size(111, 13);
			this.templateNameLabel1.TabIndex = 27;
			this.templateNameLabel1.Text = "Image or template left:";
			// 
			// verifyButton
			// 
			this.verifyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.verifyButton.Enabled = false;
			this.verifyButton.Location = new System.Drawing.Point(6, 512);
			this.verifyButton.Name = "verifyButton";
			this.verifyButton.Size = new System.Drawing.Size(121, 23);
			this.verifyButton.TabIndex = 26;
			this.verifyButton.Text = "Verify";
			this.verifyButton.UseVisualStyleBackColor = true;
			this.verifyButton.Click += new System.EventHandler(this.VerifyButtonClickAsync);
			// 
			// openImageButton2
			// 
			this.openImageButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.openImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("openImageButton2.Image")));
			this.openImageButton2.Location = new System.Drawing.Point(402, 35);
			this.openImageButton2.Name = "openImageButton2";
			this.openImageButton2.Size = new System.Drawing.Size(30, 23);
			this.openImageButton2.TabIndex = 22;
			this.toolTip.SetToolTip(this.openImageButton2, "Open second fingerprint image or template (*.dat) file");
			this.openImageButton2.UseVisualStyleBackColor = true;
			this.openImageButton2.Click += new System.EventHandler(this.OpenImageButton2ClickAsync);
			// 
			// msgLabel
			// 
			this.msgLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.msgLabel.AutoSize = true;
			this.msgLabel.Location = new System.Drawing.Point(3, 545);
			this.msgLabel.Name = "msgLabel";
			this.msgLabel.Size = new System.Drawing.Size(33, 13);
			this.msgLabel.TabIndex = 24;
			this.msgLabel.Text = "score";
			// 
			// openImageButton1
			// 
			this.openImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.openImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("openImageButton1.Image")));
			this.openImageButton1.Location = new System.Drawing.Point(203, 35);
			this.openImageButton1.Name = "openImageButton1";
			this.openImageButton1.Size = new System.Drawing.Size(30, 23);
			this.openImageButton1.TabIndex = 21;
			this.toolTip.SetToolTip(this.openImageButton1, "Open first fingerprint image or template (*.dat) file");
			this.openImageButton1.UseVisualStyleBackColor = true;
			this.openImageButton1.Click += new System.EventHandler(this.OpenImageButton1ClickAsync);
			// 
			// clearImagesButton
			// 
			this.clearImagesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.clearImagesButton.Location = new System.Drawing.Point(264, 0);
			this.clearImagesButton.Margin = new System.Windows.Forms.Padding(0);
			this.clearImagesButton.Name = "clearImagesButton";
			this.clearImagesButton.Size = new System.Drawing.Size(108, 23);
			this.clearImagesButton.TabIndex = 25;
			this.clearImagesButton.Text = "Clear Images";
			this.clearImagesButton.UseVisualStyleBackColor = true;
			this.clearImagesButton.Click += new System.EventHandler(this.ClearImagesButtonClick);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.72956F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.11321F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.64151F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.83019F));
			this.tableLayoutPanel1.Controls.Add(this.fingerView1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.fingerView2, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.chbShowBinarizedImage2, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.chbShowBinarizedImage1, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.nViewZoomSlider1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.nViewZoomSlider2, 3, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 117);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(636, 314);
			this.tableLayoutPanel1.TabIndex = 33;
			// 
			// fingerView1
			// 
			this.fingerView1.BackColor = System.Drawing.SystemColors.Control;
			this.fingerView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.fingerView1.BoundingRectColor = System.Drawing.Color.Red;
			this.tableLayoutPanel1.SetColumnSpan(this.fingerView1, 2);
			this.fingerView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fingerView1.Location = new System.Drawing.Point(3, 3);
			this.fingerView1.MinutiaColor = System.Drawing.Color.Red;
			this.fingerView1.Name = "fingerView1";
			this.fingerView1.NeighborMinutiaColor = System.Drawing.Color.Orange;
			this.fingerView1.ResultImageColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
			this.fingerView1.SelectedMinutiaColor = System.Drawing.Color.Magenta;
			this.fingerView1.SelectedSingularPointColor = System.Drawing.Color.Magenta;
			this.fingerView1.SingularPointColor = System.Drawing.Color.Red;
			this.fingerView1.Size = new System.Drawing.Size(309, 279);
			this.fingerView1.TabIndex = 24;
			this.fingerView1.TreeColor = System.Drawing.Color.Crimson;
			this.fingerView1.TreeMinutiaNumberDiplayFormat = Neurotec.Biometrics.Gui.MinutiaNumberDiplayFormat.DontDisplay;
			this.fingerView1.TreeMinutiaNumberFont = new System.Drawing.Font("Arial", 10F);
			this.fingerView1.TreeWidth = 2;
			this.fingerView1.SelectedTreeMinutiaIndexChanged += new System.EventHandler(this.FingerView1SelectedTreeMinutiaIndexChanged);
			this.fingerView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FingerView1MouseClick);
			// 
			// fingerView2
			// 
			this.fingerView2.BackColor = System.Drawing.SystemColors.Control;
			this.fingerView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.fingerView2.BoundingRectColor = System.Drawing.Color.Red;
			this.tableLayoutPanel1.SetColumnSpan(this.fingerView2, 2);
			this.fingerView2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fingerView2.Location = new System.Drawing.Point(318, 3);
			this.fingerView2.MinutiaColor = System.Drawing.Color.Red;
			this.fingerView2.Name = "fingerView2";
			this.fingerView2.NeighborMinutiaColor = System.Drawing.Color.Orange;
			this.fingerView2.ResultImageColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
			this.fingerView2.SelectedMinutiaColor = System.Drawing.Color.Magenta;
			this.fingerView2.SelectedSingularPointColor = System.Drawing.Color.Magenta;
			this.fingerView2.SingularPointColor = System.Drawing.Color.Red;
			this.fingerView2.Size = new System.Drawing.Size(315, 279);
			this.fingerView2.TabIndex = 23;
			this.fingerView2.TreeColor = System.Drawing.Color.Crimson;
			this.fingerView2.TreeMinutiaNumberDiplayFormat = Neurotec.Biometrics.Gui.MinutiaNumberDiplayFormat.DontDisplay;
			this.fingerView2.TreeMinutiaNumberFont = new System.Drawing.Font("Arial", 10F);
			this.fingerView2.TreeWidth = 2;
			this.fingerView2.SelectedTreeMinutiaIndexChanged += new System.EventHandler(this.FingerView2SelectedTreeMinutiaIndexChanged);
			this.fingerView2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FingerView2MouseClick);
			// 
			// chbShowBinarizedImage2
			// 
			this.chbShowBinarizedImage2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.chbShowBinarizedImage2.AutoSize = true;
			this.chbShowBinarizedImage2.Checked = true;
			this.chbShowBinarizedImage2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbShowBinarizedImage2.Enabled = false;
			this.chbShowBinarizedImage2.Location = new System.Drawing.Point(318, 288);
			this.chbShowBinarizedImage2.Name = "chbShowBinarizedImage2";
			this.chbShowBinarizedImage2.Size = new System.Drawing.Size(129, 23);
			this.chbShowBinarizedImage2.TabIndex = 26;
			this.chbShowBinarizedImage2.Text = "Show binarized image";
			this.chbShowBinarizedImage2.UseVisualStyleBackColor = true;
			this.chbShowBinarizedImage2.CheckedChanged += new System.EventHandler(this.ChbShowBinarizedImage2CheckedChanged);
			// 
			// chbShowBinarizedImage1
			// 
			this.chbShowBinarizedImage1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.chbShowBinarizedImage1.AutoSize = true;
			this.chbShowBinarizedImage1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.chbShowBinarizedImage1.Checked = true;
			this.chbShowBinarizedImage1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbShowBinarizedImage1.Enabled = false;
			this.chbShowBinarizedImage1.Location = new System.Drawing.Point(183, 288);
			this.chbShowBinarizedImage1.Name = "chbShowBinarizedImage1";
			this.chbShowBinarizedImage1.Size = new System.Drawing.Size(129, 23);
			this.chbShowBinarizedImage1.TabIndex = 25;
			this.chbShowBinarizedImage1.Text = "Show binarized image";
			this.chbShowBinarizedImage1.UseVisualStyleBackColor = true;
			this.chbShowBinarizedImage1.CheckedChanged += new System.EventHandler(this.ChbShowBinarizedImage1CheckedChanged);
			// 
			// nViewZoomSlider1
			// 
			this.nViewZoomSlider1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.nViewZoomSlider1.Location = new System.Drawing.Point(3, 288);
			this.nViewZoomSlider1.Name = "nViewZoomSlider1";
			this.nViewZoomSlider1.Size = new System.Drawing.Size(163, 23);
			this.nViewZoomSlider1.TabIndex = 27;
			this.nViewZoomSlider1.Text = "nViewZoomSlider1";
			this.nViewZoomSlider1.View = this.fingerView1;
			// 
			// nViewZoomSlider2
			// 
			this.nViewZoomSlider2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.nViewZoomSlider2.Location = new System.Drawing.Point(461, 288);
			this.nViewZoomSlider2.Name = "nViewZoomSlider2";
			this.nViewZoomSlider2.Size = new System.Drawing.Size(172, 23);
			this.nViewZoomSlider2.TabIndex = 28;
			this.nViewZoomSlider2.Text = "nViewZoomSlider2";
			this.nViewZoomSlider2.View = this.fingerView2;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel2.ColumnCount = 3;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 163F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.openImageButton1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.openImageButton2, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.matchingGroupBox, 1, 0);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 54);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(636, 61);
			this.tableLayoutPanel2.TabIndex = 34;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel3.ColumnCount = 1;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.Controls.Add(this.clearImagesButton, 0, 0);
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 434);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(636, 24);
			this.tableLayoutPanel3.TabIndex = 35;
			// 
			// licensePanel
			// 
			this.licensePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.licensePanel.Location = new System.Drawing.Point(3, 3);
			this.licensePanel.Name = "licensePanel";
			this.licensePanel.OptionalComponents = "Images.WSQ";
			this.licensePanel.RequiredComponents = "Biometrics.FingerExtraction,Biometrics.FingerMatching";
			this.licensePanel.Size = new System.Drawing.Size(639, 45);
			this.licensePanel.TabIndex = 36;
			// 
			// VerifyFinger
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.licensePanel);
			this.Controls.Add(this.tableLayoutPanel3);
			this.Controls.Add(this.tableLayoutPanel2);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.templateRightLabel);
			this.Controls.Add(this.templateLeftLabel);
			this.Controls.Add(this.templateNameLabel2);
			this.Controls.Add(this.templateNameLabel1);
			this.Controls.Add(this.verifyButton);
			this.Controls.Add(this.msgLabel);
			this.Name = "VerifyFinger";
			this.Size = new System.Drawing.Size(642, 561);
			this.Load += new System.EventHandler(this.VerifyFingerLoad);
			this.VisibleChanged += new System.EventHandler(this.VerifyFingerVisibleChanged);
			this.matchingGroupBox.ResumeLayout(false);
			this.matchingGroupBox.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label templateRightLabel;
		private System.Windows.Forms.Label templateLeftLabel;
		private System.Windows.Forms.Label matchingFarLabel;
		private System.Windows.Forms.GroupBox matchingGroupBox;
		private System.Windows.Forms.Button defaultButton;
		private System.Windows.Forms.ComboBox matchingFarComboBox;
		private System.Windows.Forms.Label templateNameLabel2;
		private System.Windows.Forms.Label templateNameLabel1;
		private System.Windows.Forms.Button verifyButton;
		private System.Windows.Forms.Button openImageButton2;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.Label msgLabel;
		private System.Windows.Forms.Button openImageButton1;
		private System.Windows.Forms.Button clearImagesButton;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private LicensePanel licensePanel;
		private Neurotec.Biometrics.Gui.NFingerView fingerView2;
		private Neurotec.Biometrics.Gui.NFingerView fingerView1;
		private System.Windows.Forms.CheckBox chbShowBinarizedImage1;
		private System.Windows.Forms.CheckBox chbShowBinarizedImage2;
		private Neurotec.Gui.NViewZoomSlider nViewZoomSlider1;
		private Neurotec.Gui.NViewZoomSlider nViewZoomSlider2;
	}
}
