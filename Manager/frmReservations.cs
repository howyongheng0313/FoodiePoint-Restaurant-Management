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

    public partial class frmReservations : Form
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
                DateTime rsdate = DateTime.Parse(rsDateTxt.Text);
                string rstype = rsTypetxt.Text;
                string rsstatus = rsStatusCmb.Text;
                db.AddReservation(rsid, hallid, userid, rsdate, rstype, rsstatus);
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
    }
}
