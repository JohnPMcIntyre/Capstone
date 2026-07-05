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
    public partial class WorkoutForm : Form
    {
        public WorkoutForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Fires when the form loads and applies UI styling.
        /// </summary>
        private void WorkoutForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(28, 40, 60);
            this.Text = "McIntyre Fitness App";

            lblMcIntyre.ForeColor = Color.White;
            lblMcIntyre.BackColor = Color.Transparent;
            lblMcIntyre.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblExerciseName.ForeColor = Color.White;
            lblExerciseName.BackColor = Color.Transparent;
            lblNumSets.ForeColor = Color.White;
            lblNumSets.BackColor = Color.Transparent;
            lblNumReps.ForeColor = Color.White;
            lblNumReps.BackColor = Color.Transparent;
            lblNumWeight.ForeColor = Color.White;
            lblNumWeight.BackColor = Color.Transparent;
            btnSaveWorkout.BackColor = Color.FromArgb(0, 120, 215);
            btnSaveWorkout.ForeColor = Color.White;
            btnSaveWorkout.FlatStyle = FlatStyle.Flat;
            btnSaveWorkout.FlatAppearance.BorderSize = 0;
            btnSaveWorkout.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSaveWorkout.Cursor = Cursors.Hand;
            btnBack.BackColor = Color.FromArgb(180, 40, 40);
            btnBack.ForeColor = Color.White;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnBack.Cursor = Cursors.Hand;
        }

        /// <summary>
        /// Saves the workout entry to the database.
        /// </summary>
        private void btnSaveWorkout_Click(object sender, EventArgs e)
        {
            DatabaseHelper db = new DatabaseHelper();

            string exercise = txtExerciseName.Text;
            int sets = (int)numSets.Value;
            int reps = (int)numReps.Value;
            decimal weight = numWeight.Value;

            int userId = UserSession.UserId;

            bool success = db.AddWorkout(userId, exercise, sets, reps, weight);

            if (success)
            {
                MessageBox.Show("Workout saved!");

                txtExerciseName.Clear();
                numSets.Value = 0;
                numReps.Value = 0;
                numWeight.Value = 0;
            }
            else
            {
                MessageBox.Show("Failed to save workout.");
            }
        }

        /// <summary>
        /// Closes the workout form.
        /// </summary>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}