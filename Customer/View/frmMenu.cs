using Customer.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer
{
    public partial class frmMenuPage : Form
    {
        //private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\vs\\FoodiePoint-Restaurant-Management\\Customer\\FoodiepointDb.mdf;Integrated Security=True";
        private string connectionString = ConfigurationManager.ConnectionStrings["FoodiePointDB"].ToString();
        private DatabaseHelper dbhelper;
        OrderFood ordermethod = new OrderFood();

        private List<string[]> selectedRows = new List<string[]>();

        public frmMenuPage()
        {
            InitializeComponent();
        }

        //DataTable table = new DataTable(); // Create a DataTable
        private void frmMenuPage_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'foodiepointDbDataSet.Menu' table. You can move, or remove it, as needed.
            //this.menuTableAdapter.Fill(this.foodiepointDbDataSet.Menu);
            LoadTableData("");


        }

        private void LoadTableData(string searchValue)
        {
            //string query = "SELECT * FROM Menu"; // Change "Customers" to your table name //Kuek-Customer
            string query = "SELECT ItemID, ItemName, ItemPrice, ItemCategory FROM Menu";    //Kuek-Customer

            if (!string.IsNullOrEmpty(searchValue))
            {
                query += " WHERE ItemName LIKE @search"; // Filter by name
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                    if (!string.IsNullOrEmpty(searchValue))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + searchValue + "%");
                    }

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
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

            string searchText = search_txt.Text.Trim();
            LoadTableData(searchText); 
            // Reload the data based on search input
            //string searchText = search_txt.Text; // Get text from the TextBox

            //if (!string.IsNullOrEmpty(searchText))
            //{
            //    List<string> dt = dataGridView1.DataSource as List<string>; // Get DataTable from DataSource
            //    if (dt != null)
            //    {
            //        DataView dv = dt.DefaultView;
            //        dv.RowFilter = $"ItemName LIKE '%{searchText}%' OR ItemCategory LIKE '%{searchText}%'";
            //        dataGridView1.DataSource = dv; // Apply the filter
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Please enter an item name or category to search.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //string searchText = Search_btn.Text;

            //ordermethod.searchItem(searchText);
            //dataGridView1.DataSource = ordermethod.searchItem(searchText);




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
    

