using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using McIntyresFitnessApp.Services;

namespace McIntyresFitnessApp.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Registers a new user account using the entered username and password.
        /// </summary>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Check for empty fields before hitting the database
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter a username and password.");
                return;
            }

            DatabaseHelper db = new DatabaseHelper();
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            try
            {
                bool success = db.RegisterUser(username, password);

                if (success)
                    MessageBox.Show("Account created!");
                else
                    MessageBox.Show("Registration failed. Username may already exist.");
            }
            catch (Exception)
            {
                MessageBox.Show("Username already exists.");
            }
        }

        /// <summary>
        /// Closes the registration form.
        /// </summary>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Fires when the registration form loads and applies UI styling.
        /// </summary>
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(28, 40, 60);
            this.Text = "McIntyre Fitness App";

            lblMcIntyre.ForeColor = Color.White;
            lblMcIntyre.BackColor = Color.Transparent;
            lblMcIntyre.Font = new Font("Segoe UI", 24F, FontStyle.Bold);

            label1.ForeColor = Color.White;
            label1.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.BackColor = Color.Transparent;

            btnRegister.Size = new Size(120, 40);
            btnRegister.BackColor = Color.FromArgb(0, 120, 215);
            btnRegister.ForeColor = Color.White;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRegister.Cursor = Cursors.Hand;

            btnBack.Size = new Size(120, 40);
            btnBack.BackColor = Color.FromArgb(180, 40, 40);
            btnBack.ForeColor = Color.White;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnBack.Cursor = Cursors.Hand;
        }
    }
}
