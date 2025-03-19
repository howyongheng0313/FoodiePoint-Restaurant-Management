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
    public partial class frmReservation : System.Windows.Forms.Form
    {
        Button bt = new Button();
        Database db = new Database();
        public frmReservation()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'foodieDbDataSet.Reservations' table. You can move, or remove it, as needed.
            this.reservationsTableAdapter.Fill(this.foodieDbDataSet.Reservations);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the index of the first selected row
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                // Use the selected row index to get the cell value
                rsvTxt.Text = dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString();
                hallIdTxt.Text = dataGridView1.Rows[selectedRowIndex].Cells[1].Value.ToString();
                userIdTxt.Text = dataGridView1.Rows[selectedRowIndex].Cells[2].Value.ToString();
                rsDateTxt.Text = dataGridView1.Rows[selectedRowIndex].Cells[3].Value.ToString();
                rsTypetxt.Text = dataGridView1.Rows[selectedRowIndex].Cells[4].Value.ToString();
                rsStatusCmb.Text = dataGridView1.Rows[selectedRowIndex].Cells[5].Value.ToString();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string rsid = rsvTxt.Text;
            string hallid = hallIdTxt.Text;
            string userid = userIdTxt.Text;
            DateTime rsdate = DateTime.Parse(rsDateTxt.Text);
            string rstype = rsTypetxt.Text;
            string rsstatus = rsStatusCmb.Text;
            db.UpdateReservation(rsid, hallid, userid, rsdate, rstype, rsstatus);
            db.LoadData(dataGridView1, "Reservations");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.DeleteReservation(rsvTxt.Text);
            db.LoadData(dataGridView1, "Reservations");
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

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void monthCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int month = 0;
            string monthname = monthCmbBox.Text;
            DateTime date = DateTime.ParseExact(monthname, "MMMM", System.Globalization.CultureInfo.InvariantCulture);
            month = date.Month;
            db.FilterMonth(dataGridView1, "Reservations", month);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            db.LoadData(dataGridView1, "Reservations");
        }
    }
}
