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
    public partial class frmUpdate : Form
    {
        private LoginCredent user;
        private bool lockPassword = false;
        public delegate void UserUpdatedEventHandler(object sender, LoginCredent updatedUser);
        public event UserUpdatedEventHandler UserUpdated;

        public frmUpdate()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }
        public frmUpdate(bool lockPassword)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.lockPassword = lockPassword;
        }

        public void SetUser(LoginCredent user)
        {
            if (user == null)
            {
                MessageBox.Show("User data is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.user = user;
            RenderInfo();
            txtUserID.Enabled = false;

            if (lockPassword)
            {
                txtNewPassword.Enabled = false;
                txtNewPassword.BackColor = SystemColors.Control;
            }
        }

        private void RenderInfo()
        {
            txtUserID.Text = user.UserID;
            txtUsername.Text = user.Username;
            txtNewPassword.Text = string.Empty;
            txtFullName.Text = user.FullName;
            txtEmail.Text = user.Email;
        }

        private void EmptyCheck(TextBox txtbox)
        {
            if (txtbox.Text == string.Empty)
                txtbox.BackColor = Color.FromArgb(255, 192, 192);
            else
                txtbox.BackColor = Color.White;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            EmptyCheck(txtUsername);
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
            EmptyCheck(txtFullName);
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            EmptyCheck(txtEmail);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != user.Username && LoginCredent.ExistUsername(txtUsername.Text))
            {
                MessageBox.Show("Username already exists. Please choose another username.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Text = string.Empty;
                return;
            }

            if (txtEmail.Text != user.Email && LoginCredent.ExistEmail(txtEmail.Text))
            {
                MessageBox.Show("Email already exists. Please use another email.", "Duplicate Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Text = string.Empty;
                return;
            }

            if (new[] { txtUsername.Text, txtFullName.Text, txtEmail.Text }.Any(string.IsNullOrEmpty))
            {
                MessageBox.Show("Please fill in all required fields.", "Invalid Values", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newPassword = string.Empty;
            if (txtNewPassword.Text != string.Empty)
            {
                if (MessageBox.Show("Are you sure you want to change your password?", "Change Password", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    newPassword = txtNewPassword.Text;
                }
            }

            user.Update(txtUsername.Text, txtFullName.Text, txtEmail.Text, newPassword);
            RenderInfo();
            UserUpdated?.Invoke(this, user);
            MessageBox.Show("User information updated successfully!", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            RenderInfo();
            this.Close();
        }
    }
}