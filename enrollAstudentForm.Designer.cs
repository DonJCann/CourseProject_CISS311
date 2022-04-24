namespace CourseProject_CISS_311
{
    partial class EnrollAStudentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.selectAStudentComboBox = new System.Windows.Forms.ComboBox();
            this.selectACourseComboBox = new System.Windows.Forms.ComboBox();
            this.enrollButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.closeButton);
            this.groupBox1.Controls.Add(this.enrollButton);
            this.groupBox1.Controls.Add(this.selectACourseComboBox);
            this.groupBox1.Controls.Add(this.selectAStudentComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 337);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enrollment Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select A Student:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select A course:";
            // 
            // selectAStudentComboBox
            // 
            this.selectAStudentComboBox.FormattingEnabled = true;
            this.selectAStudentComboBox.Location = new System.Drawing.Point(211, 59);
            this.selectAStudentComboBox.Name = "selectAStudentComboBox";
            this.selectAStudentComboBox.Size = new System.Drawing.Size(270, 33);
            this.selectAStudentComboBox.TabIndex = 2;
            // 
            // selectACourseComboBox
            // 
            this.selectACourseComboBox.FormattingEnabled = true;
            this.selectACourseComboBox.Location = new System.Drawing.Point(211, 168);
            this.selectACourseComboBox.Name = "selectACourseComboBox";
            this.selectACourseComboBox.Size = new System.Drawing.Size(270, 33);
            this.selectACourseComboBox.TabIndex = 3;
            // 
            // enrollButton
            // 
            this.enrollButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enrollButton.Location = new System.Drawing.Point(56, 262);
            this.enrollButton.Name = "enrollButton";
            this.enrollButton.Size = new System.Drawing.Size(102, 39);
            this.enrollButton.TabIndex = 4;
            this.enrollButton.Text = "&Enroll";
            this.enrollButton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(381, 262);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(100, 39);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // EnrollAStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 378);
            this.Controls.Add(this.groupBox1);
            this.Name = "EnrollAStudentForm";
            this.Text = "Enroll A Student A Course";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button enrollButton;
        private System.Windows.Forms.ComboBox selectACourseComboBox;
        private System.Windows.Forms.ComboBox selectAStudentComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}