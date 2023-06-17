using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           //Application.Run(new D_Page());
            //Application.Run(new Form1());
            //Application.Run(new OTP_Code());

            //Application.Run(new D_Form3());
            Application.Run(new Staff_Page());
        }
    }
}
