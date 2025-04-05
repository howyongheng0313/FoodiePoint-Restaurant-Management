using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using FoodiePointManagementSystem.Database;

namespace FoodiePointManagementSystem.Presenter
{
    public class OrderService
    {
        private DatabaseHelper dbHelper;
        public static string CurrentUserID { get; set; }

        // Constructor of OrderService
        public OrderService()
        {
            dbHelper = new DatabaseHelper();
        }

        // Method to update order status
        public bool UpdateOrderStatus(string orderID, string orderStatus)
        {
            string query = $" UPDATE Orders SET OrderStatus = '{orderStatus}' WHERE OrderID = '{orderID}' ";
            return dbHelper.ExecuteNonQuery(query);
        }

        // Method to get all orders
        public DataTable GetAllOrders()
        {
            string query = "SELECT OrderID, UserID, " +
                          "CONVERT(VARCHAR, DateTime, 103) + ' ' + CONVERT(VARCHAR, DateTime, 108) AS DateTime, " +
                          "OrderStatus FROM Orders ORDER BY DateTime DESC";
            return dbHelper.ExecuteQuery(query);
        }

        // Method to get order items based on order ID
        public DataTable GetOrderItem(string orderID)
        {
            string query
                = $"SELECT Menu.ItemName, OrderItem.Quantity " +
                $"FROM OrderItem INNER JOIN Menu ON OrderItem.ItemID = Menu.ItemID " +
                $"WHERE OrderItem.OrderID = '{orderID}' ";

            return dbHelper.ExecuteQuery(query);
        }

        public string CreateOrder(string userID)
        {
            try
            {
                string query = $"INSERT INTO Orders (UserID, DateTime, OrderStatus) " +
                               $"VALUES ('{userID}', '{DateTime.Now}', 'Pending'); " +
                               $"SELECT OrderID FROM Orders WHERE ID = SCOPE_IDENTITY();";

                object result = dbHelper.ExecuteScalar(query);
                if (result != null)
                {
                    return result.ToString();
                }
                else
                {
                    throw new Exception("Failed to retrieve OrderID after creating order");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating order: " + ex.Message);
                return null;
            }
        }

        // Method to add an item to an order
        public bool AddOrderItem(string orderID, string itemID, int quantity)
        {
            try
            {
                string query = $"INSERT INTO OrderItem (OrderID, ItemID, Quantity) " +
                               $"VALUES ('{orderID}', '{itemID}', {quantity})";

                return dbHelper.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding order item: " + ex.Message);
                return false;
            }
        }
    }
}
