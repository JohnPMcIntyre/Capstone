using System;
using System.Windows.Forms;
using McIntyresFitnessApp.Services;

namespace McIntyresFitnessApp.Forms
{
    public partial class WorkoutEditForm : Form
    {
        private int workoutId;

        /// <summary>
        /// Initializes the edit form and populates fields with the selected workout data.
        /// </summary>
        public WorkoutEditForm(int id, string exercise, int sets, int reps, decimal weight)
        {
            InitializeComponent();
            numWeight.Maximum = 9999;
            numSets.Maximum = 100;
            numReps.Maximum = 100;
            workoutId = id;
            txtExerciseName.Text = exercise;
            numSets.Value = sets;
            numReps.Value = reps;
            numWeight.Value = weight;
        }

        /// <summary>
        /// Saves the updated workout data to the database.
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            DatabaseHelper db = new DatabaseHelper();

            bool success = db.UpdateWorkout(
                workoutId,
                txtExerciseName.Text,
                (int)numSets.Value,
                (int)numReps.Value,
                numWeight.Value
            );

            if (success)
            {
                MessageBox.Show("Workout updated!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Update failed.");
            }
        }

        /// <summary>
        /// Fires when the edit form loads and applies UI styling.
        /// </summary>
        private void WorkoutEditForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(28, 40, 60);
            this.Text = "McIntyre Fitness App";

            lblMcIntyre.ForeColor = Color.White;
            lblMcIntyre.BackColor = Color.Transparent;
            lblMcIntyre.Font = new Font("Segoe UI", 24F, FontStyle.Bold);

            btnSave.Size = new Size(160, 40);
            btnSave.BackColor = Color.FromArgb(0, 120, 215);
            btnSave.ForeColor = Color.White;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSave.Cursor = Cursors.Hand;
            numWeight.Maximum = 9999;
            numSets.Maximum = 100;
            numReps.Maximum = 100;
        }
    }
}