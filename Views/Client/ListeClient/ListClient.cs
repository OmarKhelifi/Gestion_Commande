namespace GestionCommandeApp
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using MySql.Data.MySqlClient;

    public partial class ListClient : Form
    {
        private DatabaseConnection dbConnection;

        public ListClient()
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection();
        }

        private void ListClient_Load(object sender, EventArgs e)
        {
            try
            {
                List<Client> clients = ClientController.GetAllClients(dbConnection);
                if (clients.Count == 0)
                {
                    MessageBox.Show("Aucun client trouvé dans la base de données !");
                }
                else
                {
                    dataGridViewClients.DataSource = clients;
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
            dataGridViewClients.AutoGenerateColumns = true;
            dataGridViewClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewClients.Columns["ID"].HeaderText = "Identifiant";
            dataGridViewClients.Columns["Nom"].HeaderText = "Nom du Client";
            dataGridViewClients.Columns["Adresse"].HeaderText = "Adresse";
            dataGridViewClients.Columns["Telephone"].HeaderText = "Téléphone";
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un client à modifier.");
                return;
            }

            DataGridViewRow row = dataGridViewClients.SelectedRows[0];
            int id = (int)row.Cells["ID"].Value;
            string nom = row.Cells["Nom"].Value.ToString();
            string adresse = row.Cells["Adresse"].Value.ToString();
            string telephone = row.Cells["Telephone"].Value.ToString();

            ModifierClient modifierForm = new ModifierClient(id, nom, adresse, telephone);
            modifierForm.ShowDialog();
            ListClient_Load(sender, e);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un client à supprimer.");
                return;
            }

            DataGridViewRow row = dataGridViewClients.SelectedRows[0];
            int id = (int)row.Cells["ID"].Value;

            if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce client ?", "Confirmer", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ClientController.DeleteClient(dbConnection, id);
                ListClient_Load(sender, e);
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            AjoutClient ajoutForm = new AjoutClient();
            ajoutForm.ShowDialog();
            ListClient_Load(sender, e);
        }
    }
}
