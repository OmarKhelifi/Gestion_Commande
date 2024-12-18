using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GestionCommandeApp
{
    public partial class ArticleSelectionForm : Form
    {
        private DatabaseConnection dbConnection;
        private List<Article> articles; // List to hold the articles passed from AjouterCommande form

        public event EventHandler<List<string>> ArticleSelected; // Event to pass selected articles back

        public ArticleSelectionForm(List<Article> articles)
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection();
            this.articles = articles; // Initialize the list of articles
        }

        private void ArticleSelectionForm_Load(object sender, EventArgs e)
        {
            try
            {
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
            // Set up DataGridView
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Customizing column headers
            dataGridView1.Columns["ID"].HeaderText = "Identifiant";
            dataGridView1.Columns["Nom"].HeaderText = "Nom de l'Article";
            dataGridView1.Columns["Categorie"].HeaderText = "Catégorie";
            dataGridView1.Columns["Prix"].HeaderText = "Prix";
            dataGridView1.Columns["Quantite"].HeaderText = "Quantité";
        }

        private void btnConfirmSelection_Click(object sender, EventArgs e)
        {
            // Collect selected articles and pass them to the parent form
            List<string> selectedArticles = new List<string>();

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string articleName = row.Cells["Nom"].Value.ToString();
                selectedArticles.Add(articleName);
            }

            // Trigger the event to send selected articles back to the parent form
            ArticleSelected?.Invoke(this, selectedArticles);
            this.Close(); // Close the selection form
        }
    }
}