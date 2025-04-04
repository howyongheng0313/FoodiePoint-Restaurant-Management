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
        public string ID;
        public string FoodName;
        public decimal FoodPrice;
        public string Catagory;
        public int Quantity;
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
                foreach (DataGridViewRow row in dgv.SelectedRows)
                {
                    dgv.Rows.Remove(row);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static decimal add_oneitem(DataGridView dgv)
        {
            if (dgv.SelectedRows.Count == 1)
            {
                int currentQty = Convert.ToInt32(dgv.SelectedRows[0].Cells["Quantity"].Value);
                dgv.SelectedRows[0].Cells["Quantity"].Value = currentQty + 1;
                decimal currentPrice = Convert.ToDecimal(dgv.SelectedRows[0].Cells["FoodPrice"].Value);
                return currentPrice;
            }
            else
            {
                MessageBox.Show("Please select a row before adding the quantity...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
        }

        public static decimal dlt_oneitem(DataGridView dgv)
        {
            if (dgv.SelectedRows.Count == 1)
            {
                
                int currentQty = Convert.ToInt32(dgv.SelectedRows[0].Cells["Quantity"].Value);
                dgv.SelectedRows[0].Cells["Quantity"].Value = currentQty - 1;
                decimal currentPrice = Convert.ToDecimal(dgv.SelectedRows[0].Cells["FoodPrice"].Value);
                return currentPrice;
                
            }
            else
            {
                MessageBox.Show("Please select a row before deleting the quantity...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
        }

        public static void pay_food(DataGridView dgv)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["FoodiePointDB"].ToString(); // Update this with your actual DB connection

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (!row.IsNewRow) // Ignore empty rows
                    {
                        string itemID = row.Cells[0].Value.ToString();
                        string itemName = row.Cells[1].Value.ToString();
                        decimal itemPrice = Convert.ToDecimal(row.Cells[2].Value);
                        string itemCategory = row.Cells[3].Value.ToString();


                        string query = "INSERT INTO OrderItems (ItemID, ItemName, ItemPrice, ItemCategory) + " +
                                       "VALUES (@ItemID, @ItemName, @ItemPrice, @ItemCategory)";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@ItemID", itemID);
                            cmd.Parameters.AddWithValue("@ItemName", itemName);
                            cmd.Parameters.AddWithValue("@ItemPrice", itemPrice);
                            cmd.Parameters.AddWithValue("@ItemCategory", itemCategory);


                            //cmd.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("Order placed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv.Rows.Clear();
            }
        }



        //}
        //public DataTable GetAllItem()
        //{
        //    string query = "SELECT * FROM Menu";
        //    return dbHelper.ExecuteQuery(query);
        //}

        //public DataTable searchItem(string searchItemName)
        //{
        //    string query = $"SELECT * FROM Menu WHERE ItemName = '{searchItemName}' " ;
        //    return dbHelper.ExecuteQuery(query);
        //}

        //public bool addItem()
        //{
        //    string query = "";
        //    return ;
        //}

        //public bool editItem()
        //{
        //    string query = "UPDATE";
        //    return;
        //}

        //public bool deleteItem()
        //{
        //    string query = "DELETE FROM Menu WHERE ItemName = ";
        //    return;
        //}
    }
}


