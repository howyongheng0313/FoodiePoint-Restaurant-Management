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
                this.Hide();
                loginForm.ShowDialog();
            }
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            var managerForm = new frmModifyM();
            this.Hide();
            managerForm.FormClosed += (s, args) => this.Show();
            managerForm.ShowDialog();
        }
        private void btnRC_Click(object sender, EventArgs e)
        {
            var RCForm = new frmModifyRC();
            this.Hide();
            RCForm.FormClosed += (s, args) => this.Show();
            RCForm.ShowDialog();
        }

        private void btnChef_Click(object sender, EventArgs e)
        {
            var ChefForm = new frmModifyChef();
            this.Hide();
            ChefForm.FormClosed += (s, args) => this.Show();
            ChefForm.ShowDialog();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            var CForm = new frmModifyC();
            this.Hide();
            CForm.FormClosed += (s, args) => this.Show();
            CForm.ShowDialog();
        }
        private void btnFeedbacks_Click(object sender, EventArgs e)
        {
            var feedbackForm = new frmFeedbacks();
            this.Hide();
            feedbackForm.FormClosed += (s, args) => this.Show();
            feedbackForm.ShowDialog();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            var salesForm = new frmCheckSales();
            this.Hide();
            salesForm.FormClosed += (s, args) => this.Show();
            salesForm.ShowDialog();
        }
    }
}
