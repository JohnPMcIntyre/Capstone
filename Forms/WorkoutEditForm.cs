using System;
using System.Windows.Forms;
using McIntyresFitnessApp.Services;

namespace McIntyresFitnessApp.Forms
{
    public partial class WorkoutEditForm : Form
    {
        private int workoutId;

        public WorkoutEditForm(int id, string exercise, int sets, int reps, decimal weight)
        {
            InitializeComponent();

            workoutId = id;

            txtExerciseName.Text = exercise;
            numSets.Value = sets;
            numReps.Value = reps;
            numWeight.Value = weight;
        }

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
    }
}