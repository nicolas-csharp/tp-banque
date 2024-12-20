using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;

namespace ma_banque
{
	public abstract class Compte
	{
		private int id;
		private float solde;
			
		public Compte()
		{
			
		}

		public Deposer(float montant)
		{
			this.solde += montant;
		}

		public Retirer(float monatnt)
		{
			if (this.solde > montant)
			{
				this.solde -= montant;
			}
		}
	}
}
