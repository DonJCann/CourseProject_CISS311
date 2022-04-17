using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration; //needed to initialize configurationManager
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject_CISS_311
{
    public partial class DisplayStudentForm : Form
    {

        string connectionString;//declares string
        SqlConnection conn;//declares variable


        public DisplayStudentForm()
        {
            InitializeComponent();
            connectionString =
                ConfigurationManager.ConnectionStrings
                ["CourseProject_CISS_311.Properties.Settings.CourseProjectDBConnectionString"]
                .ConnectionString;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close(); // closes form
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))//setsup connection
            using (SqlDataAdapter adapter = new SqlDataAdapter
                ("SELECT * FROM student", conn))//passes conn to SqlDataAdapter

            {
                DataTable studentTable = new DataTable();//creates studentTable
                adapter.Fill(studentTable);//fills table with data
                studentListBox.DisplayMember = "studentName";//adds studentName to DisplayMember
                studentListBox.ValueMember = "studentId";//adds studentId to Value member
                studentListBox.DataSource = studentTable;//sets table to Datasource

            }

        }

        private void DisplayStudentForm_Load(object sender, EventArgs e)
        {
            /*
            using (conn = new SqlConnection(connectionString))//setsup connection
            using (SqlDataAdapter adapter = new SqlDataAdapter
                ("SELECT * FROM student", conn))//passes conn to SqlDataAdapter

            {
                DataTable studentTable = new DataTable();//creates studentTable
                adapter.Fill(studentTable);//fills table with data
                studentListBox.DisplayMember = "studentName";//adds studentName to DisplayMember
                studentListBox.ValueMember = "studentId";//adds studentId to Value member
                studentListBox.DataSource = studentTable;//sets table to Datasource
            */

        }
    }
}
