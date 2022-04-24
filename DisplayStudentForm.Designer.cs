namespace CourseProject_CISS_311
{
    partial class DisplayStudentForm
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
            this.components = new System.ComponentModel.Container();
            this.allStudentDataGridView = new System.Windows.Forms.DataGridView();
            this.courseProjectDBDataSet1 = new CourseProject_CISS_311.CourseProjectDBDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter1 = new CourseProject_CISS_311.CourseProjectDBDataSetTableAdapters.studentTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.allStudentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseProjectDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // allStudentDataGridView
            // 
            this.allStudentDataGridView.AutoGenerateColumns = false;
            this.allStudentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allStudentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.allStudentDataGridView.DataSource = this.bindingSource1;
            this.allStudentDataGridView.Location = new System.Drawing.Point(21, 37);
            this.allStudentDataGridView.Name = "allStudentDataGridView";
            this.allStudentDataGridView.Size = new System.Drawing.Size(344, 317);
            this.allStudentDataGridView.TabIndex = 0;
            // 
            // courseProjectDBDataSet1
            // 
            this.courseProjectDBDataSet1.DataSetName = "CourseProjectDBDataSet";
            this.courseProjectDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "student";
            this.bindingSource1.DataSource = this.courseProjectDBDataSet1;
            // 
            // studentTableAdapter1
            // 
            this.studentTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "studentId";
            this.dataGridViewTextBoxColumn1.HeaderText = "studentId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "studentName";
            this.dataGridViewTextBoxColumn2.HeaderText = "studentName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "coursesEnrolled";
            this.dataGridViewTextBoxColumn3.HeaderText = "coursesEnrolled";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.Location = new System.Drawing.Point(128, 409);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(166, 46);
            this.button.TabIndex = 1;
            this.button.Text = "&Close";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.allStudentDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 390);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display All Students";
            // 
            // DisplayStudentForm
            // 
            this.ClientSize = new System.Drawing.Size(418, 467);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button);
            this.Name = "DisplayStudentForm";
            this.Text = "DisplayAllStudentsForm";
            this.Load += new System.EventHandler(this.DisplayStudentForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.allStudentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseProjectDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.DataGridView allStudentsDataGridView;
        private CourseProjectDBDataSet courseProjectDBDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private CourseProjectDBDataSetTableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursesEnrolledDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView allStudentDataGridView;
        private CourseProjectDBDataSet courseProjectDBDataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private CourseProjectDBDataSetTableAdapters.studentTableAdapter studentTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}