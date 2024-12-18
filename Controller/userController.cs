using System.Security.Cryptography;
using System.Text;
using MySql.Data.MySqlClient;

public class UserController
{
    // Méthode pour hacher un mot de passe
    private string HashPassword(string password)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] bytes = Encoding.UTF8.GetBytes(password);
            byte[] hash = sha256.ComputeHash(bytes);

            // Convertir le tableau de bytes en une chaîne hexadécimale
            StringBuilder result = new StringBuilder();
            foreach (byte b in hash)
                result.Append(b.ToString("x2"));

            return result.ToString();
        }
    }

    // Add user
    public void AddUser(DatabaseConnection dbConnection, string username, string password)
    {
        using (var connection = dbConnection.GetConnection())
        {
            try
            {
                // Check if the username already exists
                string checkQuery = "SELECT COUNT(*) FROM User WHERE Username = @Username";
                using (var checkCmd = new MySqlCommand(checkQuery, connection))
                {
                    checkCmd.Parameters.AddWithValue("@Username", username);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Error: Username already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }else{
                        // Hash the password
                string hashedPassword = HashPassword(password);

                // Insert the new user
                string insertQuery = "INSERT INTO User (Username, Password, Role) VALUES (@Username, @Password, @Role)";
                using (var insertCmd = new MySqlCommand(insertQuery, connection))
                {
                    insertCmd.Parameters.AddWithValue("@Username", username);
                    insertCmd.Parameters.AddWithValue("@Password", hashedPassword); // Enregistrer le mot de passe haché
                    insertCmd.Parameters.AddWithValue("@Role", "commerciale");

                    insertCmd.ExecuteNonQuery();
                    MessageBox.Show($"User {username} has been registered successfully with role 'commerciale'.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                    }
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
