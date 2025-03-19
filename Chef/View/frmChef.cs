using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodiePointManagementSystem
{
    public partial class frmChef : Form
    {
        public frmChef()
        {
            InitializeComponent();
        }

        private void frmChef_Load(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            frmOrderPage frmOrder = new frmOrderPage();
            frmOrder.Show();
            this.Hide();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            frmInventory frmInventory = new frmInventory();
            frmInventory.Show();
            this.Hide();
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            frmChefProfile frmChefProfile = new frmChefProfile();
            frmChefProfile.Show();
            this.Hide();
        }
    }
}
