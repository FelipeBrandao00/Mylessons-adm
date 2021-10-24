using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MyLessons
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
            frmLogin f1 = new frmLogin();
            f1.Show();
            Application.Run();
        }
    }
}
