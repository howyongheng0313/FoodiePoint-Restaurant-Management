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
            string query = "SELECT * FROM Orders";
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
    }
}
