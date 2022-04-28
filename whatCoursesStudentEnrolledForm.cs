using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject_CISS_311
//Scrum Masters - Donavan Cann, Afaf Mahmood, Jorge Trejo, Dylan Taylor
//CISS 311 Advanced Agile Software Development 
//Course Project
//18-21-2022
{
    public partial class whatCoursesStudentEnrolledForm : Form
    {
        //following lines establish connection and declare sql variable
        string connectionString;
        SqlConnection conn;

        public whatCoursesStudentEnrolledForm()
        {
            InitializeComponent();
            //following line establish connection to course project database
            connectionString = ConfigurationManager.ConnectionStrings["CourseProject_CISS_311.Properties.Settings.CourseProjectDBConnectionString"].ConnectionString;
        }

        private void whatCoursesStudentEnrolledForm_Load(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter ("SELECT * FROM student", conn))
            {
                DataTable studentTable = new DataTable();
                adapter.Fill(studentTable);
                studentComboBox.DisplayMember = "studentName";
                studentComboBox.ValueMember = "studentId";
                studentComboBox.DataSource = studentTable;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //following line closes form
            Close();
        }

        private void studentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand ("SELECT coursesEnrolled FROM student " + "WHERE student.studentId = @studentId", conn ))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                comd.Parameters.AddWithValue("@studentId", studentComboBox.SelectedValue.ToString());
                DataTable studentTable = new DataTable();
                adapter.Fill(studentTable);
                enrolledCoursesListBox.DisplayMember = "coursesEnrolled";
                enrolledCoursesListBox.ValueMember = "studentId";
                enrolledCoursesListBox.DataSource = studentTable;
            }
        }
    }
}
