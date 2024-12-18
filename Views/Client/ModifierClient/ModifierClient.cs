using System;
using System.Windows.Forms;

namespace GestionCommandeApp
{
    public partial class ModifierClient : Form
    {
        private int clientId;
        private DatabaseConnection dbConnection;
        private DataGridView dataGridView;

        public ModifierClient(int id, string? nom, string? adresse, string? telephone)
        {
            InitializeComponent();

            clientId = id;

            // Assigner les valeurs en gérant les null
            textBoxNom.Text = nom ?? string.Empty;
            textBoxAdresse.Text = adresse ?? string.Empty;
            textBoxTelephone.Text = telephone ?? string.Empty;

            dbConnection = new DatabaseConnection();
        }


        private void LoadData()
        {
            try
            {
                var clients = ClientController.GetAllClients(dbConnection);
                dataGridView.DataSource = clients;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des données : {ex.Message}");
            }
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView.Columns["Action"].Index && e.RowIndex >= 0)
            {
                var nom = dataGridView.Rows[e.RowIndex].Cells["Nom"].Value?.ToString() ?? string.Empty;
                var adresse = dataGridView.Rows[e.RowIndex].Cells["Adresse"].Value?.ToString() ?? string.Empty;
                var telephone = dataGridView.Rows[e.RowIndex].Cells["Telephone"].Value?.ToString() ?? string.Empty;

                // Ouvrir le formulaire de modification
                var modifierForm = new ModifierClient(clientId, nom, adresse, telephone);
                modifierForm.ShowDialog();

                // Rafraîchir les données après modification
                LoadData();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string nom = textBoxNom.Text;
                string adresse = textBoxAdresse.Text;
                string telephone = textBoxTelephone.Text;

                // Validation
                if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(adresse) || string.IsNullOrWhiteSpace(telephone))
                {
                    MessageBox.Show("Tous les champs doivent être remplis.");
                    return;
                }

                // Créer un objet client et modifier
                Client client = new Client(clientId, nom, adresse, telephone);
                ClientController.ModifyClient(dbConnection, client);

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
