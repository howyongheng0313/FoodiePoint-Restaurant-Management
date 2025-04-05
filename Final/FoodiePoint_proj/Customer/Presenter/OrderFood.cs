using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Runtime.InteropServices;


namespace Customer.Presenter
{
    public class OrderFood
    {
        public string ID { get; set; }
        public string FoodName { get; set; }
        public decimal FoodPrice { get; set; }
        public string Catagory { get; set; }
        public int Quantity { get; set; }
        public OrderFood(string ID, string FoodName, decimal FoodPrice, string Catagory)
        {
            this.ID = ID;
            this.FoodName = FoodName;
            this.FoodPrice = FoodPrice;
            this.Catagory = Catagory;
            Quantity = 1;
        }
        public static void dlt_rowitem(DataGridView dgv)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                dgv.Rows.RemoveAt(dgv.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public static decimal add_oneitem(DataGridView dgv)
        {
            decimal addedPrice = 0;

            if (dgv.SelectedRows.Count > 0)
            {
                int rowIndex = dgv.SelectedRows[0].Index;
                int currentQty = Convert.ToInt32(dgv.Rows[rowIndex].Cells["Quantity"].Value);
                decimal price = Convert.ToDecimal(dgv.Rows[rowIndex].Cells["FoodPrice"].Value);

                dgv.Rows[rowIndex].Cells["Quantity"].Value = currentQty + 1;
                addedPrice = price;
            }

            return addedPrice;
        }
        public static decimal dlt_oneitem(DataGridView dgv)
        {
            decimal removedPrice = 0;

            if (dgv.SelectedRows.Count > 0)
            {
                int rowIndex = dgv.SelectedRows[0].Index;
                int currentQty = Convert.ToInt32(dgv.Rows[rowIndex].Cells["Quantity"].Value);
                decimal price = Convert.ToDecimal(dgv.Rows[rowIndex].Cells["FoodPrice"].Value);

                if (currentQty > 1)
                {
                    // Decrement quantity
                    dgv.Rows[rowIndex].Cells["Quantity"].Value = currentQty - 1;
                    removedPrice = price;
                }
                else
                {
                    MessageBox.Show("Quantity cannot be less than 1.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            return removedPrice;
        }

        public static void pay_food(DataGridView dgv)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["FoodiePointDB"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // First, create a new order in the Orders table
                    string orderID = GenerateOrderID(conn);
                    string userID = GetCurrentUserID();
                    DateTime orderDateTime = DateTime.Now;
                    string orderStatus = "Pending";

                    // SQL to insert into Orders table
                    string orderInsertQuery = "INSERT INTO Orders (OrderID, UserID, DateTime, OrderStatus) VALUES (@OrderID, @UserID, @DateTime, @OrderStatus)";
                    using (SqlCommand cmd = new SqlCommand(orderInsertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@OrderID", orderID);
                        cmd.Parameters.AddWithValue("@UserID", userID);
                        cmd.Parameters.AddWithValue("@DateTime", orderDateTime);
                        cmd.Parameters.AddWithValue("@OrderStatus", orderStatus);
                        cmd.ExecuteNonQuery();
                    }

                    // Then, add each item to the OrderItem table
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (!row.IsNewRow) // Skip the empty row at the end if present
                        {
                            string itemID = row.Cells["FoodID"].Value.ToString();
                            int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);

                            // SQL to insert into OrderItem table
                            string itemInsertQuery = "INSERT INTO OrderItem (OrderID, ItemID, Quantity) VALUES (@OrderID, @ItemID, @Quantity)";
                            using (SqlCommand itemCmd = new SqlCommand(itemInsertQuery, conn))
                            {
                                itemCmd.Parameters.AddWithValue("@OrderID", orderID);
                                itemCmd.Parameters.AddWithValue("@ItemID", itemID);
                                itemCmd.Parameters.AddWithValue("@Quantity", quantity);
                                itemCmd.ExecuteNonQuery();
                            }
                        }
                    }

                    MessageBox.Show("Order placed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error placing order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private static string GenerateOrderID(SqlConnection connection)
        {
            // Get the current highest ID from the Orders table
            string query = "SELECT MAX(ID) FROM Orders";
            int maxID = 0;

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                var result = cmd.ExecuteScalar();
                if (result != DBNull.Value && result != null)
                {
                    maxID = Convert.ToInt32(result);
                }
            }

            int newID = maxID + 1;
            return "OD" + newID.ToString("D3");
        }

        private static string GetCurrentUserID()
        {
            return "U001"; 
        }
    }
}


