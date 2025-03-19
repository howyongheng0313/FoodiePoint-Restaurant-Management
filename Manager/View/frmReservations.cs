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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bt.HallMgmt();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            bt.Reservations();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            bt.Profile();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            db.SearchReservationType(dataGridView1, "Reservations", search);
        }
    }
}
