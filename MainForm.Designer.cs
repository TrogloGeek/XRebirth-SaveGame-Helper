namespace XRSGHelper
{
	partial class MainForm
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.BackupTab = new System.Windows.Forms.TabPage();
			this.OpenProfileFolderBtn = new System.Windows.Forms.Button();
			this.AutoBackupStopBtn = new System.Windows.Forms.Button();
			this.AutobackupStartBtn = new System.Windows.Forms.Button();
			this.BackupBtn = new System.Windows.Forms.Button();
			this.ProfilesSelector = new System.Windows.Forms.ListBox();
			this.LogsTab = new System.Windows.Forms.TabPage();
			this.LogOutput = new System.Windows.Forms.RichTextBox();
			this.tabControl1.SuspendLayout();
			this.BackupTab.SuspendLayout();
			this.LogsTab.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.BackupTab);
			this.tabControl1.Controls.Add(this.LogsTab);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(252, 287);
			this.tabControl1.TabIndex = 1;
			// 
			// BackupTab
			// 
			this.BackupTab.Controls.Add(this.OpenProfileFolderBtn);
			this.BackupTab.Controls.Add(this.AutoBackupStopBtn);
			this.BackupTab.Controls.Add(this.AutobackupStartBtn);
			this.BackupTab.Controls.Add(this.BackupBtn);
			this.BackupTab.Controls.Add(this.ProfilesSelector);
			this.BackupTab.Location = new System.Drawing.Point(4, 22);
			this.BackupTab.Name = "BackupTab";
			this.BackupTab.Padding = new System.Windows.Forms.Padding(3);
			this.BackupTab.Size = new System.Drawing.Size(244, 261);
			this.BackupTab.TabIndex = 0;
			this.BackupTab.Text = "Backup";
			this.BackupTab.UseVisualStyleBackColor = true;
			// 
			// OpenProfileFolderBtn
			// 
			this.OpenProfileFolderBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.OpenProfileFolderBtn.Enabled = false;
			this.OpenProfileFolderBtn.Location = new System.Drawing.Point(163, 93);
			this.OpenProfileFolderBtn.Name = "OpenProfileFolderBtn";
			this.OpenProfileFolderBtn.Size = new System.Drawing.Size(75, 23);
			this.OpenProfileFolderBtn.TabIndex = 8;
			this.OpenProfileFolderBtn.Text = "Open folder";
			this.OpenProfileFolderBtn.UseVisualStyleBackColor = true;
			this.OpenProfileFolderBtn.Click += new System.EventHandler(this.OpenProfileFolderBtn_Click);
			// 
			// AutoBackupStopBtn
			// 
			this.AutoBackupStopBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.AutoBackupStopBtn.Enabled = false;
			this.AutoBackupStopBtn.Location = new System.Drawing.Point(163, 64);
			this.AutoBackupStopBtn.Name = "AutoBackupStopBtn";
			this.AutoBackupStopBtn.Size = new System.Drawing.Size(75, 23);
			this.AutoBackupStopBtn.TabIndex = 7;
			this.AutoBackupStopBtn.Text = "Stop";
			this.AutoBackupStopBtn.UseVisualStyleBackColor = true;
			this.AutoBackupStopBtn.Click += new System.EventHandler(this.AutoBackupStopBtn_Click);
			// 
			// AutobackupStartBtn
			// 
			this.AutobackupStartBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.AutobackupStartBtn.Enabled = false;
			this.AutobackupStartBtn.Location = new System.Drawing.Point(163, 35);
			this.AutobackupStartBtn.Name = "AutobackupStartBtn";
			this.AutobackupStartBtn.Size = new System.Drawing.Size(75, 23);
			this.AutobackupStartBtn.TabIndex = 6;
			this.AutobackupStartBtn.Text = "Autobackup";
			this.AutobackupStartBtn.UseVisualStyleBackColor = true;
			this.AutobackupStartBtn.Click += new System.EventHandler(this.AutobackupStartBtn_Click);
			// 
			// BackupBtn
			// 
			this.BackupBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BackupBtn.Enabled = false;
			this.BackupBtn.Location = new System.Drawing.Point(163, 6);
			this.BackupBtn.Name = "BackupBtn";
			this.BackupBtn.Size = new System.Drawing.Size(75, 23);
			this.BackupBtn.TabIndex = 5;
			this.BackupBtn.Text = "Backup";
			this.BackupBtn.UseVisualStyleBackColor = true;
			this.BackupBtn.Click += new System.EventHandler(this.BackupBtn_Click);
			// 
			// ProfilesSelector
			// 
			this.ProfilesSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ProfilesSelector.Enabled = false;
			this.ProfilesSelector.FormattingEnabled = true;
			this.ProfilesSelector.Location = new System.Drawing.Point(6, 6);
			this.ProfilesSelector.Name = "ProfilesSelector";
			this.ProfilesSelector.Size = new System.Drawing.Size(151, 108);
			this.ProfilesSelector.TabIndex = 4;
			this.ProfilesSelector.SelectedIndexChanged += new System.EventHandler(this.ProfilesSelector_SelectedIndexChanged);
			// 
			// LogsTab
			// 
			this.LogsTab.Controls.Add(this.LogOutput);
			this.LogsTab.Location = new System.Drawing.Point(4, 22);
			this.LogsTab.Name = "LogsTab";
			this.LogsTab.Padding = new System.Windows.Forms.Padding(3);
			this.LogsTab.Size = new System.Drawing.Size(244, 261);
			this.LogsTab.TabIndex = 1;
			this.LogsTab.Text = "Logs";
			this.LogsTab.UseVisualStyleBackColor = true;
			// 
			// LogOutput
			// 
			this.LogOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LogOutput.Location = new System.Drawing.Point(6, 6);
			this.LogOutput.Name = "LogOutput";
			this.LogOutput.ReadOnly = true;
			this.LogOutput.Size = new System.Drawing.Size(232, 249);
			this.LogOutput.TabIndex = 0;
			this.LogOutput.Text = "";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(276, 311);
			this.Controls.Add(this.tabControl1);
			this.Name = "MainForm";
			this.Text = "XRGSHelper";
			this.tabControl1.ResumeLayout(false);
			this.BackupTab.ResumeLayout(false);
			this.LogsTab.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage BackupTab;
		private System.Windows.Forms.TabPage LogsTab;
		private System.Windows.Forms.Button AutoBackupStopBtn;
		private System.Windows.Forms.Button AutobackupStartBtn;
		private System.Windows.Forms.Button BackupBtn;
		private System.Windows.Forms.ListBox ProfilesSelector;
		private System.Windows.Forms.Button OpenProfileFolderBtn;
		private System.Windows.Forms.RichTextBox LogOutput;
	}
}

