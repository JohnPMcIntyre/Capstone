namespace McIntyresFitnessApp.Forms
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnRegister = new Button();
            label1 = new Label();
            label2 = new Label();
            btnBack = new Button();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(168, 89);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(189, 23);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(168, 133);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(189, 23);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(225, 162);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 97);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 3;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 136);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(225, 191);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 280);
            Controls.Add(btnBack);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnRegister;
        private Label label1;
        private Label label2;
        private Button btnBack;
    }
}