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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Opens the workout logging form.
        /// </summary>
        private void btnLogWorkout_Click(object sender, EventArgs e)
        {
            using (WorkoutForm form = new WorkoutForm())
            {
                form.ShowDialog();
            }
        }

        /// <summary>
        /// Opens the workout history form.
        /// </summary>
        private void btnViewHistory_Click(object sender, EventArgs e)
        {
            using (WorkoutHistoryForm form = new WorkoutHistoryForm())
            {
                form.ShowDialog();
            }
        }

        /// <summary>
        /// Opens the progress tracking form.
        /// </summary>
        private void btnProgress_Click(object sender, EventArgs e)
        {
            ProgressForm form = new ProgressForm();
            form.ShowDialog();
        }

        /// <summary>
        /// Fires when the dashboard form loads and applies UI styling.
        /// </summary>
        private void DashboardForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(28, 40, 60);
            this.Text = "McIntyre Fitness App";
            lblMcIntyre.ForeColor = Color.White;
            lblMcIntyre.BackColor = Color.Transparent;
            lblMcIntyre.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblMcIntyre.Text = "McIntyre Fitness  |  Welcome, " + UserSession.Username + "!";
            btnLogWorkout.Size = new Size(180, 60);
            btnViewHistory.Size = new Size(180, 60);
            btnProgress.Size = new Size(180, 60);
            btnLogout.Size = new Size(180, 60);

            int formCenter = this.ClientSize.Width / 2;
            btnLogWorkout.Location = new Point(formCenter - 290, 120);
            btnViewHistory.Location = new Point(formCenter - 90, 120);
            btnProgress.Location = new Point(formCenter + 110, 120);
            btnLogout.Location = new Point(formCenter - 90, 220);

            Button[] buttons = { btnLogWorkout, btnViewHistory, btnProgress, btnLogout };
            foreach (Button btn in buttons)
            {
                btn.BackColor = Color.FromArgb(0, 120, 215);
                btn.ForeColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
                btn.Cursor = Cursors.Hand;
            }

            btnLogout.BackColor = Color.FromArgb(180, 40, 40);
        }

        /// <summary>
        /// Clears the user session and returns to the login screen.
        /// </summary>
        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Clear the current user session
            UserSession.UserId = 0;
            UserSession.Username = null;

            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }
    }
}
