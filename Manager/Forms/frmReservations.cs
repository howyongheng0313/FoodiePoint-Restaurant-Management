using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodieUI
{

    public partial class frmReservations : System.Windows.Forms.Form
    {
        Database db = new Database();
        Button bt = new Button();
        public frmReservations()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmRseservations_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'foodieDbDataSet.Reservations' table. You can move, or remove it, as needed.
            this.reservationsTableAdapter.Fill(this.foodieDbDataSet.Reservations);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string rsid = rsvTxt.Text;
                string hallid = hallIdTxt.Text;
                string userid = userIdTxt.Text;
                DateTime rsdate = dateTimePicker1.Value;
                string formattedDate = rsdate.ToString("MM/dd/yyyy");
                string rstype = rsTypetxt.Text;
                string rsstatus = rsStatusCmb.Text;
                db.AddReservation(rsid, hallid, userid, formattedDate, rstype, rsstatus);
                db.LoadData(dataGridView1, "Reservations");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bt.EditReservations();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void rsTypetxt_TextChanged(object sender, EventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)
        {
            db.LoadData(dataGridView1, "Reservations");
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
            bt.MainMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bt.HallMgmt();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            bt.Reservations();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            bt.Profile();
        }
    }
}
