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
using System.Windows.Markup;

namespace Customer
{
    public partial class frmBooking : Form
    {
        //private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\vs\\FoodiePoint-Restaurant-Management\\Customer\\FoodiepointDb.mdf;Integrated Security=True";

        private string connectionString = ConfigurationManager.ConnectionStrings["FoodiePointDB"].ToString();
        private Reservation reservation;
        private frmHallReservation mainForm;

        public frmBooking(Reservation reservation)
        {
            InitializeComponent();
            //this.reservation = reservation;
            //this.mainForm = mainForm;
            lblReservationID.Text = reservation.ReservationID;
        }

        private void frmBooking_Load(object sender, EventArgs e)
        {

        }

        private void btnReservationStatus_Click(object sender, EventArgs e)

        {
            // Get user inputs and update the reservation object
            reservation.ReservationDate = textBox1.Text;
            reservation.ReservationType = comboBox1.SelectedItem.ToString();
            reservation.GuestCount = textBox2.Text;
            reservation.Request = rtbxRequest.Text;
            reservation.ReservationStatus = "Booked";

            if (string.IsNullOrEmpty(reservation.ReservationDate) || string.IsNullOrEmpty(reservation.GuestCount) || string.IsNullOrEmpty(reservation.Request))
            {
               MessageBox.Show("Please fill in all fields.");
                return;
            }

            string query = "INSERT INTO Reservations (ReservationDate, ReservationType, GuestCount) " +
                           "OUTPUT INSERTED.ReservationID " +
                           "VALUES (@ReservationDate, @ReservationDate, @GuestCount)";
            using (SqlConnection conn = new SqlConnection(connectionString))//^^ ensure the 3 variables goes to Reservation table
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", "U001");
                        cmd.Parameters.AddWithValue("@GuestCount", reservation.GuestCount); 
                        cmd.Parameters.AddWithValue("@ReservationDate", Convert.ToDateTime(reservation.ReservationDate));
                        cmd.Parameters.AddWithValue("@ReservationType", reservation.ReservationType);

                        reservation.ReservationID = (string) cmd.ExecuteScalar();
                        //if (rowsAffected > 0)
                        //{
                        //    MessageBox.Show("Reservation successful!");
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Reservation failed.");
                        //}
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                mainForm.UpdateReservation(reservation);

                MessageBox.Show("Booking confirmed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            string another = "INSERT INTO Requests (ReservationID, UserRequest)" + 
                             "VALUES (@RequestID, @Request)";
            using (SqlConnection conn = new SqlConnection(connectionString))          //^^ ensure the variable goes to Request table
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(another, conn))
                    {
                        cmd.Parameters.AddWithValue("@ReservationID", reservation.ReservationID);
                        cmd.Parameters.AddWithValue("@UserRequest", reservation.Request);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        //if (rowsAffected > 0)
                        //{
                        //    MessageBox.Show("Reservation successful!");
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Reservation failed.");
                        //}
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }
        

        private void btnSendFeedback_Click(object sender, EventArgs e)
        {

        }

        private void rtbxFeedback_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCustomerToMenu_Click(object sender, EventArgs e)
        {
            frmMenuPage obj1 = new frmMenuPage();
            obj1.Show();
            this.Hide();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            frmCustomerMain obj1 = new frmCustomerMain();
            obj1.Show();
            this.Hide();
        }
    }
}
