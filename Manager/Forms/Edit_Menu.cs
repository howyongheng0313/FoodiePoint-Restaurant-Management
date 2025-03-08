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
    public partial class Edit_Menu : System.Windows.Forms.Form
    {
        Database db = new Database();
        public Edit_Menu()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Edit_Menu_Load(object sender, EventArgs e)
        {
            // Load data into the DataGridView
            this.menuTableAdapter.Fill(this.foodieDbDataSet.Menu);
        }



        private void dataGridViewMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow row = this.dataGridViewMenu.Rows[e.RowIndex];   
            //    itemIDtxt.Text = e.RowIndex.ToString();
            //    itemNametxt.Text = e.RowIndex.ToString();
            //    itemPricetxt.Text = e.RowIndex.ToString();
            //    itemCategorycmb.Text = e.RowIndex.ToString();
            //}
        }

        private void dataGridViewMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
