using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reservation_Coordinator.Model;
using Reservation_Coordinator.Model.Item;

namespace Reservation_Coordinator.View
{
    public partial class frmLogin: Form
    {
        public frmLogin()
        {
            InitializeComponent();
            Jumper.Look(this);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usrnm = txtUsername.Text;
            string paswd = txtPassword.Text;
            ItemUser user = ItemUser.Login(usrnm, paswd);
            if (user != null)
            {
                var mainPage = new frmMainTool();
                mainPage.SetUser(user);
                Jumper.Dive(mainPage);
            }
            else
            {
                txtPassword.Text = string.Empty;
                MessageBox.Show("Invalid Username/Password.");
            }
        }
    }
}
