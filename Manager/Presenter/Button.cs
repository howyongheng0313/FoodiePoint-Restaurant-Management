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
        //public bool CheckFormOpen(string x)
        //{
        //    string formNum = x;
        //    bool isFormOpen = false;

        //    foreach (System.Windows.Forms.Form form in Application.OpenForms)
        //    {
        //        if (form.Name == formNum)
        //        {
        //            isFormOpen = true;
        //            form.BringToFront();
        //            break;
        //        }
        //    }
        //    return isFormOpen;
        //}

        public void MainMenu()
        {
            Main_Menu fm = new Main_Menu();
            fm.Show();
        }

        public void HallMgmt()
        {
                frmHall fm = new frmHall();
                fm.Show();
        }

        public void Reservations()
        {
                frmReservations fm = new frmReservations();
                fm.Show();
        }
        public void EditReservations()
        {
                frmReservation fm = new frmReservation();
                fm.Show();
        }
        public void Profile()
        {
                frmProfile fm = new frmProfile();
                fm.Show();
        }

        public void EditMenu()
        {
                EditMenu fm = new EditMenu();
                fm.Show();

        }

        public void EditHall()
        {
                EditHalls fm = new EditHalls();
                fm.Show();
        }

    }
}
