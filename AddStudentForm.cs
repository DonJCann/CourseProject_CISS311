using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject_CISS_311
    //Scrum Masters - Donavan Cann, Afaf Mahmood, Jorge Trejo, Dylan Taylor
    //CISS 311 Advanced Agile Software Development 
    //18-04-2022
    //Course Project
{
    public partial class AddStudentForm : Form
    {
        //following lines declare sql variable
        string connectionString;
        SqlConnection conn;
        public AddStudentForm()
        {
            InitializeComponent();
            //following line establishes connection to course project database
            connectionString = ConfigurationManager.ConnectionStrings["CourseProject_CISS_311.Properties.Settings.CourseProjectDBConnectionString"].ConnectionString;
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //following line closes the add student form
            Close();
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            //following lines establish a connection to the database to insert values from the add student form
                using (conn = new SqlConnection(connectionString))
                using(SqlCommand comd = new SqlCommand 
                ("INSERT INTO student (studentName, studentId) " +
                "VALUES (@studentName, @studentId)", conn))
            {
                conn.Open();//opens connection
                comd.Parameters.AddWithValue("@studentName", 
                    studentNameTextBox.Text);//assigns value of textbox to @studentName
                comd.Parameters.AddWithValue("@studentId", 
                    studentIdTextBox.Text);//assigns value of textbox to @studentId
                //following lines confirm a student has been successfully added to database by displaying messages in a message box and on the status strip
                comd.ExecuteScalar();//performs insert
                MessageBox.Show("Student Added.");
                feedbackToolStripStatusLabel.Text = "The student has been added to the database!";
            }
        }
    }
}
