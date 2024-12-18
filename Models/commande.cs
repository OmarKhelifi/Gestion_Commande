public class Commande
{
    public int ID { get; set; }
    public int IDClient { get; set; }
    public string NomClient { get; set; }
    public List<string> NomArticles { get; set; } // Liste de noms d'articles
    public string Quantite { get; set; } // Quantité changée en string
    public string Statut { get; set; }

    public Commande()
    {
        NomArticles = new List<string>();
    }

    public Commande(int idClient, string nomClient, List<string> nomArticles, string quantite, string statut)
    {
        IDClient = idClient;
        NomClient = nomClient;
        NomArticles = nomArticles;
        Quantite = quantite;
        Statut = statut;
    }

    public string GetNomArticlesAsString()
    {
        return string.Join(", ", NomArticles); // Convertir la liste en une chaîne séparée par des virgules
    }
}
