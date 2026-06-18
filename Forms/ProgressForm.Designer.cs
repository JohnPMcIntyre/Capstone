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
        /// Required method for Designer support do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTotalWorkouts = new Label();
            lblTotalWeight = new Label();
            lblFavoriteExercise = new Label();
            lblMaxWeight = new Label();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            lblMcIntyre = new Label();
            SuspendLayout();
            // 
            // lblTotalWorkouts
            // 
            lblTotalWorkouts.AutoSize = true;
            lblTotalWorkouts.Location = new Point(90, 133);
            lblTotalWorkouts.Name = "lblTotalWorkouts";
            lblTotalWorkouts.Size = new Size(111, 20);
            lblTotalWorkouts.TabIndex = 0;
            lblTotalWorkouts.Text = "Total Workouts:";
            // 
            // lblTotalWeight
            // 
            lblTotalWeight.AutoSize = true;
            lblTotalWeight.Location = new Point(90, 195);
            lblTotalWeight.Name = "lblTotalWeight";
            lblTotalWeight.Size = new Size(138, 20);
            lblTotalWeight.TabIndex = 1;
            lblTotalWeight.Text = "Total Weight Lifted:";
            // 
            // lblFavoriteExercise
            // 
            lblFavoriteExercise.AutoSize = true;
            lblFavoriteExercise.Location = new Point(90, 325);
            lblFavoriteExercise.Name = "lblFavoriteExercise";
            lblFavoriteExercise.Size = new Size(118, 20);
            lblFavoriteExercise.TabIndex = 2;
            lblFavoriteExercise.Text = "Favorite Exercise";
            // 
            // lblMaxWeight
            // 
            lblMaxWeight.AutoSize = true;
            lblMaxWeight.Location = new Point(90, 259);
            lblMaxWeight.Name = "lblMaxWeight";
            lblMaxWeight.Size = new Size(94, 20);
            lblMaxWeight.TabIndex = 4;
            lblMaxWeight.Text = "Heaviest Lift:";
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // lblMcIntyre
            // 
            lblMcIntyre.AutoSize = true;
            lblMcIntyre.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMcIntyre.ForeColor = Color.RoyalBlue;
            lblMcIntyre.Location = new Point(12, 24);
            lblMcIntyre.Name = "lblMcIntyre";
            lblMcIntyre.Size = new Size(380, 50);
            lblMcIntyre.TabIndex = 7;
            lblMcIntyre.Text = "McIntyre Fitness";
            // 
            // ProgressForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(538, 600);
            Controls.Add(lblMcIntyre);
            Controls.Add(lblMaxWeight);
            Controls.Add(lblFavoriteExercise);
            Controls.Add(lblTotalWeight);
            Controls.Add(lblTotalWorkouts);
            Margin = new Padding(3, 4, 3, 4);
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
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Label lblMcIntyre;
    }
}