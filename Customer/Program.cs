using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace new_customer
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

            Form3 cartForm = new Form3();
            Form2 form2 = new Form2(cartForm);
            form2.Show();
            cartForm.Show();

            Application.Run(new Form1());
        }
    }
}
