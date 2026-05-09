namespace McIntyresFitnessApp.Forms
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogWorkout = new Button();
            btnViewHistory = new Button();
            btnProgress = new Button();
            SuspendLayout();
            // 
            // btnLogWorkout
            // 
            btnLogWorkout.Location = new Point(80, 40);
            btnLogWorkout.Name = "btnLogWorkout";
            btnLogWorkout.Size = new Size(150, 23);
            btnLogWorkout.TabIndex = 0;
            btnLogWorkout.Text = "Log Workout";
            btnLogWorkout.UseVisualStyleBackColor = true;
            btnLogWorkout.Click += btnLogWorkout_Click;
            // 
            // btnViewHistory
            // 
            btnViewHistory.Location = new Point(306, 40);
            btnViewHistory.Name = "btnViewHistory";
            btnViewHistory.Size = new Size(172, 23);
            btnViewHistory.TabIndex = 1;
            btnViewHistory.Text = "View History";
            btnViewHistory.UseVisualStyleBackColor = true;
            btnViewHistory.Click += btnViewHistory_Click;
            // 
            // btnProgress
            // 
            btnProgress.Location = new Point(553, 40);
            btnProgress.Name = "btnProgress";
            btnProgress.Size = new Size(168, 23);
            btnProgress.TabIndex = 2;
            btnProgress.Text = "Progress";
            btnProgress.UseVisualStyleBackColor = true;
            btnProgress.Click += btnProgress_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnProgress);
            Controls.Add(btnViewHistory);
            Controls.Add(btnLogWorkout);
            Name = "DashboardForm";
            Text = "DashboardForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogWorkout;
        private Button btnViewHistory;
        private Button btnProgress;
    }
}