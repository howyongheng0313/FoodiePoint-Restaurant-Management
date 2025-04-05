using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Admin.Presenter;
using Reservation_Coordinator.Model;

namespace Admin.View
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text) ||
               string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string usrnm = txtUser.Text;
            string paswd = txtPassword.Text;
            LoginCredent user = LoginCredent.Login(usrnm, paswd);

            txtPassword.Text = string.Empty;
            if (user != null)
            {
                txtUser.Text = string.Empty;
                Form targetForm = null;
                string role = user.Role.ToLower().Trim();

                switch (role)
                {
                    case "administrator":
                        targetForm = new frmDashboard();
                        break;
                    case "manager":
                        targetForm = new Manager.Main_Menu();
                        break;
                    case "chef":
                        targetForm = new FoodiePointManagementSystem.frmChef();
                        break;
                    case "reservation coordinator":
                        targetForm = new Reservation_Coordinator.View.frmMainTool();
                        break;
                    case "customer":
                        targetForm = new Customer.frmCustomerMain();
                        break;
                }

                if (targetForm is UserForm userForm)
                {
                    userForm.SetUser(user);
                }
                Jumper.Dive(targetForm);
            }
            else
            {
                txtUser.Text = string.Empty;
                txtPassword.Text = string.Empty;
                MessageBox.Show("Invalid Username or Password.");
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            var signUpForm = new frmSignUp("Customer");
            Jumper.Dive(signUpForm);
            txtUser.Focus();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void picLogo_Click(object sender, EventArgs e)
        {

        }
    }
}