using Customer;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Customer
{
    public partial class frmCustomerMain : Form
    {

        private string connectionString = ConfigurationManager.ConnectionStrings["FoodiePointDB"].ToString();
        public frmCustomerMain()
        {
            InitializeComponent();
        }

        private void btnCustomerToMenu_Click(object sender, EventArgs e)
        {
            frmMenuPage obj1 = new frmMenuPage();
            obj1.Show();
            this.Hide();
        }

        private void btnCustomerToHallReservation_Click(object sender, EventArgs e)
        {
            frmBooking obj1 = new frmBooking();
            obj1.Show();
            this.Hide();
        }

        private void frmCustomerMain_Load(object sender, EventArgs e)
        {
        }

        private void btnSendFeedback_Click(object sender, EventArgs e)
        {
            //string userID = tbxUsername.Text;
            //string userpass = tbxPassword.Text;
            string feedbacks = rtbxFeedback.ToString();

            if (string.IsNullOrEmpty(feedbacks)) //string.IsNullOrEmpty(userID) || string.IsNullOrEmpty(userpass) ||
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string query = "INSERT INTO Requests (RequestID, ReservationID, UserRequest) " + "VALUES (@RequestID, @ReservationID, @UserRequest)";
            using (SqlConnection conn = new SqlConnection(connectionString))          //^^ ensure the 3 variables goes to Request table
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Feedback", "LOL");
                        //cmd.Parameters.AddWithValue("@UserID", userID);
                        //cmd.Parameters.AddWithValue("@ReservationDate", Convert.ToDateTime(reservationDate));

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Feedback sent!");
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
