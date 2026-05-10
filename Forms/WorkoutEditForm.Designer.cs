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
            lblMcIntyre = new Label();
            ((System.ComponentModel.ISupportInitialize)numSets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numReps).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numWeight).BeginInit();
            SuspendLayout();
            // 
            // txtExerciseName
            // 
            txtExerciseName.Location = new Point(95, 88);
            txtExerciseName.Margin = new Padding(3, 4, 3, 4);
            txtExerciseName.Name = "txtExerciseName";
            txtExerciseName.Size = new Size(211, 27);
            txtExerciseName.TabIndex = 0;
            // 
            // numSets
            // 
            numSets.Location = new Point(95, 143);
            numSets.Margin = new Padding(3, 4, 3, 4);
            numSets.Name = "numSets";
            numSets.Size = new Size(137, 27);
            numSets.TabIndex = 1;
            // 
            // numReps
            // 
            numReps.Location = new Point(95, 181);
            numReps.Margin = new Padding(3, 4, 3, 4);
            numReps.Name = "numReps";
            numReps.Size = new Size(137, 27);
            numReps.TabIndex = 2;
            // 
            // numWeight
            // 
            numWeight.Location = new Point(95, 220);
            numWeight.Margin = new Padding(3, 4, 3, 4);
            numWeight.Name = "numWeight";
            numWeight.Size = new Size(137, 27);
            numWeight.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(95, 259);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(137, 31);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblMcIntyre
            // 
            lblMcIntyre.AutoSize = true;
            lblMcIntyre.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMcIntyre.ForeColor = Color.RoyalBlue;
            lblMcIntyre.Location = new Point(12, 9);
            lblMcIntyre.Name = "lblMcIntyre";
            lblMcIntyre.Size = new Size(380, 50);
            lblMcIntyre.TabIndex = 7;
            lblMcIntyre.Text = "McIntyre Fitness";
            // 
            // WorkoutEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(480, 396);
            Controls.Add(lblMcIntyre);
            Controls.Add(btnSave);
            Controls.Add(numWeight);
            Controls.Add(numReps);
            Controls.Add(numSets);
            Controls.Add(txtExerciseName);
            Margin = new Padding(3, 4, 3, 4);
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
        private Label lblMcIntyre;
    }
}