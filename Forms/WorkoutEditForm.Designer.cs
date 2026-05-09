namespace McIntyresFitnessApp.Forms
{
    partial class WorkoutEditForm
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
            txtExerciseName = new TextBox();
            numSets = new NumericUpDown();
            numReps = new NumericUpDown();
            numWeight = new NumericUpDown();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)numSets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numReps).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numWeight).BeginInit();
            SuspendLayout();
            // 
            // txtExerciseName
            // 
            txtExerciseName.Location = new Point(83, 66);
            txtExerciseName.Name = "txtExerciseName";
            txtExerciseName.Size = new Size(185, 23);
            txtExerciseName.TabIndex = 0;
            // 
            // numSets
            // 
            numSets.Location = new Point(83, 107);
            numSets.Name = "numSets";
            numSets.Size = new Size(120, 23);
            numSets.TabIndex = 1;
            // 
            // numReps
            // 
            numReps.Location = new Point(83, 136);
            numReps.Name = "numReps";
            numReps.Size = new Size(120, 23);
            numReps.TabIndex = 2;
            // 
            // numWeight
            // 
            numWeight.Location = new Point(83, 165);
            numWeight.Name = "numWeight";
            numWeight.Size = new Size(120, 23);
            numWeight.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(83, 194);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 23);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // WorkoutEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 297);
            Controls.Add(btnSave);
            Controls.Add(numWeight);
            Controls.Add(numReps);
            Controls.Add(numSets);
            Controls.Add(txtExerciseName);
            Name = "WorkoutEditForm";
            Text = "WorkoutEditForm";
            ((System.ComponentModel.ISupportInitialize)numSets).EndInit();
            ((System.ComponentModel.ISupportInitialize)numReps).EndInit();
            ((System.ComponentModel.ISupportInitialize)numWeight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtExerciseName;
        private NumericUpDown numSets;
        private NumericUpDown numReps;
        private NumericUpDown numWeight;
        private Button btnSave;
    }
}