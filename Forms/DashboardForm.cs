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
        /// Fires when the dashboard form loads.
        /// </summary>
        private void DashboardForm_Load(object sender, EventArgs e)
        {

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
