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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void MainMenu()
        {
            Form1 fm = new Form1();
            fm.StartPosition = FormStartPosition.Manual;
            fm.Location = this.Location;
            fm.Show();
            this.Hide();
        }
        public void HallMgmt()
        {
            Form2 fm2 = new Form2();
            fm2.StartPosition = FormStartPosition.Manual;
            fm2.Location = this.Location;
            fm2.Show();
            this.Hide();
        }
        public void Reservations()
        {
            Form3 fm3 = new Form3();
            fm3.StartPosition = FormStartPosition.Manual;
            fm3.Location = this.Location;
            fm3.Show();
            this.Hide();
        }
        public void Profile()
        {
            Form4 fm4 = new Form4();
            fm4.StartPosition = FormStartPosition.Manual;
            fm4.Location = this.Location;
            fm4.Show();
            this.Hide();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            MainMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            HallMgmt();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Reservations();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainMenu();
        }
    }
}
