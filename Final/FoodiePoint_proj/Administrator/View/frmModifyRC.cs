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
using Admin.Presenter;
using Reservation_Coordinator.Model;

namespace Admin.View
{
    public partial class frmModifyRC : Form
    {
        private DataTable RCsTable;
        private string connectionString;

        public frmModifyRC()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["FoodiePointDB"].ConnectionString;
            LoadRCs();
        }

        private void LoadRCs()
        {
            RCsTable = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT UserID, Username, FullName, Email FROM Users WHERE Role = 'Reservation Coordinator'";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.Fill(RCsTable);
                }
            }

            dgvRCs.DataSource = RCsTable;
            dgvRCs.Columns["UserID"].HeaderText = "ID";
            dgvRCs.Columns["Username"].HeaderText = "Username";
            dgvRCs.Columns["FullName"].HeaderText = "Full Name";
            dgvRCs.Columns["Email"].HeaderText = "Email";
            dgvRCs.AutoResizeColumns();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var signUpForm = new frmSignUp("RC");
            if (Jumper.Dive(signUpForm) == DialogResult.OK)
            {
                LoadRCs();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvRCs.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a Reservation Coordinator to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var cellValue = dgvRCs.SelectedRows[0].Cells["UserID"].Value;
            if (cellValue == null)
            {
                MessageBox.Show("The column selected cannot be empty.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string userID = cellValue.ToString();

            // Load the manager data
            LoginCredent RC = GetRCByUserID(userID);
            if (RC != null)
            {
                var updateForm = new frmUpdate(true);
                updateForm.SetUser(RC);
                updateForm.UserUpdated += (s, updatedUser) => LoadRCs();
                Jumper.Dive(updateForm);
            }
        }

        private LoginCredent GetRCByUserID(string userID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT UserID, Username, Password, FullName, Email, Role FROM Users WHERE UserID = @UserID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new LoginCredent(
                                reader["UserID"].ToString(),
                                reader["Username"].ToString(),
                                reader["Password"].ToString(),
                                reader["FullName"].ToString(),
                                reader["Email"].ToString(),
                                reader["Role"].ToString()
                            );
                        }
                    }
                }
            }
            return null;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvRCs.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a reservation coordinator to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string userID = null;
            if (dgvRCs.SelectedRows[0].Cells["UserID"].Value != null)
            {
                userID = dgvRCs.SelectedRows[0].Cells["UserID"].Value.ToString();
            }
            else
            {
                MessageBox.Show("The column selected cannot be empty.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string RCName = dgvRCs.SelectedRows[0].Cells["FullName"].Value.ToString();
            DialogResult result = MessageBox.Show($"Are you sure you want to delete reservation coordinator {RCName}?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM Users WHERE UserID = @UserID";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@UserID", userID);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Reservation coordinator deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadRCs();
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete reservation coordinator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting reservation coordinator: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void picLogo_Click(object sender, EventArgs e)
        {
            var mainForm = new frmDashboard();
            this.Close();
        }

        private void picSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter a search term.", "Empty Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool foundMatch = false;

            foreach (DataGridViewRow row in dgvRCs.Rows)
            {
                if (row.Cells["Username"].Value != null)
                {
                    string username = row.Cells["Username"].Value.ToString().ToLower();

                    if (username.Contains(searchText))
                    {
                        dgvRCs.ClearSelection();
                        row.Selected = true;
                        dgvRCs.FirstDisplayedScrollingRowIndex = row.Index;
                        foundMatch = true;
                        break;
                    }
                }
            }

            if (!foundMatch)
            {
                MessageBox.Show($"No reservation coordinator with username containing '{searchText}' was found.", "No Match", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSearch.Text = string.Empty;
            }
        }
    }
}