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
        Button button = new Button();
        public Form1()
        {
            InitializeComponent();
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
            button.MainMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button.HallMgmt();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button.Reservations();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button.MainMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button.Profile();
        }
    }
}
