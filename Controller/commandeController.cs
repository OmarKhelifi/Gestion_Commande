using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace GestionCommandeApp
{
    public class CommandeController
    {
        public static void AddCommande(DatabaseConnection dbConnection, Commande commande)
        {
            using (var connection = dbConnection.GetConnection())
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                string query = "INSERT INTO commande (IDClient, NomClient, NomArticle, Quantite, Statut) VALUES (@IDClient, @NomClient, @NomArticle, @Quantite, @Statut)";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IDClient", commande.IDClient);
                    command.Parameters.AddWithValue("@NomClient", commande.NomClient);
                    command.Parameters.AddWithValue("@NomArticle", commande.GetNomArticlesAsString());
                    command.Parameters.AddWithValue("@Quantite", commande.Quantite); // Now treated as a string
                    command.Parameters.AddWithValue("@Statut", commande.Statut);

                    command.ExecuteNonQuery();
                }
            }
        }

        // ModifierCommande method to update only the "Statut" of a commande
        public static void ModifierCommande(DatabaseConnection dbConnection, int commandeId, string newStatut)
        {
            using (var connection = dbConnection.GetConnection())
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                string query = "UPDATE commande SET Statut = @Statut WHERE ID = @ID";

                using (var command = new MySqlCommand(query, connection))
                {
                    // Only the "Statut" and "ID" parameters are needed for this update
                    command.Parameters.AddWithValue("@Statut", newStatut);
                    command.Parameters.AddWithValue("@ID", commandeId);

                    command.ExecuteNonQuery();
                }
            }
        }

        public static List<Commande> GetAll(DatabaseConnection dbConnection)
    {
        List<Commande> commandes = new List<Commande>();

        using (var connection = dbConnection.GetConnection())
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }

            string query = "SELECT * FROM commande";

            using (var command = new MySqlCommand(query, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Commande commande = new Commande
                        {
                            ID = reader.GetInt32("ID"),
                            IDClient = reader.GetInt32("IDClient"),
                            NomClient = reader.GetString("NomClient"),
                            // Use Split to convert the string back to a list
                            NomArticles = new List<string>(reader.GetString("NomArticle").Split(',')),
                            Quantite = reader.GetString("Quantite"),
                            Statut = reader.GetString("Statut")
                        };
                        commandes.Add(commande);
                    }
                }
            }
        }

        return commandes;
    }


        public static void DeleteCommande(DatabaseConnection dbConnection, int commandeId)
        {
            using (var connection = dbConnection.GetConnection())
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                string query = "DELETE FROM commande WHERE ID = @ID";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", commandeId);
                    command.ExecuteNonQuery();
                }
            }
        }


    }
}
