
using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;

namespace ma_banque
{
	public class Conseiller
	{
		private int id;
		private string nom;
		private string prenom;
		private string login;
		private string password;
		private List<Client> cliens;

		public Conseiller()
		{
			
		}
	}
}