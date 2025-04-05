using Admin.Presenter;
using Customer.Presenter;
using Reservation_Coordinator.Model;
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
    public partial class frmMenuPage : Form, UserForm
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["FoodiePointDB"].ToString();

        private List<OrderFood> selectedRows = new List<OrderFood>();
        private LoginCredent _currentUser;

        public frmMenuPage()
        {
            InitializeComponent();
        }

        public void SetUser(LoginCredent user)
        {
            _currentUser = user;
        }

        private void frmMenuPage_Load(object sender, EventArgs e)
        {
            //this.menuTableAdapter.Fill(this.foodiepointDbDataSet.Menu);
            LoadTableData("");
        }

        private void LoadTableData(string searchValue)
        {
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
            obj1.SetUser(_currentUser);
            Jumper.Shift(obj1);
        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            frmOrderCart form3 = new frmOrderCart(selectedRows);
            form3.SetUser(_currentUser);
            DialogResult result = Jumper.Dive(form3);

            if (result == DialogResult.OK)
            {
                frmCustomerMain obj1 = new frmCustomerMain();
                obj1.SetUser(_currentUser);
                Jumper.Shift(obj1);
            }
        }
       

        private void btnMenuToHallReservation_Click(object sender, EventArgs e)
        {
            frmHallReservation obj1 = new frmHallReservation();
            obj1.SetUser(_currentUser);
            Jumper.Shift(obj1);
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (!row.IsNewRow) // Ignore new empty rows
                {
                    OrderFood rowData = new OrderFood(
                        row.Cells[0].Value.ToString(), // Item ID
                        row.Cells[1].Value.ToString(), // Item Name
                        Convert.ToDecimal(row.Cells[2].Value), // Item Price
                        row.Cells[3].Value.ToString()  // Item Category
                    );
                    bool isExists = false;
                    foreach (OrderFood order in selectedRows)
                    {
                        if (order.ID == rowData.ID)
                        {
                            order.Quantity += 1;
                            isExists = true;
                            break;
                        }
                    }
                    if (!isExists) selectedRows.Add(rowData);

                }
            }
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            string searchText = search_txt.Text.Trim();
            LoadTableData(searchText); 
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            Admin.View.frmUpdate obj1 = new Admin.View.frmUpdate();
            obj1.SetUser(_currentUser);
            Jumper.Dive(obj1);
        }
    }
}
    

