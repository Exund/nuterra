namespace Nuterra.Installer
{
	partial class InstallProgressForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.downloadPackageProgress = new System.Windows.Forms.ProgressBar();
			this.accessModProgress = new System.Windows.Forms.ProgressBar();
			this.nuterraModProgress = new System.Windows.Forms.ProgressBar();
			this.unpackResourcesProgress = new System.Windows.Forms.ProgressBar();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// downloadPackageProgress
			// 
			this.downloadPackageProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.downloadPackageProgress.Location = new System.Drawing.Point(12, 25);
			this.downloadPackageProgress.Name = "downloadPackageProgress";
			this.downloadPackageProgress.Size = new System.Drawing.Size(284, 23);
			this.downloadPackageProgress.TabIndex = 0;
			// 
			// accessModProgress
			// 
			this.accessModProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.accessModProgress.Location = new System.Drawing.Point(12, 151);
			this.accessModProgress.Name = "accessModProgress";
			this.accessModProgress.Size = new System.Drawing.Size(284, 23);
			this.accessModProgress.TabIndex = 1;
			// 
			// nuterraModProgress
			// 
			this.nuterraModProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nuterraModProgress.Location = new System.Drawing.Point(12, 109);
			this.nuterraModProgress.Name = "nuterraModProgress";
			this.nuterraModProgress.Size = new System.Drawing.Size(284, 23);
			this.nuterraModProgress.TabIndex = 2;
			// 
			// unpackResourcesProgress
			// 
			this.unpackResourcesProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.unpackResourcesProgress.Location = new System.Drawing.Point(12, 67);
			this.unpackResourcesProgress.Name = "unpackResourcesProgress";
			this.unpackResourcesProgress.Size = new System.Drawing.Size(284, 23);
			this.unpackResourcesProgress.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(151, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Downloading release package";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 135);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Modifying accessors";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 93);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Installing Nuterra";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 51);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(108, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Unpacking resources";
			// 
			// InstallProgressForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(308, 185);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.unpackResourcesProgress);
			this.Controls.Add(this.nuterraModProgress);
			this.Controls.Add(this.accessModProgress);
			this.Controls.Add(this.downloadPackageProgress);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(232, 224);
			this.Name = "InstallProgressForm";
			this.Text = "Nuterra Installer";
			this.Load += new System.EventHandler(this.InstallProgressForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ProgressBar downloadPackageProgress;
		private System.Windows.Forms.ProgressBar accessModProgress;
		private System.Windows.Forms.ProgressBar nuterraModProgress;
		private System.Windows.Forms.ProgressBar unpackResourcesProgress;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}