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

    public partial class Form3 : Form
    {
        Database db = new Database();
        Button button = new Button();

        public Form3()
        {
            InitializeComponent();
            InitializeComponent();
        }


        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'foodieDbDataSet.Reservations' table. You can move, or remove it, as needed.
            this.reservationsTableAdapter.Fill(this.foodieDbDataSet.Reservations);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button.HallMgmt();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button.MainMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button.Reservations();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button.Profile();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            button.MainMenu();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            button.Reservations();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            button.Profile();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            button.HallMgmt();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void chkinput()
        {
            if (rsvTxt.Text == "" || hallIdTxt.Text == "" || userIdTxt.Text == "" || rsDateTxt.Text == "" || rsTypetxt.Text == "" || rsStatusCmb.Text == "")
            {
                MessageBox.Show("Please enter all inputs.");
                return;
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            //chkinput();
            string ReservationID = rsvTxt.Text;
            string HallID = hallIdTxt.Text;
            string UserID = userIdTxt.Text;
            string ReservationDate = rsDateTxt.Text;
            string ReservationType = rsTypetxt.Text;
            string ReservationStatus = rsStatusCmb.Text;
            db.AddReservation(ReservationID, HallID, UserID, ReservationDate, ReservationType, ReservationStatus);
            db.LoadData(dataGridView1, "Reservations");
        }
        EditMenu edm = new EditMenu();
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpdateListBox()
        {
            listBox1.Items.Clear();
            foreach (string item in edm.Idarray)
            {
                MessageBox.Show(item);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            UpdateListBox();
        }
    }
}
