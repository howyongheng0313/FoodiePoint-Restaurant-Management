using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace new_customer
{
    public partial class Form2 : Form
    {
        private Form3 cartForm;
        public Form2(Form3 form3Instance)
        {
            InitializeComponent();
            this.cartForm = form3Instance;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'foodiepointDbDataSet.Menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter.Fill(this.foodiepointDbDataSet.Menu);
            DataTable table = new DataTable(); // Create a DataTable
        }


        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 obj1 = new Form1();
            obj1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cartForm.RefreshCart(); // Ensure the latest cart is shown
            cartForm.Show();

            //Form3 obj1 = new Form3();
            //obj1.Show();
            //this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 obj1 = new Form4();
            obj1.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string selectfood = selectedRow.Cells[0].Value.ToString();
                string quantity = selectedRow.Cells[1].Value.ToString();

                cartForm.AddToCart(selectfood, quantity);
                cartForm.RefreshCart(); // Update DataGridView

                MessageBox.Show("Item added to cart!");
            }
            else
            {
                MessageBox.Show("Please select a food item to add to the cart.");
            }
        }
    }
}
    

