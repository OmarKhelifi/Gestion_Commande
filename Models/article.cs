public class Article
{
    public int ID { get; set; }
    public string Nom { get; set; } = string.Empty;  // Default to empty string
    public string Description { get; set; } = string.Empty;  // Default to empty string
    public string Categorie { get; set; } = string.Empty;  // Default to empty string
    public decimal Prix { get; set; }
    public int Quantite { get; set; }

    public Article() { }

    public Article(int id, string nom, string description, string categorie, decimal prix, int quantite)
    {
        ID = id;
        Nom = nom ?? string.Empty;  // Ensure non-null value for Nom
        Description = description ?? string.Empty;  // Ensure non-null value for Description
        Categorie = categorie ?? string.Empty;  // Ensure non-null value for Categorie
        Prix = prix;
        Quantite = quantite;
    }

    public override string ToString()
    {
        return $"{Nom} - {Categorie} - {Prix:C}";
    }
}
