using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject_CISS_311
{
    public partial class EnrollAStudentForm : Form
    {
        string connectionString;//declares string
        SqlConnection conn;//declares variable

        public EnrollAStudentForm()
        {
            InitializeComponent();
            //following line establish connection to course project database
            connectionString = ConfigurationManager.ConnectionStrings["CourseProject_CISS_311.Properties.Settings.CourseProjectDBConnectionString"].ConnectionString;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //following line closes form
            Close();
        }

        private void selectAStudentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EnrollAStudentForm_Load(object sender, EventArgs e)
        {

            using (conn = new SqlConnection(connectionString))//setsup connection
            using (SqlDataAdapter adapter = new SqlDataAdapter
                ("SELECT student.studentName FROM student", conn))//passes conn to SqlDataAdapter

            {
                DataTable studentTable = new DataTable();//creates studentTable
                adapter.Fill(studentTable);//fills table with data

                selectAStudentComboBox.DisplayMember = "studentName";//adds studentName to DisplayMember
                selectAStudentComboBox.ValueMember = "studentId";//adds studentId to Value member
                selectAStudentComboBox.DataSource = studentTable;//sets table to Datasource


            }

            using (conn = new SqlConnection(connectionString))//setsup connection
            using (SqlDataAdapter adapter = new SqlDataAdapter
                ("SELECT courses.courseName FROM courses", conn))//passes conn to SqlDataAdapter

            {
                DataTable courseTable = new DataTable();//creates courseTable
                adapter.Fill(courseTable);//fills table with data

                selectACourseComboBox.DisplayMember = "courseName";//adds courseName to DisplayMember
                selectACourseComboBox.ValueMember = "courseId";//adds courseId to Value member
                selectACourseComboBox.DataSource = courseTable;//sets table to Datasource


            }
        }
    }
}
