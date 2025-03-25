using Customer.Presenter;
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
    public partial class frmOrderCart : Form
    {
        private decimal total = 0;
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

        public frmOrderCart()
        {
            InitializeComponent();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            OrderFood.pay_food(dgv);
            frmPayment obj1 = new frmPayment();
            obj1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmHallReservation obj1 = new frmHallReservation();
            obj1.Show();
            this.Hide();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            frmCustomerMain obj1 = new frmCustomerMain();
            obj1.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void frmOrderCart_Load(object sender, EventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            total -= OrderFood.dlt_oneitem(dgv);
            label1.Text = $"Total Price: " + total.ToString();
        }

        private void lbltotal_Click(object sender, EventArgs e)
        {


        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
