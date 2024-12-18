using MySql.Data.MySqlClient;
using System.Collections.Generic;

public class ClientController
{
   public static List<Client> GetAllClients(DatabaseConnection dbConnection)
    {
        var clients = new List<Client>();

        using (var connection = dbConnection.GetConnection()) // Using statement automatically closes connection
        {
            string query = "SELECT * FROM client";
            using (var command = new MySqlCommand(query, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var client = new Client(
                            reader.GetInt32("ID"),
                            reader.GetString("Nom"),
                            reader.GetString("Adresse"),
                            reader.GetString("Telephone")
                        );
                        clients.Add(client);
                    }
                }
            }
        }

        return clients;
    }



    public static void AddClient(DatabaseConnection dbConnection, Client client)
    {
        using (var connection = dbConnection.GetConnection()) // Open connection automatically when used inside 'using'
        {
            string query = "INSERT INTO client (Nom, Adresse, Telephone) VALUES (@Nom, @Adresse, @Telephone)";
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Nom", client.Nom);
                command.Parameters.AddWithValue("@Adresse", client.Adresse);
                command.Parameters.AddWithValue("@Telephone", client.Telephone);
                command.ExecuteNonQuery(); // Execute the query
            }
        }
    }


   public static void DeleteClient(DatabaseConnection dbConnection, int id)
    {
        using (var connection = dbConnection.GetConnection()) // Open connection automatically when used inside 'using'
        {
            string query = "DELETE FROM client WHERE ID = @ID";
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ID", id);
                command.ExecuteNonQuery(); // Execute the delete command
            }
        }
    }


   public static void ModifyClient(DatabaseConnection dbConnection, Client client)
    {
        using (var connection = dbConnection.GetConnection()) // Open connection automatically when used inside 'using'
        {
            string query = "UPDATE client SET Nom = @Nom, Adresse = @Adresse, Telephone = @Telephone WHERE ID = @ID";
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ID", client.ID);
                command.Parameters.AddWithValue("@Nom", client.Nom);
                command.Parameters.AddWithValue("@Adresse", client.Adresse);
                command.Parameters.AddWithValue("@Telephone", client.Telephone);
                command.ExecuteNonQuery(); // Execute the update command
            }
        }
    }

}
