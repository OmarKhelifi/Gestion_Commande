using System;
using System.Drawing;
using System.Windows.Forms;

namespace GestionCommandeApp
{
    public partial class AjoutArticle : Form
    {

        /// <summary>
        /// Centrer dynamiquement les contrôles à l'ouverture du formulaire.
        /// </summary>
        private void AjoutForm_Load(object sender, EventArgs e)
        {
            CenterControls();
        }

        /// <summary>
        /// Centre tous les contrôles en fonction de la taille du formulaire.
        /// </summary>
       private void CenterControls()
        {
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            // Centrer le titre
            labelTitre.Location = new Point((formWidth - labelTitre.Width) / 2, labelTitre.Location.Y);

            // Définir un offset de base pour les contrôles
            int centerX = formWidth / 2;
            int baseY = 50; // Distance initiale en haut
            int verticalSpacing = 40; // Espacement vertical entre les contrôles

            // Positionner les contrôles dynamiquement
            labelNom.Location = new Point(centerX - 150, baseY);
            textBoxNom.Location = new Point(centerX, baseY);

            labelDescription.Location = new Point(centerX - 150, baseY + verticalSpacing);
            textBoxDescription.Location = new Point(centerX, baseY + verticalSpacing);

            labelCategorie.Location = new Point(centerX - 150, baseY + 2 * verticalSpacing);
            comboBoxCategorie.Location = new Point(centerX, baseY + 2 * verticalSpacing);

            labelPrix.Location = new Point(centerX - 150, baseY + 3 * verticalSpacing);
            textBoxPrix.Location = new Point(centerX, baseY + 3 * verticalSpacing);

            labelQuantite.Location = new Point(centerX - 150, baseY + 4 * verticalSpacing);
            textBoxQuantite.Location = new Point(centerX, baseY + 4 * verticalSpacing);

            // Positionner le bouton "Valider"
            buttonValider.Location = new Point(centerX - (buttonValider.Width / 2), baseY + 5 * verticalSpacing);

            // Positionner le bouton "Terminer" à côté du bouton "Valider"
            buttonAnnuler.Location = new Point(buttonValider.Right + 10, buttonValider.Top);  // 10px d'espacement entre les deux boutons
        }

        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button buttonAnnuler;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelCategorie;
        private System.Windows.Forms.ComboBox comboBoxCategorie;
        private System.Windows.Forms.Label labelPrix;
        private System.Windows.Forms.TextBox textBoxPrix;
        private System.Windows.Forms.Label labelQuantite;
        private System.Windows.Forms.TextBox textBoxQuantite;
        private System.Windows.Forms.Button buttonValider;

        private void InitializeComponent()
        {
            // Titre
            this.labelTitre = new System.Windows.Forms.Label();
            this.labelTitre.Text = "Formulaire d'Ajout d'Article";
            this.labelTitre.Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold);
            this.labelTitre.Size = new System.Drawing.Size(500, 30);

            // Nom
            this.labelNom = new System.Windows.Forms.Label();
            this.labelNom.Text = "Nom :";
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxNom.Size = new System.Drawing.Size(200, 20);

            // Description
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelDescription.Text = "Description :";
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxDescription.Size = new System.Drawing.Size(200, 20);

            // Catégorie
            this.labelCategorie = new System.Windows.Forms.Label();
            this.labelCategorie.Text = "Catégorie :";
            this.comboBoxCategorie = new System.Windows.Forms.ComboBox();
            this.comboBoxCategorie.Size = new System.Drawing.Size(200, 21);
            this.comboBoxCategorie.Items.AddRange(new string[] { "Électronique", "Vêtements", "Alimentation", "Autre" });

            // Prix
            this.labelPrix = new System.Windows.Forms.Label();
            this.labelPrix.Text = "Prix :";
            this.textBoxPrix = new System.Windows.Forms.TextBox();
            this.textBoxPrix.Size = new System.Drawing.Size(200, 20);

            // Quantité
            this.labelQuantite = new System.Windows.Forms.Label();
            this.labelQuantite.Text = "Quantité :";
            this.textBoxQuantite = new System.Windows.Forms.TextBox();
            this.textBoxQuantite.Size = new System.Drawing.Size(200, 20);

            // Bouton Valider
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonValider.Text = "Valider";
            this.buttonValider.Size = new System.Drawing.Size(100, 30);
            this.buttonValider.BackColor = Color.LightGreen;
            this.buttonValider.FlatStyle = FlatStyle.Flat;
            this.buttonValider.Font = new Font("Arial", 12, FontStyle.Bold);
            this.buttonValider.ForeColor = Color.White;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);

            // Bouton Terminer
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonAnnuler.Text = "Terminer";
            this.buttonAnnuler.Size = new System.Drawing.Size(100, 30);
            this.buttonAnnuler.BackColor = Color.IndianRed;
            this.buttonAnnuler.FlatStyle = FlatStyle.Flat;
            this.buttonAnnuler.Font = new Font("Arial", 12, FontStyle.Bold);
            this.buttonAnnuler.ForeColor = Color.White;
            this.buttonAnnuler.Location = new System.Drawing.Point(210, 180); // Positionner le bouton Annuler à côté du bouton Ajouter
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonTerminer_Click); // Connecter l'événement "Click"

            // Ajouter les contrôles au formulaire
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelCategorie);
            this.Controls.Add(this.comboBoxCategorie);
            this.Controls.Add(this.labelPrix);
            this.Controls.Add(this.textBoxPrix);
            this.Controls.Add(this.labelQuantite);
            this.Controls.Add(this.textBoxQuantite);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.buttonAnnuler); // N'oubliez pas d'ajouter le bouton Annuler

            // Configuration de la fenêtre
            this.Text = "Ajouter un Article";
            this.Size = new System.Drawing.Size(800, 400);
        }


        #endregion
    }
}
