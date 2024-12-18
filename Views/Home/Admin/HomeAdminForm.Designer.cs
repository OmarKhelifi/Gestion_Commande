namespace GestionCommandeApp
{
    partial class HomeAdminForm
    {
        private System.ComponentModel.IContainer components = null;

        // Dispose des ressources
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
            this.lblBienvenue = new System.Windows.Forms.Label();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnCommande = new System.Windows.Forms.Button();
            this.btnArticle = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // lblBienvenue
            // 
            this.lblBienvenue.AutoSize = true;
            this.lblBienvenue.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblBienvenue.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblBienvenue.Location = new System.Drawing.Point(45, 30); // Adjusted for centering
            this.lblBienvenue.Name = "lblBienvenue";
            this.lblBienvenue.Size = new System.Drawing.Size(340, 26);
            this.lblBienvenue.TabIndex = 0;
            this.lblBienvenue.Text = "Bienvenue Admin à notre application";
            this.lblBienvenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // btnClient
            // 
            this.btnClient.BackColor = System.Drawing.Color.LightSkyBlue; // Client button color
            this.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClient.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnClient.ForeColor = System.Drawing.Color.White;
            this.btnClient.Location = new System.Drawing.Point(200, 100); // Centered
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(150, 50);
            this.btnClient.TabIndex = 1;
            this.btnClient.Text = "Client";
            this.btnClient.UseVisualStyleBackColor = false;
            this.btnClient.Click += new System.EventHandler(this.BtnClient_Click);

            // 
            // btnCommande
            // 
            this.btnCommande.BackColor = System.Drawing.Color.LightGreen; // Commande button color
            this.btnCommande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommande.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnCommande.ForeColor = System.Drawing.Color.White;
            this.btnCommande.Location = new System.Drawing.Point(200, 170); // Positioned below the Client button
            this.btnCommande.Name = "btnCommande";
            this.btnCommande.Size = new System.Drawing.Size(150, 50);
            this.btnCommande.TabIndex = 2;
            this.btnCommande.Text = "Commande";
            this.btnCommande.UseVisualStyleBackColor = false;
            this.btnCommande.Click += new System.EventHandler(this.BtnCommande_Click);

            // 
            // btnArticle
            // 
            this.btnArticle.BackColor = System.Drawing.Color.Salmon; // Article button color
            this.btnArticle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArticle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnArticle.ForeColor = System.Drawing.Color.White;
            this.btnArticle.Location = new System.Drawing.Point(200, 240); // Positioned below the Commande button
            this.btnArticle.Name = "btnArticle";
            this.btnArticle.Size = new System.Drawing.Size(150, 50);
            this.btnArticle.TabIndex = 3;
            this.btnArticle.Text = "Article";
            this.btnArticle.UseVisualStyleBackColor = false;
            this.btnArticle.Click += new System.EventHandler(this.BtnArticle_Click);

            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.Red; // Quitter button color
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnQuitter.ForeColor = System.Drawing.Color.White;
            this.btnQuitter.Location = new System.Drawing.Point(200, 310); // Positioned below the Article button
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(150, 50);
            this.btnQuitter.TabIndex = 4;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);

            // 
            // HomeAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400); // Adjusted form size
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnArticle);
            this.Controls.Add(this.btnCommande);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.lblBienvenue);
            this.Name = "HomeAdminForm";
            this.Text = "Admin Home";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblBienvenue;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnCommande;
        private System.Windows.Forms.Button btnArticle;
        private System.Windows.Forms.Button btnQuitter;
    }
}
