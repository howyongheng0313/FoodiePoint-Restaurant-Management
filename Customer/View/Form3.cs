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
        Form2 cp = new Form2();
        public Form3()
        {
            InitializeComponent();
        }

        //public void SetSelectedCells(List<string> selectedCells)
        //{
        //    foreach (string cellValue in selectedCells)
        //    {
        //        dataGridView1.Rows.Add(cellValue); // Assuming dataGridView3 is the DataGridView in Form3
        //    }
        //}


        //private DataGridView orderDataGridView;
        DataGridView orderDataGridView = new DataGridView();

        public void DisplayOrder(string id, string name)
        {
            DataTable Cart = new DataTable();

            if (orderDataGridView.DataSource == null)
            {
                Cart.Columns.Add("ItemID", typeof(string));
                Cart.Columns.Add("ItemName", typeof(string));

                Cart.Columns.Add("Quantity", typeof(int));

                Cart.Rows.Add(id, name, 1);

                orderDataGridView.DataSource = Cart;
            }
            else
            {
                Cart = (DataTable)orderDataGridView.DataSource;

                bool item = false;
                foreach (DataRow row in Cart.Rows)
                {
                    if (row["ItemID"].ToString() == id)
                    {
                        int quantity = Convert.ToInt32(row["Quantity"]) + 1;
                        row["Quantity"] = quantity;
                        item = true;
                        break;

                    }
                }
                if (!item)
                {
                    Cart.Rows.Add(id, name, 1);
                }

                orderDataGridView.Refresh();
            }

        }

        public void DisplaySelectedCells(List<string> selectedCells)
        {
            foreach (string cellValue in selectedCells)
            {
                dataGridView1.Rows.Add(cellValue); // Assuming dataGridView3 is the DataGridView in Form3
            }
        }


        public void RefreshCart()
        {
            dataGridView1.Refresh(); // Forces UI update
        }
        public void AddToCart(string selectfood, string quantity)
        {
  
            {
 
            }
            
        }

        

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'foodiepointDbDataSet1.Menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter1.Fill(this.foodiepointDbDataSet1.Menu);
            // TODO: This line of code loads data into the 'foodiepointDbDataSet.Menu' table. You can move, or remove it, as needed.
            //this.menuTableAdapter.Fill(this.foodiepointDbDataSet.Menu);

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

        }

        private void button2_Click(object sender, EventArgs e)
        {
     
    
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
    }
}
