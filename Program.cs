using AS200_RobotDenso_Control;
using System;
using System.Windows.Forms;
using WindowsFormsApp4;
using SampleApplication;

namespace SampleApplication
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
           // Application.Run(new MainForm());
            Application.Run(MyLib.form1);


        }
    }
}
