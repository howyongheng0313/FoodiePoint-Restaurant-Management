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
using Reservation_Coordinator.Model;

namespace Reservation_Coordinator.View
{
    public partial class pgeViewRev: UserControl
    {
        private ReservationHelper dgvAllRevHelper;
        private NoticeHelper floNoticeHelper;

        public pgeViewRev()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void pgeViewRev_Load(object sender, EventArgs e)
        {
            floNoticeHelper = new NoticeHelper(floNotice);
            dgvAllRevHelper = new ReservationHelper(dgvAllRev);
            dgvAllRevHelper.Refresh();
            dgvAllRevHelper.RevTimer = true;

        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvAllRevHelper.Filter_Status(cmbStatus.Text);
        }

        private void txtRevID_TextChanged(object sender, EventArgs e)
        {
            dgvAllRevHelper.Filter_ID(txtRevID.Text);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            dgvAllRevHelper.Filter_Name(txtName.Text);
        }

        private void dgvAllRev_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string selectedID = dgvAllRev.Rows[e.RowIndex].Cells["Reservation ID"].Value.ToString();
            ItemReservation selectedRev = ItemReservation.GetByID(selectedID);

            if (selectedRev == null)
            {
                MessageBox.Show($"Cannot found the Reservation {selectedID}.");
                return;
            }
            var detailPage = new frmSubReservationDetail();
            detailPage.SetRev(selectedRev);

            Jumper.Dive(detailPage);
            dgvAllRevHelper.Refresh();
        }

        private void btnNotice_Click(object sender, EventArgs e)
        {
            floNotice.Visible = !floNotice.Visible;
            if (floNotice.Visible)
            {
                floNoticeHelper.Refresh();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAllRev.SelectedRows.Count < 1) return;
            DialogResult confirm = MessageBox.Show("Are you confirm to delete reservation?", "Delete Reservation", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.No) return;

            string selectedID = dgvAllRev.SelectedRows[0].Cells["Reservation ID"].Value.ToString();
            ItemReservation selectedRev = ItemReservation.GetByID(selectedID);

            if (selectedRev == null)
            {
                MessageBox.Show($"Cannot found the Reservation {selectedID}.");
                return;
            }
            selectedRev.Delete();
            dgvAllRevHelper.Refresh();
        }
    }
}
