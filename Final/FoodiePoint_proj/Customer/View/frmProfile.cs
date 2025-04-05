using Admin.Presenter;
using Customer;
using Reservation_Coordinator.Model;
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
    public partial class frmCustomerMain : Form, UserForm
    {

        private string connectionString = ConfigurationManager.ConnectionStrings["FoodiePointDB"].ToString();
        private LoginCredent _currentUser;

        public frmCustomerMain()
        {
            InitializeComponent();
        }

        public void SetUser(LoginCredent user)
        {
            _currentUser = user;
        }

        private void btnCustomerToMenu_Click(object sender, EventArgs e)
        {
            frmMenuPage obj1 = new frmMenuPage();
            obj1.SetUser(_currentUser);
            Jumper.Shift(obj1);
        }

        private void btnCustomerToHallReservation_Click(object sender, EventArgs e)
        {
            frmHallReservation obj1 = new frmHallReservation();
            obj1.SetUser(_currentUser);
            Jumper.Shift(obj1);
        }

        private void frmCustomerMain_Load(object sender, EventArgs e)
        {
        }

        private void btnSendFeedback_Click(object sender, EventArgs e)
        {
            //string userID = tbxUsername.Text;
            //string userpass = tbxPassword.Text;
            string feedbacks = rtbxFeedback.Text;
            string rating = cmbRating.Text;

            if (string.IsNullOrEmpty(feedbacks) || string.IsNullOrEmpty(rating)) //string.IsNullOrEmpty(userID) || string.IsNullOrEmpty(userpass) ||
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string query = "INSERT INTO Feedbacks (UserID, Feedback, Rating) " + 
                           "VALUES (@UserID, @Feedback, @Rating)";
            using (SqlConnection conn = new SqlConnection(connectionString))          //^^ ensure the 3 variables goes to Request table
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Feedback", feedbacks);
                        cmd.Parameters.AddWithValue("@UserID", _currentUser.UserID);
                        cmd.Parameters.AddWithValue("@Rating", int.Parse(rating));

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

        private void lblFeedback_Click(object sender, EventArgs e)
        {

        }

        private void rtbxFeedback_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            Admin.View.frmUpdate obj1 = new Admin.View.frmUpdate();
            obj1.SetUser(_currentUser);
            Jumper.Dive(obj1);
        }
    }
}
