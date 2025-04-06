using Admin.Presenter;
using Reservation_Coordinator.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodiePointManagementSystem
{
    public partial class frmChef : Form, UserForm
    {
        private LoginCredent _currentUser;

        public frmChef()
        {
            InitializeComponent();
        }

        public void SetUser(LoginCredent user)
        {
            _currentUser = user;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            frmOrderPage frmOrder = new frmOrderPage();
            frmOrder.SetUser(_currentUser);
            Jumper.Shift(frmOrder);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            frmInventory frmInventory = new frmInventory();
            frmInventory.SetUser(_currentUser);
            Jumper.Shift(frmInventory);
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            Admin.View.frmUpdate frmChefProfile = new Admin.View.frmUpdate();
            frmChefProfile.SetUser(_currentUser);
            Jumper.Dive(frmChefProfile);
        }
    }
}
