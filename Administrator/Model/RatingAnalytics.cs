using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Admin.Model
{
    public class RatingAnalytics
    {
        private readonly string connectionString;

        public RatingAnalytics()
        {
            connectionString = ConfigurationManager.ConnectionStrings["FoodiePoint"].ConnectionString;
        }
        public decimal CalculateAverageRating()
        {
            decimal averageRating = 0;


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT AVG(CAST(Rating AS DECIMAL(10,1))) FROM Feedbacks";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        averageRating = Math.Round(Convert.ToDecimal(result), 1);
                    }
                }
            }
            return averageRating;
        }
        public string GetFormattedAverageRating()
        {
            decimal rating = CalculateAverageRating();
            return $"{rating:0.0} ⭐";
        }
    }
}