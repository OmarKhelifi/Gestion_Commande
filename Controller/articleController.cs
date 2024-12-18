using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

public class ArticleController
{
    public static List<Article> GetAllArticles(DatabaseConnection dbConnection)
    {
        List<Article> articles = new List<Article>();

        using (var connection = dbConnection.GetConnection())
        {
            string query = "SELECT * FROM article";
            using (var command = new MySqlCommand(query, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Article article = new Article
                        {
                            ID = reader.GetInt32("ID"),
                            Nom = reader.GetString("Nom"),
                            Description = reader.IsDBNull(reader.GetOrdinal("Description")) ? string.Empty : reader.GetString("Description"),
                            Categorie = reader.IsDBNull(reader.GetOrdinal("Categorie")) ? string.Empty : reader.GetString("Categorie"),
                            Prix = reader.GetDecimal("Prix"),
                            Quantite = reader.GetInt32("Quantite")
                        };
                        articles.Add(article);
                    }
                }
            }
        }

        return articles;
    }

    public static void AddArticle(DatabaseConnection dbConnection, Article article)
    {
        using (var connection = dbConnection.GetConnection())
        {
            string query = "INSERT INTO article (Nom, Description, Categorie, Prix, Quantite) VALUES (@Nom, @Description, @Categorie, @Prix, @Quantite)";
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Nom", article.Nom);
                command.Parameters.AddWithValue("@Description", article.Description ?? string.Empty); // Handle null descriptions
                command.Parameters.AddWithValue("@Categorie", article.Categorie);
                command.Parameters.AddWithValue("@Prix", article.Prix);
                command.Parameters.AddWithValue("@Quantite", article.Quantite);

                command.ExecuteNonQuery();
            }
        }
    }

    public static void DeleteArticle(DatabaseConnection dbConnection, int id)
    {
        using (var connection = dbConnection.GetConnection())
        {
            string query = "DELETE FROM article WHERE ID = @ID";
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ID", id);
                command.ExecuteNonQuery();
            }
        }
    }

    public static void ModifyArticle(DatabaseConnection dbConnection, Article article)
    {
        using (var connection = dbConnection.GetConnection())
        {
            string query = "UPDATE article SET Nom = @Nom, Description = @Description, Categorie = @Categorie, Prix = @Prix, Quantite = @Quantite WHERE ID = @ID";
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ID", article.ID);
                command.Parameters.AddWithValue("@Nom", article.Nom);
                command.Parameters.AddWithValue("@Description", article.Description ?? string.Empty); // Handle null descriptions
                command.Parameters.AddWithValue("@Categorie", article.Categorie);
                command.Parameters.AddWithValue("@Prix", article.Prix);
                command.Parameters.AddWithValue("@Quantite", article.Quantite);

                command.ExecuteNonQuery();
            }
        }
    }
}
