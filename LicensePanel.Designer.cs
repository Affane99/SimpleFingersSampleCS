namespace Neurotec.Samples
{
	partial class LicensePanel
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
			this.label1 = new System.Windows.Forms.Label();
			this.lblStatus = new System.Windows.Forms.Label();
			this.rtbComponents = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
			this.label1.Location = new System.Drawing.Point(5, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(178, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Required component licenses:";
			// 
			// lblStatus
			// 
			this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblStatus.AutoSize = true;
			this.lblStatus.ForeColor = System.Drawing.Color.Red;
			this.lblStatus.Location = new System.Drawing.Point(5, 20);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(164, 13);
			this.lblStatus.TabIndex = 3;
			this.lblStatus.Text = "Component licenses not obtained";
			// 
			// rtbComponents
			// 
			this.rtbComponents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.rtbComponents.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtbComponents.Enabled = false;
			this.rtbComponents.HideSelection = false;
			this.rtbComponents.Location = new System.Drawing.Point(189, 3);
			this.rtbComponents.Multiline = false;
			this.rtbComponents.Name = "rtbComponents";
			this.rtbComponents.ReadOnly = true;
			this.rtbComponents.Size = new System.Drawing.Size(228, 13);
			this.rtbComponents.TabIndex = 5;
			this.rtbComponents.Text = "Components";
			// 
			// LicensePanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.rtbComponents);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.label1);
			this.Name = "LicensePanel";
			this.Size = new System.Drawing.Size(420, 43);
			this.Load += new System.EventHandler(this.LicensePanelLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.RichTextBox rtbComponents;
	}
}
