namespace GestionCommandeApp
{
    partial class ListCommande
    {
        private System.Windows.Forms.DataGridView dataGridViewCommandes;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.ComponentModel.IContainer components = null;

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
            this.dataGridViewCommandes = new System.Windows.Forms.DataGridView();
            this.labelTitre = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCommandes)).BeginInit();
            this.SuspendLayout();

            // 
            // dataGridViewCommandes
            // 
            this.dataGridViewCommandes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCommandes.Location = new System.Drawing.Point(12, 60);
            this.dataGridViewCommandes.Name = "dataGridViewCommandes";
            this.dataGridViewCommandes.Size = new System.Drawing.Size(776, 300);
            this.dataGridViewCommandes.TabIndex = 0;
            this.dataGridViewCommandes.AutoGenerateColumns = true;
            this.dataGridViewCommandes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCommandes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCommandes.DefaultCellStyle.BackColor = System.Drawing.Color.AliceBlue;
            this.dataGridViewCommandes.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewCommandes.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            this.dataGridViewCommandes.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;

            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.labelTitre.Location = new System.Drawing.Point(280, 15);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(240, 29);
            this.labelTitre.TabIndex = 1;
            this.labelTitre.Text = "Gestion des Commandes";
            this.labelTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(200, 380);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(120, 40);
            this.btnAjouter.TabIndex = 4;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.BackColor = System.Drawing.Color.LightGreen;
            this.btnAjouter.FlatStyle = FlatStyle.Flat;
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);

            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(340, 380);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(120, 40);
            this.btnModifier.TabIndex = 2;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.BackColor = System.Drawing.Color.SkyBlue;
            this.btnModifier.FlatStyle = FlatStyle.Flat;
            this.btnModifier.FlatAppearance.BorderSize = 0;
            this.btnModifier.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);

            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(480, 380);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(120, 40);
            this.btnSupprimer.TabIndex = 3;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.BackColor = System.Drawing.Color.IndianRed;
            this.btnSupprimer.FlatStyle = FlatStyle.Flat;
            this.btnSupprimer.FlatAppearance.BorderSize = 0;
            this.btnSupprimer.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);

            // 
            // ListCommande
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.dataGridViewCommandes);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Name = "ListCommande";
            this.Text = "Gestion des Commandes";
            this.Load += new System.EventHandler(this.ListCommande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCommandes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
