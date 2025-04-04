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
using FoodiePointManagementSystem.Presenter;

namespace FoodiePointManagementSystem
{
    public partial class frmOrderPage : Form, UserForm
    {
        private OrderService orderService;
        private LoginCredent _currentUser;

        public frmOrderPage()
        {
            InitializeComponent();
            orderService = new OrderService();
        }

        public void SetUser(LoginCredent user)
        {
            _currentUser = user;
        }

        // Load order form
        private void frmOrder_Load(object sender, EventArgs e)
        {
            btnReturnOrder.Visible = false;

            dgvOrders.AutoGenerateColumns = false;
            dgvOrders.Columns.Clear();

            dgvOrders.Columns.Add("OrderID", "Order ID");
            dgvOrders.Columns["OrderID"].DataPropertyName = "OrderID";

            dgvOrders.Columns.Add("UserID", "User ID");
            dgvOrders.Columns["UserID"].DataPropertyName = "UserID";

            dgvOrders.Columns.Add("DateTime", "Date Time");
            dgvOrders.Columns["DateTime"].DataPropertyName = "DateTime";

            dgvOrders.Columns.Add("OrderStatus", "Order Status");
            dgvOrders.Columns["OrderStatus"].DataPropertyName = "OrderStatus";

            dgvOrders.DataSource = orderService.GetAllOrders();
            dgvOrders.Refresh();

            // Testing purpose
            string columnNames = string.Join(", ", dgvOrders.Columns.Cast<DataGridViewColumn>().Select(c => c.Name));
            MessageBox.Show("Columns found: " + columnNames);
        }

        // Button to update order status to "In Progress"
        private void btnInProgress_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                string selectedOrderID = dgvOrders.SelectedRows[0].Cells["OrderID"].Value?.ToString();
                bool isUpdated = orderService.UpdateOrderStatus(selectedOrderID, "In Progress");

                if (isUpdated)
                {
                    MessageBox.Show("Order status succesfully change to In Progress!");

                    dgvOrders.DataSource = orderService.GetAllOrders(); // Dispaly all orders after update status to "In Progress"
                    dgvOrders.Refresh();
                }
                else
                {
                    MessageBox.Show("Order status update fail!");
                }
            }
            else
            {
                MessageBox.Show("Please select an order!");
            }
        }

        // Button to update order status to "Completed"
        private void btnCompleted_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0 )
            {
                string selectedOrderID = dgvOrders.SelectedRows[0].Cells["OrderID"].Value?.ToString();
                bool isUpdated = orderService.UpdateOrderStatus(selectedOrderID, "Completed");

                if (isUpdated)
                {
                    MessageBox.Show("Order status succesfully change to Completed!");

                    dgvOrders.DataSource = orderService.GetAllOrders(); // Dispaly all orders after update status to "Completed"
                    dgvOrders.Refresh();
                }
                else
                {
                    MessageBox.Show("Order status update fail!");
                }
            }
            else
            {
                MessageBox.Show("Please select an order!");
            }
        }

        // Button to update order status to "Cancelled"
        //private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)       //Kuek-Chef
        private void dgvOrders_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)   //Kuek-Chef
        {
            if (e.RowIndex >= 0)
            {
                string selectedOrderID = dgvOrders.Rows[e.RowIndex].Cells["OrderID"].Value?.ToString();
                DataTable dtOrderItems = orderService.GetOrderItem(selectedOrderID);

                dgvOrders.AutoGenerateColumns = false;
                dgvOrders.Columns.Clear();

                dgvOrders.Columns.Add("ItemName", "Item Name");
                dgvOrders.Columns["ItemName"].DataPropertyName = "ItemName";

                dgvOrders.Columns.Add("Quantity", "Quantity");
                dgvOrders.Columns["Quantity"].DataPropertyName = "Quantity";

                dgvOrders.DataSource = dtOrderItems;
                dgvOrders.Refresh();

                btnReturnOrder.Visible = true;

                MessageBox.Show($"Order items shown for {selectedOrderID}");
            }
        }

        // Button to return order list
        public void btnReturnOrder_Click(object sender, EventArgs e)
        {
            dgvOrders.AutoGenerateColumns = false;
            dgvOrders.Columns.Clear();

            dgvOrders.Columns.Add("OrderID", "Order ID");
            dgvOrders.Columns["OrderID"].DataPropertyName = "OrderID";

            dgvOrders.Columns.Add("UserID", "User ID");
            dgvOrders.Columns["UserID"].DataPropertyName = "UserID";

            dgvOrders.Columns.Add("DateTime", "Date Time");
            dgvOrders.Columns["DateTime"].DataPropertyName = "DateTime";

            dgvOrders.Columns.Add("OrderStatus", "Order Status");
            dgvOrders.Columns["OrderStatus"].DataPropertyName = "OrderStatus";

            dgvOrders.DataSource = orderService.GetAllOrders();
            dgvOrders.Refresh();

            MessageBox.Show("Order list is returned!");
        }

        // Button to navigate to chef form
        private void btnOrderToChef_Click(object sender, EventArgs e)
        {
            frmChef frmChef = new frmChef();
            frmChef.SetUser(_currentUser);
            frmChef.Show();
            this.Hide();
        }

        // Button to navigate to inventory form
        private void btnOrderToInventory_Click(object sender, EventArgs e)
        {
            frmInventory frmInventory = new frmInventory();
            frmInventory.SetUser(_currentUser);
            frmInventory.Show();
            this.Hide();
        }

        // Button to navigate to chef profile form
        private void btnOrderToProfile_Click(object sender, EventArgs e)
        {
            Admin.View.frmUpdate frmChefProfile = new Admin.View.frmUpdate();
            frmChefProfile.SetUser(_currentUser);
            this.Hide();
            frmChefProfile.ShowDialog();
            this.Show();
        }
    }
}
