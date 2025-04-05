using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Admin.Presenter;
using Reservation_Coordinator.Model;

namespace Admin.View
{
    public partial class frmDashboard : Form, UserForm
    {
        private LoginCredent _currentUser;

        public frmDashboard()
        {
            InitializeComponent();
        }

        public void SetUser(LoginCredent user)
        {
            _currentUser = user;
            lblWelcome.Text = $"Welcome, {_currentUser.FullName}!";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var updateForm = new frmUpdate();
            updateForm.SetUser(_currentUser);
            updateForm.UserUpdated += UpdateForm_UserUpdated;
            Jumper.Dive(updateForm);
        }

        private void UpdateForm_UserUpdated(object sender, LoginCredent updatedUser)
        {
            _currentUser = updatedUser;
            lblWelcome.Text = $"Welcome, {_currentUser.FullName}!";
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?","Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            var managerForm = new frmModifyM();
            Jumper.Dive(managerForm);
        }
        private void btnRC_Click(object sender, EventArgs e)
        {
            var RCForm = new frmModifyRC();
            Jumper.Dive(RCForm);
        }

        private void btnChef_Click(object sender, EventArgs e)
        {
            var ChefForm = new frmModifyChef();
            Jumper.Dive(ChefForm);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            var CForm = new frmModifyC();
            Jumper.Dive(CForm);
        }
        private void btnFeedbacks_Click(object sender, EventArgs e)
        {
            var feedbackForm = new frmFeedbacks();
            Jumper.Dive(feedbackForm);
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            var salesForm = new frmCheckSales();
            Jumper.Dive(salesForm);
        }
    }
}
