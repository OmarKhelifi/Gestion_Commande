namespace GestionCommandeApp
{
    partial class ListArticle
    {
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelTitre = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 60);  // Move down to leave space for title
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 300);  // Adjust the height to fit the grid
            this.dataGridView1.TabIndex = 0;

            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitre.Location = new System.Drawing.Point(300, 15);  // Title position
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(200, 26);  // Text size
            this.labelTitre.TabIndex = 1;
            this.labelTitre.Text = "Gestion des Articles";  // Title text

            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(200, 380);  // Button for adding, centered horizontally
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(120, 45);
            this.btnAjouter.TabIndex = 2;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.BackColor = System.Drawing.Color.LightGreen;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);

            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(340, 380);  // Button for modifying, centered horizontally
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(120, 45);
            this.btnModifier.TabIndex = 3;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.BackColor = System.Drawing.Color.SkyBlue;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.FlatAppearance.BorderSize = 0;
            this.btnModifier.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);

            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(480, 380);  // Button for deleting, centered horizontally
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(120, 45);
            this.btnSupprimer.TabIndex = 4;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.BackColor = System.Drawing.Color.IndianRed;
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.FlatAppearance.BorderSize = 0;
            this.btnSupprimer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);

            // 
            // ListArticle
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);  // Adjusted the form size to fit the grid and buttons
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAjouter);  // Add the add button to the form
            this.Controls.Add(this.btnModifier); // Add the modify button to the form
            this.Controls.Add(this.btnSupprimer); // Add the delete button to the form
            this.Name = "ListArticle";
            this.Text = "Liste des Articles";
            this.Load += new System.EventHandler(this.ListArticle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
