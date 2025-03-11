using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace new_customer
{
    public partial class frmOrderCart : Form
    {
        //private string connectionString = 

        public frmOrderCart(List<string[]> selectedRows)
        {
            InitializeComponent();

            // Ensure DataGridView2 has columns (Adjust based on your database)
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Item ID";
            dataGridView1.Columns[1].Name = "Item Name";
            dataGridView1.Columns[2].Name = "Item Price";
            dataGridView1.Columns[3].Name = "Item Category";
            dataGridView1.Columns[4].Name = "Quantity";


            // Add selected rows to DataGridView2
            foreach (var row in selectedRows)
            {
                string itemID = row[0]; // Assuming the first column is Item ID
                bool itemExists = false;

                // Loop through existing rows to check for duplicates
                foreach (DataGridViewRow existingRow in dataGridView1.Rows)
                {
                    if (!existingRow.IsNewRow && existingRow.Cells[0].Value.ToString() == itemID)
                    {
                        // Update quantity column
                        int currentQuantity = Convert.ToInt32(existingRow.Cells[4].Value);
                        existingRow.Cells[4].Value = currentQuantity + 1;
                        itemExists = true;
                        break;
                    }
                }

                // If the item is new, add it with quantity 1
                if (!itemExists)
                {
                    dataGridView1.Rows.Add(row[0], row[1], row[2], row[3], 1);
                }

                //dataGridView1.Rows.Add(row);
            }
        }

        public frmOrderCart()
        {
            InitializeComponent();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\vs\\FoodiePoint-Restaurant-Management\\Customer\\FoodiepointDb.mdf;Integrated Security=True"; // Update this with your actual DB connection

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow) // Ignore empty rows
                    {
                        string itemID = row.Cells[0].Value.ToString();
                        string itemName = row.Cells[1].Value.ToString();
                        decimal itemPrice = Convert.ToDecimal(row.Cells[2].Value);
                        string itemCategory = row.Cells[3].Value.ToString();
                        //string orderDate = DateTime.Now.ToString("yyyy-MM-dd");

                        string query = "INSERT INTO OrderItems (ItemID, ItemName, ItemPrice, ItemCategory) VALUES (@ItemID, @ItemName, @ItemPrice, @ItemCategory)";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@ItemID", itemID);
                            cmd.Parameters.AddWithValue("@ItemName", itemName);
                            cmd.Parameters.AddWithValue("@ItemPrice", itemPrice);
                            cmd.Parameters.AddWithValue("@ItemCategory", itemCategory);
                            //cmd.Parameters.AddWithValue("@OrderDate", orderDate);

                            //cmd.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("Order placed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.Rows.Clear(); // Clear cart after placing order
            }
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
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    if (!row.IsNewRow) // Ensure we don't delete a new empty row
                    {
                        dataGridView1.Rows.Remove(row);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Delete Row", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // Ensure a row is selected
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Get current quantity, ensure it's not null
                int currentQuantity = selectedRow.Cells[4].Value != null
                    ? Convert.ToInt32(selectedRow.Cells[4].Value)
                    : 0;

                // Increase quantity
                selectedRow.Cells[4].Value = currentQuantity + 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.ColumnIndex == 0) // Ensure an Item ID cell is clicked
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];

                int currentQuantity = Convert.ToInt32(selectedRow.Cells[4].Value);
                if (currentQuantity > 1)
                {
                    selectedRow.Cells[4].Value = currentQuantity - 1; // Decrease quantity
                }
                else
                {
                    // Optional: Remove item if quantity reaches 1
                    dataGridView1.Rows.RemoveAt(rowIndex);
                }
            }
        }
    }
}
