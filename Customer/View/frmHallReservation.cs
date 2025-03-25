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
    public partial class frmHallReservation : Form
    {
        //private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\vs\\FoodiePoint-Restaurant-Management\\Customer\\FoodiepointDb.mdf;Integrated Security=True";

        private string connectionString = ConfigurationManager.ConnectionStrings["FoodiePointDB"].ToString();
        public frmHallReservation()
        {
            InitializeComponent();
        }
        private void frmHallReservation_Load(object sender, EventArgs e)
        {
            LoadTableData();
        }

        private void LoadTableData()
        {
            //string query = "SELECT * FROM Halls"; // Change "Customers" to your table name            //Kuek-Customer
            string query = "SELECT ReservationID, HallID, UserID, ReservationStatus FROM Reservations"; //Kuek-Customer

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

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmMenuPage obj1 = new frmMenuPage();
            obj1.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("Total reservations: " + reservations.Count);
            if (e.RowIndex >= 0) // Ensure a valid row is clicked
            {
                string reservationID = dataGridView1.Rows[e.RowIndex].Cells["ReservationID"].Value?.ToString();
                string userID = dataGridView1.Rows[e.RowIndex].Cells["UserID"].Value?.ToString();
                string hallID = dataGridView1.Rows[e.RowIndex].Cells["HallID"].Value?.ToString();
                string reservationstatus = dataGridView1.Rows[e.RowIndex].Cells["ReservationStatus"].Value?.ToString();

                Reservation selectedReservation = new Reservation(reservationID, userID, hallID, reservationstatus);
                frmBooking bookingForm = new frmBooking(selectedReservation);
                bookingForm.ShowDialog();
            }
        }

        

        public void UpdateReservation(Reservation updatedReservation)
        {
            // Update the reservation in the list
            for (int i = 0; i < reservations.Count; i++)
            {
                if (reservations[i].ReservationID == updatedReservation.ReservationID)
                {
                    reservations[i] = updatedReservation; // Replace with updated object
                    break;
                }
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ReservationID"].Value.ToString() == updatedReservation.ReservationID)
                {
                    row.Cells["ReservationStatus"].Value = "Booked"; // Update status
                    break;
                }
            }


        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            frmCustomerMain obj1 = new frmCustomerMain();
            obj1.Show();
            this.Hide();
        }
    }
}
