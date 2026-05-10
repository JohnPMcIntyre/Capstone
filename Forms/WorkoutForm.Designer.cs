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
            lblMcIntyre = new Label();
            ((System.ComponentModel.ISupportInitialize)numSets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numReps).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numWeight).BeginInit();
            SuspendLayout();
            // 
            // lblExerciseName
            // 
            lblExerciseName.AutoSize = true;
            lblExerciseName.Location = new Point(310, 217);
            lblExerciseName.Name = "lblExerciseName";
            lblExerciseName.Size = new Size(106, 20);
            lblExerciseName.TabIndex = 0;
            lblExerciseName.Text = "Exercise Name";
            // 
            // lblNumSets
            // 
            lblNumSets.AutoSize = true;
            lblNumSets.Location = new Point(310, 275);
            lblNumSets.Name = "lblNumSets";
            lblNumSets.Size = new Size(112, 20);
            lblNumSets.TabIndex = 1;
            lblNumSets.Text = "Number of Sets";
            // 
            // lblNumReps
            // 
            lblNumReps.AutoSize = true;
            lblNumReps.Location = new Point(310, 335);
            lblNumReps.Name = "lblNumReps";
            lblNumReps.Size = new Size(117, 20);
            lblNumReps.TabIndex = 2;
            lblNumReps.Text = "Number of Reps";
            // 
            // lblNumWeight
            // 
            lblNumWeight.AutoSize = true;
            lblNumWeight.Location = new Point(310, 389);
            lblNumWeight.Name = "lblNumWeight";
            lblNumWeight.Size = new Size(132, 20);
            lblNumWeight.TabIndex = 3;
            lblNumWeight.Text = "Number of Weight";
            // 
            // txtExerciseName
            // 
            txtExerciseName.Location = new Point(411, 217);
            txtExerciseName.Margin = new Padding(3, 4, 3, 4);
            txtExerciseName.Name = "txtExerciseName";
            txtExerciseName.Size = new Size(188, 27);
            txtExerciseName.TabIndex = 4;
            // 
            // numSets
            // 
            numSets.Location = new Point(418, 272);
            numSets.Margin = new Padding(3, 4, 3, 4);
            numSets.Name = "numSets";
            numSets.Size = new Size(137, 27);
            numSets.TabIndex = 5;
            // 
            // numReps
            // 
            numReps.Location = new Point(418, 332);
            numReps.Margin = new Padding(3, 4, 3, 4);
            numReps.Name = "numReps";
            numReps.Size = new Size(137, 27);
            numReps.TabIndex = 6;
            // 
            // numWeight
            // 
            numWeight.Location = new Point(438, 387);
            numWeight.Margin = new Padding(3, 4, 3, 4);
            numWeight.Name = "numWeight";
            numWeight.Size = new Size(137, 27);
            numWeight.TabIndex = 7;
            // 
            // btnSaveWorkout
            // 
            btnSaveWorkout.Location = new Point(344, 463);
            btnSaveWorkout.Margin = new Padding(3, 4, 3, 4);
            btnSaveWorkout.Name = "btnSaveWorkout";
            btnSaveWorkout.Size = new Size(211, 31);
            btnSaveWorkout.TabIndex = 8;
            btnSaveWorkout.Text = "Save Workout";
            btnSaveWorkout.UseVisualStyleBackColor = true;
            btnSaveWorkout.Click += btnSaveWorkout_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(770, 525);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(86, 31);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblMcIntyre
            // 
            lblMcIntyre.AutoSize = true;
            lblMcIntyre.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMcIntyre.ForeColor = Color.RoyalBlue;
            lblMcIntyre.Location = new Point(264, 53);
            lblMcIntyre.Name = "lblMcIntyre";
            lblMcIntyre.Size = new Size(380, 50);
            lblMcIntyre.TabIndex = 10;
            lblMcIntyre.Text = "McIntyre Fitness";
            // 
            // WorkoutForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(914, 600);
            Controls.Add(lblMcIntyre);
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
            Margin = new Padding(3, 4, 3, 4);
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
        private Label lblMcIntyre;
    }
}