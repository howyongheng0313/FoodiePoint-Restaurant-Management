using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Windows.Forms;


namespace Customer.Presenter
{
    class OrderFood
    {
        private DatabaseHelper dbHelper;
        

        public OrderFood()
        {
            dbHelper = new DatabaseHelper();
        }
        public static void dlt_rowitem(DataGridView dgv)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgv.SelectedRows)
                {
                    dgv.Rows.Remove(row); 
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static void add_oneitem(DataGridView dgv)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgv.SelectedRows)
                {
                    int currentQty = Convert.ToInt32(row.Cells["Quantity"].Value);
                    row.Cells["Quantity"].Value = currentQty + 1; 
                }
             
            }
            else
            {
                MessageBox.Show("Please select a row before adding the quantity...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static void dlt_oneitem(DataGridView dgv)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgv.SelectedRows)
                {
                    int currentQty = Convert.ToInt32(row.Cells["Quantity"].Value);
                    row.Cells["Quantity"].Value = currentQty - 1; 
                }
            }
            else
            {
                MessageBox.Show("Please select a row before deleting the quantity...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //public DataTable GetAllItem()
            //{
            //    string query = "SELECT * FROM Menu";
            //    return dbHelper.ExecuteQuery(query);
            //}

            //public DataTable searchItem(string searchItemName)
            //{
            //    string query = $"SELECT * FROM Menu WHERE ItemName = '{searchItemName}' " ;
            //    return dbHelper.ExecuteQuery(query);
            //}

            //public bool addItem()
            //{
            //    string query = "";
            //    return ;
            //}

            //public bool editItem()
            //{
            //    string query = "UPDATE";
            //    return;
            //}

            //public bool deleteItem()
            //{
            //    string query = "DELETE FROM Menu WHERE ItemName = ";
            //    return;
            //}
        }
    }
}

