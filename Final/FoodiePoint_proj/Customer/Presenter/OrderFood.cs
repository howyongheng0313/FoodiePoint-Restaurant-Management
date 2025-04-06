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

        public static string CreateOrder(string userID)
        {
            try
            {
                object result;
                string formattedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                string query = $"INSERT INTO Orders (UserID, DateTime, OrderStatus) " +
                               $"VALUES ('{userID}', '{formattedDate}', 'Pending'); " +
                               $"SELECT OrderID FROM Orders WHERE ID = SCOPE_IDENTITY();";

                using (SqlConnection conn = new SqlConnection(DatabaseHelper.connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        result = cmd.ExecuteScalar();
                        conn.Close();
                    }
                }

                if (result != null)
                    return result.ToString();
                else
                    throw new Exception("Failed to retrieve OrderID after creating order");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating order: " + ex.Message);
                return null;
            }
        }

        public static int AddOrderItems(DataGridViewRowCollection dgvRow, string orderID)
        {
            string query = "INSERT INTO OrderItem (OrderID, ItemID, Quantity) VALUES ";
            bool not_first = false;
            foreach (DataGridViewRow row in dgvRow)
            {
                if (row.IsNewRow) break;
                if (not_first) query += ",";
                else not_first = true;

                string itemID = row.Cells["FoodID"].Value.ToString();
                int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                query += $"('{orderID}', '{itemID}', {quantity})";
            }
            if (!not_first) return 0;

            int result;
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    result = cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            return result;
        }
    }
}


