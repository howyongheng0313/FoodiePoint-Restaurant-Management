using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reservation_Coordinator.Model;
using Reservation_Coordinator.Model.Item;

namespace Reservation_Coordinator.View
{
    public partial class frmSubReservationDetail: Form
    {
        private ItemReservation rev;
        private RequestHelper chatListHelper;

        public frmSubReservationDetail()
        {
            InitializeComponent();
        }

        public void SetRev(ItemReservation rev)
        {
            this.rev = rev;
            lblRevID.Text      = rev.ReservationID;
            lblStatus.Text     = rev.ReservationStatus;
            lblUserID.Text     = rev.UserID;
            lblFullName.Text   = rev.FullName;
            lblRevType.Text    = rev.ReservationType;
            lblGuestCount.Text = rev.GuestCount.ToString();
            lblDateTime.Text   = rev.ReservationDate.ToString();
            lblHallID.Text     = rev.HallID;
            lblHallName.Text   = rev.HallName;
        }

        private void frmSubReservationDetail_Load(object sender, EventArgs e)
        {
            chatListHelper = new RequestHelper(floChatList, txtChat, rev.ReservationID);
            chatListHelper.Refresh();
            chatListHelper.ChatTimer = true;
        }

        private void btnComfirm_Click(object sender, EventArgs e)
        {
            string result = rev.Confirm();
            if (result == null)
                lblStatus.Text = ItemReservation.Confirmed;
            else
                MessageBox.Show(result);
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            string result = rev.Complete();
            if (result == null)
                lblStatus.Text = ItemReservation.Completed;
            else
                MessageBox.Show(result);
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            string result = rev.Reject();
            if (result == null)
                lblStatus.Text = ItemReservation.Rejected;
            else
                MessageBox.Show(result);
        }

        private void btnMatch_Click(object sender, EventArgs e)
        {
            if (rev.ReservationStatus != ItemReservation.Pending && rev.ReservationStatus != ItemReservation.Confirmed)
            {
                MessageBox.Show("The current status is not allow to choose a hall.");
                return;
            }
            var pickerPage = new frmTinyHallPick();
            pickerPage.SetRev(rev);
            Jumper.Dive(pickerPage);

            lblHallID.Text = rev.HallID;
            lblHallName.Text = rev.HallName;
        }
    }
}
