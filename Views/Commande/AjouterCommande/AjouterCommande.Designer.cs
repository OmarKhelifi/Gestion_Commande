namespace GestionCommandeApp
{
    partial class AjouterCommande
    {
        private System.ComponentModel.IContainer components = null;

        // Déclarations des contrôles
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.ComboBox comboBoxClients;
        private System.Windows.Forms.Label labelNomArticle;
        private System.Windows.Forms.TextBox textBoxNomArticles;
        private System.Windows.Forms.Button buttonSelectionnerArticles;
        private System.Windows.Forms.Label labelQuantite;
        private System.Windows.Forms.TextBox textBoxQuantite;
        private System.Windows.Forms.Label labelStatut;
        private System.Windows.Forms.ComboBox comboBoxStatut;
        private System.Windows.Forms.Button buttonAjouterCommande;
        private System.Windows.Forms.Button buttonAnnuler;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelTitre = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
            this.comboBoxClients = new System.Windows.Forms.ComboBox();
            this.labelNomArticle = new System.Windows.Forms.Label();
            this.textBoxNomArticles = new System.Windows.Forms.TextBox();
            this.buttonSelectionnerArticles = new System.Windows.Forms.Button();
            this.labelQuantite = new System.Windows.Forms.Label();
            this.textBoxQuantite = new System.Windows.Forms.TextBox();
            this.labelStatut = new System.Windows.Forms.Label();
            this.comboBoxStatut = new System.Windows.Forms.ComboBox();
            this.buttonAjouterCommande = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelTitre.Location = new System.Drawing.Point(100, 10);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(180, 22);
            this.labelTitre.TabIndex = 0;
            this.labelTitre.Text = "Ajouter Commande";

            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(20, 60);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(115, 15);
            this.labelClient.TabIndex = 1;
            this.labelClient.Text = "Sélectionner Client :";

            // 
            // comboBoxClients
            // 
            this.comboBoxClients.FormattingEnabled = true;
            this.comboBoxClients.Location = new System.Drawing.Point(170, 57);
            this.comboBoxClients.Name = "comboBoxClients";
            this.comboBoxClients.Size = new System.Drawing.Size(200, 23);
            this.comboBoxClients.TabIndex = 2;

            // 
            // labelNomArticle
            // 
            this.labelNomArticle.AutoSize = true;
            this.labelNomArticle.Location = new System.Drawing.Point(20, 100);
            this.labelNomArticle.Name = "labelNomArticle";
            this.labelNomArticle.Size = new System.Drawing.Size(107, 15);
            this.labelNomArticle.TabIndex = 3;
            this.labelNomArticle.Text = "Nom des Articles :";

            // 
            // textBoxNomArticles
            // 
            this.textBoxNomArticles.Location = new System.Drawing.Point(170, 97);
            this.textBoxNomArticles.Name = "textBoxNomArticles";
            this.textBoxNomArticles.Size = new System.Drawing.Size(200, 23);
            this.textBoxNomArticles.TabIndex = 4;

            // 
            // buttonSelectionnerArticles
            // 
            this.buttonSelectionnerArticles.BackColor = System.Drawing.Color.LightBlue;
            this.buttonSelectionnerArticles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectionnerArticles.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.buttonSelectionnerArticles.Location = new System.Drawing.Point(170, 130);
            this.buttonSelectionnerArticles.Name = "buttonSelectionnerArticles";
            this.buttonSelectionnerArticles.Size = new System.Drawing.Size(200, 30);
            this.buttonSelectionnerArticles.TabIndex = 5;
            this.buttonSelectionnerArticles.Text = "Sélectionner Articles";
            this.buttonSelectionnerArticles.UseVisualStyleBackColor = false;
            this.buttonSelectionnerArticles.Click += new System.EventHandler(this.buttonSelectionnerArticles_Click);

            // 
            // labelQuantite
            // 
            this.labelQuantite.AutoSize = true;
            this.labelQuantite.Location = new System.Drawing.Point(20, 180);
            this.labelQuantite.Name = "labelQuantite";
            this.labelQuantite.Size = new System.Drawing.Size(59, 15);
            this.labelQuantite.TabIndex = 6;
            this.labelQuantite.Text = "Quantité :";

            // 
            // textBoxQuantite
            // 
            this.textBoxQuantite.Location = new System.Drawing.Point(170, 177);
            this.textBoxQuantite.Name = "textBoxQuantite";
            this.textBoxQuantite.Size = new System.Drawing.Size(200, 23);
            this.textBoxQuantite.TabIndex = 7;

            // 
            // labelStatut
            // 
            this.labelStatut.AutoSize = true;
            this.labelStatut.Location = new System.Drawing.Point(20, 220);
            this.labelStatut.Name = "labelStatut";
            this.labelStatut.Size = new System.Drawing.Size(45, 15);
            this.labelStatut.TabIndex = 8;
            this.labelStatut.Text = "Statut :";

            // ...
            // comboBoxStatut
            // 
            this.comboBoxStatut.FormattingEnabled = true;
            this.comboBoxStatut.Items.AddRange(new object[] {
                "En cours",
                "Livré",
                "Annulé"});
            this.comboBoxStatut.Location = new System.Drawing.Point(170, 217);
            this.comboBoxStatut.Name = "comboBoxStatut";
            this.comboBoxStatut.Size = new System.Drawing.Size(200, 23);
            this.comboBoxStatut.TabIndex = 9;
            this.comboBoxStatut.SelectedIndex = 0; // Définit "En cours" comme valeur par défaut
            // ...


            // 
            // buttonAjouterCommande
            // 
            this.buttonAjouterCommande.BackColor = System.Drawing.Color.LightGreen;
            this.buttonAjouterCommande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouterCommande.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.buttonAjouterCommande.Location = new System.Drawing.Point(60, 270);
            this.buttonAjouterCommande.Name = "buttonAjouterCommande";
            this.buttonAjouterCommande.Size = new System.Drawing.Size(100, 35);
            this.buttonAjouterCommande.TabIndex = 10;
            this.buttonAjouterCommande.Text = "Ajouter";
            this.buttonAjouterCommande.UseVisualStyleBackColor = false;
            this.buttonAjouterCommande.Click += new System.EventHandler(this.buttonAjouterCommande_Click);

            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.BackColor = System.Drawing.Color.LightCoral;
            this.buttonAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnnuler.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.buttonAnnuler.Location = new System.Drawing.Point(200, 270);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(100, 35);
            this.buttonAnnuler.TabIndex = 11;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = false;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);

            // 
            // AjouterCommande
            // 
            this.ClientSize = new System.Drawing.Size(384, 330);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.comboBoxClients);
            this.Controls.Add(this.labelNomArticle);
            this.Controls.Add(this.textBoxNomArticles);
            this.Controls.Add(this.buttonSelectionnerArticles);
            this.Controls.Add(this.labelQuantite);
            this.Controls.Add(this.textBoxQuantite);
            this.Controls.Add(this.labelStatut);
            this.Controls.Add(this.comboBoxStatut);
            this.Controls.Add(this.buttonAjouterCommande);
            this.Controls.Add(this.buttonAnnuler);
            this.Name = "AjouterCommande";
            this.Text = "Ajouter Commande";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}