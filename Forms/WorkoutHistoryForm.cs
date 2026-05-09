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
    public partial class WorkoutHistoryForm : Form
    {
        private int selectedWorkoutId = -1;

        public WorkoutHistoryForm()
        {
            InitializeComponent();
        }

        private void WorkoutHistoryForm_Load(object sender, EventArgs e)
        {
            LoadWorkouts();
        }

        private void LoadWorkouts()
        {
            DatabaseHelper db = new DatabaseHelper();
            int userId = UserSession.UserId;

            DataTable data = db.GetWorkouts(userId);

            dgvWorkouts.DataSource = data;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteWorkout_Click(object sender, EventArgs e)
        {
            if (dgvWorkouts.SelectedRows.Count > 0)
            {
                int workoutId = Convert.ToInt32(dgvWorkouts.SelectedRows[0].Cells["WorkoutID"].Value);

                DatabaseHelper db = new DatabaseHelper();

                bool success = db.DeleteWorkout(workoutId);

                if (success)
                {
                    MessageBox.Show("Workout deleted!");
                    LoadWorkouts();
                }
                else
                {
                    MessageBox.Show("Delete failed.");
                }
            }
        }

        private void dgvWorkouts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvWorkouts.Rows[e.RowIndex];

                selectedWorkoutId = Convert.ToInt32(row.Cells["WorkoutID"].Value);
            }
        }

        private void btnEditWorkout_Click(object sender, EventArgs e)
        {
            if (dgvWorkouts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a workout first.");
                return;
            }

            DataGridViewRow row = dgvWorkouts.SelectedRows[0];

            int workoutId = Convert.ToInt32(row.Cells["WorkoutID"].Value);
            string exercise = row.Cells["ExerciseName"].Value.ToString();
            int sets = Convert.ToInt32(row.Cells["Sets"].Value);
            int reps = Convert.ToInt32(row.Cells["Reps"].Value);
            decimal weight = Convert.ToDecimal(row.Cells["Weight"].Value);

            WorkoutEditForm form = new WorkoutEditForm(
                workoutId,
                exercise,
                sets,
                reps,
                weight
            );

            form.ShowDialog();

            LoadWorkouts();
        }
    }
}
