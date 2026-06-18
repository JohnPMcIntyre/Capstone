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
        /// Loads and displays the user's progress statistics when the form opens.
        /// </summary>
        private void ProgressForm_Load(object sender, EventArgs e)
        {
            DatabaseHelper db = new DatabaseHelper();

            int userId = UserSession.UserId;

            lblTotalWorkouts.Text =
                "Total Workouts: " + db.GetTotalWorkouts(userId);

            lblTotalWeight.Text =
                "Total Weight Lifted: " + db.GetTotalWeightLifted(userId) + " lbs";

            lblMaxWeight.Text =
                "Heaviest Lift: " + db.GetMaxWeight(userId) + " lbs";

            lblFavoriteExercise.Text =
                "Favorite Exercise: " + db.GetFavoriteExercise(userId);
        }
    }
}
