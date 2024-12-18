namespace GestionCommandeApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // Créer une instance de DatabaseConnection
            DatabaseConnection dbConnection = new DatabaseConnection();

            // Initialisation de l'application
            ApplicationConfiguration.Initialize();
            Application.Run(new AuthentificationForm()); // Passer dbConnection au formulaire AjouterCommande
        }
    }
}
