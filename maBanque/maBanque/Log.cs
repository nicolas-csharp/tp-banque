using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;

namespace ma_banque
{
	public static class Log
	{
		public static void WriteLog(string logMessage, System.IO.TexWriter w)
		{
			w.Write("\r\nLog Entry : ");
			w.Write($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongString()}");
			w.Write(" :");
			w.Write($" :{logMessage}");
			w.Write("-------------------------------");
		}

		public static void DumpLog(System.IO.StreamReader r)
		{
			string line;
			while ((line = r.ReadLine()) != null)
			{
				Console.WriteLine(line);
			}
		}
	}
}
