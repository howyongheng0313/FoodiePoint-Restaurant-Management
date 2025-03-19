using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Reservation_Coordinator.Model.Item
{
    public class DgvReservationHelper
    {
        private string filterStatus = "";
        private string filterID = "";
        private string filterName = "";
        private DataGridView dGridv;
        private DataTable dTable = new DataTable();
        private SqlDataAdapter dAdapter = new SqlDataAdapter(
            "SELECT " +
            "[ReservationID] AS [Reservation ID], " +
            "[FullName] AS [Customer], " +
            "[HallName] AS [Hall], " +
            "[ReservationType] AS [Reservation Type], " +
            "[ReservationDate] AS [Date], " +
            "[ReservationStatus] AS [Status] " +
            $"FROM {ItemReservation.tb_code} AS [ResTB] " +
            $"LEFT JOIN {ItemUser.tb_code} AS [UsrTB] ON [ResTB].[UserID] = [UsrTB].[UserID] " +
            $"LEFT JOIN {ItemHall.tb_code} AS [HalTB] ON [ResTB].[HallID] = [HalTB].[HallID]", DataHelper.conn);

        public DgvReservationHelper(DataGridView dgv)
        {
            this.dGridv = dgv;
            dGridv.DataSource = dTable;
            dAdapter.Fill(dTable);
        }

        public void Refresh()
        {
            dAdapter.Fill(dTable);
        }

        public void Filter_Status(string status)
        {
            if (status == "All" || status == string.Empty)
                filterStatus = string.Empty;
            else
                filterStatus = $" AND [Status] = '{status}'";
            dTable.DefaultView.RowFilter = "TRUE" + filterStatus + filterID + filterName;
        }

        public void Filter_ID(string id)
        {
            if (id == string.Empty)
                filterID = string.Empty;
            else
                filterID = $" AND [Reservation ID] LIKE '{id}%'";
            dTable.DefaultView.RowFilter = "TRUE" + filterStatus + filterID + filterName;
        }

        public void Filter_Name(string name)
        {
            if (name == string.Empty)
                filterName = string.Empty;
            else
                filterName = $" AND ([Customer] LIKE '%{name}%' OR [Hall] LIKE '%{name}%')";
            dTable.DefaultView.RowFilter = "TRUE" + filterStatus + filterID + filterName;
        }
    }
}
