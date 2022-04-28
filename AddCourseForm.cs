using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CourseProject_CISS_311
{
    public partial class AddCourseForm : Form
    {
        // String variable at the class level so that all methods in the class can use it

        string connectionString;

        // A SqlConnection variable called conn declared which will be used in several methods of the class

        SqlConnection conn;
        public AddCourseForm()
        {
            InitializeComponent();

            // To assign a value to the variable declared

            connectionString =
                ConfigurationManager.ConnectionStrings
                ["CourseProject_CISS_311.Properties.Settings.CourseProjectDBConnectionString"]
                .ConnectionString;
        }


        private void addCourse_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand

            // SQL INSERT statement issued 
            ("INSERT INTO courses (courseId, courseName, courseSemester)" +
            "VALUES (@courseId, @courseName, @courseSemester)", conn))
            {
                // Connection opened because SqlDataAdapter is not used this time
                conn.Open();
                comd.Parameters.AddWithValue("@courseId",
                    courseIdTextBox.Text);
                comd.Parameters.AddWithValue("@courseName",
                    courseNameTextBox.Text);
                comd.Parameters.AddWithValue("@courseSemester",
                    semesterComboBox.SelectedValue);
                comd.ExecuteScalar();//performs insert
                //Displays that the course has been added
                MessageBox.Show("Course Added.");
            }
        }


        private void closeButton_Click_1(object sender, EventArgs e)
        {
            //following lines close form
            Close();
        }

        private void courseSemesterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddCourseForm_Load(object sender, EventArgs e)
        {
            /*
            using (conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM courses", conn))
            {
                DataTable coursesTable = new DataTable();
                adapter.Fill(coursesTable);
                semesterComboBox.DisplayMember = "courseSemester";
                semesterComboBox.ValueMember = "courseId";
                semesterComboBox.DataSource = coursesTable;
            }*/
            Dictionary<string, string> dict = new Dictionary<string, string>()
            {
                 {"Fall ","Fall" },
                 {"Winter  ","Winter" },
                 {"Spring  ","Spring " },
                {"Summer  ","Summer " }
            };

                  semesterComboBox.DataSource = new BindingSource(dict, null);
                  semesterComboBox.DisplayMember = "Key";
                  semesterComboBox.ValueMember = "Value";
        }
    }
}
   
