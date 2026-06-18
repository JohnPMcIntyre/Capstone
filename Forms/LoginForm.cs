using MySql.Data.MySqlClient;
using McIntyresFitnessApp.Services;
using System;
using System.Windows.Forms;

namespace McIntyresFitnessApp.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Validates the user's credentials and opens the dashboard on success.
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            DatabaseHelper db = new DatabaseHelper();

            string username = txtUsername.Text;
            string password = txtPassword.Text;

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT UserID FROM Users WHERE Username = @username AND PasswordHash = @password";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            int userId = Convert.ToInt32(result);
                            UserSession.UserId = userId;
                            UserSession.Username = username;

                            MessageBox.Show("Login Successful!");

                            DashboardForm dashboard = new DashboardForm();
                            dashboard.Show();

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        /// <summary>
        /// Opens the registration form.
        /// </summary>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }
    }
}