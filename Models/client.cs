public class Client
{
    public int ID { get; set; }
    public string Nom { get; set; }
    public string Adresse { get; set; }
    public string Telephone { get; set; }

    public Client(int id, string nom, string adresse, string telephone)
    {
        ID = id;
        Nom = nom;
        Adresse = adresse;
        Telephone = telephone;
    }
}
