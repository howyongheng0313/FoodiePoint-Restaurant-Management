using Admin.Presenter;
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
        private LoginCredent _currentUser;

        public Button(LoginCredent user)
        {
            _currentUser = user;
        }

        public void MainMenu()
        {
            Main_Menu fm = new Main_Menu();
            fm.SetUser(_currentUser);
            fm.Show();
        }

        public void HallMgmt()
        {
            frmHall fm = new frmHall();
            fm.SetUser(_currentUser);
            fm.Show();
        }

        public void Reservations()
        {
            frmReservations fm = new frmReservations();
            fm.SetUser(_currentUser);
            fm.Show();
        }
        public void EditReservations()
        {
            frmReservation fm = new frmReservation();
            fm.SetUser(_currentUser);
            fm.Show();
        }
        public void Profile()
        {
            Admin.View.frmUpdate fm = new Admin.View.frmUpdate();
            fm.SetUser(_currentUser);
            fm.Show();
        }

        public void EditMenu()
        {
            EditMenu fm = new EditMenu();
            fm.SetUser(_currentUser);
            fm.Show();

        }

        public void EditHall()
        {
            EditHalls fm = new EditHalls();
            fm.SetUser(_currentUser);
            fm.Show();
        }
    }
}
