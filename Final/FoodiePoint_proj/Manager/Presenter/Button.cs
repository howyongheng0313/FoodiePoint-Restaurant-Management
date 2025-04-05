using Admin.Presenter;
using Reservation_Coordinator.Model;
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
        private LoginCredent _currentUser;

        public Button(LoginCredent user)
        {
            _currentUser = user;
        }

        public void MainMenu()
        {
            Main_Menu fm = new Main_Menu();
            fm.SetUser(_currentUser);
            Jumper.Shift(fm);
        }

        public void HallMgmt()
        {
            frmHall fm = new frmHall();
            fm.SetUser(_currentUser);
            Jumper.Shift(fm);
        }

        public void Reservations()
        {
            frmReservations fm = new frmReservations();
            fm.SetUser(_currentUser);
            Jumper.Shift(fm);
        }

        public void Profile()
        {
            Admin.View.frmUpdate fm = new Admin.View.frmUpdate();
            fm.SetUser(_currentUser);
            Jumper.Dive(fm);
        }

        public void EditMenu()
        {
            EditMenu fm = new EditMenu();
            fm.SetUser(_currentUser);
            Jumper.Shift(fm);
        }

        public void EditHall()
        {
            EditHalls fm = new EditHalls();
            fm.SetUser(_currentUser);
            Jumper.Shift(fm);
        }
    }
}
