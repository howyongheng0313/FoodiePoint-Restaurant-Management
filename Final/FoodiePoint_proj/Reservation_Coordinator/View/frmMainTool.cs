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
using Reservation_Coordinator.Model.Item;

namespace Reservation_Coordinator.View
{
    public partial class frmMainTool : Form, UserForm
    {
        private LoginCredent _currentUser;

        public frmMainTool()
        {
            InitializeComponent();
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(new pgeWelcome());
        }

        public void SetUser(LoginCredent user)
        {
            _currentUser = user;
            lblTitle.Text = $"Welcome, {_currentUser.FullName}";
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            var nextPage = new Admin.View.frmUpdate();
            nextPage.SetUser(_currentUser);
            Jumper.Dive(nextPage);
            this.SetUser(_currentUser);
        }

        private void btnViewRev_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "View Reservations";
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(new pgeViewRev());
        }
    }
}
