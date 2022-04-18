
using System;

namespace CourseProject_CISS_311
{
    partial class welcomeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.addCourseButton = new System.Windows.Forms.Button();
            this.displayStudentButton = new System.Windows.Forms.Button();
            this.displayCoursesButton = new System.Windows.Forms.Button();
            this.enrollStudentButton = new System.Windows.Forms.Button();
            this.whoIsInACourseButton = new System.Windows.Forms.Button();
            this.whatCoursesIsAStudentInButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(901, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Scrum Masters Course Tracking System";
            // 
            // addStudentButton
            // 
            this.addStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudentButton.Location = new System.Drawing.Point(211, 169);
            this.addStudentButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(321, 78);
            this.addStudentButton.TabIndex = 1;
            this.addStudentButton.Text = "Add A Student";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // addCourseButton
            // 
            this.addCourseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCourseButton.Location = new System.Drawing.Point(832, 169);
            this.addCourseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addCourseButton.Name = "addCourseButton";
            this.addCourseButton.Size = new System.Drawing.Size(303, 78);
            this.addCourseButton.TabIndex = 2;
            this.addCourseButton.Text = "Add A Course";
            this.addCourseButton.UseVisualStyleBackColor = true;
            this.addCourseButton.Click += new System.EventHandler(this.addCourseButton_Click);
            // 
            // displayStudentButton
            // 
            this.displayStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayStudentButton.Location = new System.Drawing.Point(211, 266);
            this.displayStudentButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.displayStudentButton.Name = "displayStudentButton";
            this.displayStudentButton.Size = new System.Drawing.Size(321, 90);
            this.displayStudentButton.TabIndex = 3;
            this.displayStudentButton.Text = "Display All Students";
            this.displayStudentButton.UseVisualStyleBackColor = true;
            this.displayStudentButton.Click += new System.EventHandler(this.displayStudentButton_Click);
            // 
            // displayCoursesButton
            // 
            this.displayCoursesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayCoursesButton.Location = new System.Drawing.Point(832, 266);
            this.displayCoursesButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.displayCoursesButton.Name = "displayCoursesButton";
            this.displayCoursesButton.Size = new System.Drawing.Size(303, 90);
            this.displayCoursesButton.TabIndex = 4;
            this.displayCoursesButton.Text = "Display All Courses";
            this.displayCoursesButton.UseVisualStyleBackColor = true;
            // 
            // enrollStudentButton
            // 
            this.enrollStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enrollStudentButton.Location = new System.Drawing.Point(211, 382);
            this.enrollStudentButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.enrollStudentButton.Name = "enrollStudentButton";
            this.enrollStudentButton.Size = new System.Drawing.Size(321, 87);
            this.enrollStudentButton.TabIndex = 5;
            this.enrollStudentButton.Text = "Enroll A Student In A Course";
            this.enrollStudentButton.UseVisualStyleBackColor = true;
            // 
            // whoIsInACourseButton
            // 
            this.whoIsInACourseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whoIsInACourseButton.Location = new System.Drawing.Point(832, 382);
            this.whoIsInACourseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.whoIsInACourseButton.Name = "whoIsInACourseButton";
            this.whoIsInACourseButton.Size = new System.Drawing.Size(303, 87);
            this.whoIsInACourseButton.TabIndex = 6;
            this.whoIsInACourseButton.Text = "Who Is In A Course";
            this.whoIsInACourseButton.UseVisualStyleBackColor = true;
            // 
            // whatCoursesIsAStudentInButton
            // 
            this.whatCoursesIsAStudentInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whatCoursesIsAStudentInButton.Location = new System.Drawing.Point(211, 489);
            this.whatCoursesIsAStudentInButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.whatCoursesIsAStudentInButton.Name = "whatCoursesIsAStudentInButton";
            this.whatCoursesIsAStudentInButton.Size = new System.Drawing.Size(321, 92);
            this.whatCoursesIsAStudentInButton.TabIndex = 7;
            this.whatCoursesIsAStudentInButton.Text = "What Courses A Student Enrolled In";
            this.whatCoursesIsAStudentInButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(832, 502);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(303, 79);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // welcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 700);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.whatCoursesIsAStudentInButton);
            this.Controls.Add(this.whoIsInACourseButton);
            this.Controls.Add(this.enrollStudentButton);
            this.Controls.Add(this.displayCoursesButton);
            this.Controls.Add(this.displayStudentButton);
            this.Controls.Add(this.addCourseButton);
            this.Controls.Add(this.addStudentButton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "welcomeForm";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.welcomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void welcomeForm_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.Button addCourseButton;
        private System.Windows.Forms.Button displayStudentButton;
        private System.Windows.Forms.Button displayCoursesButton;
        private System.Windows.Forms.Button enrollStudentButton;
        private System.Windows.Forms.Button whoIsInACourseButton;
        private System.Windows.Forms.Button whatCoursesIsAStudentInButton;
        private System.Windows.Forms.Button exitButton;
    }
}

