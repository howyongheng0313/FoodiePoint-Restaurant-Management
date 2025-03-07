using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservation_Coordinator.View
{
    public partial class frmMainTool : Form
    {
        public frmMainTool()
        {
            InitializeComponent();
        }
        private void btnViewRev_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "View Reservations";
            pnlContent.Controls.Add(new pgeViewRev());
        }
    }
}
