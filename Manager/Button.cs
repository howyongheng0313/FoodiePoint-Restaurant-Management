using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodieUI
{
    internal class Button
    {
        //public Size Size { get; private set; }

        //public void changeFormSize()
        //{
        //    MessageBox.Show(Size);
        //}


        public bool CheckFormOpen(string x)
        {
            string formNum = x;
            bool isFormOpen = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == formNum)
                {
                    isFormOpen = true;
                    form.BringToFront();
                    break;
                }
            }
            return isFormOpen;
        }

        public void MainMenu()
        {
            bool isFormOpen = CheckFormOpen("Main_Menu");
            if (isFormOpen == false)
            {
                Main_Menu fm = new Main_Menu();
                fm.Show();
            }
        }

        public void HallMgmt()
        {
            bool isFormOpen = CheckFormOpen("Form2");
            if (isFormOpen == false)
            {
                Form2 fm = new Form2();
                fm.Show();
            }
        }

        public void Reservations()
        {
            bool isFormOpen = CheckFormOpen("Form3");
            if (isFormOpen == false)
            {
                Form3 fm = new Form3();
                fm.Show();
            }
        }
        public void Profile()
        {
            bool isFormOpen = CheckFormOpen("Form4");
            if (isFormOpen == false)
            {
                Form4 fm = new Form4();
                fm.Show();
            }
        }
    }
}
