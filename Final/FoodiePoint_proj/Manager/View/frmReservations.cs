using Admin.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager
{

    public partial class frmReservations : System.Windows.Forms.Form, UserForm
    {
        Database db = new Database();
        Button bt;
        private LoginCredent _currentUser;

        public frmReservations()
        {
            InitializeComponent();
        }
        public void SetUser(LoginCredent user)
        {
            _currentUser = user;
            bt = new Button(_currentUser);
            label1.Text = $"Welcome, {_currentUser.FullName}";
        }

        private void frmRseservations_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'foodieDbDataSet.Reservations' table. You can move, or remove it, as needed.
            this.reservationsTableAdapter.Fill(this.foodieDbDataSet.Reservations);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            db.LoadData(dataGridView1, "Reservations");
            txtHallID.Clear();
            txtUserID.Clear();
            txtReservationID.Clear();
            txtStatus.Clear();
            txtSearch.Clear();
        }

        private void monthCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int month = 0;
            string monthname = monthCmbBox.Text;
            DateTime date = DateTime.ParseExact(monthname, "MMMM", System.Globalization.CultureInfo.InvariantCulture);
            month = date.Month;
            db.FilterMonth(dataGridView1, "Reservations", month);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            bt.MainMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            bt.HallMgmt();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            bt.Reservations();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            bt.Profile();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string searchid = txtReservationID.Text;
            db.SearchReservationID(dataGridView1, "Reservations", searchid);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string searchhallid = txtHallID.Text;
            db.SearchHallID(dataGridView1, "Reservations", searchhallid);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string searchuserid = txtUserID.Text;
            db.SearchUserID(dataGridView1, "Reservations", searchuserid);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string searchtype = txtSearch.Text;
            db.SearchReservationType(dataGridView1, "Reservations", searchtype);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string searchstatus = txtStatus.Text;
            db.SearchReservationStatus(dataGridView1, "Reservations", searchstatus);
        }
    }
}
