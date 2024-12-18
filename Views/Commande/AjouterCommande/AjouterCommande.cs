using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestionCommandeApp
{
    public partial class AjouterCommande : Form
    {
        private DatabaseConnection dbConnection;
        private List<Article> articles;

        public AjouterCommande(DatabaseConnection connection)
        {
            InitializeComponent();
            dbConnection = connection;
            LoadClients();
            LoadArticles();
        }

        private void LoadClients()
        {
            try
            {
                var clients = ClientController.GetAllClients(dbConnection);
                comboBoxClients.DataSource = clients;
                comboBoxClients.DisplayMember = "Nom";
                comboBoxClients.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des clients : {ex.Message}");
            }
        }

        private void LoadArticles()
        {
            try
            {
                articles = ArticleController.GetAllArticles(dbConnection);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des articles : {ex.Message}");
            }
        }

        private void buttonAjouterCommande_Click(object sender, EventArgs e)
        {
            try
            {
                int idClient = ((Client)comboBoxClients.SelectedItem).ID;
                string nomClient = ((Client)comboBoxClients.SelectedItem).Nom;
                List<string> nomArticles = new List<string>(textBoxNomArticles.Text.Split(','));
                string quantite = textBoxQuantite.Text;
                string statut = comboBoxStatut.SelectedItem.ToString();

                Commande newCommande = new Commande(idClient, nomClient, nomArticles, quantite, statut);
                CommandeController.AddCommande(dbConnection, newCommande);

                MessageBox.Show("Commande ajoutée avec succès!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}");
            }
        }

        private void buttonSelectionnerArticles_Click(object sender, EventArgs e)
        {
            ArticleSelectionForm articleSelectionForm = new ArticleSelectionForm(articles);
            articleSelectionForm.ArticleSelected += (s, selectedArticles) =>
            {
                SetNomArticles(selectedArticles);
            };
            articleSelectionForm.ShowDialog();
        }

        public void SetNomArticles(List<string> articles)
        {
            textBoxNomArticles.Text = string.Join(", ", articles);
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            // Ferme la fenêtre actuelle
            this.Close();
        }
    }
}
