namespace schoolSystem3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtExam = new TextBox();
            txtSubject = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnRemove = new Button();
            dataGridView1 = new DataGridView();
            exam = new DataGridViewTextBoxColumn();
            subject = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 41);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 0;
            label1.Text = "Exam";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 92);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 1;
            label2.Text = "Subject";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 157);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 2;
            label3.Text = "Date";
            // 
            // txtExam
            // 
            txtExam.Location = new Point(167, 41);
            txtExam.Name = "txtExam";
            txtExam.Size = new Size(162, 27);
            txtExam.TabIndex = 3;
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(167, 92);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(162, 27);
            txtSubject.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(167, 157);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(243, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(540, 41);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(102, 42);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(540, 107);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(102, 45);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(540, 171);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(97, 48);
            btnRemove.TabIndex = 8;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { exam, subject, date });
            dataGridView1.Location = new Point(81, 230);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(408, 187);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // exam
            // 
            exam.HeaderText = "exam";
            exam.MinimumWidth = 6;
            exam.Name = "exam";
            exam.Width = 125;
            // 
            // subject
            // 
            subject.HeaderText = "subject";
            subject.MinimumWidth = 6;
            subject.Name = "subject";
            subject.Width = 125;
            // 
            // date
            // 
            date.HeaderText = "Date";
            date.MinimumWidth = 6;
            date.Name = "date";
            date.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnRemove);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtSubject);
            Controls.Add(txtExam);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtExam;
        private TextBox txtSubject;
        private DateTimePicker dateTimePicker1;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnRemove;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn exam;
        private DataGridViewTextBoxColumn subject;
        private DataGridViewTextBoxColumn date;
    }
}
