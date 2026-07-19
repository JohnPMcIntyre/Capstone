using System.Windows.Forms.DataVisualization.Charting;

namespace McIntyresFitnessApp.Forms
{
    partial class WorkoutChartForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            chart1 = new Chart();
            ChartArea chartArea = new ChartArea();
            lblMcIntyre = new System.Windows.Forms.Label();
            btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();

            // chart1
            chartArea.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea);
            chart1.Location = new System.Drawing.Point(0, 80);
            chart1.Name = "chart1";
            chart1.Size = new System.Drawing.Size(914, 460);
            chart1.TabIndex = 0;

            // lblMcIntyre
            lblMcIntyre.AutoSize = true;
            lblMcIntyre.Location = new System.Drawing.Point(12, 15);
            lblMcIntyre.Name = "lblMcIntyre";
            lblMcIntyre.Size = new System.Drawing.Size(380, 50);
            lblMcIntyre.TabIndex = 1;
            lblMcIntyre.Text = "McIntyre Fitness";

            // btnBack
            btnBack.Location = new System.Drawing.Point(771, 555);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(114, 36);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.Click += btnBack_Click;

            // WorkoutChartForm
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(914, 600);
            Controls.Add(btnBack);
            Controls.Add(lblMcIntyre);
            Controls.Add(chart1);
            Name = "WorkoutChartForm";
            Text = "WorkoutChartForm";
            this.Load += new System.EventHandler(this.WorkoutChartForm_Load);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Chart chart1;
        private System.Windows.Forms.Label lblMcIntyre;
        private System.Windows.Forms.Button btnBack;
    }
}