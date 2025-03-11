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
    public partial class pgeViewRev: UserControl
    {
        private DgvReservationHelper dgvAllRevHelper;

        public pgeViewRev()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void pgeViewRev_Load(object sender, EventArgs e)
        {
            dgvAllRevHelper = new DgvReservationHelper(dgvAllRev);
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
            dgvAllRev.Rows[e.RowIndex].Cells["Reservation ID"].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ItemReservation newRev = ItemReservation.NewReservation();
            
        }
    }
}
