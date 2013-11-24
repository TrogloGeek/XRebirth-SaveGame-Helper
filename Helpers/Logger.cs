using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XRSGHelper.Helpers
{
	class Logger
	{
		protected static List<string> Logs = new List<string>();

		public static string[] LogLines
		{
			get { return Logger.Logs.ToArray(); }
		}

		public static void Log(string message)
		{
			string logMessage = DateTime.Now.ToString("G") + ": " + message;
			Logs.Add(logMessage);
		}

		public static void Save()
		{
			System.IO.File.AppendAllLines(DateTime.Now.ToString("yyyy-MM-dd") + ".log", Logger.Logs);
		}
	}
}
