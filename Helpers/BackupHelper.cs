using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Timers;

namespace XRSGHelper.Helpers
{
	class BackupHelper
	{
		private static bool Busy = false;
		private static string[] ScanList = new string[] {
			"quicksave.xml",
			"save_001.xml",
			"save_002.xml",
			"save_003.xml",
			"save_004.xml",
			"save_005.xml",
			"save_006.xml",
			"save_007.xml",
			"save_008.xml",
			"save_009.xml",
			"save_010.xml",
		};

		private static Timer WatchTimer;
		private static string watchingProfile;

		public static string GetProfileBackupsPath(string profile)
		{
			return Path.Combine(PathHelper.GetProfilePath(profile), "save-archives");
		}

		protected static void CreateArchivesFolder(string profile)
		{
			string archivePath = BackupHelper.GetProfileBackupsPath(profile);
			if (!Directory.Exists(archivePath))
				Directory.CreateDirectory(archivePath);
		}

		public static void ScanAndBackup(string profile)
		{
			if (BackupHelper.Busy)
			{
				Logger.Log("Skipping savegame ScanAndBackup because Busy flag is set");
				return;
			}
			BackupHelper.Busy = true;
			Logger.Log(String.Format("ScanAndBackup: {0}", profile));
			foreach (string savename in BackupHelper.ScanList)
			{
				string savepath = Path.Combine(PathHelper.GetProfileSavegamesPath(profile), savename);
				if (File.Exists(savepath))
				{
					FileInfo saveinfo = new FileInfo(savepath);
					string archivepath = BackupHelper.ArchivePathFor(saveinfo, profile);
					if (!File.Exists(archivepath))
					{
						Logger.Log(String.Format("Archiving {0} to {1}", saveinfo.FullName, archivepath));
						BackupHelper.ArchiveTo(saveinfo, archivepath, profile);
					}
				}
			}
			BackupHelper.Busy = false;
		}

		protected static string GetSavenamePath(string profile, string savename)
		{
			return Path.Combine(PathHelper.GetProfileSavegamesPath(profile), savename);
		}

		public static bool ArchiveTo(FileInfo savegame, string destination, string profile)
		{
			BackupHelper.CreateArchivesFolder(profile);
			FileStream stream = null;
			try
			{
				//Check if file is being written
				stream = savegame.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None);
				//Immediately release the handle, we do not want X Rebirth to crash trying to overwrite it
				//	I choosen game stability over corruption protection
				stream.Close();
				savegame.CopyTo(destination, false);
				return true;
			}
			catch (Exception e)
			{
				Logger.Log(String.Format("Encountered an Exception while trying to archive {0}, file is probably busy. Exception: {1}", savegame.FullName, e.ToString()));
			}
			return false;
		}

		public static string ArchivePathFor(FileInfo savegame, string profile)
		{
			DateTime lastWrite = savegame.LastWriteTime;
			return Path.Combine(BackupHelper.GetProfileBackupsPath(profile), lastWrite.ToString("yyyy-MM-dd-HHmmss") + "_" + savegame.Name);
		}

		public static void StartWatching(string profile)
		{
			if (BackupHelper.WatchTimer != null)
				throw new Exception("Already watching !");
			BackupHelper.watchingProfile = profile;
			BackupHelper.WatchTimer = new Timer(Convert.ToDouble(System.Configuration.ConfigurationManager.AppSettings.Get("BackupHelperWatchInterval") ?? "30000"));
			BackupHelper.WatchTimer.Elapsed += new ElapsedEventHandler(WatchTimer_Elapsed);
			BackupHelper.WatchTimer.Start();
		}

		protected static void WatchTimer_Elapsed(object source, ElapsedEventArgs e)
		{
			Timer timer = source as Timer;
			timer.Stop();
			BackupHelper.ScanAndBackup(BackupHelper.watchingProfile);
			timer.Start();
		}

		public static void StopWatching()
		{
			if (BackupHelper.WatchTimer != null)
			{
				BackupHelper.WatchTimer.Stop();
				BackupHelper.WatchTimer.Close();
				BackupHelper.WatchTimer = null;
			}
			BackupHelper.watchingProfile = null;
		}
	}
}
