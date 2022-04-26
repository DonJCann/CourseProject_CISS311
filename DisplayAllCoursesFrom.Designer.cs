
namespace CourseProject_CISS_311
{
    partial class DisplayAllCoursesFrom
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
            this.allCoursesGridBox = new System.Windows.Forms.GroupBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.allCourseDataGridView = new System.Windows.Forms.DataGridView();
            this.courseProjectDBDataSet = new CourseProject_CISS_311.CourseProjectDBDataSet();
            this.courseProjectDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.coursesTableAdapter = new CourseProject_CISS_311.CourseProjectDBDataSetTableAdapters.coursesTableAdapter();
            this.courseIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseSemesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allCoursesGridBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allCourseDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseProjectDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseProjectDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // allCoursesGridBox
            // 
            this.allCoursesGridBox.Controls.Add(this.allCourseDataGridView);
            this.allCoursesGridBox.Location = new System.Drawing.Point(12, 12);
            this.allCoursesGridBox.Name = "allCoursesGridBox";
            this.allCoursesGridBox.Size = new System.Drawing.Size(776, 348);
            this.allCoursesGridBox.TabIndex = 0;
            this.allCoursesGridBox.TabStop = false;
            this.allCoursesGridBox.Text = "All Courses";
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(301, 366);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(191, 50);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Cl&ose";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // allCourseDataGridView
            // 
            this.allCourseDataGridView.AllowUserToAddRows = false;
            this.allCourseDataGridView.AllowUserToDeleteRows = false;
            this.allCourseDataGridView.AutoGenerateColumns = false;
            this.allCourseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allCourseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseIdDataGridViewTextBoxColumn,
            this.courseNameDataGridViewTextBoxColumn,
            this.courseSemesterDataGridViewTextBoxColumn});
            this.allCourseDataGridView.DataSource = this.bindingSource1;
            this.allCourseDataGridView.Location = new System.Drawing.Point(18, 19);
            this.allCourseDataGridView.Name = "allCourseDataGridView";
            this.allCourseDataGridView.ReadOnly = true;
            this.allCourseDataGridView.Size = new System.Drawing.Size(735, 306);
            this.allCourseDataGridView.TabIndex = 1;
            this.allCourseDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // courseProjectDBDataSet
            // 
            this.courseProjectDBDataSet.DataSetName = "CourseProjectDBDataSet";
            this.courseProjectDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseProjectDBDataSetBindingSource
            // 
            this.courseProjectDBDataSetBindingSource.DataSource = this.courseProjectDBDataSet;
            this.courseProjectDBDataSetBindingSource.Position = 0;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "courses";
            this.bindingSource1.DataSource = this.courseProjectDBDataSetBindingSource;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // courseIdDataGridViewTextBoxColumn
            // 
            this.courseIdDataGridViewTextBoxColumn.DataPropertyName = "courseId";
            this.courseIdDataGridViewTextBoxColumn.HeaderText = "courseId";
            this.courseIdDataGridViewTextBoxColumn.Name = "courseIdDataGridViewTextBoxColumn";
            this.courseIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseNameDataGridViewTextBoxColumn
            // 
            this.courseNameDataGridViewTextBoxColumn.DataPropertyName = "courseName";
            this.courseNameDataGridViewTextBoxColumn.HeaderText = "courseName";
            this.courseNameDataGridViewTextBoxColumn.Name = "courseNameDataGridViewTextBoxColumn";
            this.courseNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseSemesterDataGridViewTextBoxColumn
            // 
            this.courseSemesterDataGridViewTextBoxColumn.DataPropertyName = "courseSemester";
            this.courseSemesterDataGridViewTextBoxColumn.HeaderText = "courseSemester";
            this.courseSemesterDataGridViewTextBoxColumn.Name = "courseSemesterDataGridViewTextBoxColumn";
            this.courseSemesterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DisplayAllCoursesFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.allCoursesGridBox);
            this.Name = "DisplayAllCoursesFrom";
            this.Text = "DisplayAllCoursesFrom";
            this.Load += new System.EventHandler(this.DisplayAllCoursesFrom_Load);
            this.allCoursesGridBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.allCourseDataGridView)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.courseProjectDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseProjectDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox allCoursesGridBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.DataGridView allCourseDataGridView;

        private System.Windows.Forms.BindingSource courseProjectDBDataSetBindingSource;
        private CourseProjectDBDataSet courseProjectDBDataSet;
        private System.Windows.Forms.BindingSource bindingSource1;
        private CourseProjectDBDataSetTableAdapters.coursesTableAdapter coursesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseSemesterDataGridViewTextBoxColumn;
    }
}