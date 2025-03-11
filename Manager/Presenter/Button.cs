using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager
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

            foreach (System.Windows.Forms.Form form in Application.OpenForms)
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
            bool isFormOpen = CheckFormOpen("frmHall");
            if (isFormOpen == false)
            {
                frmHall fm = new frmHall();
                fm.Show();
            }
        }

        public void Reservations()
        {
            bool isFormOpen = CheckFormOpen("frmReservations");
            if (isFormOpen == false)
            {
                frmReservations fm = new frmReservations();
                fm.Show();
            }
        }
        public void EditReservations()
        {
            bool isFormOpen = CheckFormOpen("frmReservation");
            if (isFormOpen == false)
            {
                frmReservation fm = new frmReservation();
                fm.Show();
            }
        }
        public void Profile()
        {
            bool isFormOpen = CheckFormOpen("Form4");
            if (isFormOpen == false)
            {
                frmProfile fm = new frmProfile();
                fm.Show();
            }
        }

        public void EditMenu()
        {
            bool isFormOpen = CheckFormOpen("EditMenu");
            if (isFormOpen == false)
            {
                EditMenu fm = new EditMenu();
                fm.Show();
            }
        }

        public void EditHall()
        {
            bool isFormOpen = CheckFormOpen("EditHalls");
            if (isFormOpen == false)
            {
                EditHalls fm = new EditHalls();
                fm.Show();
            }
        }

    }
}
