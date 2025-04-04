using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace FoodiePointManagementSystem.Database
{
    public class DatabaseHelper
    {
        private string connectionString;

        public DatabaseHelper()
        {
            // Get connection string from App.config
            connectionString = ConfigurationManager.ConnectionStrings["FoodiePointDB"].ConnectionString;
        }

        // Execute SQL query that returns data in the form of DataTable (SELECT)
        public DataTable ExecuteQuery(string query)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                DataTable dt = new DataTable();
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception error:" + ex.Message);
                }
                return dt;
            }
        }

        // Execute SQL query that does not return any data (INSERT, UPDATE, DELETE)
        public bool ExecuteNonQuery(string query)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SQL Execution Failure" + ex.Message);
                    return false;
                }
            }

            
        }
    }
}
