using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Admin.Model;

namespace Admin.View
{
    public partial class frmFeedbacks : Form
    {
        private string connectionString;
        private RatingAnalytics ratingAnalytics;
        public frmFeedbacks()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["FoodiePointDB"].ConnectionString;
            ratingAnalytics = new RatingAnalytics();
            LoadFeedbacks();
            UpdateAverageRatingDisplay();
        }

        private void frmFeedbacks_Load(object sender, EventArgs e)
        {
            LoadFeedbacks();
            UpdateAverageRatingDisplay();
        }
        private void UpdateAverageRatingDisplay()
        {
            lblAveRating.Text = ratingAnalytics.GetFormattedAverageRating();
        }

        private void LoadFeedbacks(string sortCondition = "")
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT FeedbackID, UserID, Feedback, Rating FROM Feedbacks";

                    // Add sorting condition if provided
                    if (!string.IsNullOrEmpty(sortCondition))
                    {
                        query += sortCondition;
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvFeedbacks.DataSource = dataTable;
                    FormatDataGridView();
                    UpdateAverageRatingDisplay();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading feedbacks: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatDataGridView()
        {
            // Set column headers and other formatting
            if (dgvFeedbacks.Columns.Count > 0)
            {
                dgvFeedbacks.Columns["FeedbackID"].HeaderText = "Feedback ID";
                dgvFeedbacks.Columns["UserID"].HeaderText = "User ID";
                dgvFeedbacks.Columns["Feedback"].HeaderText = "Feedback";
                dgvFeedbacks.Columns["Rating"].HeaderText = "Rating (★)";
                dgvFeedbacks.AutoResizeColumns();
            }
        }

        private void btn1star_Click(object sender, EventArgs e)
        {
            LoadFeedbacks(" WHERE Rating = 1 ORDER BY Rating ASC");
        }

        private void btn2star_Click(object sender, EventArgs e)
        {
            LoadFeedbacks(" WHERE Rating = 2 ORDER BY Rating ASC");
        }

        private void btn3star_Click(object sender, EventArgs e)
        {
            LoadFeedbacks(" WHERE Rating = 3 ORDER BY Rating ASC");
        }

        private void btn4star_Click(object sender, EventArgs e)
        {
            LoadFeedbacks(" WHERE Rating = 4 ORDER BY Rating ASC");
        }

        private void btn5star_Click(object sender, EventArgs e)
        {
            LoadFeedbacks(" WHERE Rating = 5 ORDER BY Rating ASC");
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            LoadFeedbacks();
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvFeedbacks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


