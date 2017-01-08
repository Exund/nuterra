namespace Nuterra.Installer
{
	partial class InstallSettingsForm
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.packageSourceComboBox = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.installModeComboBox = new System.Windows.Forms.ComboBox();
			this.installDirButton = new System.Windows.Forms.Button();
			this.terraTechDirTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.refreshVersionsButton = new System.Windows.Forms.Button();
			this.includePreReleasesCheckBox = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.releaseComboBox = new System.Windows.Forms.ComboBox();
			this.startButton = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.packageSourceTabControl = new System.Windows.Forms.TabControl();
			this.githubPackageTab = new System.Windows.Forms.TabPage();
			this.localPackageTab = new System.Windows.Forms.TabPage();
			this.label6 = new System.Windows.Forms.Label();
			this.localPackageButton = new System.Windows.Forms.Button();
			this.localPackageTextBox = new System.Windows.Forms.TextBox();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.packageSourceTabControl.SuspendLayout();
			this.githubPackageTab.SuspendLayout();
			this.localPackageTab.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.packageSourceComboBox);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.installModeComboBox);
			this.groupBox2.Controls.Add(this.installDirButton);
			this.groupBox2.Controls.Add(this.terraTechDirTextBox);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new System.Drawing.Point(12, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(519, 106);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Install options";
			// 
			// packageSourceComboBox
			// 
			this.packageSourceComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.packageSourceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.packageSourceComboBox.FormattingEnabled = true;
			this.packageSourceComboBox.Location = new System.Drawing.Point(100, 72);
			this.packageSourceComboBox.Name = "packageSourceComboBox";
			this.packageSourceComboBox.Size = new System.Drawing.Size(412, 21);
			this.packageSourceComboBox.TabIndex = 6;
			this.packageSourceComboBox.SelectedIndexChanged += new System.EventHandler(this.packageSourceComboBox_SelectedIndexChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 75);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Package source:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Install mode:";
			// 
			// installModeComboBox
			// 
			this.installModeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.installModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.installModeComboBox.FormattingEnabled = true;
			this.installModeComboBox.Location = new System.Drawing.Point(100, 45);
			this.installModeComboBox.Name = "installModeComboBox";
			this.installModeComboBox.Size = new System.Drawing.Size(412, 21);
			this.installModeComboBox.TabIndex = 3;
			// 
			// installDirButton
			// 
			this.installDirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.installDirButton.Location = new System.Drawing.Point(485, 19);
			this.installDirButton.Name = "installDirButton";
			this.installDirButton.Size = new System.Drawing.Size(27, 20);
			this.installDirButton.TabIndex = 2;
			this.installDirButton.Text = "...";
			this.installDirButton.UseVisualStyleBackColor = true;
			this.installDirButton.Click += new System.EventHandler(this.installDirButton_Click);
			// 
			// terraTechDirTextBox
			// 
			this.terraTechDirTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.terraTechDirTextBox.Location = new System.Drawing.Point(100, 19);
			this.terraTechDirTextBox.Name = "terraTechDirTextBox";
			this.terraTechDirTextBox.Size = new System.Drawing.Size(379, 20);
			this.terraTechDirTextBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "TerraTech dir:";
			// 
			// refreshVersionsButton
			// 
			this.refreshVersionsButton.Location = new System.Drawing.Point(235, 3);
			this.refreshVersionsButton.Name = "refreshVersionsButton";
			this.refreshVersionsButton.Size = new System.Drawing.Size(75, 21);
			this.refreshVersionsButton.TabIndex = 10;
			this.refreshVersionsButton.Text = "Refresh";
			this.refreshVersionsButton.UseVisualStyleBackColor = true;
			this.refreshVersionsButton.Click += new System.EventHandler(this.refreshVersionsButton_Click);
			// 
			// includePreReleasesCheckBox
			// 
			this.includePreReleasesCheckBox.AutoSize = true;
			this.includePreReleasesCheckBox.Location = new System.Drawing.Point(316, 5);
			this.includePreReleasesCheckBox.Name = "includePreReleasesCheckBox";
			this.includePreReleasesCheckBox.Size = new System.Drawing.Size(84, 17);
			this.includePreReleasesCheckBox.TabIndex = 9;
			this.includePreReleasesCheckBox.Text = "Pre-releases";
			this.includePreReleasesCheckBox.UseVisualStyleBackColor = true;
			this.includePreReleasesCheckBox.CheckedChanged += new System.EventHandler(this.includePreReleasesCheckBox_CheckedChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(0, 7);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(82, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Nuterra version:";
			// 
			// releaseComboBox
			// 
			this.releaseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.releaseComboBox.FormattingEnabled = true;
			this.releaseComboBox.Location = new System.Drawing.Point(93, 3);
			this.releaseComboBox.Name = "releaseComboBox";
			this.releaseComboBox.Size = new System.Drawing.Size(136, 21);
			this.releaseComboBox.TabIndex = 7;
			// 
			// startButton
			// 
			this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.startButton.Location = new System.Drawing.Point(456, 190);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(75, 23);
			this.startButton.TabIndex = 5;
			this.startButton.Text = "Install";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.startButton_Click);
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 195);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(139, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Installer by Maritaria (v0.0.1)";
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.packageSourceTabControl);
			this.groupBox1.Location = new System.Drawing.Point(12, 124);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(519, 57);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Package source";
			// 
			// packageSourceTabControl
			// 
			this.packageSourceTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
			this.packageSourceTabControl.Controls.Add(this.githubPackageTab);
			this.packageSourceTabControl.Controls.Add(this.localPackageTab);
			this.packageSourceTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.packageSourceTabControl.ItemSize = new System.Drawing.Size(0, 1);
			this.packageSourceTabControl.Location = new System.Drawing.Point(3, 16);
			this.packageSourceTabControl.Name = "packageSourceTabControl";
			this.packageSourceTabControl.SelectedIndex = 0;
			this.packageSourceTabControl.Size = new System.Drawing.Size(513, 38);
			this.packageSourceTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.packageSourceTabControl.TabIndex = 0;
			// 
			// githubPackageTab
			// 
			this.githubPackageTab.Controls.Add(this.refreshVersionsButton);
			this.githubPackageTab.Controls.Add(this.label4);
			this.githubPackageTab.Controls.Add(this.includePreReleasesCheckBox);
			this.githubPackageTab.Controls.Add(this.releaseComboBox);
			this.githubPackageTab.Location = new System.Drawing.Point(4, 5);
			this.githubPackageTab.Name = "githubPackageTab";
			this.githubPackageTab.Size = new System.Drawing.Size(505, 29);
			this.githubPackageTab.TabIndex = 0;
			this.githubPackageTab.Text = "Github";
			this.githubPackageTab.UseVisualStyleBackColor = true;
			// 
			// localPackageTab
			// 
			this.localPackageTab.Controls.Add(this.label6);
			this.localPackageTab.Controls.Add(this.localPackageButton);
			this.localPackageTab.Controls.Add(this.localPackageTextBox);
			this.localPackageTab.Location = new System.Drawing.Point(4, 5);
			this.localPackageTab.Name = "localPackageTab";
			this.localPackageTab.Padding = new System.Windows.Forms.Padding(3);
			this.localPackageTab.Size = new System.Drawing.Size(505, 29);
			this.localPackageTab.TabIndex = 1;
			this.localPackageTab.Text = "Local";
			this.localPackageTab.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(75, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "Local mod.zip:";
			// 
			// localPackageButton
			// 
			this.localPackageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.localPackageButton.Location = new System.Drawing.Point(472, 6);
			this.localPackageButton.Name = "localPackageButton";
			this.localPackageButton.Size = new System.Drawing.Size(27, 20);
			this.localPackageButton.TabIndex = 4;
			this.localPackageButton.Text = "...";
			this.localPackageButton.UseVisualStyleBackColor = true;
			this.localPackageButton.Click += new System.EventHandler(this.localPackageButton_Click);
			// 
			// localPackageTextBox
			// 
			this.localPackageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.localPackageTextBox.Location = new System.Drawing.Point(93, 6);
			this.localPackageTextBox.Name = "localPackageTextBox";
			this.localPackageTextBox.Size = new System.Drawing.Size(373, 20);
			this.localPackageTextBox.TabIndex = 3;
			// 
			// InstallSettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(543, 225);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.startButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "InstallSettingsForm";
			this.Text = "Nuterra Installer";
			this.Load += new System.EventHandler(this.InstallSettingsForm_Load);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.packageSourceTabControl.ResumeLayout(false);
			this.githubPackageTab.ResumeLayout(false);
			this.githubPackageTab.PerformLayout();
			this.localPackageTab.ResumeLayout(false);
			this.localPackageTab.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox installModeComboBox;
		private System.Windows.Forms.Button installDirButton;
		private System.Windows.Forms.TextBox terraTechDirTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox releaseComboBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox includePreReleasesCheckBox;
		private System.Windows.Forms.Button refreshVersionsButton;
		private System.Windows.Forms.ComboBox packageSourceComboBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TabControl packageSourceTabControl;
		private System.Windows.Forms.TabPage githubPackageTab;
		private System.Windows.Forms.TabPage localPackageTab;
		private System.Windows.Forms.Button localPackageButton;
		private System.Windows.Forms.TextBox localPackageTextBox;
		private System.Windows.Forms.Label label6;
	}
}

