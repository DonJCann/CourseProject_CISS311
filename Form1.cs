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
{
    public partial class welcomeForm : Form
    {
        //following lines declare sql variable
        string connectionString;
        SqlConnection conn;
        public welcomeForm()
        {
            InitializeComponent();
            //following line establish connection to course project database
            connectionString = ConfigurationManager.ConnectionStrings["CourseProject_CISS_311.Properties.Settings.CourseProjectDBConnectionString"].ConnectionString;
        }

        private void addStudentButton_Click(object sender, EventArgs e)
            //following lines open the add student form when the add stduent button is clicked
        {
            AddStudentForm addStudentForm = new AddStudentForm();
            addStudentForm.ShowDialog();
        }
    }
}
