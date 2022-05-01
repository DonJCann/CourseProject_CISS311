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
            if (courseIdTextBox.Text == "") // if/else for empty textbox detection
            {
                string myStringVariable1 = string.Empty;
                MessageBox.Show("Course ID is required");
            }
            else if (courseNameTextBox.Text == "")
            {
                string myStringVariable2 = string.Empty;
                MessageBox.Show("Course Name is required");
            }
            else
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
                        courseIdTextBox.Text);//sets @courseId to textbox
                    comd.Parameters.AddWithValue("@courseName",
                        courseNameTextBox.Text);//sets @courseName to textbox
                    comd.Parameters.AddWithValue("@courseSemester",
                        semesterComboBox.SelectedValue);//sets @courseSemester to combobox
                    comd.ExecuteScalar();//performs insert
                                         //Displays that the course has been added
                    MessageBox.Show("Course Added.");
                }
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

            Dictionary<string, string> dict = new Dictionary<string, string>()//creates dictionary string
            {
                 {"Fall ","Fall" }, //Tkey,Tvalue
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
   
