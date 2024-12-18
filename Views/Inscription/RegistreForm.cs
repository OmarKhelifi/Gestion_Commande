using System;
using System.Windows.Forms;

namespace GestionCommandeApp
{
    public partial class RegistreForm : Form
    {
        private DatabaseConnection dbConnection;
        private UserController userController;

        public RegistreForm()
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection();
            userController = new UserController();
        }

        // Event handler for Register button
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                // Validate input fields
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Add user to database
                userController.AddUser(dbConnection, username, password);

                // Clear fields after registration
                txtUsername.Clear();
                txtPassword.Clear();

                // Success message and redirect to AuthentificationForm
                MessageBox.Show("Inscription réussie ! Vous serez redirigé vers la page de connexion.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AuthentificationForm authForm = new AuthentificationForm();
                authForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for Exit button
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
