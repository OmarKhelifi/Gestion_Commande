namespace GestionCommandeApp
{
    public partial class AjoutClient : Form
{
    private DatabaseConnection dbConnection;

    public AjoutClient()
    {
        InitializeComponent();
        dbConnection = new DatabaseConnection();
    }

    private void buttonValider_Click(object sender, EventArgs e)
    {
        try
        {
            string nom = textBoxNom.Text;
            string adresse = textBoxAdresse.Text;
            string telephone = textBoxTelephone.Text;

            if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(adresse) || string.IsNullOrWhiteSpace(telephone))
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Client nouveauClient = new Client(0, nom, adresse, telephone);
            ClientController.AddClient(dbConnection, nouveauClient);

            MessageBox.Show("Client ajouté avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBoxNom.Clear();
            textBoxAdresse.Clear();
            textBoxTelephone.Clear();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erreur lors de l'ajout du client : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonTerminer_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}

}
