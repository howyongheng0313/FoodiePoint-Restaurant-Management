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

namespace Admin.View
{
    public partial class frmModifyM : Form
    {
        private DataTable managersTable;
        private string connectionString;

        public frmModifyM()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["FoodiePointDB"].ConnectionString;
            LoadManagers();
        }

        private void LoadManagers()
        {
            // Create DataTable to hold managers
            managersTable = new DataTable();

            // Connect to database and load managers (Role = 'Manager')
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT UserID, Username, FullName, Email FROM Users WHERE Role = 'Manager'";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.Fill(managersTable);
                }
            }

            dgvManagers.DataSource = managersTable;
            dgvManagers.Columns["UserID"].HeaderText = "ID";
            dgvManagers.Columns["Username"].HeaderText = "Username";
            dgvManagers.Columns["FullName"].HeaderText = "Full Name";
            dgvManagers.Columns["Email"].HeaderText = "Email";
            dgvManagers.AutoResizeColumns();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var signUpForm = new frmSignUp("Manager");
            if (signUpForm.ShowDialog() == DialogResult.OK)
            {
                LoadManagers();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvManagers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a manager to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the selected manager's UserID
            var cellValue = dgvManagers.SelectedRows[0].Cells["UserID"].Value;
            if (cellValue == null)
            {
                MessageBox.Show("The column selected cannot be empty.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string userID = cellValue.ToString();

            // Load the manager data
            LoginCredent manager = GetManagerByUserID(userID);
            if (manager != null)
            {
                var updateForm = new frmUpdate(true);
                updateForm.SetUser(manager);
                updateForm.UserUpdated += (s, updatedUser) => LoadManagers();
                updateForm.ShowDialog();
            }
        }

        private LoginCredent GetManagerByUserID(string userID)
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
            if (dgvManagers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a manager to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the selected manager's UserID
            string userID = null;
            if (dgvManagers.SelectedRows[0].Cells["UserID"].Value != null)
            {
                userID = dgvManagers.SelectedRows[0].Cells["UserID"].Value.ToString();
            }
            else
            {
                MessageBox.Show("The column selected cannot be empty.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string managerName = dgvManagers.SelectedRows[0].Cells["FullName"].Value.ToString();
            DialogResult result = MessageBox.Show($"Are you sure you want to delete manager {managerName}?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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
                                MessageBox.Show("Manager deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadManagers();
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete manager.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting manager: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            foreach (DataGridViewRow row in dgvManagers.Rows)
            {
                if (row.Cells["Username"].Value != null)
                {
                    string username = row.Cells["Username"].Value.ToString().ToLower();

                    if (username.Contains(searchText))
                    {
                        dgvManagers.ClearSelection();
                        row.Selected = true;
                        dgvManagers.FirstDisplayedScrollingRowIndex = row.Index;
                        foundMatch = true;
                        break;
                    }
                }
            }

            if (!foundMatch)
            {
                MessageBox.Show($"No manager with username containing '{searchText}' was found.", "No Match", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSearch.Text = string.Empty;
            }
        }
    }
}