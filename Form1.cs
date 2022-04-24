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
//Scrum Masters - Donavan Cann, Afaf Mahmood, Jorge Trejo, Dylan Taylor
//CISS 311 Advanced Agile Software Development 
//18-04-2022
//Course Project
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

        private void displayStudentButton_Click(object sender, EventArgs e)
        {
            //display all students form
            DisplayStudentForm displayStudentForm = new DisplayStudentForm();
            displayStudentForm.ShowDialog();
        }

        private void addCourseButton_Click(object sender, EventArgs e)
        {
            // Opens the add course form when the add course button is clicked 
            AddCourseForm addCourseForm = new AddCourseForm();
            addCourseForm.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //following line closes main form
            Close();
        }

        private void displayCoursesButton_Click(object sender, EventArgs e)
        {
            //following lines open display all courses form
            DisplayAllCoursesFrom displayAllCoursesForm = new DisplayAllCoursesFrom();
            displayAllCoursesForm.ShowDialog();
        }

        private void whatCoursesIsAStudentInButton_Click(object sender, EventArgs e)
        {
            //following lines open what courses a student is enrolled in form
            whatCoursesStudentEnrolledForm whatCoursesStudentEnrolledForm = new whatCoursesStudentEnrolledForm();
            whatCoursesStudentEnrolledForm.ShowDialog();
        }
    }
}
