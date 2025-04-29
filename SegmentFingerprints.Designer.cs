namespace Neurotec.Samples
{
	partial class SegmentFingerprints
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SegmentFingerprints));
			this.chlbMissing = new System.Windows.Forms.CheckedListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnSaveImages = new System.Windows.Forms.Button();
			this.lbPosition = new System.Windows.Forms.ListBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.segmentButton = new System.Windows.Forms.Button();
			this.openButton = new System.Windows.Forms.Button();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.originalFingerView = new Neurotec.Biometrics.Gui.NFingerView();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lbQuality1 = new System.Windows.Forms.Label();
			this.lbClass1 = new System.Windows.Forms.Label();
			this.lbPosition1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.lbQuality3 = new System.Windows.Forms.Label();
			this.lbClass3 = new System.Windows.Forms.Label();
			this.lbPosition3 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.lbQuality4 = new System.Windows.Forms.Label();
			this.lbClass4 = new System.Windows.Forms.Label();
			this.lbPosition4 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lbQuality2 = new System.Windows.Forms.Label();
			this.lbClass2 = new System.Windows.Forms.Label();
			this.lbPosition2 = new System.Windows.Forms.Label();
			this.lblStatus = new System.Windows.Forms.Label();
			this.nViewZoomSlider1 = new Neurotec.Gui.NViewZoomSlider();
			this.licensePanel = new Neurotec.Samples.LicensePanel();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// chlbMissing
			// 
			this.chlbMissing.Dock = System.Windows.Forms.DockStyle.Fill;
			this.chlbMissing.FormattingEnabled = true;
			this.chlbMissing.Location = new System.Drawing.Point(168, 16);
			this.chlbMissing.Name = "chlbMissing";
			this.chlbMissing.Size = new System.Drawing.Size(159, 64);
			this.chlbMissing.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(159, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Position";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label2.Location = new System.Drawing.Point(168, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(159, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Missing positions";
			// 
			// btnSaveImages
			// 
			this.btnSaveImages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSaveImages.Enabled = false;
			this.btnSaveImages.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveImages.Image")));
			this.btnSaveImages.Location = new System.Drawing.Point(3, 349);
			this.btnSaveImages.Name = "btnSaveImages";
			this.btnSaveImages.Size = new System.Drawing.Size(96, 23);
			this.btnSaveImages.TabIndex = 10;
			this.btnSaveImages.Text = "Save Images";
			this.btnSaveImages.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSaveImages.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSaveImages.UseVisualStyleBackColor = true;
			this.btnSaveImages.Click += new System.EventHandler(this.BtnSaveImagesClick);
			// 
			// lbPosition
			// 
			this.lbPosition.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbPosition.FormattingEnabled = true;
			this.lbPosition.Location = new System.Drawing.Point(3, 16);
			this.lbPosition.Name = "lbPosition";
			this.lbPosition.Size = new System.Drawing.Size(159, 69);
			this.lbPosition.TabIndex = 11;
			this.lbPosition.SelectedIndexChanged += new System.EventHandler(this.LbPositionSelectedIndexChanged);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.lbPosition, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.chlbMissing, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.panel5, 2, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 42);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(429, 96);
			this.tableLayoutPanel1.TabIndex = 12;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.segmentButton);
			this.panel5.Controls.Add(this.openButton);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(333, 16);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(93, 77);
			this.panel5.TabIndex = 12;
			// 
			// segmentButton
			// 
			this.segmentButton.Location = new System.Drawing.Point(0, 51);
			this.segmentButton.Name = "segmentButton";
			this.segmentButton.Size = new System.Drawing.Size(93, 23);
			this.segmentButton.TabIndex = 4;
			this.segmentButton.Text = "Segment";
			this.segmentButton.UseVisualStyleBackColor = true;
			this.segmentButton.Click += new System.EventHandler(this.SegmentButtonClickAsync);
			// 
			// openButton
			// 
			this.openButton.Image = ((System.Drawing.Image)(resources.GetObject("openButton.Image")));
			this.openButton.Location = new System.Drawing.Point(0, 22);
			this.openButton.Name = "openButton";
			this.openButton.Size = new System.Drawing.Size(93, 23);
			this.openButton.TabIndex = 3;
			this.openButton.Tag = "Open";
			this.openButton.Text = "Open Image";
			this.openButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.openButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.openButton.UseVisualStyleBackColor = true;
			this.openButton.Click += new System.EventHandler(this.OpenButtonClickAsync);
			// 
			// folderBrowserDialog
			// 
			this.folderBrowserDialog.Description = "Select directory where to save cut images";
			// 
			// pictureBox2
			// 
			this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox2.Location = new System.Drawing.Point(0, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(100, 100);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 15;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox3.Location = new System.Drawing.Point(0, 0);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(100, 100);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 16;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox4.Location = new System.Drawing.Point(0, 0);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(102, 100);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox4.TabIndex = 17;
			this.pictureBox4.TabStop = false;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.Location = new System.Drawing.Point(9, 144);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.originalFingerView);
			this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
			this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.splitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.splitContainer1.Size = new System.Drawing.Size(426, 199);
			this.splitContainer1.SplitterDistance = 89;
			this.splitContainer1.TabIndex = 18;
			// 
			// originalFingerView
			// 
			this.originalFingerView.AutoScroll = true;
			this.originalFingerView.BackColor = System.Drawing.SystemColors.Control;
			this.originalFingerView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.originalFingerView.BoundingRectColor = System.Drawing.Color.Red;
			this.originalFingerView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.originalFingerView.Location = new System.Drawing.Point(0, 0);
			this.originalFingerView.MinutiaColor = System.Drawing.Color.Red;
			this.originalFingerView.Name = "originalFingerView";
			this.originalFingerView.NeighborMinutiaColor = System.Drawing.Color.Orange;
			this.originalFingerView.ResultImageColor = System.Drawing.Color.Green;
			this.originalFingerView.SelectedMinutiaColor = System.Drawing.Color.Magenta;
			this.originalFingerView.SelectedSingularPointColor = System.Drawing.Color.Magenta;
			this.originalFingerView.SingularPointColor = System.Drawing.Color.Red;
			this.originalFingerView.Size = new System.Drawing.Size(426, 89);
			this.originalFingerView.TabIndex = 0;
			this.originalFingerView.TreeColor = System.Drawing.Color.Crimson;
			this.originalFingerView.TreeMinutiaNumberDiplayFormat = Neurotec.Biometrics.Gui.MinutiaNumberDiplayFormat.DontDisplay;
			this.originalFingerView.TreeMinutiaNumberFont = new System.Drawing.Font("Arial", 10F);
			this.originalFingerView.TreeWidth = 2;
			this.originalFingerView.ZoomToFit = true;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 4;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.88263F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.88263F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.panel3, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.panel4, 3, 0);
			this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.Size = new System.Drawing.Size(426, 106);
			this.tableLayoutPanel2.TabIndex = 18;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lbQuality1);
			this.panel1.Controls.Add(this.lbClass1);
			this.panel1.Controls.Add(this.lbPosition1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(100, 100);
			this.panel1.TabIndex = 15;
			// 
			// lbQuality1
			// 
			this.lbQuality1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbQuality1.AutoSize = true;
			this.lbQuality1.Location = new System.Drawing.Point(3, 62);
			this.lbQuality1.Name = "lbQuality1";
			this.lbQuality1.Size = new System.Drawing.Size(42, 13);
			this.lbQuality1.TabIndex = 15;
			this.lbQuality1.Text = "Quality:";
			// 
			// lbClass1
			// 
			this.lbClass1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbClass1.AutoSize = true;
			this.lbClass1.Location = new System.Drawing.Point(3, 75);
			this.lbClass1.Name = "lbClass1";
			this.lbClass1.Size = new System.Drawing.Size(35, 13);
			this.lbClass1.TabIndex = 16;
			this.lbClass1.Text = "Class:";
			// 
			// lbPosition1
			// 
			this.lbPosition1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbPosition1.AutoSize = true;
			this.lbPosition1.Location = new System.Drawing.Point(3, 49);
			this.lbPosition1.Name = "lbPosition1";
			this.lbPosition1.Size = new System.Drawing.Size(47, 13);
			this.lbPosition1.TabIndex = 2;
			this.lbPosition1.Text = "Position:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 100);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 14;
			this.pictureBox1.TabStop = false;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.lbQuality3);
			this.panel3.Controls.Add(this.lbClass3);
			this.panel3.Controls.Add(this.lbPosition3);
			this.panel3.Controls.Add(this.pictureBox3);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(215, 3);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(100, 100);
			this.panel3.TabIndex = 17;
			// 
			// lbQuality3
			// 
			this.lbQuality3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbQuality3.AutoSize = true;
			this.lbQuality3.Location = new System.Drawing.Point(3, 62);
			this.lbQuality3.Name = "lbQuality3";
			this.lbQuality3.Size = new System.Drawing.Size(42, 13);
			this.lbQuality3.TabIndex = 21;
			this.lbQuality3.Text = "Quality:";
			// 
			// lbClass3
			// 
			this.lbClass3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbClass3.AutoSize = true;
			this.lbClass3.Location = new System.Drawing.Point(3, 75);
			this.lbClass3.Name = "lbClass3";
			this.lbClass3.Size = new System.Drawing.Size(35, 13);
			this.lbClass3.TabIndex = 22;
			this.lbClass3.Text = "Class:";
			// 
			// lbPosition3
			// 
			this.lbPosition3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbPosition3.AutoSize = true;
			this.lbPosition3.Location = new System.Drawing.Point(3, 49);
			this.lbPosition3.Name = "lbPosition3";
			this.lbPosition3.Size = new System.Drawing.Size(47, 13);
			this.lbPosition3.TabIndex = 20;
			this.lbPosition3.Text = "Position:";
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.lbQuality4);
			this.panel4.Controls.Add(this.lbClass4);
			this.panel4.Controls.Add(this.lbPosition4);
			this.panel4.Controls.Add(this.pictureBox4);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(321, 3);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(102, 100);
			this.panel4.TabIndex = 18;
			// 
			// lbQuality4
			// 
			this.lbQuality4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbQuality4.AutoSize = true;
			this.lbQuality4.Location = new System.Drawing.Point(3, 62);
			this.lbQuality4.Name = "lbQuality4";
			this.lbQuality4.Size = new System.Drawing.Size(42, 13);
			this.lbQuality4.TabIndex = 24;
			this.lbQuality4.Text = "Quality:";
			// 
			// lbClass4
			// 
			this.lbClass4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbClass4.AutoSize = true;
			this.lbClass4.Location = new System.Drawing.Point(3, 75);
			this.lbClass4.Name = "lbClass4";
			this.lbClass4.Size = new System.Drawing.Size(35, 13);
			this.lbClass4.TabIndex = 25;
			this.lbClass4.Text = "Class:";
			// 
			// lbPosition4
			// 
			this.lbPosition4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbPosition4.AutoSize = true;
			this.lbPosition4.Location = new System.Drawing.Point(3, 49);
			this.lbPosition4.Name = "lbPosition4";
			this.lbPosition4.Size = new System.Drawing.Size(47, 13);
			this.lbPosition4.TabIndex = 23;
			this.lbPosition4.Text = "Position:";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.lbQuality2);
			this.panel2.Controls.Add(this.lbClass2);
			this.panel2.Controls.Add(this.lbPosition2);
			this.panel2.Controls.Add(this.pictureBox2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(109, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(100, 100);
			this.panel2.TabIndex = 16;
			// 
			// lbQuality2
			// 
			this.lbQuality2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbQuality2.AutoSize = true;
			this.lbQuality2.Location = new System.Drawing.Point(3, 62);
			this.lbQuality2.Name = "lbQuality2";
			this.lbQuality2.Size = new System.Drawing.Size(42, 13);
			this.lbQuality2.TabIndex = 18;
			this.lbQuality2.Text = "Quality:";
			// 
			// lbClass2
			// 
			this.lbClass2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbClass2.AutoSize = true;
			this.lbClass2.Location = new System.Drawing.Point(3, 75);
			this.lbClass2.Name = "lbClass2";
			this.lbClass2.Size = new System.Drawing.Size(35, 13);
			this.lbClass2.TabIndex = 19;
			this.lbClass2.Text = "Class:";
			// 
			// lbPosition2
			// 
			this.lbPosition2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbPosition2.AutoSize = true;
			this.lbPosition2.Location = new System.Drawing.Point(3, 49);
			this.lbPosition2.Name = "lbPosition2";
			this.lbPosition2.Size = new System.Drawing.Size(47, 13);
			this.lbPosition2.TabIndex = 17;
			this.lbPosition2.Text = "Position:";
			// 
			// lblStatus
			// 
			this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new System.Drawing.Point(105, 354);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(0, 13);
			this.lblStatus.TabIndex = 19;
			// 
			// nViewZoomSlider1
			// 
			this.nViewZoomSlider1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.nViewZoomSlider1.Location = new System.Drawing.Point(160, 349);
			this.nViewZoomSlider1.Name = "nViewZoomSlider1";
			this.nViewZoomSlider1.Size = new System.Drawing.Size(275, 23);
			this.nViewZoomSlider1.TabIndex = 20;
			this.nViewZoomSlider1.Text = "nViewZoomSlider1";
			this.nViewZoomSlider1.View = this.originalFingerView;
			// 
			// licensePanel
			// 
			this.licensePanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.licensePanel.Location = new System.Drawing.Point(0, 0);
			this.licensePanel.Name = "licensePanel";
			this.licensePanel.OptionalComponents = "Images.WSQ,Biometrics.FingerQualityAssessmentBase";
			this.licensePanel.RequiredComponents = "Biometrics.FingerSegmentation";
			this.licensePanel.Size = new System.Drawing.Size(438, 43);
			this.licensePanel.TabIndex = 0;
			// 
			// SegmentFingerprints
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.nViewZoomSlider1);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.btnSaveImages);
			this.Controls.Add(this.licensePanel);
			this.Name = "SegmentFingerprints";
			this.Size = new System.Drawing.Size(438, 377);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private LicensePanel licensePanel;
		private System.Windows.Forms.CheckedListBox chlbMissing;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnSaveImages;
		private System.Windows.Forms.ListBox lbPosition;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label lbPosition1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lbClass1;
		private System.Windows.Forms.Label lbQuality1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label lbQuality3;
		private System.Windows.Forms.Label lbClass3;
		private System.Windows.Forms.Label lbPosition3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label lbQuality4;
		private System.Windows.Forms.Label lbClass4;
		private System.Windows.Forms.Label lbPosition4;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lbQuality2;
		private System.Windows.Forms.Label lbClass2;
		private System.Windows.Forms.Label lbPosition2;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Button openButton;
		private System.Windows.Forms.Button segmentButton;
		private Neurotec.Biometrics.Gui.NFingerView originalFingerView;
		private System.Windows.Forms.PictureBox pictureBox1;
		private Neurotec.Gui.NViewZoomSlider nViewZoomSlider1;
	}
}
