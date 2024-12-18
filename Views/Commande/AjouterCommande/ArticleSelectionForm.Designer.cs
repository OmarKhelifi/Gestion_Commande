namespace GestionCommandeApp
{
    partial class ArticleSelectionForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnConfirmSelection;

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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnConfirmSelection = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            
            // DataGridView setup
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(776, 375);
            this.dataGridView1.TabIndex = 0;

            // 
            // btnConfirmSelection
            // 
            this.btnConfirmSelection.BackColor = System.Drawing.Color.LightGreen;
            this.btnConfirmSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmSelection.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnConfirmSelection.Location = new System.Drawing.Point(690, 407);
            this.btnConfirmSelection.Name = "btnConfirmSelection";
            this.btnConfirmSelection.Size = new System.Drawing.Size(100, 35);
            this.btnConfirmSelection.TabIndex = 1;
            this.btnConfirmSelection.Text = "Confirmer";
            this.btnConfirmSelection.UseVisualStyleBackColor = false;
            this.btnConfirmSelection.Click += new System.EventHandler(this.btnConfirmSelection_Click);


            // ArticleSelectionForm setup
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConfirmSelection);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ArticleSelectionForm";
            this.Text = "Sélectionner un Article";
            this.Load += new System.EventHandler(this.ArticleSelectionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }
    }
}