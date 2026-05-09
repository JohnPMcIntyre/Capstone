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

        private void WorkoutForm_Load(object sender, EventArgs e)
        {
        }

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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}