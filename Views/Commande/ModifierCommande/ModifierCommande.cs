namespace GestionCommandeApp
{
    public partial class ModifierCommande : Form
    {
        int commandeId;
        
        public ModifierCommande(int commandeId)
        {
            InitializeComponent();
            this.commandeId = commandeId;
            LoadCommandeDetails();
        }

        private void LoadCommandeDetails()
        {
            // Récupérer les détails de la commande depuis la base de données
            DatabaseConnection dbConnection = new DatabaseConnection();
            Commande commande = CommandeController.GetAll(dbConnection).Find(c => c.ID == commandeId);

            if (commande != null)
            {
                // Afficher les informations de la commande dans les champs texte
                txtCommandeId.Text = commande.ID.ToString();
                txtNomClient.Text = commande.NomClient;
                txtNomArticle.Text = string.Join(", ", commande.NomArticles);
                txtQuantite.Text = commande.Quantite.ToString();
                // Remplir le ComboBox avec les différents statuts disponibles
                comboStatut.Items.AddRange(new string[] { "En cours","Livré","Annulé" });
                comboStatut.SelectedItem = commande.Statut; // Prendre le statut actuel
            }
            else
            {
                MessageBox.Show("Commande introuvable.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnModifier_Click(object sender, EventArgs e)
        {
            string newStatut = comboStatut.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(newStatut))
            {
                // Mettre à jour uniquement le statut de la commande
                DatabaseConnection dbConnection = new DatabaseConnection();
                CommandeController.ModifierCommande(dbConnection, commandeId, newStatut);

                MessageBox.Show("Statut de la commande mis à jour avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un statut valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Handler pour le bouton "Terminer"
        private void btnTerminer_Click(object sender, EventArgs e)
        {
            this.Close();  // Fermer la fenêtre
        }
    }
}
