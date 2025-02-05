using System;
using System.Data;
using System.Data.SqlClient;

namespace BanqueApp.DataAccess
{
    public class Connexion
    {
        private readonly string _connectionString;

        public Connexion(string connectionString)
        {
            _connectionString = connectionString;
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }

    public class DbInterface
    {
        private readonly Connexion _connexion;

        public DbInterface(Connexion connexion)
        {
            _connexion = connexion;
        }

        // Méthode pour créer un client
        public void CreateClient(string nom, string prenom, string email, string telephone, DateTime dateNaissance)
        {
            using (var connection = _connexion.GetConnection())
            {
                connection.Open();
                var query = "INSERT INTO Clients (Nom, Prenom, Email, Telephone, DateNaissance) VALUES (@Nom, @Prenom, @Email, @Telephone, @DateNaissance)";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nom", nom);
                    command.Parameters.AddWithValue("@Prenom", prenom);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Telephone", telephone);
                    command.Parameters.AddWithValue("@DateNaissance", dateNaissance);
                    command.ExecuteNonQuery();
                }
            }
        }

        // Méthode pour lire les clients
        public DataTable GetClients()
        {
            using (var connection = _connexion.GetConnection())
            {
                connection.Open();
                var query = "SELECT * FROM Clients";
                using (var command = new SqlCommand(query, connection))
                {
                    using (var adapter = new SqlDataAdapter(command))
                    {
                        var table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
            }
        }

        // Méthode pour mettre à jour le solde d'un compte
        public void UpdateSolde(int compteId, decimal nouveauSolde)
        {
            using (var connection = _connexion.GetConnection())
            {
                connection.Open();
                var query = "UPDATE Comptes SET Solde = @Solde WHERE CompteID = @CompteID";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Solde", nouveauSolde);
                    command.Parameters.AddWithValue("@CompteID", compteId);
                    command.ExecuteNonQuery();
                }
            }
        }

        // Méthode pour supprimer un client
        public void DeleteClient(int clientId)
        {
            using (var connection = _connexion.GetConnection())
            {
                connection.Open();
                var query = "DELETE FROM Clients WHERE ClientID = @ClientID";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ClientID", clientId);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
