namespace McIntyresFitnessApp.Forms
{
    partial class WorkoutForm
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
            lblExerciseName = new Label();
            lblNumSets = new Label();
            lblNumReps = new Label();
            lblNumWeight = new Label();
            txtExerciseName = new TextBox();
            numSets = new NumericUpDown();
            numReps = new NumericUpDown();
            numWeight = new NumericUpDown();
            btnSaveWorkout = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)numSets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numReps).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numWeight).BeginInit();
            SuspendLayout();
            // 
            // lblExerciseName
            // 
            lblExerciseName.AutoSize = true;
            lblExerciseName.Location = new Point(271, 163);
            lblExerciseName.Name = "lblExerciseName";
            lblExerciseName.Size = new Size(83, 15);
            lblExerciseName.TabIndex = 0;
            lblExerciseName.Text = "Exercise Name";
            // 
            // lblNumSets
            // 
            lblNumSets.AutoSize = true;
            lblNumSets.Location = new Point(271, 206);
            lblNumSets.Name = "lblNumSets";
            lblNumSets.Size = new Size(89, 15);
            lblNumSets.TabIndex = 1;
            lblNumSets.Text = "Number of Sets";
            // 
            // lblNumReps
            // 
            lblNumReps.AutoSize = true;
            lblNumReps.Location = new Point(271, 251);
            lblNumReps.Name = "lblNumReps";
            lblNumReps.Size = new Size(93, 15);
            lblNumReps.TabIndex = 2;
            lblNumReps.Text = "Number of Reps";
            // 
            // lblNumWeight
            // 
            lblNumWeight.AutoSize = true;
            lblNumWeight.Location = new Point(271, 292);
            lblNumWeight.Name = "lblNumWeight";
            lblNumWeight.Size = new Size(106, 15);
            lblNumWeight.TabIndex = 3;
            lblNumWeight.Text = "Number of Weight";
            // 
            // txtExerciseName
            // 
            txtExerciseName.Location = new Point(360, 163);
            txtExerciseName.Name = "txtExerciseName";
            txtExerciseName.Size = new Size(165, 23);
            txtExerciseName.TabIndex = 4;
            // 
            // numSets
            // 
            numSets.Location = new Point(366, 204);
            numSets.Name = "numSets";
            numSets.Size = new Size(120, 23);
            numSets.TabIndex = 5;
            // 
            // numReps
            // 
            numReps.Location = new Point(366, 249);
            numReps.Name = "numReps";
            numReps.Size = new Size(120, 23);
            numReps.TabIndex = 6;
            // 
            // numWeight
            // 
            numWeight.Location = new Point(383, 290);
            numWeight.Name = "numWeight";
            numWeight.Size = new Size(120, 23);
            numWeight.TabIndex = 7;
            // 
            // btnSaveWorkout
            // 
            btnSaveWorkout.Location = new Point(301, 347);
            btnSaveWorkout.Name = "btnSaveWorkout";
            btnSaveWorkout.Size = new Size(185, 23);
            btnSaveWorkout.TabIndex = 8;
            btnSaveWorkout.Text = "Save Workout";
            btnSaveWorkout.UseVisualStyleBackColor = true;
            btnSaveWorkout.Click += btnSaveWorkout_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(674, 394);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // WorkoutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnSaveWorkout);
            Controls.Add(numWeight);
            Controls.Add(numReps);
            Controls.Add(numSets);
            Controls.Add(txtExerciseName);
            Controls.Add(lblNumWeight);
            Controls.Add(lblNumReps);
            Controls.Add(lblNumSets);
            Controls.Add(lblExerciseName);
            Name = "WorkoutForm";
            Text = "WorkoutForm";
            Load += WorkoutForm_Load;
            ((System.ComponentModel.ISupportInitialize)numSets).EndInit();
            ((System.ComponentModel.ISupportInitialize)numReps).EndInit();
            ((System.ComponentModel.ISupportInitialize)numWeight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblExerciseName;
        private Label lblNumSets;
        private Label lblNumReps;
        private Label lblNumWeight;
        private TextBox txtExerciseName;
        private NumericUpDown numSets;
        private NumericUpDown numReps;
        private NumericUpDown numWeight;
        private Button btnSaveWorkout;
        private Button btnBack;
    }
}