﻿using Customer;
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
            frmHallReservation obj1 = new frmHallReservation();
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
            string feedbacks = rtbxFeedback.Text;

            if (string.IsNullOrEmpty(feedbacks)) //string.IsNullOrEmpty(userID) || string.IsNullOrEmpty(userpass) ||
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string query = "INSERT INTO Feedbacks (FeedbackID) " + 
                           "VALUES (@Feedback)";
            using (SqlConnection conn = new SqlConnection(connectionString))          //^^ ensure the 3 variables goes to Request table
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Feedback", feedbacks);
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

        private void lblFeedback_Click(object sender, EventArgs e)
        {

        }

        private void rtbxFeedback_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {

        }
    }
}
