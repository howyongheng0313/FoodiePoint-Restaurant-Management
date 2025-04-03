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
            updateForm.ShowDialog();
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
                var loginForm = new frmLogin();
                loginForm.ShowDialog();
                this.Close();
            }
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            var managerForm = new frmModifyM();
            managerForm.ShowDialog();
        }
        private void btnRC_Click(object sender, EventArgs e)
        {
            var RCForm = new frmModifyRC();
            RCForm.ShowDialog();
        }

        private void btnChef_Click(object sender, EventArgs e)
        {
            var ChefForm = new frmModifyChef();
            ChefForm.ShowDialog();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            var CForm = new frmModifyC();
            CForm.ShowDialog();
        }
    }
}
