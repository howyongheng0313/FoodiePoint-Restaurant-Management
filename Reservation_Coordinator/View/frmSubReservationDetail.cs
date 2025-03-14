using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            chatListHelper.renderList();
        }
    }
}
