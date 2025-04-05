using Reservation_Coordinator.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodiePoint_proj
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string gitRoot = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\.."));
            AppDomain.CurrentDomain.SetData("DataDirectory", gitRoot);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var mainPage = new Admin.View.frmLogin();
            Jumper.Look(mainPage);
            Application.Run(mainPage);
        }
    }
}
