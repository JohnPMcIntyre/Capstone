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
            lblMcIntyre = new Label();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // btnLogWorkout
            // 
            btnLogWorkout.Location = new Point(91, 86);
            btnLogWorkout.Margin = new Padding(3, 4, 3, 4);
            btnLogWorkout.Name = "btnLogWorkout";
            btnLogWorkout.Size = new Size(171, 64);
            btnLogWorkout.TabIndex = 0;
            btnLogWorkout.Text = "Log Workout";
            btnLogWorkout.UseVisualStyleBackColor = true;
            btnLogWorkout.Click += btnLogWorkout_Click;
            // 
            // btnViewHistory
            // 
            btnViewHistory.Location = new Point(350, 86);
            btnViewHistory.Margin = new Padding(3, 4, 3, 4);
            btnViewHistory.Name = "btnViewHistory";
            btnViewHistory.Size = new Size(197, 64);
            btnViewHistory.TabIndex = 1;
            btnViewHistory.Text = "View History";
            btnViewHistory.UseVisualStyleBackColor = true;
            btnViewHistory.Click += btnViewHistory_Click;
            // 
            // btnProgress
            // 
            btnProgress.Location = new Point(632, 86);
            btnProgress.Margin = new Padding(3, 4, 3, 4);
            btnProgress.Name = "btnProgress";
            btnProgress.Size = new Size(192, 64);
            btnProgress.TabIndex = 2;
            btnProgress.Text = "Progress";
            btnProgress.UseVisualStyleBackColor = true;
            btnProgress.Click += btnProgress_Click;
            // 
            // lblMcIntyre
            // 
            lblMcIntyre.AutoSize = true;
            lblMcIntyre.BackColor = Color.DimGray;
            lblMcIntyre.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMcIntyre.ForeColor = Color.RoyalBlue;
            lblMcIntyre.Location = new Point(12, 9);
            lblMcIntyre.Name = "lblMcIntyre";
            lblMcIntyre.Size = new Size(380, 50);
            lblMcIntyre.TabIndex = 3;
            lblMcIntyre.Text = "McIntyre Fitness";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(359, 268);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(197, 64);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(914, 600);
            Controls.Add(btnLogout);
            Controls.Add(lblMcIntyre);
            Controls.Add(btnProgress);
            Controls.Add(btnViewHistory);
            Controls.Add(btnLogWorkout);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DashboardForm";
            Text = "DashboardForm";
            this.Load += new EventHandler(this.DashboardForm_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogWorkout;
        private Button btnViewHistory;
        private Button btnProgress;
        private Label lblMcIntyre;
        private Button btnLogout;
    }
}