using Reservation_Coordinator.Model.Item;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservation_Coordinator.View
{
    public partial class frmTinyHallPick: Form
    {
        private HallHelper dgvHallHelper;
        private ItemReservation rev;

        public frmTinyHallPick()
        {
            InitializeComponent();
        }

        public void SetRev(ItemReservation rev)
        {
            this.rev = rev;
        }

        private void frmTinyHallPick_Load(object sender, EventArgs e)
        {
            dgvHallHelper = new HallHelper(dgvHallList, rev.GuestCount, rev.HallID);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (rev.ReservationStatus != ItemReservation.Pending)
            {
                MessageBox.Show("The current status is not allow to clear reserved hall.");
                return;
            }

            string result = rev.UpdateHall(null);
            if (result == null)
                this.Close();
            else
                MessageBox.Show(result);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvHallList.SelectedRows.Count != 1) return;
            string selectID = dgvHallList.SelectedRows[0].Cells[0].Value.ToString();
            if (selectID == rev.HallID) return;

            string result = rev.UpdateHall(selectID);
            if (result == null)
                this.Close();
            else
                MessageBox.Show(result);
        }
    }
}
