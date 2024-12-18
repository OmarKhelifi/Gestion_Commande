using MySql.Data.MySqlClient;
using System;

public class Authentification
{
    // Méthode de connexion
    public string Login(DatabaseConnection dbConnection, string username, string password)
    {
        using (var connection = dbConnection.GetConnection())
        {
            try
            {
                // Hash du mot de passe fourni
                string hashedPassword = HashPassword(password);

                // Vérification des identifiants
                string query = "SELECT Role FROM User WHERE Username = @Username AND Password = @Password";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", hashedPassword);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        return result.ToString(); // Retourne le rôle de l'utilisateur
                    }
                    else
                    {
                        return null; // Identifiants incorrects
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur lors de l'authentification : {ex.Message}");
            }
        }
    }

    // Méthode pour hacher un mot de passe (comme dans UserController)
    private string HashPassword(string password)
    {
        using (var sha256 = System.Security.Cryptography.SHA256.Create())
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(password);
            byte[] hash = sha256.ComputeHash(bytes);

            System.Text.StringBuilder result = new System.Text.StringBuilder();
            foreach (byte b in hash)
                result.Append(b.ToString("x2"));

            return result.ToString();
        }
    }
}
