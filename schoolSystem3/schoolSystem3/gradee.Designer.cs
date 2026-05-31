namespace schoolSystem3
{
    partial class gradee
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbStudent = new ComboBox();
            combExam = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            dataGridView1 = new DataGridView();
            studentdgv = new DataGridViewTextBoxColumn();
            Examdgv = new DataGridViewTextBoxColumn();
            Gradedgv = new DataGridViewTextBoxColumn();
            btnAddg = new Button();
            btnUpdateg = new Button();
            btnRemoveg = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 49);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "Student";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 89);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 1;
            label2.Text = "Exam";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 142);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 2;
            label3.Text = "grade";
            // 
            // cmbStudent
            // 
            cmbStudent.FormattingEnabled = true;
            cmbStudent.Location = new Point(197, 44);
            cmbStudent.Name = "cmbStudent";
            cmbStudent.Size = new Size(151, 28);
            cmbStudent.TabIndex = 3;
            cmbStudent.SelectedIndexChanged += cmbStudent_SelectedIndexChanged;
            // 
            // combExam
            // 
            combExam.FormattingEnabled = true;
            combExam.Location = new Point(196, 89);
            combExam.Name = "combExam";
            combExam.Size = new Size(151, 28);
            combExam.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(197, 142);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { studentdgv, Examdgv, Gradedgv });
            dataGridView1.Location = new Point(69, 227);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(428, 188);
            dataGridView1.TabIndex = 6;
            // 
            // studentdgv
            // 
            studentdgv.HeaderText = "Student";
            studentdgv.MinimumWidth = 6;
            studentdgv.Name = "studentdgv";
            studentdgv.ReadOnly = true;
            studentdgv.Width = 125;
            // 
            // Examdgv
            // 
            Examdgv.HeaderText = "Exam";
            Examdgv.MinimumWidth = 6;
            Examdgv.Name = "Examdgv";
            Examdgv.ReadOnly = true;
            Examdgv.Width = 125;
            // 
            // Gradedgv
            // 
            Gradedgv.HeaderText = "Grade";
            Gradedgv.MinimumWidth = 6;
            Gradedgv.Name = "Gradedgv";
            Gradedgv.ReadOnly = true;
            Gradedgv.Width = 125;
            // 
            // btnAddg
            // 
            btnAddg.Location = new Point(525, 49);
            btnAddg.Name = "btnAddg";
            btnAddg.Size = new Size(94, 29);
            btnAddg.TabIndex = 7;
            btnAddg.Text = "Add";
            btnAddg.UseVisualStyleBackColor = true;
            btnAddg.Click += btnAddg_Click;
            // 
            // btnUpdateg
            // 
            btnUpdateg.Location = new Point(525, 102);
            btnUpdateg.Name = "btnUpdateg";
            btnUpdateg.Size = new Size(94, 29);
            btnUpdateg.TabIndex = 8;
            btnUpdateg.Text = "update";
            btnUpdateg.UseVisualStyleBackColor = true;
            btnUpdateg.Click += btnUpdateg_Click;
            // 
            // btnRemoveg
            // 
            btnRemoveg.Location = new Point(525, 142);
            btnRemoveg.Name = "btnRemoveg";
            btnRemoveg.Size = new Size(94, 29);
            btnRemoveg.TabIndex = 9;
            btnRemoveg.Text = "Remove";
            btnRemoveg.UseVisualStyleBackColor = true;
            btnRemoveg.Click += btnRemoveg_Click;
            // 
            // gradee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRemoveg);
            Controls.Add(btnUpdateg);
            Controls.Add(btnAddg);
            Controls.Add(dataGridView1);
            Controls.Add(numericUpDown1);
            Controls.Add(combExam);
            Controls.Add(cmbStudent);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "gradee";
            Text = "gradee";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbStudent;
        private ComboBox combExam;
        private NumericUpDown numericUpDown1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn studentdgv;
        private DataGridViewTextBoxColumn Examdgv;
        private DataGridViewTextBoxColumn Gradedgv;
        private Button btnAddg;
        private Button btnUpdateg;
        private Button btnRemoveg;
    }
}