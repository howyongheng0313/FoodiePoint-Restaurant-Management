using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reservation_Coordinator.Model.Item;

namespace Reservation_Coordinator.View
{
    public partial class frmMainTool : Form
    {
        private ItemUser user;

        public frmMainTool()
        {
            InitializeComponent();
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(new pgeWelcome());
        }

        public void SetUser(ItemUser user)
        {
            this.user = user;
            lblTitle.Text = $"Welcome, {this.user.FullName}";
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Owner Profile";
            pnlContent.Controls.Clear();
            var nextPage = new pgeProfile();
            nextPage.SetUser(user);
            pnlContent.Controls.Add(nextPage);
        }

        private void btnViewRev_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "View Reservations";
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(new pgeViewRev());
        }
    }
}
