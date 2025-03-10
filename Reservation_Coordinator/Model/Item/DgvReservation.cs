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
    public class DgvReservation
    {
        private DataGridView dGridv;
        private DataTable dTable = new DataTable();
        private SqlDataAdapter dAdapter = new SqlDataAdapter(
            "SELECT " +
            "[ReservationID] AS [Reservation ID], " +
            "[FullName] AS [Customer], " +
            "[ReservationType] AS [Reservation Type], " +
            "[HallName] AS [Hall], " +
            "[ReservationDate] AS [Date], " +
            "[ReservationStatus] AS [Status] " +
            "FROM [dbo].[Reservations] AS [ResTB] " +
            "LEFT JOIN [dbo].[Users] AS [UsrTB] ON [ResTB].[UserID] = [UsrTB].[UserID] " +
            "LEFT JOIN [dbo].[Halls] AS [HalTB] ON [ResTB].[HallID] = [HalTB].[HallID]", DataHelper.conn);

        public DgvReservation(DataGridView dgv)
        {
            this.dGridv = dgv;
            dGridv.DataSource = dTable;
            dAdapter.Fill(dTable);
        }
    }
}
