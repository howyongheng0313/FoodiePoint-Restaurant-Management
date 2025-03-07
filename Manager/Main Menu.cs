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
    public partial class Main_Menu : Form
    {
        Button button = new Button();
        private DataTable menuDataTable;

        Database db = new Database();
        public Main_Menu()
        {
            InitializeComponent();
            //this.Resize += new EventHandler(Form_Resize);
            //initialFormWidth = this.Width;
            //initialFormHeight = this.Height;
            //initialFontSize = this.Font.Size;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button10_Click(object sender, EventArgs e)
        {
            button.Profile();
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'foodieDbDataSet.Menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter.Fill(this.foodieDbDataSet.Menu);
        }

        //private void Form_Resize(object sender, EventArgs e)
        //{
        //    float scaleFactorWidth = this.Width / initialFormWidth;
        //    float scaleFactorHeight = this.Height / initialFormHeight;
        //    float scaleFactor = Math.Min(scaleFactorWidth, scaleFactorHeight);

        //    float newFontSize = initialFontSize * scaleFactor;

        //    // Ensure the new font size is valid
        //    if (newFontSize > 0)
        //    {
        //        this.Font = new Font(this.Font.FontFamily, newFontSize);
        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void MenuItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string x = itemIDtxt.Text;
                string name = itemNametxt.Text;
                double price = double.Parse(itemPricetxt.Text);
                string category = itemCategorycmb.Text;
                db.AddItem(x, name, price, category);
                db.LoadData(dataGridViewMenu, "Menu");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button.EditMenu();
        }
    }
}
