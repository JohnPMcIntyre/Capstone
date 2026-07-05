using MySql.Data.MySqlClient;
using McIntyresFitnessApp.Services;
using System;
using System.Windows.Forms;

namespace McIntyresFitnessApp.Forms
{
    public partial class LoginForm : Form
    {
        /// <summary>
        /// Initializes the login form components.
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Hashes a plain text password using SHA256.
        /// </summary>
        private string HashPassword(string password)
        {
            using (System.Security.Cryptography.SHA256 sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }

        /// <summary>
        /// Validates the user's credentials and opens the dashboard on success.
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            DatabaseHelper db = new DatabaseHelper();
            string username = txtUsername.Text;
            string password = HashPassword(txtPassword.Text);

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    // Query to check if the username and hashed password match a record
                    string query = "SELECT UserID FROM Users WHERE Username = @username AND PasswordHash = @password";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            // Store the logged in user's info in the session
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

        /// <summary>
        /// Fires when the login form loads and applies UI styling.
        /// </summary>
        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(28, 40, 60);
            this.Text = "McIntyre Fitness App";
            lblMcIntyre.ForeColor = Color.White;
            lblMcIntyre.BackColor = Color.Transparent;
            lblMcIntyre.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            Username.ForeColor = Color.White;
            Username.BackColor = Color.Transparent;
            Password.ForeColor = Color.White;
            Password.BackColor = Color.Transparent;
            btnLogin.Size = new Size(120, 40);
            btnLogin.BackColor = Color.FromArgb(0, 120, 215);
            btnLogin.ForeColor = Color.White;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogin.Cursor = Cursors.Hand;
            btnRegister.Size = new Size(120, 40);
            btnRegister.BackColor = Color.FromArgb(80, 80, 80);
            btnRegister.ForeColor = Color.White;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRegister.Cursor = Cursors.Hand;
        }
    }
}