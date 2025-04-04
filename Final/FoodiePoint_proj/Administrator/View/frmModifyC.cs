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
    public partial class frmModifyC : Form
    {
        private DataTable CsTable;
        private string connectionString;

        public frmModifyC()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["FoodiePointDB"].ConnectionString;
            LoadCs();
        }

        private void LoadCs()
        {
            CsTable = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT UserID, Username, FullName, Email FROM Users WHERE Role = 'Customer'";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.Fill(CsTable);
                }
            }

            dgvCs.DataSource = CsTable;
            dgvCs.Columns["UserID"].HeaderText = "ID";
            dgvCs.Columns["Username"].HeaderText = "Username";
            dgvCs.Columns["FullName"].HeaderText = "Full Name";
            dgvCs.Columns["Email"].HeaderText = "Email";
            dgvCs.AutoResizeColumns();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var signUpForm = new frmSignUp("Customer");
            if (signUpForm.ShowDialog() == DialogResult.OK)
            {
                LoadCs();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvCs.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a Customer to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var cellValue = dgvCs.SelectedRows[0].Cells["UserID"].Value;
            if (cellValue == null)
            {
                MessageBox.Show("The column selected cannot be empty.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string userID = cellValue.ToString();

            LoginCredent customer = GetCustomerByUserID(userID);
            if (customer != null)
            {
                var updateForm = new frmUpdate(true);
                updateForm.SetUser(customer);
                updateForm.UserUpdated += (s, updatedUser) => LoadCs();
                updateForm.ShowDialog();
            }
        }

        private LoginCredent GetCustomerByUserID(string userID)
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
            if (dgvCs.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string userID = null;
            if (dgvCs.SelectedRows[0].Cells["UserID"].Value != null)
            {
                userID = dgvCs.SelectedRows[0].Cells["UserID"].Value.ToString();
            }
            else
            {
                MessageBox.Show("The column selected cannot be empty.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string CustomerName = dgvCs.SelectedRows[0].Cells["FullName"].Value.ToString();
            DialogResult result = MessageBox.Show($"Are you sure you want to delete customer {CustomerName}?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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
                                MessageBox.Show("Customer deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadCs();
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            foreach (DataGridViewRow row in dgvCs.Rows)
            {
                if (row.Cells["Username"].Value != null)
                {
                    string username = row.Cells["Username"].Value.ToString().ToLower();

                    if (username.Contains(searchText))
                    {
                        dgvCs.ClearSelection();
                        row.Selected = true;
                        dgvCs.FirstDisplayedScrollingRowIndex = row.Index;
                        foundMatch = true;
                        break;
                    }
                }
            }

            if (!foundMatch)
            {
                MessageBox.Show($"No customer with username containing '{searchText}' was found.", "No Match", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSearch.Text = string.Empty;
            }
        }
    }
}