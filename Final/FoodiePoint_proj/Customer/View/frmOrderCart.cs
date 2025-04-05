using Admin.Presenter;
using Customer.Presenter;
using FoodiePointManagementSystem.Presenter;
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
            if (_currentUser == null)
            {
                MessageBox.Show("Please login before ordering.", "Login Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Create the order first
                string orderID = OrderFood.CreateOrder(_currentUser.UserID);

                if (orderID != null)
                {
                    // Add each item to the order
                    int result = OrderFood.AddOrderItems(dgv.Rows, orderID);
                    if (result == -1)
                    {
                        MessageBox.Show("Error adding items to order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    MessageBox.Show("Order placed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error placing order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.SelectedRows.Count > 0)
                {
                    // Get the food price and quantity before removing
                    decimal price = Convert.ToDecimal(dgv.SelectedRows[0].Cells["FoodPrice"].Value);
                    int qty = Convert.ToInt32(dgv.SelectedRows[0].Cells["Quantity"].Value);

                    // Remove the row
                    OrderFood.dlt_rowitem(dgv);

                    // Update the total
                    total -= price * qty;
                    label1.Text = $"Total Price: " + total.ToString();
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting item: " + ex.Message);
            }
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