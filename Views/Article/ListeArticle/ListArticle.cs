using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GestionCommandeApp
{
    public partial class ListArticle : Form
    {
        private DatabaseConnection dbConnection;

        public ListArticle()
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection();
        }

        private void ListArticle_Load(object sender, EventArgs e)
        {
            try
            {
                List<Article> articles = ArticleController.GetAllArticles(dbConnection);
                if (articles.Count == 0)
                {
                    MessageBox.Show("Aucun article trouvé dans la base de données !");
                }
                else
                {
                    dataGridView1.DataSource = articles;
                    CustomizeDataGridView();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erreur de base de données : {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur inattendue : {ex.Message}");
            }
        }

        private void CustomizeDataGridView()
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Optionally, customize column headers for clarity
            dataGridView1.Columns["ID"].HeaderText = "Identifiant";
            dataGridView1.Columns["Nom"].HeaderText = "Nom de l'Article";
            dataGridView1.Columns["Categorie"].HeaderText = "Catégorie";
            dataGridView1.Columns["Prix"].HeaderText = "Prix";
            dataGridView1.Columns["Quantite"].HeaderText = "Quantité";
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            AjoutArticle ajoutForm = new AjoutArticle();
            ajoutForm.ShowDialog();
            ListArticle_Load(sender, e); // Refresh the list after adding an article
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un article à modifier.");
                return;
            }

            DataGridViewRow row = dataGridView1.SelectedRows[0];
            int id = (int)row.Cells["ID"].Value;
            string nom = row.Cells["Nom"].Value.ToString();
            string description = row.Cells["Description"].Value.ToString();
            string categorie = row.Cells["Categorie"].Value.ToString();
            decimal prix = (decimal)row.Cells["Prix"].Value;
            int quantite = (int)row.Cells["Quantite"].Value;

            // Open a form to modify the selected article
            ModifierArticle modifierForm = new ModifierArticle(id, nom, description, categorie, prix, quantite);
            modifierForm.ShowDialog();
            ListArticle_Load(sender, e); // Refresh the list after modification
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un article à supprimer.");
                return;
            }

            DataGridViewRow row = dataGridView1.SelectedRows[0];
            int id = (int)row.Cells["ID"].Value;

            if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet article ?", "Confirmer", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ArticleController.DeleteArticle(dbConnection, id);
                ListArticle_Load(sender, e); // Refresh the list after deletion
            }
        }
    }
}
