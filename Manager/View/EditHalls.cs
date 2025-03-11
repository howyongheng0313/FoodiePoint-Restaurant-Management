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
    public partial class EditHalls : System.Windows.Forms.Form
    {
        Database db = new Database();
        public EditHalls()
        {
            InitializeComponent();
        }

        private void EditHalls_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'foodieDbDataSet.Halls' table. You can move, or remove it, as needed.
            this.hallsTableAdapter.Fill(this.foodieDbDataSet.Halls);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the index of the first selected row
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                // Use the selected row index to get the cell value
                hallIdTxt.Text = dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString();
                hallNametxt.Text = dataGridView1.Rows[selectedRowIndex].Cells[1].Value.ToString();
                hallPartyTypeTxt.Text = dataGridView1.Rows[selectedRowIndex].Cells[2].Value.ToString();
                hallCapacityTxt.Text = dataGridView1.Rows[selectedRowIndex].Cells[3].Value.ToString();
                availabilityCmb.Text = dataGridView1.Rows[selectedRowIndex].Cells[4].Value.ToString();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string hallid = hallIdTxt.Text;
            string hallname = hallNametxt.Text;
            string halltype = hallPartyTypeTxt.Text;
            int capacity = int.Parse(hallCapacityTxt.Text);
            string availability = availabilityCmb.Text;
            db.UpdateHall(hallid, hallname, halltype, capacity, availability);
            db.LoadData(dataGridView1, "Halls");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hallid = hallIdTxt.Text;
            db.DeleteHall(hallid);
            db.LoadData(dataGridView1, "Halls");
        }
    }
    
}

