using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer
{
    public partial class frmCustomerMain: Form
    {
        public frmCustomerMain()
        {
            InitializeComponent();
        }

        private void btnCustomerToMenu_Click(object sender, EventArgs e)
        {
            frmMenuPage obj1 = new frmMenuPage();
            obj1.Show();
            this.Hide();
        }

        private void btnCustomerToHallReservation_Click(object sender, EventArgs e)
        {
            frmHallReservation obj1 = new frmHallReservation();
            obj1.Show();
            this.Hide();
        }

        private void frmCustomerMain_Load(object sender, EventArgs e)
        {

        }
    }
}
