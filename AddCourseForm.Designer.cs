
namespace CourseProject_CISS_311
{
    partial class AddCourseForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.semesterComboBox = new System.Windows.Forms.ComboBox();
            this.courseIdTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.courseNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addCourse = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.semesterComboBox);
            this.groupBox1.Controls.Add(this.courseIdTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.courseNameTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(160, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(396, 219);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Course Data";
            // 
            // semesterComboBox
            // 
            this.semesterComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semesterComboBox.FormattingEnabled = true;
            this.semesterComboBox.Location = new System.Drawing.Point(258, 151);
            this.semesterComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.semesterComboBox.Name = "semesterComboBox";
            this.semesterComboBox.Size = new System.Drawing.Size(108, 37);
            this.semesterComboBox.TabIndex = 3;
            // 
            // courseIdTextBox
            // 
            this.courseIdTextBox.Location = new System.Drawing.Point(258, 50);
            this.courseIdTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.courseIdTextBox.Name = "courseIdTextBox";
            this.courseIdTextBox.Size = new System.Drawing.Size(108, 22);
            this.courseIdTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Course Id:";
            // 
            // courseNameTextBox
            // 
            this.courseNameTextBox.Location = new System.Drawing.Point(258, 96);
            this.courseNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.courseNameTextBox.Name = "courseNameTextBox";
            this.courseNameTextBox.Size = new System.Drawing.Size(108, 22);
            this.courseNameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Course Semester:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course Name:";
            // 
            // addCourse
            // 
            this.addCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCourse.Location = new System.Drawing.Point(187, 318);
            this.addCourse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addCourse.Name = "addCourse";
            this.addCourse.Size = new System.Drawing.Size(170, 46);
            this.addCourse.TabIndex = 4;
            this.addCourse.Text = "&Add Course";
            this.addCourse.UseVisualStyleBackColor = true;
            this.addCourse.Click += new System.EventHandler(this.addCourse_Click);
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(418, 319);
            this.closeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(124, 45);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Cl&ose";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click_1);
            // 
            // AddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addCourse);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddCourseForm";
            this.Text = "AddCourseForm";
            this.Load += new System.EventHandler(this.AddCourseForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox courseNameTextBox;
        private System.Windows.Forms.Button addCourse;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TextBox courseIdTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox semesterComboBox;
    }
}