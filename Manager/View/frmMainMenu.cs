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
    public partial class Main_Menu : System.Windows.Forms.Form
    {
        Button button = new Button();

        Database db = new Database();
        string FoodID;
        public Main_Menu()
        {
            InitializeComponent();
            this.Shown += new EventHandler(initializeFoodItemID);
        }
        private void initializeFoodItemID(object sender, EventArgs e)
        {
            int rows = dataGridViewMenu.Rows.Count+1;
   
            string row = rows.ToString("D3");
            FoodID = $"I{row}";
            lblItemID.Text = FoodID;
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
                string name = itemNametxt.Text;
                double price = double.Parse(itemPricetxt.Text);
                string category = itemCategorycmb.Text;
                db.AddItem(name, price, category);
                db.LoadData(dataGridViewMenu, "Menu");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.button2.Click += new EventHandler(this.initializeFoodItemID);
        }

        private void dataGridViewMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button.EditMenu();
        }

        private void itemIDtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
