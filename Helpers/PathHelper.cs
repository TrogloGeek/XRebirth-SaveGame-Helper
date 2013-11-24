using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace XRSGHelper.Helpers
{
	class PathHelper
	{
		public static string GetXRebirthDocumentPath()
		{
			return Path.Combine(
				Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
				"Egosoft",
				"X Rebirth"
			);
		}

		public static IEnumerable<string> GetXRebirthProfilesWithSavegames()
		{
			string xRebirthDocPath = PathHelper.GetXRebirthDocumentPath();
			List<string> profiles = new List<string>();
			if (!Directory.Exists(xRebirthDocPath))
			{
				Logger.Log(String.Format("Expecting to find your X Rebirth document folder at `{0}`, nothing here. Sorry I won't be able to backup your savegames.", xRebirthDocPath));
				return profiles;
			}
			foreach (string profileFolder in Directory.GetDirectories(xRebirthDocPath, "*", SearchOption.TopDirectoryOnly))
				if (Directory.Exists(Path.Combine(profileFolder, "save")))
					profiles.Add(profileFolder.Split(Path.DirectorySeparatorChar).Last());
			return profiles;
		}

		public static string GetProfilePath(string profile)
		{
			return Path.Combine(PathHelper.GetXRebirthDocumentPath(), profile);
		}

		public static string GetProfileSavegamesPath(string profile)
		{
			return Path.Combine(PathHelper.GetProfilePath(profile), "save");
		}
	}
}
