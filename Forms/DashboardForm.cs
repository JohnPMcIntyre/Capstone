using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace McIntyresFitnessApp.Forms
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void btnLogWorkout_Click(object sender, EventArgs e)
        {
            using (WorkoutForm form = new WorkoutForm())
            {
                form.ShowDialog();
            }
        }

        private void btnViewHistory_Click(object sender, EventArgs e)
        {
            using (WorkoutHistoryForm form = new WorkoutHistoryForm())
            {
                form.ShowDialog();
            }
        }

        private void btnProgress_Click(object sender, EventArgs e)
        {
            ProgressForm form = new ProgressForm();
            form.ShowDialog();
        }
    }
}
