using System;
using MySql.Data.MySqlClient;

public class DatabaseConnection
{
    private string connectionString = "Server=localhost;Database=gestioncommandedb;Uid=root;Pwd=root;";

    // Open and return the MySQL connection
    public MySqlConnection GetConnection()
{
    try
    {
        MySqlConnection connection = new MySqlConnection(connectionString);
        if (connection.State == System.Data.ConnectionState.Closed)
        {
            connection.Open();
        }
        return connection;
    }
    catch (Exception ex)
    {
        throw new Exception($"Error connecting to the database: {ex.Message}");
    }
}

}
