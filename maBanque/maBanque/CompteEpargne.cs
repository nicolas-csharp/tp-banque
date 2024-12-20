using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;

namespace ma_banque
{
	public class CompteEpargne : Compte
	{
		private string type;
		private float tauxInteret; // si 10% alors la valeur sera 1.1

		public CompteEpargne()
		{
			
		}

		public float CalculerInteret()
		{
			return this.solde * this.tauxInteret;
		}
	}
}
