using System;
using System.Drawing;
using System.Windows.Forms;

namespace GestionCommandeApp
{
    public partial class CommercialeForm : Form
    {
        public CommercialeForm()
        {
            InitializeComponent();
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
            // Fermer l'application
            Application.Exit();
        }
    }
}
