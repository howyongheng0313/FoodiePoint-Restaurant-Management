using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reservation_Coordinator.Model.Item;

namespace Reservation_Coordinator.View
{
    public partial class pgeProfile: UserControl
    {
        private ItemUser user;

        public pgeProfile()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        public void SetUser(ItemUser user)
        {
            this.user = user;
            RenderInfo();
        }

        private void RenderInfo()
        {
            txtUserID.Text      = user.UserID;
            txtUsername.Text    = user.Username;
            txtNewPassword.Text = string.Empty;
            txtFullName.Text    = user.FullName;
            txtEmail.Text       = user.Email;
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
            if (txtUsername.Text != user.Username && ItemUser.ExistUsername(txtUsername.Text))
                txtUsername.Text = string.Empty;
            if (txtEmail.Text != user.Email && ItemUser.ExistUsername(txtEmail.Text))
                txtEmail.Text = string.Empty;
            if (new[] { txtUsername.Text, txtFullName.Text, txtEmail.Text }.Any(string.IsNullOrEmpty))
            {
                MessageBox.Show("Invalid Values.");
                return;
            }
            if (!(
                txtNewPassword.Text != string.Empty &&
                MessageBox.Show("Are you sure you want to change your password?", "Change Password", MessageBoxButtons.YesNo) == DialogResult.Yes
            ))
                txtNewPassword.Text = string.Empty;

            user.Update(txtUsername.Text, txtFullName.Text, txtEmail.Text, txtNewPassword.Text);
            RenderInfo();
        }

        private void btnCencel_Click(object sender, EventArgs e)
        {
            RenderInfo();
        }
    }
}
