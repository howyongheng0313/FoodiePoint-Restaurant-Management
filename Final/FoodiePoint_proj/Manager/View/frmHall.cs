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
    public partial class frmHall : Form, UserForm
    {
        Button button;
        Database db = new Database();
        string HallID;
        private LoginCredent _currentUser;

        public frmHall()
        {
            InitializeComponent();
            this.Shown += new EventHandler(initializeHallID);
        }
        public void SetUser(LoginCredent user)
        {
            _currentUser = user;
            button = new Button(_currentUser);
            label1.Text = $"Welcome, {_currentUser.FullName}";
        }
        private void initializeHallID(object sender, EventArgs e)
        {
            int rows = dataGridViewHall.Rows.Count;
            string row = rows.ToString("D2");
            HallID = $"H{row}";
            lblHallID.Text = HallID;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            button.MainMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            button.HallMgmt();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            button.Reservations();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button.Profile();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'foodieDbDataSet.Halls' table. You can move, or remove it, as needed.
            this.hallsTableAdapter.Fill(this.foodieDbDataSet.Halls);

        }

        private void hallIdTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string HallName = hallNametxt.Text;
                string HallPartyType = hallPartyTypeTxt.Text;
                int HallCapacity = int.Parse(hallCapacityTxt.Text);
                string Availability = availabilityCmb.Text;
                db.AddHall(HallName, HallPartyType, HallCapacity, Availability);
                db.LoadData(dataGridViewHall, "Halls");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            button.EditHall();
        }

        private void dataGridViewHall_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
