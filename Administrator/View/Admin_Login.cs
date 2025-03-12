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
using Customers;

namespace Admin
{
    public partial class frmLogin : Form
    {
        LoginCredent login = new LoginCredent();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblAdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void linklblForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            {
                //new SignUpForm().Show();
                this.Hide();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text.Trim();
            string password = txtPassword.Text;
            login.GetUserType(username);
            login.RetrievePassword(password,username);
        }


    }
}
