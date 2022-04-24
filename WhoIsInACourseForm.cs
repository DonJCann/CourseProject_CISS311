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
{
    public partial class WhoIsInACourseForm : Form
    {

        //establishes SQL connection
        string connectionString;
        SqlConnection conn;
        int courseId;

        public WhoIsInACourseForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings
                ["CourseProject_CISS_311.Properties.Settings.CourseProjectDBConnectionString"].ConnectionString;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();//closes form
        }



        private void WhoIsInACourseForm_Load(object sender, EventArgs e)
        {

        }

        private void studentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void findButton_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand(//SQL commands to SELECT based off courseId that matches
                "SELECT courses.courseId, courses.courseName, student.studentName FROM courses JOIN student ON courses.courseName = student.coursesEnrolled WHERE courseId = @courseId", conn))

            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                comd.Parameters.AddWithValue("@courseId", courseIdTextBox.Text);
                DataTable coursesTable = new DataTable();
                adapter.Fill(coursesTable);//fills course table from db
                if (coursesTable.Rows.Count < 1)//if statement for no record
                    courseTitleTextBox.Text = "No students found in course";
                else //else for the record found
                {

                    DataRow dr = coursesTable.Rows[0];//creates dr and assigns coursestable
                    courseId = int.Parse(dr["courseId"].ToString());//used to update courseId from update button
                    courseTitleTextBox.Text = dr["courseName"].ToString();//finds courseId from dr and assigns to currentTitleTextBox
                    studentListBox.Text = dr["studentName"].ToString();


                }
            }
        }
    }
}
