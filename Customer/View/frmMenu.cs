using Customer.Presenter;
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
    public partial class frmMenuPage : Form
    {
        private DatabaseHelper dbhelper;

        private List<string[]> selectedRows = new List<string[]>();

        public frmMenuPage()
        {
            InitializeComponent();
        }

        //DataTable table = new DataTable(); // Create a DataTable
        private void frmMenuPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'foodiepointDbDataSet.Menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter.Fill(this.foodiepointDbDataSet.Menu);

            
        }

        private void btnMenuToProfile_Click(object sender, EventArgs e)
        {
            frmCustomerMain obj1 = new frmCustomerMain();
            obj1.Show();
            this.Hide();
        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            frmOrderCart form3 = new frmOrderCart(selectedRows);
            form3.ShowDialog();
        }
       

        private void btnMenuToHallReservation_Click(object sender, EventArgs e)
        {
            frmHallReservation obj1 = new frmHallReservation();
            obj1.Show();
            this.Hide();
        }

        public List<string> selectedCellValue = new List<string>();

        private void btnAddToCart_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (!row.IsNewRow) // Ignore new empty rows
                {
                    string[] rowData = new string[]
                    {
                        row.Cells[0].Value.ToString(), // Item ID
                        row.Cells[1].Value.ToString(), // Item Name
                        row.Cells[2].Value.ToString(), // Item Price
                        row.Cells[3].Value.ToString()  // Item Category
                    };

                    selectedRows.Add(rowData);

                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            string searchText = search.Text.Trim(); // Get text from TextBox

            if (!string.IsNullOrEmpty(searchText))
            {
                searchItem(searchText); // Call the method with input
            }
            else
            {
                MessageBox.Show("Please enter an item name to search.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
    

