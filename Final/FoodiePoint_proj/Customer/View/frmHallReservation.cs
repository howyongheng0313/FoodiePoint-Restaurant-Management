using Admin.Presenter;
using Customer.Presenter;
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

namespace Customer
{
    public partial class frmHallReservation : Form, UserForm
    {
        private LoginCredent _currentUser;

        public frmHallReservation()
        {
            InitializeComponent();
            
        }
        public void SetUser(LoginCredent user)
        {
            _currentUser = user;
        }
        private void frmHallReservation_Load(object sender, EventArgs e)
        {
            this.RefreshData();
        }

        public void RefreshData()
        {
            string query = $"SELECT * FROM Reservations WHERE UserID = '{_currentUser.UserID}'";
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
            obj1.SetUser(_currentUser);
            Jumper.Shift(obj1);
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
                bookingForm.SetUser(_currentUser);
                Jumper.Dive(bookingForm);
                this.RefreshData();
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            frmCustomerMain obj1 = new frmCustomerMain();
            obj1.SetUser(_currentUser);
            Jumper.Shift(obj1);
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
                UserID = _currentUser.UserID,
                ReservationStatus = "Pending"
            };
            frmBooking bookingForm = new frmBooking(newReservation);
            bookingForm.SetUser(_currentUser);
            Jumper.Dive(bookingForm);
            this.RefreshData();
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            Admin.View.frmUpdate obj1 = new Admin.View.frmUpdate();
            obj1.SetUser(_currentUser);
            Jumper.Dive(obj1);
        }
    }
}
