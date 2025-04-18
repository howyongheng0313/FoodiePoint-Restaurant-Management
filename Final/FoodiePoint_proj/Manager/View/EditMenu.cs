﻿using Admin.Presenter;
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
    public partial class EditMenu : System.Windows.Forms.Form, UserForm
    {
        Database db = new Database();
        Button bt;
        private LoginCredent _currentUser;
        public EditMenu()
        {
            InitializeComponent();
        }
        public void SetUser(LoginCredent user)
        {
            _currentUser = user;
            bt = new Button(_currentUser);
            label1.Text = $"Welcome, {_currentUser.FullName}";
        }

        private void EditMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'foodieDbDataSet.Menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter.Fill(this.foodieDbDataSet.Menu);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the index of the first selected row
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                // Use the selected row index to get the cell value
                itemIDtxt.Text = dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString();
                itemNametxt.Text = dataGridView1.Rows[selectedRowIndex].Cells[1].Value.ToString();
                itemPricetxt.Text = dataGridView1.Rows[selectedRowIndex].Cells[2].Value.ToString();
                itemCategorycmb.Text = dataGridView1.Rows[selectedRowIndex].Cells[3].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string id = itemIDtxt.Text;
                string name = itemNametxt.Text;
                double price = double.Parse(itemPricetxt.Text);
                string category = itemCategorycmb.Text;
                db.UpdateItem(id, name, price, category);
                db.LoadData(dataGridView1, "Menu");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = itemIDtxt.Text;
            db.DeleteItem(id);
            db.LoadData(dataGridView1, "Menu");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            bt.MainMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            bt.HallMgmt();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            bt.Reservations();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            bt.Profile();
        }

        public string[] Idarray = new string[0];

        public void Seend()
        {
            string id = itemIDtxt.Text;
            Array.Resize(ref Idarray, Idarray.Length + 1);
            Idarray[Idarray.Length - 1] = id;
            foreach (string item in Idarray)
            {
                MessageBox.Show(item);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Seend();

            //string id = itemIDtxt.Text;
            //Array.Resize(ref Idarray, Idarray.Length + 1);
            //Idarray[Idarray.Length - 1] = id;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            bt.MainMenu();
            this.Hide();
        }

        private void itemIDtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
