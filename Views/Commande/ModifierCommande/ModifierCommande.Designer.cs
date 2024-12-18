namespace GestionCommandeApp
{
    partial class ModifierCommande
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtCommandeId;
        private TextBox txtNomClient;
        private TextBox txtNomArticle;
        private TextBox txtQuantite;
        private ComboBox comboStatut;
        private Button btnModifier;
        private Button btnTerminer;
        private Label lblCommandeId;
        private Label lblNomClient;
        private Label lblNomArticle;
        private Label lblQuantite;
        private Label lblStatut;
        private Label lblTitre;

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
            this.txtCommandeId = new System.Windows.Forms.TextBox();
            this.txtNomClient = new System.Windows.Forms.TextBox();
            this.txtNomArticle = new System.Windows.Forms.TextBox();
            this.txtQuantite = new System.Windows.Forms.TextBox();
            this.comboStatut = new System.Windows.Forms.ComboBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnTerminer = new System.Windows.Forms.Button();
            this.lblCommandeId = new System.Windows.Forms.Label();
            this.lblNomClient = new System.Windows.Forms.Label();
            this.lblNomArticle = new System.Windows.Forms.Label();
            this.lblQuantite = new System.Windows.Forms.Label();
            this.lblStatut = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // lblTitre
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitre.Location = new System.Drawing.Point(80, 15);  // Ajuster la position
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(172, 22);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Modifier Commande";

            // txtCommandeId
            this.txtCommandeId.Location = new System.Drawing.Point(140, 60);
            this.txtCommandeId.Name = "txtCommandeId";
            this.txtCommandeId.Size = new System.Drawing.Size(200, 20);
            this.txtCommandeId.TabIndex = 1;
            this.txtCommandeId.ReadOnly = true;

            // txtNomClient
            this.txtNomClient.Location = new System.Drawing.Point(140, 100);
            this.txtNomClient.Name = "txtNomClient";
            this.txtNomClient.Size = new System.Drawing.Size(200, 20);
            this.txtNomClient.TabIndex = 2;
            this.txtNomClient.ReadOnly = true;

            // txtNomArticle
            this.txtNomArticle.Location = new System.Drawing.Point(140, 140);
            this.txtNomArticle.Name = "txtNomArticle";
            this.txtNomArticle.Size = new System.Drawing.Size(200, 20);
            this.txtNomArticle.TabIndex = 3;
            this.txtNomArticle.ReadOnly = true;

            // txtQuantite
            this.txtQuantite.Location = new System.Drawing.Point(140, 180);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.Size = new System.Drawing.Size(200, 20);
            this.txtQuantite.TabIndex = 4;
            this.txtQuantite.ReadOnly = true;

            // comboStatut
            this.comboStatut.Location = new System.Drawing.Point(140, 220);
            this.comboStatut.Name = "comboStatut";
            this.comboStatut.Size = new System.Drawing.Size(200, 21);
            this.comboStatut.TabIndex = 5;

            // btnModifier
            this.btnModifier.BackColor = System.Drawing.Color.LightGreen;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnModifier.Location = new System.Drawing.Point(80, 260);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(100, 35);
            this.btnModifier.TabIndex = 6;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);

            // btnTerminer
            this.btnTerminer.BackColor = System.Drawing.Color.LightCoral;
            this.btnTerminer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerminer.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnTerminer.Location = new System.Drawing.Point(210, 260);
            this.btnTerminer.Name = "btnTerminer";
            this.btnTerminer.Size = new System.Drawing.Size(100, 35);
            this.btnTerminer.TabIndex = 7;
            this.btnTerminer.Text = "Terminer";
            this.btnTerminer.UseVisualStyleBackColor = false;
            this.btnTerminer.Click += new System.EventHandler(this.btnTerminer_Click);

            // lblCommandeId
            this.lblCommandeId.AutoSize = true;
            this.lblCommandeId.Location = new System.Drawing.Point(30, 60);
            this.lblCommandeId.Name = "lblCommandeId";
            this.lblCommandeId.Size = new System.Drawing.Size(84, 13);
            this.lblCommandeId.TabIndex = 8;
            this.lblCommandeId.Text = "Commande ID:";

            // lblNomClient
            this.lblNomClient.AutoSize = true;
            this.lblNomClient.Location = new System.Drawing.Point(30, 100);
            this.lblNomClient.Name = "lblNomClient";
            this.lblNomClient.Size = new System.Drawing.Size(68, 13);
            this.lblNomClient.TabIndex = 9;
            this.lblNomClient.Text = "Nom Client:";

            // lblNomArticle
            this.lblNomArticle.AutoSize = true;
            this.lblNomArticle.Location = new System.Drawing.Point(30, 140);
            this.lblNomArticle.Name = "lblNomArticle";
            this.lblNomArticle.Size = new System.Drawing.Size(75, 13);
            this.lblNomArticle.TabIndex = 10;
            this.lblNomArticle.Text = "Nom Article:";

            // lblQuantite
            this.lblQuantite.AutoSize = true;
            this.lblQuantite.Location = new System.Drawing.Point(30, 180);
            this.lblQuantite.Name = "lblQuantite";
            this.lblQuantite.Size = new System.Drawing.Size(53, 13);
            this.lblQuantite.TabIndex = 11;
            this.lblQuantite.Text = "Quantité:";

            // lblStatut
            this.lblStatut.AutoSize = true;
            this.lblStatut.Location = new System.Drawing.Point(30, 220);
            this.lblStatut.Name = "lblStatut";
            this.lblStatut.Size = new System.Drawing.Size(41, 13);
            this.lblStatut.TabIndex = 12;
            this.lblStatut.Text = "Statut:";

            // ModifierCommande
            this.ClientSize = new System.Drawing.Size(384, 320);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.lblStatut);
            this.Controls.Add(this.lblQuantite);
            this.Controls.Add(this.lblNomArticle);
            this.Controls.Add(this.lblNomClient);
            this.Controls.Add(this.lblCommandeId);
            this.Controls.Add(this.btnTerminer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.comboStatut);
            this.Controls.Add(this.txtQuantite);
            this.Controls.Add(this.txtNomArticle);
            this.Controls.Add(this.txtNomClient);
            this.Controls.Add(this.txtCommandeId);
            this.Name = "ModifierCommande";
            this.Text = "Modifier Commande";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
