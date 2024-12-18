using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GestionCommandeApp;

namespace GestionCommandeApp
{
    public partial class ListCommande : Form
    {
        private DatabaseConnection dbConnection;

        public ListCommande()
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection();
            LoadCommandes();
        }

        private void LoadCommandes()
        {
            List<Commande> commandes = CommandeController.GetAll(dbConnection);

            // Clear any existing columns in the DataGridView
            dataGridViewCommandes.Columns.Clear();

            // Manually define columns for the DataGridView to match the database structure
            dataGridViewCommandes.Columns.Add("ID", "ID");
            dataGridViewCommandes.Columns.Add("IDClient", "ID Client");
            dataGridViewCommandes.Columns.Add("NomClient", "Nom Client");
            dataGridViewCommandes.Columns.Add("NomArticle", "Nom Articles");
            dataGridViewCommandes.Columns.Add("Quantite", "Quantité");
            dataGridViewCommandes.Columns.Add("Statut", "Statut");

            // Populate the DataGridView with data from the database
            foreach (var commande in commandes)
            {
                dataGridViewCommandes.Rows.Add(
                    commande.ID, 
                    commande.IDClient, 
                    commande.NomClient, 
                    string.Join(", ", commande.NomArticles),  // Join article names in case of multiple articles
                    commande.Quantite, 
                    commande.Statut
                );
            }
        }


        // Click event for "Ajouter" (Add) button
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // Show form to add a new commande
            AjouterCommande ajouterCommandeForm = new AjouterCommande(dbConnection);
            ajouterCommandeForm.ShowDialog();

            // Reload the list of commandes after adding a new one
            LoadCommandes();
        }

        // Click event for "Modifier" (Modify) button
        private void btnModifier_Click(object sender, EventArgs e)
        {
            // Get the selected commande ID from the DataGridView
            if (dataGridViewCommandes.SelectedRows.Count > 0)
            {
                int commandeId = Convert.ToInt32(dataGridViewCommandes.SelectedRows[0].Cells["ID"].Value);
                ModifierCommande modifierCommandeForm = new ModifierCommande(commandeId);
                modifierCommandeForm.ShowDialog();

                // Reload the list after modification
                LoadCommandes();
            }
            else
            {
                MessageBox.Show("Please select a commande to modify.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Click event for "Supprimer" (Delete) button
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            // Get the selected commande ID from the DataGridView
            if (dataGridViewCommandes.SelectedRows.Count > 0)
            {
                int commandeId = Convert.ToInt32(dataGridViewCommandes.SelectedRows[0].Cells["ID"].Value);
                CommandeController.DeleteCommande(dbConnection, commandeId);

                // Reload the list after deletion
                LoadCommandes();
            }
            else
            {
                MessageBox.Show("Please select a commande to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Load event for the ListCommande form
        private void ListCommande_Load(object sender, EventArgs e)
        {
            LoadCommandes();
        }
    }
}
