namespace GestionCommandeApp
{
    partial class RegistreForm
    {
        private System.ComponentModel.IContainer components = null;

        // Controls
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnExit;

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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();

            // Setting up the form
            this.SuspendLayout();
            this.Text = "Inscription";
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Title Label
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(150, 20);
            this.lblTitle.Text = "Créer un compte";

            // Label Username
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Arial", 10F);
            this.lblUsername.Location = new System.Drawing.Point(50, 80);
            this.lblUsername.Text = "Nom d'utilisateur:";

            // TextBox Username
            this.txtUsername.Location = new System.Drawing.Point(200, 80);
            this.txtUsername.Size = new System.Drawing.Size(200, 20);

            // Label Password
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Arial", 10F);
            this.lblPassword.Location = new System.Drawing.Point(50, 120);
            this.lblPassword.Text = "Mot de passe:";

            // TextBox Password
            this.txtPassword.Location = new System.Drawing.Point(200, 120);
            this.txtPassword.Size = new System.Drawing.Size(200, 20);
            this.txtPassword.PasswordChar = '*'; // Les caractères saisis seront masqués

            // Button Register
            this.btnRegister.Location = new System.Drawing.Point(100, 200);
            this.btnRegister.Size = new System.Drawing.Size(100, 30);
            this.btnRegister.Text = "S'inscrire";
            this.btnRegister.BackColor = System.Drawing.Color.LightGreen;
            this.btnRegister.FlatStyle = FlatStyle.Flat;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);

            // Button Exit
            this.btnExit.Location = new System.Drawing.Point(250, 200);
            this.btnExit.Size = new System.Drawing.Size(100, 30);
            this.btnExit.Text = "Quitter";
            this.btnExit.BackColor = System.Drawing.Color.IndianRed;
            this.btnExit.FlatStyle = FlatStyle.Flat;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);

            // Adding Controls
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnExit);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
