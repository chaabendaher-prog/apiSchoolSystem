namespace schoolSystem3
{
    partial class Students
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
            txtStudentc = new TextBox();
            txtclassec = new TextBox();
            btnAddc = new Button();
            btnUpdatec = new Button();
            btnRemovec = new Button();
            dataGridView1 = new DataGridView();
            studentdtgv = new DataGridViewTextBoxColumn();
            classdtv = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 51);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "Student";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 96);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 1;
            label2.Text = "Class";
            // 
            // txtStudentc
            // 
            txtStudentc.Location = new Point(165, 51);
            txtStudentc.Name = "txtStudentc";
            txtStudentc.Size = new Size(125, 27);
            txtStudentc.TabIndex = 2;
            // 
            // txtclassec
            // 
            txtclassec.Location = new Point(165, 96);
            txtclassec.Name = "txtclassec";
            txtclassec.Size = new Size(125, 27);
            txtclassec.TabIndex = 3;
            // 
            // btnAddc
            // 
            btnAddc.Location = new Point(432, 41);
            btnAddc.Name = "btnAddc";
            btnAddc.Size = new Size(94, 29);
            btnAddc.TabIndex = 4;
            btnAddc.Text = "Add";
            btnAddc.UseVisualStyleBackColor = true;
            btnAddc.Click += btnAddc_Click;
            // 
            // btnUpdatec
            // 
            btnUpdatec.Location = new Point(432, 96);
            btnUpdatec.Name = "btnUpdatec";
            btnUpdatec.Size = new Size(94, 29);
            btnUpdatec.TabIndex = 5;
            btnUpdatec.Text = "Update";
            btnUpdatec.UseVisualStyleBackColor = true;
            btnUpdatec.Click += btnUpdatec_Click;
            // 
            // btnRemovec
            // 
            btnRemovec.Location = new Point(432, 152);
            btnRemovec.Name = "btnRemovec";
            btnRemovec.Size = new Size(94, 29);
            btnRemovec.TabIndex = 6;
            btnRemovec.Text = "Remove";
            btnRemovec.UseVisualStyleBackColor = true;
            btnRemovec.Click += btnRemovec_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { studentdtgv, classdtv });
            dataGridView1.Location = new Point(59, 193);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 202);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // studentdtgv
            // 
            studentdtgv.HeaderText = "student";
            studentdtgv.MinimumWidth = 6;
            studentdtgv.Name = "studentdtgv";
            studentdtgv.ReadOnly = true;
            studentdtgv.Width = 125;
            // 
            // classdtv
            // 
            classdtv.HeaderText = "class";
            classdtv.MinimumWidth = 6;
            classdtv.Name = "classdtv";
            classdtv.ReadOnly = true;
            classdtv.Width = 125;
            // 
            // Students
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnRemovec);
            Controls.Add(btnUpdatec);
            Controls.Add(btnAddc);
            Controls.Add(txtclassec);
            Controls.Add(txtStudentc);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Students";
            Text = "Students";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtStudentc;
        private TextBox txtclassec;
        private Button btnAddc;
        private Button btnUpdatec;
        private Button btnRemovec;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn studentdtgv;
        private DataGridViewTextBoxColumn classdtv;
    }
}