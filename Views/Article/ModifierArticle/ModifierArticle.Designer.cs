namespace GestionCommandeApp
{
    partial class ModifierArticle
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxCategorie;
        private System.Windows.Forms.TextBox textBoxPrix;
        private System.Windows.Forms.TextBox textBoxQuantite;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelCategorie;
        private System.Windows.Forms.Label labelPrix;
        private System.Windows.Forms.Label labelQuantite;

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
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxCategorie = new System.Windows.Forms.TextBox();
            this.textBoxPrix = new System.Windows.Forms.TextBox();
            this.textBoxQuantite = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelCategorie = new System.Windows.Forms.Label();
            this.labelPrix = new System.Windows.Forms.Label();
            this.labelQuantite = new System.Windows.Forms.Label();

            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(12, 20);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(35, 13);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nom :";

            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(100, 17);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(200, 20);
            this.textBoxNom.TabIndex = 1;

            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(12, 60);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(67, 13);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "Description :";

            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(100, 57);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(200, 20);
            this.textBoxDescription.TabIndex = 3;

            // 
            // labelCategorie
            // 
            this.labelCategorie.AutoSize = true;
            this.labelCategorie.Location = new System.Drawing.Point(12, 100);
            this.labelCategorie.Name = "labelCategorie";
            this.labelCategorie.Size = new System.Drawing.Size(60, 13);
            this.labelCategorie.TabIndex = 4;
            this.labelCategorie.Text = "Catégorie :";

            // 
            // textBoxCategorie
            // 
            this.textBoxCategorie.Location = new System.Drawing.Point(100, 97);
            this.textBoxCategorie.Name = "textBoxCategorie";
            this.textBoxCategorie.Size = new System.Drawing.Size(200, 20);
            this.textBoxCategorie.TabIndex = 5;

            // 
            // labelPrix
            // 
            this.labelPrix.AutoSize = true;
            this.labelPrix.Location = new System.Drawing.Point(12, 140);
            this.labelPrix.Name = "labelPrix";
            this.labelPrix.Size = new System.Drawing.Size(31, 13);
            this.labelPrix.TabIndex = 6;
            this.labelPrix.Text = "Prix :";

            // 
            // textBoxPrix
            // 
            this.textBoxPrix.Location = new System.Drawing.Point(100, 137);
            this.textBoxPrix.Name = "textBoxPrix";
            this.textBoxPrix.Size = new System.Drawing.Size(200, 20);
            this.textBoxPrix.TabIndex = 7;

            // 
            // labelQuantite
            // 
            this.labelQuantite.AutoSize = true;
            this.labelQuantite.Location = new System.Drawing.Point(12, 180);
            this.labelQuantite.Name = "labelQuantite";
            this.labelQuantite.Size = new System.Drawing.Size(52, 13);
            this.labelQuantite.TabIndex = 8;
            this.labelQuantite.Text = "Quantité :";

            // 
            // textBoxQuantite
            // 
            this.textBoxQuantite.Location = new System.Drawing.Point(100, 177);
            this.textBoxQuantite.Name = "textBoxQuantite";
            this.textBoxQuantite.Size = new System.Drawing.Size(200, 20);
            this.textBoxQuantite.TabIndex = 9;

            this.btnSave = new Button
            {
                Text = "Enregistrer",
                Size = new Size(120, 30),
                BackColor = Color.LightGreen,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Arial", 10, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(135, 220) 
            };
            this.btnSave.Click += btnSave_Click;

            // 
            // ModifierArticle
            // 
            this.ClientSize = new System.Drawing.Size(324, 261);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelCategorie);
            this.Controls.Add(this.textBoxCategorie);
            this.Controls.Add(this.labelPrix);
            this.Controls.Add(this.textBoxPrix);
            this.Controls.Add(this.labelQuantite);
            this.Controls.Add(this.textBoxQuantite);
            this.Controls.Add(this.btnSave);
            this.Name = "ModifierArticle";
            this.Text = "Modifier Article";
        }
    }
}
