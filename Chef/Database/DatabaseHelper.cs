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
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\heeth\OneDrive - Asia Pacific University\Degree 1st Year (Sem 2)\Object-oriented\Chef\Chef\Database\FoodiePoint.mdf;Integrated Security=True";

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
            

        public int ExecuteNonQuery(string query)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    return cmd.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("SQL Execution Failure" + ex.Message);
                    return 0;
                }
            }
        }

            
        }
    }
}
