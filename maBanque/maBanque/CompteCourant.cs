using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;

namespace ma_banque
{
	public class CompteCourant : Compte
	{
		private float decouvertAutorise; //montant (ex : 100 pour 100$ de decouvert autorisé)

		public CompteCourant()
		{
		
		}

		public override Retirer(float montant)
		{
			if (this.solde + this.decouvertAutorise > montant)
			{
				this.solde -= montant;
			}
		}
	}
}
