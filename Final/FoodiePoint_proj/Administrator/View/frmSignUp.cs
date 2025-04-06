using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Admin.Presenter;

namespace Admin.View
{
    public partial class frmSignUp : Form
    {
        // Constructor with no parameters (for normal usage)
        public frmSignUp()
        {
            InitializeComponent();
            cmbRole.Items.Add("Customer");
            cmbRole.SelectedIndex = 0;
        }

        // Constructor with role parameter
        public frmSignUp(string role)
        {
            InitializeComponent();
            if (role == "Customer")
            {
                cmbRole.Items.Add("Customer");
                cmbRole.SelectedItem = "Customer";
            }

            if (role == "Manager")
            {
                cmbRole.Items.Add("Manager");
                cmbRole.SelectedItem = "Manager";
            }

            if (role == "Chef")
            {
                cmbRole.Items.Add("Chef");
                cmbRole.SelectedItem = "Chef";
            }

            if (role == "RC")
            {
                cmbRole.Items.Add("Reservation Coordinator");
                cmbRole.SelectedItem = "Reservation Coordinator";
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtConfirm.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtFullName.Text) ||
                cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtPassword.Text != txtConfirm.Text)
            {
                MessageBox.Show("Passwords do not match. Please confirm your password.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirm.Focus();
                return;
            }
            bool usernameExists = LoginCredent.ExistUsername(txtUsername.Text);
            if (usernameExists)
            {
                MessageBox.Show("Username already exists. Please choose another username.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Check if email already exists
            bool emailExists = LoginCredent.ExistEmail(txtEmail.Text);
            if (emailExists)
            {
                MessageBox.Show("Email already exists. Please use another email.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool success = RegisterHelper.RegisterNewUser(
                txtUsername.Text,
                txtPassword.Text,
                txtFullName.Text,
                txtEmail.Text,
                cmbRole.SelectedItem.ToString()
            );
            if (success)
            {
                MessageBox.Show("Registration successful! You can now log in.", "Registration Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to register user. Please try again.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}