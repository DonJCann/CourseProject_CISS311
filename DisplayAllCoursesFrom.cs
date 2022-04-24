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
    //04-20-2022
{
    public partial class DisplayAllCoursesFrom : Form
    {
        //follwing lines establish connections and make sql declaration 
        string connectionString;
        BindingSource coursesBindingSource = new BindingSource();
        SqlDataAdapter adapter;

        public DisplayAllCoursesFrom()
        {
            InitializeComponent();
            //following line establishes connection to course project database
            connectionString = ConfigurationManager.ConnectionStrings["CourseProject_CISS_311.Properties.Settings.CourseProjectDBConnectionString"].ConnectionString;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DisplayAllCoursesFrom_Load(object sender, EventArgs e)
        {
            // following lines pull data from database to fill the display grid on the form
            this.coursesTableAdapter.Fill(this.courseProjectDBDataSet.courses);
            allCourseDataGridView.DataSource = coursesBindingSource;
            adapter = new SqlDataAdapter("SELECT * FROM courses", connectionString);
            SqlCommandBuilder comdBuilder = new SqlCommandBuilder(adapter);
            DataTable coursesTable = new DataTable();
            adapter.Fill(coursesTable);
            coursesBindingSource.DataSource = coursesTable;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //following line closes display all courses form
            Close();
        }
    }
}
