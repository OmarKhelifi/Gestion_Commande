namespace GestionCommandeApp
{
    partial class ModifierClient
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.TextBox textBoxTelephone;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelAdresse;
        private System.Windows.Forms.Label labelTelephone;

        // Nettoyage des ressources
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le concepteur

        private void InitializeComponent()
        {
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.textBoxTelephone = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelAdresse = new System.Windows.Forms.Label();
            this.labelTelephone = new System.Windows.Forms.Label();

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
            // labelAdresse
            // 
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.Location = new System.Drawing.Point(12, 60);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(52, 13);
            this.labelAdresse.TabIndex = 2;
            this.labelAdresse.Text = "Adresse :";

            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Location = new System.Drawing.Point(100, 57);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(200, 20);
            this.textBoxAdresse.TabIndex = 3;

            // 
            // labelTelephone
            // 
            this.labelTelephone.AutoSize = true;
            this.labelTelephone.Location = new System.Drawing.Point(12, 100);
            this.labelTelephone.Name = "labelTelephone";
            this.labelTelephone.Size = new System.Drawing.Size(67, 13);
            this.labelTelephone.TabIndex = 4;
            this.labelTelephone.Text = "Téléphone :";

            // 
            // textBoxTelephone
            // 
            this.textBoxTelephone.Location = new System.Drawing.Point(100, 97);
            this.textBoxTelephone.Name = "textBoxTelephone";
            this.textBoxTelephone.Size = new System.Drawing.Size(200, 20);
            this.textBoxTelephone.TabIndex = 5;

            this.btnSave = new Button
            {
                Text = "Modifier",
                Location = new Point(100, 135),
                Size = new Size(110, 35),
                BackColor = Color.LightGreen,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Arial", 10, FontStyle.Bold)
            };
            this.btnSave.Click += btnSave_Click;

            // 
            // ModifierClient
            // 
            this.ClientSize = new System.Drawing.Size(324, 181);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelAdresse);
            this.Controls.Add(this.textBoxAdresse);
            this.Controls.Add(this.labelTelephone);
            this.Controls.Add(this.textBoxTelephone);
            this.Controls.Add(this.btnSave);
            this.Name = "ModifierClient";
            this.Text = "Modifier Client";
        }

        #endregion
    }
}
