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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            DatabaseHelper db = new DatabaseHelper();

            string username = txtUsername.Text;
            string password = txtPassword.Text;

            bool success = db.RegisterUser(username, password);

            if (success)
                MessageBox.Show("Account created!");
            else
                MessageBox.Show("Registration failed.");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
