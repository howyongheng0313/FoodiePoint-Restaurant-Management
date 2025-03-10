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
        private DgvReservation dgvAllRevHelper;

        public pgeViewRev()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void pgeViewRev_Load(object sender, EventArgs e)
        {
            dgvAllRevHelper = new DgvReservation(dgvAllRev);
        }
    }
}
