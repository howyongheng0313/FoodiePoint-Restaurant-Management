using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Admin.Model
{
    public class SalesAnalytics
    {
        private readonly string _connectionString;

        public SalesAnalytics(string connectionString)
        {
            _connectionString = connectionString;
        }

        /// <summary>
        /// Gets the list of years for which sales data is available
        /// </summary>
        /// <returns>DataTable containing years</returns>
        public DataTable GetAvailableYears()
        {
            DataTable yearsTable = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();

                    string query = "SELECT DISTINCT YEAR([DateTime]) AS Year FROM [dbo].[Orders] ORDER BY Year DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(yearsTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving available years: " + ex.Message, ex);
            }

            return yearsTable;
        }

        /// <summary>
        /// Gets monthly sales data for a specific year
        /// </summary>
        /// <param name="year">The year to get sales data for</param>
        /// <returns>DataTable with Month and TotalSales columns</returns>
        public DataTable GetMonthlySalesData(int year)
        {
            DataTable salesData = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            MONTH([od].[DateTime]) AS [Month],
                            SUM([oi].[Quantity] * [mn].[ItemPrice]) AS [TotalSales]
                        FROM [dbo].[Orders] AS [od]
                        LEFT JOIN [dbo].[OrderItem] AS [oi] ON [od].[OrderID] = [oi].[OrderID]
                        LEFT JOIN [dbo].[Menu] AS [mn] ON [oi].[ItemID] = [mn].[ItemID]
                        WHERE YEAR([od].[DateTime]) = @Year
                        GROUP BY MONTH([od].[DateTime])
                        ORDER BY [Month]";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Year", year);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(salesData);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving monthly sales data: " + ex.Message, ex);
            }

            return salesData;
        }

        /// <summary>
        /// Gets sales data categorized by menu item categories for a specific year
        /// </summary>
        /// <param name="year">The year to get sales data for</param>
        /// <returns>DataTable with ItemCategory and TotalSales columns</returns>
        public DataTable GetCategorySalesData(int year)
        {
            DataTable categoryData = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            [mn].[ItemCategory],
                            SUM([oi].[Quantity] * [mn].[ItemPrice]) AS [TotalSales]
                        FROM [dbo].[Orders] AS [od]
                        LEFT JOIN [dbo].[OrderItem] AS [oi] ON [od].[OrderID] = [oi].[OrderID]
                        LEFT JOIN [dbo].[Menu] AS [mn] ON [oi].[ItemID] = [mn].[ItemID]
                        WHERE YEAR([od].[DateTime]) = @Year
                        GROUP BY [mn].[ItemCategory]
                        ORDER BY [TotalSales] DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Year", year);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(categoryData);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving category sales data: " + ex.Message, ex);
            }

            return categoryData;
        }
    }
}