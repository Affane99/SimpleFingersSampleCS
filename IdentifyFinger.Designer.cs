namespace Neurotec.Samples
{
	partial class IdentifyFinger
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IdentifyFinger));
			this.openTemplatesButton = new System.Windows.Forms.Button();
			this.defaultButton = new System.Windows.Forms.Button();
			this.thresholdNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.ThresholdLabel = new System.Windows.Forms.Label();
			this.defaultMatchingFARButton = new System.Windows.Forms.Button();
			this.matchingFarComboBox = new System.Windows.Forms.ComboBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.listView = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.identifyButton = new System.Windows.Forms.Button();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.templatesCountLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.nViewZoomSlider1 = new Neurotec.Gui.NViewZoomSlider();
			this.fingerView = new Neurotec.Biometrics.Gui.NFingerView();
			this.chbShowBinarizedImage = new System.Windows.Forms.CheckBox();
			this.panel = new System.Windows.Forms.Panel();
			this.fileForIdentificationLabel = new System.Windows.Forms.Label();
			this.openImageButton = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.licensePanel = new Neurotec.Samples.LicensePanel();
			((System.ComponentModel.ISupportInitialize)(this.thresholdNumericUpDown)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.panel.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// openTemplatesButton
			// 
			this.openTemplatesButton.Image = ((System.Drawing.Image)(resources.GetObject("openTemplatesButton.Image")));
			this.openTemplatesButton.Location = new System.Drawing.Point(6, 24);
			this.openTemplatesButton.Name = "openTemplatesButton";
			this.openTemplatesButton.Size = new System.Drawing.Size(30, 23);
			this.openTemplatesButton.TabIndex = 5;
			this.toolTip.SetToolTip(this.openTemplatesButton, "Open templates files (*.data) ");
			this.openTemplatesButton.UseVisualStyleBackColor = true;
			this.openTemplatesButton.Click += new System.EventHandler(this.OpenTemplatesButtonClickAsync);
			// 
			// defaultButton
			// 
			this.defaultButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.defaultButton.Enabled = false;
			this.defaultButton.Location = new System.Drawing.Point(224, 167);
			this.defaultButton.Name = "defaultButton";
			this.defaultButton.Size = new System.Drawing.Size(63, 23);
			this.defaultButton.TabIndex = 10;
			this.defaultButton.Text = "Default";
			this.defaultButton.UseVisualStyleBackColor = true;
			this.defaultButton.Click += new System.EventHandler(this.DefaultButtonClick);
			// 
			// thresholdNumericUpDown
			// 
			this.thresholdNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.thresholdNumericUpDown.Location = new System.Drawing.Point(170, 168);
			this.thresholdNumericUpDown.Name = "thresholdNumericUpDown";
			this.thresholdNumericUpDown.Size = new System.Drawing.Size(48, 20);
			this.thresholdNumericUpDown.TabIndex = 9;
			this.thresholdNumericUpDown.Value = new decimal(new int[] {
            39,
            0,
            0,
            0});
			this.thresholdNumericUpDown.ValueChanged += new System.EventHandler(this.ThresholdNumericUpDownValueChanged);
			this.thresholdNumericUpDown.Enter += new System.EventHandler(this.ThresholdNumericUpDownEnter);
			// 
			// ThresholdLabel
			// 
			this.ThresholdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ThresholdLabel.AutoSize = true;
			this.ThresholdLabel.Location = new System.Drawing.Point(107, 172);
			this.ThresholdLabel.Name = "ThresholdLabel";
			this.ThresholdLabel.Size = new System.Drawing.Size(57, 13);
			this.ThresholdLabel.TabIndex = 8;
			this.ThresholdLabel.Text = "Threshold:";
			// 
			// defaultMatchingFARButton
			// 
			this.defaultMatchingFARButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.defaultMatchingFARButton.Location = new System.Drawing.Point(705, 19);
			this.defaultMatchingFARButton.Name = "defaultMatchingFARButton";
			this.defaultMatchingFARButton.Size = new System.Drawing.Size(63, 23);
			this.defaultMatchingFARButton.TabIndex = 20;
			this.defaultMatchingFARButton.Text = "Default";
			this.defaultMatchingFARButton.UseVisualStyleBackColor = true;
			this.defaultMatchingFARButton.Click += new System.EventHandler(this.DefaultMatchingFarButtonClick);
			// 
			// matchingFarComboBox
			// 
			this.matchingFarComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.matchingFarComboBox.FormattingEnabled = true;
			this.matchingFarComboBox.Location = new System.Drawing.Point(620, 21);
			this.matchingFarComboBox.Name = "matchingFarComboBox";
			this.matchingFarComboBox.Size = new System.Drawing.Size(79, 21);
			this.matchingFarComboBox.TabIndex = 19;
			this.matchingFarComboBox.Leave += new System.EventHandler(this.MatchingFarComboBoxLeave);
			this.matchingFarComboBox.Enter += new System.EventHandler(this.MatchingFarComboBoxEnter);
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox3.Controls.Add(this.defaultMatchingFARButton);
			this.groupBox3.Controls.Add(this.matchingFarComboBox);
			this.groupBox3.Controls.Add(this.listView);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.identifyButton);
			this.groupBox3.Location = new System.Drawing.Point(3, 335);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(774, 223);
			this.groupBox3.TabIndex = 11;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Identification";
			// 
			// listView
			// 
			this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
			this.listView.Location = new System.Drawing.Point(9, 48);
			this.listView.Name = "listView";
			this.listView.Size = new System.Drawing.Size(759, 169);
			this.listView.TabIndex = 2;
			this.listView.UseCompatibleStateImageBehavior = false;
			this.listView.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "ID";
			this.columnHeader1.Width = 300;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Score";
			this.columnHeader2.Width = 100;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(0, 13);
			this.label2.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(536, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Matching FAR:";
			// 
			// identifyButton
			// 
			this.identifyButton.Enabled = false;
			this.identifyButton.Location = new System.Drawing.Point(9, 19);
			this.identifyButton.Name = "identifyButton";
			this.identifyButton.Size = new System.Drawing.Size(92, 23);
			this.identifyButton.TabIndex = 0;
			this.identifyButton.Text = "&Identify";
			this.identifyButton.UseVisualStyleBackColor = true;
			this.identifyButton.Click += new System.EventHandler(this.IdentifyButtonClickAsync);
			// 
			// templatesCountLabel
			// 
			this.templatesCountLabel.AutoSize = true;
			this.templatesCountLabel.Location = new System.Drawing.Point(142, 34);
			this.templatesCountLabel.Name = "templatesCountLabel";
			this.templatesCountLabel.Size = new System.Drawing.Size(82, 13);
			this.templatesCountLabel.TabIndex = 7;
			this.templatesCountLabel.Text = "templates count";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(42, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Templates loaded:";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.defaultButton);
			this.groupBox2.Controls.Add(this.nViewZoomSlider1);
			this.groupBox2.Controls.Add(this.thresholdNumericUpDown);
			this.groupBox2.Controls.Add(this.ThresholdLabel);
			this.groupBox2.Controls.Add(this.chbShowBinarizedImage);
			this.groupBox2.Controls.Add(this.panel);
			this.groupBox2.Controls.Add(this.fileForIdentificationLabel);
			this.groupBox2.Controls.Add(this.openImageButton);
			this.groupBox2.Location = new System.Drawing.Point(3, 114);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(774, 215);
			this.groupBox2.TabIndex = 10;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Image / template for identification";
			// 
			// nViewZoomSlider1
			// 
			this.nViewZoomSlider1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.nViewZoomSlider1.Location = new System.Drawing.Point(491, 167);
			this.nViewZoomSlider1.Name = "nViewZoomSlider1";
			this.nViewZoomSlider1.Size = new System.Drawing.Size(275, 23);
			this.nViewZoomSlider1.TabIndex = 18;
			this.nViewZoomSlider1.Text = "nViewZoomSlider1";
			this.nViewZoomSlider1.View = this.fingerView;
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
			this.fingerView.Size = new System.Drawing.Size(755, 139);
			this.fingerView.TabIndex = 0;
			this.fingerView.TreeColor = System.Drawing.Color.Crimson;
			this.fingerView.TreeMinutiaNumberDiplayFormat = Neurotec.Biometrics.Gui.MinutiaNumberDiplayFormat.DontDisplay;
			this.fingerView.TreeMinutiaNumberFont = new System.Drawing.Font("Arial", 10F);
			this.fingerView.TreeWidth = 2;
			this.fingerView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FingerViewMouseClick);
			// 
			// chbShowBinarizedImage
			// 
			this.chbShowBinarizedImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.chbShowBinarizedImage.AutoSize = true;
			this.chbShowBinarizedImage.Checked = true;
			this.chbShowBinarizedImage.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbShowBinarizedImage.Enabled = false;
			this.chbShowBinarizedImage.Location = new System.Drawing.Point(356, 171);
			this.chbShowBinarizedImage.Name = "chbShowBinarizedImage";
			this.chbShowBinarizedImage.Size = new System.Drawing.Size(129, 17);
			this.chbShowBinarizedImage.TabIndex = 12;
			this.chbShowBinarizedImage.Text = "Show binarized image";
			this.chbShowBinarizedImage.UseVisualStyleBackColor = true;
			this.chbShowBinarizedImage.CheckedChanged += new System.EventHandler(this.ChbShowBinarizedImageCheckedChanged);
			// 
			// panel
			// 
			this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.panel.AutoScroll = true;
			this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel.Controls.Add(this.fingerView);
			this.panel.Location = new System.Drawing.Point(9, 20);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(759, 143);
			this.panel.TabIndex = 11;
			// 
			// fileForIdentificationLabel
			// 
			this.fileForIdentificationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.fileForIdentificationLabel.Location = new System.Drawing.Point(6, 199);
			this.fileForIdentificationLabel.Name = "fileForIdentificationLabel";
			this.fileForIdentificationLabel.Size = new System.Drawing.Size(661, 13);
			this.fileForIdentificationLabel.TabIndex = 10;
			// 
			// openImageButton
			// 
			this.openImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.openImageButton.Image = ((System.Drawing.Image)(resources.GetObject("openImageButton.Image")));
			this.openImageButton.Location = new System.Drawing.Point(9, 167);
			this.openImageButton.Name = "openImageButton";
			this.openImageButton.Size = new System.Drawing.Size(92, 23);
			this.openImageButton.TabIndex = 8;
			this.openImageButton.Text = "Open";
			this.openImageButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.openImageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.openImageButton, "Open fingerprint image for indentification");
			this.openImageButton.UseVisualStyleBackColor = true;
			this.openImageButton.Click += new System.EventHandler(this.OpenImageButtonClickAsync);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.templatesCountLabel);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.openTemplatesButton);
			this.groupBox1.Location = new System.Drawing.Point(6, 51);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(774, 57);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Templates loading";
			// 
			// licensePanel
			// 
			this.licensePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.licensePanel.Location = new System.Drawing.Point(0, 0);
			this.licensePanel.Name = "licensePanel";
			this.licensePanel.OptionalComponents = "Images.WSQ";
			this.licensePanel.RequiredComponents = "Biometrics.FingerExtraction,Biometrics.FingerMatching";
			this.licensePanel.Size = new System.Drawing.Size(780, 45);
			this.licensePanel.TabIndex = 12;
			// 
			// IdentifyFinger
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.licensePanel);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "IdentifyFinger";
			this.Size = new System.Drawing.Size(780, 561);
			this.Load += new System.EventHandler(this.IdentifyFingerLoad);
			this.VisibleChanged += new System.EventHandler(this.IdentifyFingerVisibleChanged);
			((System.ComponentModel.ISupportInitialize)(this.thresholdNumericUpDown)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.panel.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button openTemplatesButton;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.Button defaultButton;
		private System.Windows.Forms.NumericUpDown thresholdNumericUpDown;
		private System.Windows.Forms.Label ThresholdLabel;
		private System.Windows.Forms.Button defaultMatchingFARButton;
		private System.Windows.Forms.ComboBox matchingFarComboBox;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ListView listView;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button identifyButton;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.Label templatesCountLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Panel panel;
		private System.Windows.Forms.Label fileForIdentificationLabel;
		private System.Windows.Forms.Button openImageButton;
		private System.Windows.Forms.GroupBox groupBox1;
		private LicensePanel licensePanel;
		private Neurotec.Biometrics.Gui.NFingerView fingerView;
		private System.Windows.Forms.CheckBox chbShowBinarizedImage;
		private Neurotec.Gui.NViewZoomSlider nViewZoomSlider1;
		private System.Windows.Forms.Label label3;
	}
}
