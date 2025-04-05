using Admin.Presenter;
using Customer.Presenter;
using Reservation_Coordinator.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer
{
    public partial class frmOrderCart : Form, UserForm
    {
        private decimal total = 0;
        private LoginCredent _currentUser;

        public frmOrderCart(List<OrderFood> selectedRows)
        {
            InitializeComponent();

            dgv.ColumnCount = 5;
            dgv.Columns[0].Name = "FoodID";
            dgv.Columns[1].Name = "FoodName";
            dgv.Columns[2].Name = "FoodPrice";
            dgv.Columns[3].Name = "Food Category";
            dgv.Columns[4].Name = "Quantity";
            foreach (OrderFood row in selectedRows)
            {
                dgv.Rows.Add(row.ID ,row.FoodName, row.FoodPrice, row.Catagory, row.Quantity);
                total += row.FoodPrice * row.Quantity;
            }
            label1.Text = $"Total Price: " + total.ToString();
        }

        public void SetUser(LoginCredent user)
        {
            _currentUser = user;
        }

        public frmOrderCart()
        {
            InitializeComponent();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            OrderFood.pay_food(dgv);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            OrderFood.dlt_rowitem(dgv);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            total += OrderFood.add_oneitem(dgv);
            label1.Text = $"Total Price: " + total.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            total -= OrderFood.dlt_oneitem(dgv);
            label1.Text = $"Total Price: " + total.ToString();
        }
    }
}
