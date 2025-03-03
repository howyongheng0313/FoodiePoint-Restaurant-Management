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
    public partial class Form4 : Form
    {
        Button button = new Button();
        public Form4()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            button.Reservations();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button.MainMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button.HallMgmt();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button.Profile();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
