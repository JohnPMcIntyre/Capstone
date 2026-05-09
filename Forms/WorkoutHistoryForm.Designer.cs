namespace McIntyresFitnessApp.Forms
{
    partial class WorkoutHistoryForm
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
            dgvWorkouts = new DataGridView();
            btnBack = new Button();
            btnDeleteWorkout = new Button();
            btnEditWorkout = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvWorkouts).BeginInit();
            SuspendLayout();
            // 
            // dgvWorkouts
            // 
            dgvWorkouts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWorkouts.Location = new Point(0, 0);
            dgvWorkouts.Name = "dgvWorkouts";
            dgvWorkouts.Size = new Size(800, 414);
            dgvWorkouts.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(675, 420);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 23);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnDeleteWorkout
            // 
            btnDeleteWorkout.Location = new Point(569, 420);
            btnDeleteWorkout.Name = "btnDeleteWorkout";
            btnDeleteWorkout.Size = new Size(100, 23);
            btnDeleteWorkout.TabIndex = 2;
            btnDeleteWorkout.Text = "Delete";
            btnDeleteWorkout.UseVisualStyleBackColor = true;
            btnDeleteWorkout.Click += btnDeleteWorkout_Click;
            // 
            // btnEditWorkout
            // 
            btnEditWorkout.Location = new Point(463, 420);
            btnEditWorkout.Name = "btnEditWorkout";
            btnEditWorkout.Size = new Size(100, 23);
            btnEditWorkout.TabIndex = 3;
            btnEditWorkout.Text = "Edit";
            btnEditWorkout.UseVisualStyleBackColor = true;
            btnEditWorkout.Click += btnEditWorkout_Click;
            // 
            // WorkoutHistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEditWorkout);
            Controls.Add(btnDeleteWorkout);
            Controls.Add(btnBack);
            Controls.Add(dgvWorkouts);
            Name = "WorkoutHistoryForm";
            Text = "WorkoutHistoryForm";
            Load += WorkoutHistoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvWorkouts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvWorkouts;
        private Button btnBack;
        private Button btnDeleteWorkout;
        private Button button1;
        private Button btnEditWorkout;
    }
}