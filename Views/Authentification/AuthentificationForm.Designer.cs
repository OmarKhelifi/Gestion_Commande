namespace GestionCommandeApp
{
    partial class AuthentificationForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCreateAccount;

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
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCreateAccount = new System.Windows.Forms.Label();

            // Setting up the form
            this.SuspendLayout();
            this.Text = "Authentification";
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            // Title Label
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(150, 20);
            this.lblTitle.Text = "Bienvenue";

            // Label Username
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Arial", 10F);
            this.lblUsername.Location = new System.Drawing.Point(50, 80);
            this.lblUsername.Text = "Nom d'utilisateur :";

            // TextBox Username
            this.txtUsername.Location = new System.Drawing.Point(200, 80);
            this.txtUsername.Size = new System.Drawing.Size(200, 20);

            // Label Password
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Arial", 10F);
            this.lblPassword.Location = new System.Drawing.Point(50, 130);
            this.lblPassword.Text = "Mot de passe :";

            // TextBox Password
            this.txtPassword.Location = new System.Drawing.Point(200, 130);
            this.txtPassword.Size = new System.Drawing.Size(200, 20);
            this.txtPassword.PasswordChar = '*';

            // Button Login
            this.btnLogin.Location = new System.Drawing.Point(80, 200);
            this.btnLogin.Size = new System.Drawing.Size(120, 40);
            this.btnLogin.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogin.Text = "Connexion";
            this.btnLogin.BackColor = System.Drawing.Color.LightBlue;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);

            // Button Exit
            this.btnExit.Location = new System.Drawing.Point(250, 200);
            this.btnExit.Size = new System.Drawing.Size(120, 40);
            this.btnExit.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnExit.Text = "Quitter";
            this.btnExit.BackColor = System.Drawing.Color.LightCoral;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);

            // Label Create Account
            this.lblCreateAccount.AutoSize = true;
            this.lblCreateAccount.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Underline);
            this.lblCreateAccount.ForeColor = System.Drawing.Color.Blue;
            this.lblCreateAccount.Location = new System.Drawing.Point(150, 250);
            this.lblCreateAccount.Text = "Créer un compte";
            this.lblCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCreateAccount.Click += new System.EventHandler(this.LblCreateAccount_Click);

            // Adding Controls
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblCreateAccount);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

    }
}
