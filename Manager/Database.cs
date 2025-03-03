using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodieUI
{
    internal class Database
    {
        private string connectionString;
        public Database()
        {
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\FoodieDb.mdf;Integrated Security=True";
        }

        public void AddItem(string id, string name, double price, string category)
        {
            string query = $"INSERT INTO Menu (ItemID, ItemName, ItemPrice, ItemCategory) VALUES ('{id}', '{name}', {price}, '{category}')";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
        }

        public void LoadData(DataGridView dataGridView)
        {
            string query = "SELECT * FROM Menu";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView.DataSource = table;
            }
        }
    }
}
