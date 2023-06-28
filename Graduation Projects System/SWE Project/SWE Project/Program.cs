using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWE_Project
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
            //mainform f1 = new mainform();
            //f1.Show();C:\Users\Vip B\Desktop\SWE Project\SWE Project\Program.cs
            Application.Run(new mainform());
        }
    }
}
