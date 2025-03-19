using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer
{
    public partial class frmHallReservation: Form
    {
        //private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\vs\\FoodiePoint-Restaurant-Management\\Customer\\FoodiepointDb.mdf;Integrated Security=True";
        private string connectionString = ConfigurationManager.ConnectionStrings["FoodiePointDB"].ToString();
        public frmHallReservation()
        {
            InitializeComponent();
        }

        private void frmHallReservation_Load(object sender, EventArgs e)
        {
            LoadTableData("");
        }

        private void LoadTableData(string searchValue)
        {
            //string query = "SELECT * FROM Halls"; // Change "Customers" to your table name                //Kuek-Customer
            string query = "SELECT HallID, HallName, HallPartyType, HallCapacity, Availability FROM Halls"; //Kuek-Customer

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
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

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // Ensure a row is selected
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Extract Hall Name and Availability
                string hallID = selectedRow.Cells["HallID"].Value.ToString();
                string hallName = selectedRow.Cells["HallName"].Value.ToString();
                string availability = selectedRow.Cells["Availability"].Value.ToString(); // Change column name if different

                // Check if the hall is available
                if (availability.ToLower() == "available")
                {
                    UpdateHallAvailability(hallID);
                    //LoadHallsData();
                    MessageBox.Show(hallName + " booked!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show(hallName + " isn't available!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select a hall before booking!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateHallAvailability(string hallID)
        {
            string query = "UPDATE Halls SET Availability = 'Unavailable' WHERE HallID = @HallID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@HallID", hallID);
                        cmd.ExecuteNonQuery(); // Execute the update
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating hall: " + ex.Message);
                }
            }
        }

        //private void LoadHallsData()
        //{
        //    string query = "SELECT * FROM Halls"; // Fetch all halls from the database

        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    {
        //        try
        //        {
        //            conn.Open();
        //            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
        //            DataTable dt = new DataTable();
        //            adapter.Fill(dt);
        //            dataGridViewHalls.DataSource = dt; // Display in DataGridView
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Error loading halls: " + ex.Message);
        //        }
        //    }
        //}
    }
}
