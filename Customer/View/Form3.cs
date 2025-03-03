using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace new_customer
{
    public partial class Form3: Form
    {
        private Form3
        public Form3()
        {
            InitializeComponent();
            
        }
        public void RefreshCart()
        {
            dataGridView1.Refresh(); // Forces UI update
        }
        public void AddToCart(string selectfood, string quantity)
        {
            // Check if the item already exists in the DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == selectfood)
                {
                    //Update the quantity if the item exists
                    int existingQuantity = Convert.ToInt32(row.Cells[1].Value);
                    row.Cells[1].Value = existingQuantity + quantity;
                    return; // Exit the method after updating
                }
            }

            // If the item does not exist, add a new row
            dataGridView1.Rows.Add(selectfood, quantity);

            //Ensure columns are created before adding rows
            //if (dataGridView1.Columns.Count == 0)
            //{
            //    dataGridView1.Columns.Add("ItemID", "Item ID");
            //    dataGridView1.Columns.Add("ItemName", "Item Name");
            //    dataGridView1.Columns.Add("ItemPrice", "Item Price");
            //    dataGridView1.Columns.Add("ItemCategory", "Item Category");
            //}
            //dataGridView1.Rows.Add(itemID, itemName, itemPrice, itemCategory);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 obj1 = new Form5();
            obj1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 obj1 = new Form4();
            obj1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 obj1 = new Form1();
            obj1.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row index
                int rowIndex = dataGridView1.SelectedRows[0].Index;

                // Remove the row from the DataTable
                DataTable cartTable = (DataTable)dataGridView1.DataSource;
                cartTable.Rows.RemoveAt(rowIndex);

                // Refresh the DataGridView
                dataGridView1.DataSource = cartTable;
            }
            else
            {
                MessageBox.Show("Please select an order to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 obj1 = new Form2();
            obj1.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
