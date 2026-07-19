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
    public partial class ProgressForm : Form
    {
        public ProgressForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads and displays the user's progress statistics when the form opens and applies UI styling.
        /// </summary>
        private void ProgressForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(28, 40, 60);
            this.Text = "McIntyre Fitness App";


            lblMcIntyre.ForeColor = Color.White;
            lblMcIntyre.BackColor = Color.Transparent;
            lblMcIntyre.Font = new Font("Segoe UI", 24F, FontStyle.Bold);

            Label[] statLabels = { lblTotalWorkouts, lblTotalWeight, lblMaxWeight, lblFavoriteExercise };
            foreach (Label lbl in statLabels)
            {
                lbl.ForeColor = Color.White;
                lbl.BackColor = Color.Transparent;
                lbl.Font = new Font("Segoe UI", 13F);
            }

            DatabaseHelper db = new DatabaseHelper();
            int userId = UserSession.UserId;
            lblTotalWorkouts.Text = "Total Workouts: " + db.GetTotalWorkouts(userId);
            lblTotalWeight.Text = "Total Weight Lifted: " + db.GetTotalWeightLifted(userId) + " lbs";
            lblMaxWeight.Text = "Heaviest Lift: " + db.GetMaxWeight(userId) + " lbs";
            lblFavoriteExercise.Text = "Favorite Exercise: " + db.GetFavoriteExercise(userId);

            btnBack.BackColor = Color.FromArgb(180, 40, 40);
            btnBack.ForeColor = Color.White;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnBack.Cursor = Cursors.Hand;
        }

        /// <summary>
        /// Closes the progress form.
        /// </summary>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
