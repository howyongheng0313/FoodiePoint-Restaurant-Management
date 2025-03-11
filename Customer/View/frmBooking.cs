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
    public partial class frmBooking : Form
    {
        //private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\vs\\FoodiePoint-Restaurant-Management\\Customer\\FoodiepointDb.mdf;Integrated Security=True";
        private string connectionString = ConfigurationManager.ConnectionStrings["FoodiePointDB"].ToString();

        public frmBooking()
        {
            InitializeComponent();
        }

        private void frmBooking_Load(object sender, EventArgs e)
        {
           
        }

        private void btnReservationStatus_Click(object sender, EventArgs e)
        {
            string reservationDate = textBox1.Text;
            string reservationType = comboBox1.SelectedItem.ToString();
            string userID = textBox2.Text;  // Assuming user enters this manually

            if (string.IsNullOrEmpty(reservationDate) || string.IsNullOrEmpty(reservationType) || string.IsNullOrEmpty(userID))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string query = "INSERT INTO Reservations (HallID, UserID, ReservationDate, ReservationType, ReservationStatus) " +
                           "VALUES (@HallID, @UserID, @ReservationDate, @ReservationType, 'Confirmed')";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@HallID", "H01");  // Change as needed
                        cmd.Parameters.AddWithValue("@UserID", userID);
                        cmd.Parameters.AddWithValue("@ReservationDate", Convert.ToDateTime(reservationDate));
                        cmd.Parameters.AddWithValue("@ReservationType", reservationType);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Reservation successful!");
                        }
                        else
                        {
                            MessageBox.Show("Reservation failed.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
