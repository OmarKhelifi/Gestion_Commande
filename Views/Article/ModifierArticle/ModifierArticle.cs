using System;
using System.Windows.Forms;

namespace GestionCommandeApp
{
    public partial class ModifierArticle : Form
    {
        private int articleId;
        private DatabaseConnection dbConnection;

        public ModifierArticle(int id, string? nom, string? description, string? categorie, decimal prix, int quantite)
        {
            InitializeComponent();

            articleId = id;

            // Assigner les valeurs en gérant les null
            textBoxNom.Text = nom ?? string.Empty;
            textBoxDescription.Text = description ?? string.Empty;
            textBoxCategorie.Text = categorie ?? string.Empty;
            textBoxPrix.Text = prix.ToString();
            textBoxQuantite.Text = quantite.ToString();

            dbConnection = new DatabaseConnection();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string nom = textBoxNom.Text;
                string description = textBoxDescription.Text;
                string categorie = textBoxCategorie.Text;
                decimal prix = decimal.Parse(textBoxPrix.Text);
                int quantite = int.Parse(textBoxQuantite.Text);

                // Validation
                if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(description) || string.IsNullOrWhiteSpace(categorie))
                {
                    MessageBox.Show("Tous les champs doivent être remplis.");
                    return;
                }

                // Créer un objet article et modifier
                Article article = new Article
                {
                    ID = articleId,
                    Nom = nom,
                    Description = description,
                    Categorie = categorie,
                    Prix = prix,
                    Quantite = quantite
                };

                ArticleController.ModifyArticle(dbConnection, article);

                MessageBox.Show("Modification réussie !");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la modification : {ex.Message}");
            }
        }
    }
}
