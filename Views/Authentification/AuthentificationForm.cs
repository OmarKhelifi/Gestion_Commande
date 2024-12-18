using System;
using System.Windows.Forms;

namespace GestionCommandeApp
{
    public partial class AuthentificationForm : Form
    {
        private DatabaseConnection dbConnection;
        private Authentification auth;

        public AuthentificationForm()
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection();
            auth = new Authentification();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                // Validation des champs
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Authentification
                string role = auth.Login(dbConnection, username, password);

                if (role == null)
                {
                    MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (role == "admin")
                {
                    MessageBox.Show("Bienvenue Admin !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HomeAdminForm adminForm = new HomeAdminForm();
                    adminForm.Show();
                    this.Hide();
                }
                else if (role == "commerciale")
                {
                    MessageBox.Show("Bienvenue Commerciale !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CommercialeForm CommercialeForm = new CommercialeForm();
                    CommercialeForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Rôle inconnu.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Event handler for "Créer un compte" label click
        private void LblCreateAccount_Click(object sender, EventArgs e)
        {
            RegistreForm registreForm = new RegistreForm();
            registreForm.Show();
            this.Hide();
        }
    }
}
