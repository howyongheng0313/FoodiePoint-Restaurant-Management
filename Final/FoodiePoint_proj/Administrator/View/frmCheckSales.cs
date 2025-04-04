using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Admin.Model;

namespace Admin.View
{
    public partial class frmCheckSales : Form
    {
        private string connectionString;
        private SalesAnalytics _salesAnalytics;

        public frmCheckSales()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["FoodiePointDB"].ConnectionString;
            _salesAnalytics = new SalesAnalytics(connectionString);
            LoadYears();
        }

        private void LoadYears()
        {
            try
            {
                DataTable yearsTable = _salesAnalytics.GetAvailableYears();

                cmbYear.Items.Clear();
                foreach (DataRow row in yearsTable.Rows)
                {
                    cmbYear.Items.Add(row["Year"].ToString());
                }

                // Select the current year by default if available
                if (cmbYear.Items.Count > 0)
                {
                    cmbYear.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading years: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (cmbYear.SelectedItem == null)
            {
                MessageBox.Show("Please select a year first!", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedYear = int.Parse(cmbYear.SelectedItem.ToString());
            GenerateMonthlySalesChart(selectedYear);
        }

        private void GenerateMonthlySalesChart(int year)
        {
            try
            {
                DataTable salesData = _salesAnalytics.GetMonthlySalesData(year);

                // Clear existing series and points
                chartReport.Series.Clear();
                chartReport.ChartAreas.Clear();
                chartReport.Titles.Clear();

                // Add chart area
                ChartArea chartArea = new ChartArea("SalesChartArea");
                chartReport.ChartAreas.Add(chartArea);

                // Create series for the chart
                Series salesSeries = new Series("MonthlySales");
                salesSeries.ChartType = SeriesChartType.Column;
                salesSeries.Color = Color.SteelBlue;

                // Add the series to the chart
                chartReport.Series.Add(salesSeries);

                // Prepare data for all 12 months (including months with zero sales)
                string[] monthNames = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
                decimal[] monthlySales = new decimal[12];

                // Initialize with zeros
                for (int i = 0; i < 12; i++)
                {
                    monthlySales[i] = 0;
                }

                // Fill in the actual sales data
                foreach (DataRow row in salesData.Rows)
                {
                    int month = Convert.ToInt32(row["Month"]);
                    decimal sales = Convert.ToDecimal(row["TotalSales"]);

                    if (month >= 1 && month <= 12)
                    {
                        monthlySales[month - 1] = sales;
                    }
                }

                // Add the data points to the series
                for (int i = 0; i < 12; i++)
                {
                    DataPoint point = new DataPoint();
                    point.AxisLabel = monthNames[i];
                    point.YValues = new double[] { Convert.ToDouble(monthlySales[i]) };
                    salesSeries.Points.Add(point);
                }

                // Set chart title
                Title title = new Title($"Monthly Sales for {year}", Docking.Top);
                title.Font = new Font("Arial", 14, FontStyle.Bold);
                chartReport.Titles.Add(title);

                // Configure X-axis
                chartArea.AxisX.Title = "Month";
                chartArea.AxisX.TitleFont = new Font("Arial", 10, FontStyle.Bold);

                // Configure Y-axis
                chartArea.AxisY.Title = "Total Sales ($)";
                chartArea.AxisY.TitleFont = new Font("Arial", 10, FontStyle.Bold);
                chartArea.AxisY.LabelStyle.Format = "C0"; // Currency format without decimal places

                // Refresh the chart
                chartReport.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating monthly sales chart: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            if (cmbYear.SelectedItem == null)
            {
                MessageBox.Show("Please select a year first!", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedYear = int.Parse(cmbYear.SelectedItem.ToString());
            GenerateCategorySalesChart(selectedYear);
        }

        private void GenerateCategorySalesChart(int year)
        {
            try
            {
                DataTable categoryData = _salesAnalytics.GetCategorySalesData(year);

                if (categoryData.Rows.Count == 0)
                {
                    MessageBox.Show("No sales data available for the selected year.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Clear existing series and points
                chartReport.Series.Clear();
                chartReport.ChartAreas.Clear();
                chartReport.Titles.Clear();

                // Add chart area
                ChartArea chartArea = new ChartArea("CategoryChartArea");
                chartReport.ChartAreas.Add(chartArea);

                // Create series for the chart
                Series categorySeries = new Series("CategorySales");
                categorySeries.ChartType = SeriesChartType.Column;
                categorySeries.Color = Color.ForestGreen;

                // Add the series to the chart
                chartReport.Series.Add(categorySeries);

                // Add data points for each category
                foreach (DataRow row in categoryData.Rows)
                {
                    string category = row["ItemCategory"].ToString();
                    decimal sales = Convert.ToDecimal(row["TotalSales"]);

                    DataPoint point = new DataPoint();
                    point.AxisLabel = category;
                    point.YValues = new double[] { Convert.ToDouble(sales) };
                    categorySeries.Points.Add(point);

                    // Add data label to show the value on each bar
                    point.Label = sales.ToString("C0");
                    point.LabelForeColor = Color.Black;
                }

                // Set chart title
                Title title = new Title($"Sales by Category for {year}", Docking.Top);
                title.Font = new Font("Arial", 14, FontStyle.Bold);
                chartReport.Titles.Add(title);

                // Configure X-axis
                chartArea.AxisX.Title = "Category";
                chartArea.AxisX.TitleFont = new Font("Arial", 10, FontStyle.Bold);
                chartArea.AxisX.Interval = 1;
                chartArea.AxisX.LabelStyle.Angle = -45; // Angle the category names for better readability
                chartArea.AxisX.LabelStyle.Font = new Font("Arial", 8);

                // Configure Y-axis
                chartArea.AxisY.Title = "Total Sales ($)";
                chartArea.AxisY.TitleFont = new Font("Arial", 10, FontStyle.Bold);
                chartArea.AxisY.LabelStyle.Format = "C0"; // Currency format without decimal places

                // Add some visual enhancements
                chartArea.BackColor = Color.WhiteSmoke;
                categorySeries.BorderWidth = 1;
                categorySeries.BorderColor = Color.DarkGray;

                // Set the maximum number of vertical grid lines
                chartArea.AxisX.MajorGrid.Interval = 1;

                // Refresh the chart
                chartReport.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating category sales chart: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            var mainForm = new frmDashboard();
            this.Close();
        }
    }
}