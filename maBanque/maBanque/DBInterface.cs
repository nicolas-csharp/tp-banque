using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;


namespace ma_banque
{
    public class DBInterface
    {
        public static List<Client> GetAllClients(int idConseiller)
        {
            List<Client> clients = new List<Client> ();
            SqlConnection connection = null;    
            SqlDataReader sqlDataReader = null;
            try
            {
                connection = connection.getInstance().GetConnection();
                SqlCommande sqlCommande = new SqlCommande("spClient_GetByConseiller", connection); // il faut mettre le nom de la procedure stockée correspondante
                sqlCommande.CommandeType = CommandeType.StoredProcedure;
                sqlCommande.Parameters.AddWithValue("@pIdConseiller", SqlDbType.Int).Value = idConseiller;
                sqlDataReader = sqlCommande.ExecuteReader();
                while(sqlDataReader.Read())
                {
                    Client client = new Client();
                    client.id = sqlDataReader.GetInt32(0);
                    client.nom = sqlDataReader.GetString(1);
                    client.prenom = sqlDataReader.GetString(2);
                    client.rue = sqlDataReader.GetString(3);
                    client.codePostal = sqlDataReader.GetString(4);
                    client.ville = sqlDataReader.GetString(5);
                    client.mobil = sqlDataReader.GetString(6);
                    client.mail = sqlDataReader.GetString(7);
                    clients.comptes = GetAllComptes(client.id);4
                    client.Add(clients);

                }
            }
            catch(InvalidOperationException)
            {
                using (StreamWriter w = File.AppendText("../Logs/logerror.txt"))
                {
                    Log.WriteLog("DBInterface : erreur SQL", w);
                }
            }
            finally
            {
                connection.Close();
            }
            return clients;
        }

        public static List<Compte> GetAllComptes(int idClient)
        {
            List<Compte> comptes = new List<Compte> ();
            SqlConnection connection = null;
            SqlDataReader sqlDataReader = null;
            try
            {
                connection = connection.getInstance().GetConnection();
                SqlCommande sqlCommande = new SqlCommande("spCompte_GetByClient", connection); // il faut mettre le nom de la procedure stockée correspondante
                sqlCommande.CommandeType = CommandeType.StoredProcedure;
                sqlCommande.Parameters.AddWithValue("@pIdClient", SqlDbType.Int).Value = idClient;
                sqlDataReader = sqlCommande.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    //si type de compte = null (ds colone 4) alors c'est un compte courant 
                    if (sqlDataReader.IsDBNull(3))
                    {
                        CompteCourant compteCourant = new CompteCourant();
                        compteCourant.id = sqlDataReader.GetInt32(0);
                        compteCourant.solde = decimal.ToFloat(sqlDataReader.GetDecimal(1));
                        compteCourant.decouvertAutorise = decimal.ToFloat(sqlDataReader.GetDecimal(2));
                        comptes.Add(compteCourant);
                    }
                    else
                    {
                        compteEpargne compteEpargne = new compteEpargne();
                        compteEpargne.id = sqlDataReader.GetInt32(0);
                        compteEpargne.solde = decimal.ToFloat(sqlDataReader.GetDecimal(1));
                        compteEpargne.type = sqlDataReader.GetString(3);
                        compteEpargne.tauxInteret decimal.ToFloat(sqlDataReader.GetDecimal(4));
                        comptes.Add(compteEpargne);
                    }
                }
            }
            catch(InvalideOperationException)
            {
                using (StreamWriter w = File.AppendText("../Logs/logerror.txt"))
                {
                    Log.WriteLog("DBInterface : erreur SQL", w);
                }
            }
            finally
            {
                connection.Close();
            }
            return comptes;
        }
    }
}