using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using McIntyresFitnessApp.Services;

namespace McIntyresFitnessApp.Forms
{
    public partial class WorkoutChartForm : Form
    {
        /// <summary>
        /// Initializes the workout chart form components.
        /// </summary>
        public WorkoutChartForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads and displays the workout progress chart when the form opens.
        /// </summary>
        private void WorkoutChartForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(28, 40, 60);
            this.Text = "McIntyre Fitness App";
            lblMcIntyre.ForeColor = Color.White;
            lblMcIntyre.BackColor = Color.Transparent;
            lblMcIntyre.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            btnBack.BackColor = Color.FromArgb(180, 40, 40);
            btnBack.ForeColor = Color.White;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnBack.Cursor = Cursors.Hand;
            LoadChart();
        }

        /// <summary>
        /// Queries the database and plots workout weight over time on a line graph.
        /// </summary>
        private void LoadChart()
        {
            DatabaseHelper db = new DatabaseHelper();
            int userId = UserSession.UserId;
            DataTable data = db.GetWorkoutsForChart(userId);
            chart1.Series.Clear();
            chart1.ChartAreas[0].BackColor = Color.FromArgb(40, 55, 80);
            chart1.BackColor = Color.FromArgb(28, 40, 60);
            chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
            chart1.ChartAreas[0].AxisX.LineColor = Color.White;
            chart1.ChartAreas[0].AxisY.LineColor = Color.White;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.FromArgb(60, 80, 110);
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.FromArgb(60, 80, 110);
            chart1.ChartAreas[0].AxisX.Title = "Date";
            chart1.ChartAreas[0].AxisX.TitleForeColor = Color.White;
            chart1.ChartAreas[0].AxisX.IsReversed = false;
            chart1.ChartAreas[0].AxisY.Title = "Weight (lbs)";
            chart1.ChartAreas[0].AxisY.TitleForeColor = Color.White;
            Series series = new Series("Weight Lifted");
            series.ChartType = SeriesChartType.Line;
            series.Color = Color.FromArgb(0, 120, 215);
            series.BorderWidth = 3;
            series.MarkerStyle = MarkerStyle.Circle;
            series.MarkerSize = 8;
            series.MarkerColor = Color.White;
            if (data.Rows.Count == 0)
            {
                chart1.Titles.Add("No workout data available yet.");
            }
            else
            {
                foreach (DataRow row in data.Rows)
                {
                    DateTime date = Convert.ToDateTime(row["WorkoutDate"]);
                    decimal weight = Convert.ToDecimal(row["Weight"]);
                    series.Points.AddXY(date.ToShortDateString(), (double)weight);
                }
            }
            chart1.Series.Add(series);
            chart1.Legends.Clear();
        }

        /// <summary>
        /// Closes the chart form.
        /// </summary>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}