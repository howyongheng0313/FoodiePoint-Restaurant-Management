﻿using Customer.Presenter;
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
        //private SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\vs\\FoodiePoint-Restaurant-Management\\Database\\FoodiePoint.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");


        public frmHallReservation()
        {
            InitializeComponent();
            
        }
        private void frmHallReservation_Load(object sender, EventArgs e)
        {
            this.RefreshData();
        }

        public void RefreshData()
        {
            string query = "SELECT * FROM Reservations WHERE UserID = 'U001'";
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
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
            if (e.RowIndex >= 0) // Ensure the row index is valid
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];


                Reservation selectedReservation = new Reservation
                {
                    HallID = row.Cells["HallID"].Value.ToString(),
                    ReservationID = row.Cells["ReservationID"].Value.ToString(),
                    ReservationType = row.Cells["ReservationType"].Value.ToString(),
                    ReservationDate = row.Cells["ReservationDate"].Value.ToString(),
                    GuestCount = int.Parse(row.Cells["GuestCount"].Value.ToString()),
                    UserID = row.Cells["UserID"].Value.ToString(),
                    ReservationStatus = row.Cells["reservationStatus"].Value.ToString()
                };

                // Open frmBooking with the existing reservation
                frmBooking bookingForm = new frmBooking(selectedReservation);
                this.Hide();
                bookingForm.ShowDialog();
                this.RefreshData();
                this.Show();
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            frmCustomerMain obj1 = new frmCustomerMain();
            obj1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reservation newReservation = new Reservation
            {
                ReservationID = "",
                ReservationType = "",
                ReservationDate = "",
                HallID = "",
                GuestCount = 0,
                UserID = "U001",
                ReservationStatus = "Pending"
            };
            frmBooking bookingForm = new frmBooking(newReservation);
            this.Hide();
            bookingForm.ShowDialog();
            this.RefreshData();
            this.Show();
            
        }
    }
}
