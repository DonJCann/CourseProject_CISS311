using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject_CISS_311
//Scrum Masters - Donavan Cann, Afaf Mahmood, Jorge Trejo, Dylan Taylor
//CISS 311 Advanced Agile Software Development 
//18-04-2022
//Course Project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new welcomeForm());
        }
    }
}
// Push / Pull Test 
