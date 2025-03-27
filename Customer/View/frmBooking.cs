using Customer.Presenter;
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
        private Reservation currentReservation;
        //private string connectionString = ("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\vs\\FoodiePoint-Restaurant-Management\\Database\\FoodiePoint.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        public frmBooking(Reservation currentReservation)
        {
            InitializeComponent();

            this.currentReservation = currentReservation;
            lblresID.Text = currentReservation.ReservationID;
            txtResType.Text = currentReservation.ReservationType;
            txtResDate.Text = currentReservation.ReservationDate;
            txtGuestCount.Text = currentReservation.GuestCount.ToString();
            lblreservationStatus.Text = currentReservation.ReservationStatus;
            HallID.Text = currentReservation.HallID;

            


            string query = $"SELECT UserRequest, Reply FROM Requests WHERE ReservationID = '{currentReservation.ReservationID}'";
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.connectionString))
            {
               
                conn.Open();
                SqlCommand chat = new SqlCommand(query, conn);
                SqlDataReader chatread = chat.ExecuteReader();

                while (chatread.Read())
                {
                    string req = chatread.IsDBNull(0) ? "" : chatread.GetString(0);
                    string rep = chatread.IsDBNull(1) ? "" : chatread.GetString(1);
                    richTextBox1.Text += ("[Request]\n" + req + "\n[Reply]\n" + rep + "\n");

                }
            }
        }


        private void frmBooking_Load(object sender, EventArgs e)
        {

        }

        private void btnReservationStatus_Click(object sender, EventArgs e)

        {
            if (currentReservation == null)
            {
                currentReservation = new Reservation(); // Ensure it is initialized
            }
            // Store user input in the reservation object
            currentReservation.ReservationDate = txtResDate.Text;
            currentReservation.ReservationType = txtResType.Text;
            currentReservation.GuestCount = int.Parse(txtGuestCount.Text);
            currentReservation.UserID = "U001"; // Assign default user ID

            // Save to database
            SaveReservationToDatabase(currentReservation);

            this.Close();
        }

        private void SaveReservationToDatabase(Reservation res)
        {
            string query = "INSERT INTO Reservations (UserID, GuestCount, ReservationDate, ReservationType) " +
                           "VALUES (@user, @count, @date, @type)";

            using (SqlConnection conn = new SqlConnection(DatabaseHelper.connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {


                    cmd.Parameters.AddWithValue("@user", res.UserID);
                    cmd.Parameters.AddWithValue("@count", res.GuestCount);
                    cmd.Parameters.AddWithValue("@date", res.ReservationDate);
                    cmd.Parameters.AddWithValue("@type", res.ReservationType);


                    cmd.ExecuteNonQuery();
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

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentReservation.ReservationID)) return;

            string request_text = reqtxtbox.Text;
            if (!string.IsNullOrEmpty(request_text))
            {
                richTextBox1.Text += ("[Request]\n"+ request_text + "\n[Reply]\n...\n");
                string query = "INSERT INTO Requests (ReservationID, UserRequest) " +
                          "VALUES (@reservationID, @userrequest)";

                using (SqlConnection conn = new SqlConnection(DatabaseHelper.connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@reservationID", currentReservation.ReservationID);
                        cmd.Parameters.AddWithValue("@userrequest", reqtxtbox.Text); // Ensure this is correct
                        

                        reqtxtbox.Clear();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter text before sending request.");
            }
        }
    } 
}





