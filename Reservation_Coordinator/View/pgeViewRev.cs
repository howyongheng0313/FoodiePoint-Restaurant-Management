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

        public pgeViewRev()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void pgeViewRev_Load(object sender, EventArgs e)
        {
            dgvAllRevHelper = new ReservationHelper(dgvAllRev);
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
    }
}
