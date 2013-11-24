using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XRSGHelper.Helpers;

namespace XRSGHelper
{
	public partial class MainForm : Form
	{
		static private MainForm _Instance;
		static public MainForm Instance
		{
			get { return MainForm._Instance; }
		}

		protected System.Timers.Timer LogUpdater;
		protected string _backupProfileSelected;

		public MainForm()
		{
			MainForm._Instance = this;
			InitializeComponent();
			Logger.Log("Application started, will now search your X Rebirth profiles");
			foreach (string profile in PathHelper.GetXRebirthProfilesWithSavegames())
			{
				this.ProfilesSelector.Items.Add(profile);
			}
			this.ProfilesSelector.Enabled = true;
			this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);
			this.LogUpdater = new System.Timers.Timer(1000);
			this.LogUpdater.Elapsed += new System.Timers.ElapsedEventHandler(LogUpdater_Elapsed);
			this.LogUpdater.Start();
			
		}

		public delegate void UIDelegate();

		void LogUpdater_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			this.LogUpdater.Stop();
			this.UpdateLogs(Logger.LogLines);
			this.LogUpdater.Start();
		}

		public void UpdateLogs(string[] logs)
		{
			if (this.InvokeRequired)
			{
				this.Invoke(new Action<string[]>(this.UpdateLogs), new object[] { logs });
				return;
			}
			this.LogOutput.Lines = logs;
		}

		void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			BackupHelper.StopWatching();
			this.LogUpdater.Stop();
			this.LogUpdater.Close();
			Logger.Save();
		}

		protected void SelectProfile(string profile)
		{
			this._backupProfileSelected = profile;
			this.BackupBtn.Enabled = true;
			this.AutobackupStartBtn.Enabled = true;
			this.AutoBackupStopBtn.Enabled = false;
			this.OpenProfileFolderBtn.Enabled = true;
		}

		protected void UnselectProfile()
		{
			this._backupProfileSelected = null;
			this.BackupBtn.Enabled = false;
			this.AutobackupStartBtn.Enabled = false;
			this.AutoBackupStopBtn.Enabled = false;
			this.OpenProfileFolderBtn.Enabled = false;
		}

		private void OpenProfileFolderBtn_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process proc = new System.Diagnostics.Process();
			proc.StartInfo.FileName = PathHelper.GetProfilePath(this._backupProfileSelected);
			proc.Start();
		}

		private void ProfilesSelector_SelectedIndexChanged(object sender, EventArgs e)
		{
			string selected = (sender as ListBox).SelectedItem as string;
			if (this._backupProfileSelected == selected)
				return;
			this.UnselectProfile();
			this.SelectProfile(selected);
		}

		private void AutobackupStartBtn_Click(object sender, EventArgs e)
		{
			this.AutobackupStartBtn.Enabled = false;
			BackupHelper.StartWatching(this._backupProfileSelected);
			this.AutoBackupStopBtn.Enabled = true;
		}

		private void AutoBackupStopBtn_Click(object sender, EventArgs e)
		{
			this.AutoBackupStopBtn.Enabled = false;
			BackupHelper.StopWatching();
			this.AutobackupStartBtn.Enabled = true;
		}

		private void BackupBtn_Click(object sender, EventArgs e)
		{
			BackupHelper.ScanAndBackup(this._backupProfileSelected);
		}
	}
}
