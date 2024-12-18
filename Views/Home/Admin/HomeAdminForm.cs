using System;
using System.Drawing;
using System.Windows.Forms;

namespace GestionCommandeApp
{
    public partial class HomeAdminForm : Form
    {
        public HomeAdminForm()
        {
            InitializeComponent(); // This should now reference the generated method
        }

        private void BtnClient_Click(object sender, EventArgs e)
        {
            // Ouvrir le formulaire ListClientForm
            ListClient clientForm = new ListClient();
            clientForm.Show();
        }

        private void BtnArticle_Click(object sender, EventArgs e)
        {
            // Ouvrir le formulaire ListClientForm
            ListArticle articleForm = new ListArticle();
            articleForm.Show();
        }

        private void BtnCommande_Click(object sender, EventArgs e)
        {
            // Ouvrir le formulaire ListClientForm
            ListCommande commandeForm = new ListCommande();
            commandeForm.Show();
        }


        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            // Close the application
            Application.Exit();
        }

    }
}
