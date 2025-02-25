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

            if (isForm1Open == false)
            {
                Form1 fm = new Form1();
                fm.Show();
            }
        }

        public void HallMgmt()
        {
            bool isForm2Open = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form is Form2)
                {
                    isForm2Open = true;
                    form.BringToFront();
                    break;
                }
            }
            if (isForm2Open == false)
            {            
                Form2 fm2 = new Form2();
                fm2.Show();
            }
        }

        public void Reservations()
        {
            bool isForm3Open = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form is Form3)
                {
                    isForm3Open = true;
                    form.BringToFront();
                    break;
                }
            }
            if (isForm3Open == false)
            {
                Form3 fm3 = new Form3();
                fm3.Show();
            }
        }
        public void Profile()
        {
            bool isForm4Open = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form is Form4)
                {
                    isForm4Open = true;
                    form.BringToFront();
                    break;
                }
            }
            if (isForm4Open == false)
            {
                Form4 fm4 = new Form4();
                fm4.Show();
            }
        }
    }
}
