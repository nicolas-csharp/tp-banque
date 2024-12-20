using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;


namespace ma_banque
{
	public class Connection
	{
		private static SqlConnection sqlConnection;
		private static Connection instance;

		private Connection() { }

		public SqlConnection GetSqlConnection()
		{
			string connectionString;
			try
			{
				connectionString = ConfigurationManager.ConnectionStrings["sqlserver_banque"].ConnectionString;
				sqlConnection = new SqlConnection(connectionString);
				sqlConnection.Open();
			}
			catch (SqlException)
			{
				using (StreamWriter w = File.AppendText("../Logs/logerror.txt"))
				{
					Log.WriteLog("Connection : erreur de cpnnexion au serveu", w);
				}
			}
			return sqlConnection;
		}


		public static Connection getInstance()
		{
			if (Connection.instance == null)

			{
				Connection.instance = new Connection();
			}
			return Connection.instance;
		}
	}
}
