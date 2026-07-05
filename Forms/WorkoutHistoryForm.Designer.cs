namespace McIntyresFitnessApp.Forms
{
    partial class WorkoutHistoryForm
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
            dgvWorkouts = new DataGridView();
            btnBack = new Button();
            btnDeleteWorkout = new Button();
            btnEditWorkout = new Button();
            lblMcIntyre = new Label();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            btnFilter = new Button();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvWorkouts).BeginInit();
            SuspendLayout();

            // dgvWorkouts
            dgvWorkouts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWorkouts.Location = new Point(0, 0);
            dgvWorkouts.Margin = new Padding(3, 4, 3, 4);
            dgvWorkouts.Name = "dgvWorkouts";
            dgvWorkouts.RowHeadersWidth = 51;
            dgvWorkouts.Size = new Size(914, 552);
            dgvWorkouts.TabIndex = 0;

            // btnBack
            btnBack.Location = new Point(771, 560);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(114, 31);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;

            // btnDeleteWorkout
            btnDeleteWorkout.Location = new Point(650, 560);
            btnDeleteWorkout.Margin = new Padding(3, 4, 3, 4);
            btnDeleteWorkout.Name = "btnDeleteWorkout";
            btnDeleteWorkout.Size = new Size(114, 31);
            btnDeleteWorkout.TabIndex = 2;
            btnDeleteWorkout.Text = "Delete";
            btnDeleteWorkout.UseVisualStyleBackColor = true;
            btnDeleteWorkout.Click += btnDeleteWorkout_Click;

            // btnEditWorkout
            btnEditWorkout.Location = new Point(529, 560);
            btnEditWorkout.Margin = new Padding(3, 4, 3, 4);
            btnEditWorkout.Name = "btnEditWorkout";
            btnEditWorkout.Size = new Size(114, 31);
            btnEditWorkout.TabIndex = 3;
            btnEditWorkout.Text = "Edit";
            btnEditWorkout.UseVisualStyleBackColor = true;
            btnEditWorkout.Click += btnEditWorkout_Click;

            // lblMcIntyre
            lblMcIntyre.AutoSize = true;
            lblMcIntyre.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMcIntyre.ForeColor = Color.RoyalBlue;
            lblMcIntyre.Location = new Point(0, 556);
            lblMcIntyre.Name = "lblMcIntyre";
            lblMcIntyre.Size = new Size(380, 50);
            lblMcIntyre.TabIndex = 7;
            lblMcIntyre.Text = "McIntyre Fitness";

            // dtpStartDate
            dtpStartDate.Location = new Point(10, 560);
            dtpStartDate.Size = new Size(150, 31);
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.TabIndex = 8;

            // dtpEndDate
            dtpEndDate.Location = new Point(170, 560);
            dtpEndDate.Size = new Size(150, 31);
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.TabIndex = 9;

            // btnFilter
            btnFilter.Location = new Point(330, 560);
            btnFilter.Size = new Size(90, 31);
            btnFilter.Text = "Filter";
            btnFilter.Name = "btnFilter";
            btnFilter.TabIndex = 10;
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;

            // btnClear
            btnClear.Location = new Point(428, 560);
            btnClear.Size = new Size(90, 31);
            btnClear.Text = "Clear";
            btnClear.Name = "btnClear";
            btnClear.TabIndex = 11;
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;

            // WorkoutHistoryForm
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(lblMcIntyre);
            Controls.Add(btnEditWorkout);
            Controls.Add(btnDeleteWorkout);
            Controls.Add(btnBack);
            Controls.Add(dgvWorkouts);
            Controls.Add(dtpStartDate);
            Controls.Add(dtpEndDate);
            Controls.Add(btnFilter);
            Controls.Add(btnClear);
            Margin = new Padding(3, 4, 3, 4);
            Name = "WorkoutHistoryForm";
            Text = "WorkoutHistoryForm";
            Load += WorkoutHistoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvWorkouts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView dgvWorkouts;
        private Button btnBack;
        private Button btnDeleteWorkout;
        private Button button1;
        private Button btnEditWorkout;
        private Label lblMcIntyre;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Button btnFilter;
        private Button btnClear;
    }
}