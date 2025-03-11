using new_customer;
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

        public frmBooking()
        {
            InitializeComponent();
        }

        private void frmBooking_Load(object sender, EventArgs e)
        {

        }

        private void btnReservationStatus_Click(object sender, EventArgs e)
        {
            string userID = textBox1.Text;
            string reservationDate = textBox2.Text;
            string reservationType = comboBox1.SelectedItem.ToString(); //For user to enter the booking details
            string request = rtbxRequest.ToString();
            string hallID = textBox3.Text;
            
            if (string.IsNullOrEmpty(reservationDate) || string.IsNullOrEmpty(userID) || string.IsNullOrEmpty(request))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string query = "INSERT INTO Requests (RequestID, ReservationID, UserRequest) " + "VALUES (@RequestID, @ReservationID, @UserRequest)";
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

            string another = "INSERT INTO Reservation (ReservationType, HallID)" + "VALUES (@ReservationType, @HallID)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(another, conn))
                    {
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

            //string[] lines = rtbxRequest.Lines;

            //// Extract up to 3 requests
            //string request1 = lines.Length > 0 ? lines[0] : "";
            //string request2 = lines.Length > 1 ? lines[1] : "";
            //string request3 = lines.Length > 2 ? lines[2] : "";

           
            //string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\vs\\FoodiePoint-Restaurant-Management\\Customer\\FoodiepointDb.mdf;Integrated Security=True";

            //using (SqlConnection conn = new SqlConnection(connectionString))
            //{
            //    conn.Open();
            //    string requestlines = "INSERT INTO RequestTable (Request1, Request2, Request3) VALUES (@Request1, @Request2, @Request3)";

            //    using (SqlCommand cmd = new SqlCommand(requestlines, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@Request1", request1);
            //        cmd.Parameters.AddWithValue("@Request2", request2);
            //        cmd.Parameters.AddWithValue("@Request3", request3);

            //        cmd.ExecuteNonQuery();
            //    }
            //}

            //MessageBox.Show("Requests saved successfully!");


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
