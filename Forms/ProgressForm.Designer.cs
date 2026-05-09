namespace McIntyresFitnessApp.Forms
{
    partial class ProgressForm
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
            lblTotalWorkouts = new Label();
            lblTotalWeight = new Label();
            lblFavoriteExercise = new Label();
            lblMaxWeight = new Label();
            SuspendLayout();
            // 
            // lblTotalWorkouts
            // 
            lblTotalWorkouts.AutoSize = true;
            lblTotalWorkouts.Location = new Point(82, 56);
            lblTotalWorkouts.Name = "lblTotalWorkouts";
            lblTotalWorkouts.Size = new Size(90, 15);
            lblTotalWorkouts.TabIndex = 0;
            lblTotalWorkouts.Text = "Total Workouts:";
            // 
            // lblTotalWeight
            // 
            lblTotalWeight.AutoSize = true;
            lblTotalWeight.Location = new Point(82, 103);
            lblTotalWeight.Name = "lblTotalWeight";
            lblTotalWeight.Size = new Size(110, 15);
            lblTotalWeight.TabIndex = 1;
            lblTotalWeight.Text = "Total Weight Lifted:";
            // 
            // lblFavoriteExercise
            // 
            lblFavoriteExercise.AutoSize = true;
            lblFavoriteExercise.Location = new Point(82, 200);
            lblFavoriteExercise.Name = "lblFavoriteExercise";
            lblFavoriteExercise.Size = new Size(93, 15);
            lblFavoriteExercise.TabIndex = 2;
            lblFavoriteExercise.Text = "Favorite Exercise";
            // 
            // lblMaxWeight
            // 
            lblMaxWeight.AutoSize = true;
            lblMaxWeight.Location = new Point(82, 151);
            lblMaxWeight.Name = "lblMaxWeight";
            lblMaxWeight.Size = new Size(75, 15);
            lblMaxWeight.TabIndex = 4;
            lblMaxWeight.Text = "Heaviest Lift:";
            // 
            // ProgressForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 450);
            Controls.Add(lblMaxWeight);
            Controls.Add(lblFavoriteExercise);
            Controls.Add(lblTotalWeight);
            Controls.Add(lblTotalWorkouts);
            Name = "ProgressForm";
            Text = "ProgressForm";
            Load += ProgressForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTotalWorkouts;
        private Label lblTotalWeight;
        private Label lblFavoriteExercise;
        private Label lblMaxWeight;
    }
}