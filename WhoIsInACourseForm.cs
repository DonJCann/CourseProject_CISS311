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

        private void courseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void WhoIsInACourseForm_Load(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM courses", conn))
            {
                DataTable courseTable = new DataTable();
                adapter.Fill(courseTable);
                courseComboBox.DisplayMember = "courseName";
                courseComboBox.ValueMember = "courseId";
                courseComboBox.DataSource = courseTable;
            }
        }

        private void studentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT  * FROM student JOIN courses ON student.studentId = courses.studentId", conn))
            {
                DataTable courseTable = new DataTable();
                adapter.Fill(courseTable);
                studentListBox.DisplayMember = "studentName";
                studentListBox.ValueMember = "studentId";
                studentListBox.DataSource = courseTable;
            }
        }
    }
}
