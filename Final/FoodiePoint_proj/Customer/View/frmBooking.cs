using Admin.Presenter;
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
    public partial class frmBooking : Form, UserForm
    {
        private Reservation currentReservation;
        private LoginCredent _currentUser;

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

        public void SetUser(LoginCredent user)
        {
            _currentUser = user;
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

            if (!int.TryParse(txtGuestCount.Text, out int guestCount) || guestCount > 1000)
            {
                MessageBox.Show("Guest count cannot exceed 1000.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stop further execution
            }

            string query = "SELECT * FROM Reservations WHERE ReservationID = @ReservationID";
            using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\vs\\FoodiePoint-Restaurant-Management\\Database\\FoodiePoint.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ReservationID", lblresID.Text);
                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0) // If ReservationID exists, UPDATE instead of INSERT
                    {
                        string updateQuery = "UPDATE Reservations SET ReservationType = @ResType, ReservationDate = @ResDate, GuestCount = @GuestCount WHERE ReservationID = @ReservationID";
                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                        {
                            updateCmd.Parameters.AddWithValue("@ReservationID", lblresID.Text);
                            updateCmd.Parameters.AddWithValue("@ResType", txtResType.Text);
                            updateCmd.Parameters.AddWithValue("@ResDate", txtResDate.Text);
                            updateCmd.Parameters.AddWithValue("@GuestCount", guestCount);

                            updateCmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Reservation updated successfully!", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    { // If ReservationID doesn't exist, INSERT a new reservation

                        currentReservation.ReservationDate = txtResDate.Text;
                        currentReservation.ReservationType = txtResType.Text;
                        currentReservation.GuestCount = int.Parse(txtGuestCount.Text);
                        currentReservation.UserID = "U001"; // Assign default user ID

                        // Save to database
                        SaveReservationToDatabase(currentReservation);

                        
                    }

                    this.Close();
                }
            }
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

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            Admin.View.frmUpdate obj1 = new Admin.View.frmUpdate();
            obj1.SetUser(_currentUser);
            this.Hide();
            obj1.ShowDialog();
            this.Show();
        }
    } 
}





