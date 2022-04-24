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
    public partial class DisplayStudentForm : Form
    {

        //follwing lines establish connections and make sql declaration 
        string connectionString;
        BindingSource coursesBindingSource = new BindingSource();
        SqlDataAdapter adapter;


        public DisplayStudentForm()
        {
            InitializeComponent();
            connectionString =
                ConfigurationManager.ConnectionStrings
                ["CourseProject_CISS_311.Properties.Settings.CourseProjectDBConnectionString"]
                .ConnectionString;
        }




        private void DisplayStudentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'courseProjectDBDataSet.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.courseProjectDBDataSet.student);

            // following lines pull data from database to fill the display grid on the form
            this.studentTableAdapter.Fill(this.courseProjectDBDataSet.student);
            allStudentsDataGridView.DataSource = studentBindingSource;
            adapter = new SqlDataAdapter("SELECT * FROM courses", connectionString);
            SqlCommandBuilder comdBuilder = new SqlCommandBuilder(adapter);
            DataTable studentTable = new DataTable();
            adapter.Fill(studentTable);
            studentBindingSource.DataSource = studentTable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DisplayStudentForm_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'courseProjectDBDataSet1.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter1.Fill(this.courseProjectDBDataSet1.student);

        }

        private void button_Click(object sender, EventArgs e)
        {
            Close(); // closes form
        }
    }
}
