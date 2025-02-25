using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodieUI
{
    internal class Button
    {
        public void MainMenu()
        {
            bool isForm1Open = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form is Form1)
                {
                    isForm1Open = true;
                    form.BringToFront();
                    break;
                }
            }
            if (!isForm1Open)
            {
                Form1 fm = new Form1();
                fm.Show();
            }
        }

        public void HallMgmt()
        {
            Form2 fm2 = new Form2();
            fm2.Show();
        }
        public void Reservations()
        {
            Form3 fm3 = new Form3();
            fm3.Show();
        }
        public void Profile()
        {
            Form4 fm4 = new Form4();
            fm4.Show();
        }
    }
}
