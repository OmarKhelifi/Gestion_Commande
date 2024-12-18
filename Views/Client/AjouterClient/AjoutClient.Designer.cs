namespace GestionCommandeApp
{
    partial class AjoutClient
    {
        private System.ComponentModel.IContainer components = null;

        // Déclarations des contrôles
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelAdresse;
        private System.Windows.Forms.Label labelTelephone;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.TextBox textBoxTelephone;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Button buttonAnnuler; // Déclaration du bouton "Annuler"
        private System.Windows.Forms.Label labelTitre;  // Ajout d'un label pour le titre visible

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
            this.labelNom = new System.Windows.Forms.Label();
            this.labelAdresse = new System.Windows.Forms.Label();
            this.labelTelephone = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.textBoxTelephone = new System.Windows.Forms.TextBox();
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button(); // Initialisation du bouton "Annuler"
            this.labelTitre = new System.Windows.Forms.Label();  // Initialisation du label pour le titre

            this.SuspendLayout();

            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelTitre.Location = new System.Drawing.Point(100, 10);  // Position du titre en haut du formulaire
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(125, 22);
            this.labelTitre.TabIndex = 7;
            this.labelTitre.Text = "Ajouter un Client";  // Texte du titre

            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(20, 60);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(35, 13);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nom :";

            // 
            // labelAdresse
            // 
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.Location = new System.Drawing.Point(20, 100);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(52, 13);
            this.labelAdresse.TabIndex = 1;
            this.labelAdresse.Text = "Adresse :";

            // 
            // labelTelephone
            // 
            this.labelTelephone.AutoSize = true;
            this.labelTelephone.Location = new System.Drawing.Point(20, 140);
            this.labelTelephone.Name = "labelTelephone";
            this.labelTelephone.Size = new System.Drawing.Size(65, 13);
            this.labelTelephone.TabIndex = 2;
            this.labelTelephone.Text = "Téléphone :";

            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(100, 60);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(200, 20);
            this.textBoxNom.TabIndex = 3;

            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Location = new System.Drawing.Point(100, 100);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(200, 20);
            this.textBoxAdresse.TabIndex = 4;

            // 
            // textBoxTelephone
            // 
            this.textBoxTelephone.Location = new System.Drawing.Point(100, 140);
            this.textBoxTelephone.Name = "textBoxTelephone";
            this.textBoxTelephone.Size = new System.Drawing.Size(200, 20);
            this.textBoxTelephone.TabIndex = 5;

             this.buttonValider = new Button
            {
                Text = "Ajouter",
                Size = new Size(100, 35),
                Location = new Point(80, 200),
                BackColor = Color.LightGreen,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Arial", 10, FontStyle.Bold)
            };
            this.buttonValider.Click += buttonValider_Click;

        
            this.buttonAnnuler = new Button
            {
                Text = "Terminer",
                Size = new Size(100, 35),
                Location = new Point(200, 200),
                BackColor = Color.LightCoral,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Arial", 10, FontStyle.Bold)
            };
            this.buttonAnnuler.Click += buttonTerminer_Click;

            // 
            // AjoutClient
            // 
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.labelTitre);  // Ajouter le label du titre à la liste des contrôles
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.labelAdresse);
            this.Controls.Add(this.labelTelephone);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.textBoxAdresse);
            this.Controls.Add(this.textBoxTelephone);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.buttonAnnuler);  // Ajouter le bouton "Annuler" aux contrôles
            this.Name = "AjoutClient";
            this.Text = "Ajout Client";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
