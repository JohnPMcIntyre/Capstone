namespace McIntyresFitnessApp.Forms
{
    partial class LoginForm : Form
    {
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
            Username = new Label();
            txtUsername = new TextBox();
            Password = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(82, 71);
            Username.Name = "Username";
            Username.Size = new Size(60, 15);
            Username.TabIndex = 0;
            Username.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(148, 68);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(173, 23);
            txtUsername.TabIndex = 1;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(85, 114);
            Password.Name = "Password";
            Password.Size = new Size(57, 15);
            Password.TabIndex = 2;
            Password.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(148, 106);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(173, 23);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(148, 190);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(246, 190);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 288);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(Password);
            Controls.Add(txtUsername);
            Controls.Add(Username);
            Name = "LoginForm";
            Text = "McIntyre Fitness Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Username;
        private TextBox txtUsername;
        private Label Password;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnRegister;
    }
}
