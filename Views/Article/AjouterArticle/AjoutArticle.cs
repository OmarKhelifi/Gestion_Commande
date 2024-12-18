using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestionCommandeApp
{
    public partial class AjoutArticle : Form
    {
        private DatabaseConnection dbConnection;

        public AjoutArticle()
        {
            InitializeComponent();
            this.Load += AjoutForm_Load;
            dbConnection = new DatabaseConnection();
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            try
            {
                // Récupérer les données saisies
                string nom = textBoxNom.Text;
                string description = textBoxDescription.Text;
                string categorie = comboBoxCategorie.SelectedItem?.ToString();
                decimal prix = decimal.Parse(textBoxPrix.Text);
                int quantite = int.Parse(textBoxQuantite.Text);

                // Vérifier les champs obligatoires
                if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(categorie))
                {
                    MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Créer un nouvel article
                Article nouvelArticle = new Article(0, nom, description, categorie, prix, quantite);

                // Ajouter l'article via le contrôleur
                ArticleController.AddArticle(dbConnection, nouvelArticle);

                // Afficher un message de confirmation
                MessageBox.Show("Article ajouté avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Réinitialiser les champs
                textBoxNom.Clear();
                textBoxDescription.Clear();
                comboBoxCategorie.SelectedIndex = -1;
                textBoxPrix.Clear();
                textBoxQuantite.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout de l'article : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonTerminer_Click(object sender, EventArgs e)
        {
            // Fermer le formulaire
            this.Close();
        }
    }
}
