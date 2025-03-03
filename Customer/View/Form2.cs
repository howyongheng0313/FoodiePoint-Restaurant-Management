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
        //private Form3 _form3;

        // In your Form2 constructor or Load event:
        public Form2() // or private void Form2_Load(object sender, EventArgs e)
        {
            InitializeComponent();  // Important!  Call this first

            // Create the Form3 instance only once
            //_form3 = new Form3();
            //_form3.Hide(); // Initially hide Form3
        }

        public List<string> CartItems = new List<string>(); // Store selected food names


        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'foodiepointDbDataSet.Menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter.Fill(this.foodiepointDbDataSet.Menu);
            DataTable table = new DataTable(); // Create a DataTable

            // Define columns
            //table.Columns.Add("Food", typeof(string));
            //table.Columns.Add("Cuisine", typeof(string));


            //Add data rows
            //table.Rows.Add("Chicken Chop", "Western");
            //table.Rows.Add("Fish and Chips", "Western");
            //table.Rows.Add("Burger", "Western");
            //table.Rows.Add("Fried Rice", "Chinese");
            //table.Rows.Add("Dumpling", "Chinese");
            //table.Rows.Add("Dim Sum", "Chinese");
            //table.Rows.Add("Bibimbap", "Korean");
            //table.Rows.Add("Bulgogi", "Korean");

            // Bind the DataTable to a DataGridView
            //dataGridView1.DataSource = table;
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
            //Form3 cartForm = new Form3(this); // Pass Form2 reference
            //cartForm.Show();

            Form3 obj1 = new Form3(this);
            obj1.Show();
            this.Hide();
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
                // Get the selected food name from the first column (Food Name)
                string ItemID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                


                // Add it to the CartItems list
                CartItems.Add(ItemID);
                

                // Open Form3 and pass the cart data
                Form3 cartForm = new Form3(this);
                // doesnt let cartForm.Show();
            }
            else
            {
                MessageBox.Show("Please select a food item to add to the cart.");
            }
        }
    }
    }
    

