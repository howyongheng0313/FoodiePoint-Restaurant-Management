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
        private Form1 f1;

        public Form3()
        {
            InitializeComponent();
            f1 = new Form1();

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

        }

        private void button8_Click(object sender, EventArgs e)
        {
            f1.HallMgmt();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            f1.MainMenu();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            f1.Reservations();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            f1.Profile();
            this.Hide();
        }
    }
}
