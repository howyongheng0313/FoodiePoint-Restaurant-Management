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
    public partial class frmChefProfile : Form
    {
        public frmChefProfile()
        {
            InitializeComponent();
        }

        private void frmChefProfile_Load(object sender, EventArgs e)
        {

        }

        private void btnProfileToChef_Click(object sender, EventArgs e)
        {
            frmChef frmChef = new frmChef();
            frmChef.Show();
            this.Hide();
        }

        private void btnProfileToOrder_Click(object sender, EventArgs e)
        {
            frmOrderPage frmOrder = new frmOrderPage();
            frmOrder.Show();
            this.Hide();
        }

        private void btnProfileToInventory_Click(object sender, EventArgs e)
        {
            frmInventory frmInventory = new frmInventory();
            frmInventory.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
