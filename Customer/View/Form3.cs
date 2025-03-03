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
        public Form3()
        {
            InitializeComponent();
        }

        private Form2 form2menu; // Reference to Form2

        public Form3(Form2 form2)
        {
            InitializeComponent();
            form2menu = form2; // Store Form2 reference
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'foodiepointDbDataSet.OrderItem' table. You can move, or remove it, as needed.
            this.orderItemTableAdapter.Fill(this.foodiepointDbDataSet.OrderItem);
            // TODO: This line of code loads data into the 'foodiepointDbDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.foodiepointDbDataSet.Orders);

            // Create a DataTable for the cart
            DataTable cartTable = new DataTable();
            cartTable.Columns.Add("Food", typeof(string));
            cartTable.Columns.Add("Quantity", typeof(int));

            // Populate with items from Form2’s CartItems list
            foreach (string food in form2menu.CartItems)
            {
                cartTable.Rows.Add(food, 1); // Default quantity = 1
            }

            // Bind the table to DataGridView
            dataGridView1.DataSource = cartTable;
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
