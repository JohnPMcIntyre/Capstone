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

        /// <summary>
        /// Loads the workout history when the form opens and applies UI styling.
        /// </summary>
        private void WorkoutHistoryForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(28, 40, 60);
            this.Text = "McIntyre Fitness App";

            lblMcIntyre.ForeColor = Color.White;
            lblMcIntyre.BackColor = Color.Transparent;
            lblMcIntyre.Font = new Font("Segoe UI", 16F, FontStyle.Bold);

            btnEditWorkout.BackColor = Color.FromArgb(0, 120, 215);
            btnEditWorkout.ForeColor = Color.White;
            btnEditWorkout.FlatStyle = FlatStyle.Flat;
            btnEditWorkout.FlatAppearance.BorderSize = 0;
            btnEditWorkout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEditWorkout.Cursor = Cursors.Hand;

            btnDeleteWorkout.BackColor = Color.FromArgb(180, 40, 40);
            btnDeleteWorkout.ForeColor = Color.White;
            btnDeleteWorkout.FlatStyle = FlatStyle.Flat;
            btnDeleteWorkout.FlatAppearance.BorderSize = 0;
            btnDeleteWorkout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDeleteWorkout.Cursor = Cursors.Hand;

            btnBack.BackColor = Color.FromArgb(80, 80, 80);
            btnBack.ForeColor = Color.White;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.Cursor = Cursors.Hand;

            btnFilter.BackColor = Color.FromArgb(0, 120, 215);
            btnFilter.ForeColor = Color.White;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.FlatAppearance.BorderSize = 0;
            btnFilter.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnFilter.Cursor = Cursors.Hand;

            btnClear.BackColor = Color.FromArgb(80, 80, 80);
            btnClear.ForeColor = Color.White;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClear.Cursor = Cursors.Hand;

            dgvWorkouts.BackgroundColor = Color.FromArgb(28, 40, 60);
            dgvWorkouts.BorderStyle = BorderStyle.None;
            dgvWorkouts.DefaultCellStyle.BackColor = Color.FromArgb(40, 55, 80);
            dgvWorkouts.DefaultCellStyle.ForeColor = Color.White;
            dgvWorkouts.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgvWorkouts.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            dgvWorkouts.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvWorkouts.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvWorkouts.EnableHeadersVisualStyles = false;
            dgvWorkouts.GridColor = Color.FromArgb(60, 80, 110);
            dgvWorkouts.RowHeadersVisible = true;
            dgvWorkouts.RowHeadersWidth = 20;
            dgvWorkouts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            lblMcIntyre.Visible = false;

            LoadWorkouts();
        }

        /// <summary>
        /// Retrieves and displays the logged in user's workouts in the grid.
        /// </summary>
        private void LoadWorkouts()
        {
            DatabaseHelper db = new DatabaseHelper();
            int userId = UserSession.UserId;
            DataTable data = db.GetWorkouts(userId);
            dgvWorkouts.DataSource = data;
        }

        /// <summary>
        /// Filters workouts by the selected date range.
        /// </summary>
        private void btnFilter_Click(object sender, EventArgs e)
        {
            DatabaseHelper db = new DatabaseHelper();
            int userId = UserSession.UserId;
            DataTable data = db.GetWorkoutsByDate(userId, dtpStartDate.Value.Date, dtpEndDate.Value.Date);
            dgvWorkouts.DataSource = data;
        }

        /// <summary>
        /// Clears the date filter and reloads all workouts.
        /// </summary>
        private void btnClear_Click(object sender, EventArgs e)
        {
            LoadWorkouts();
        }

        /// <summary>
        /// Closes the workout history form.
        /// </summary>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Deletes the selected workout from the database and refreshes the grid.
        /// </summary>
        private void btnDeleteWorkout_Click(object sender, EventArgs e)
        {
            if (dgvWorkouts.SelectedRows.Count > 0)
            {
                DialogResult confirm = MessageBox.Show(
                    "Are you sure you want to delete this workout?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirm == DialogResult.Yes)
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
        }

        /// <summary>
        /// Stores the ID of the workout row clicked in the grid.
        /// </summary>
        private void dgvWorkouts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvWorkouts.Rows[e.RowIndex];
                selectedWorkoutId = Convert.ToInt32(row.Cells["WorkoutID"].Value);
            }
        }

        /// <summary>
        /// Opens the edit form for the selected workout and refreshes the grid after saving.
        /// </summary>
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

            WorkoutEditForm form = new WorkoutEditForm(workoutId, exercise, sets, reps, weight);
            form.ShowDialog();
            LoadWorkouts();
        }
    }
}