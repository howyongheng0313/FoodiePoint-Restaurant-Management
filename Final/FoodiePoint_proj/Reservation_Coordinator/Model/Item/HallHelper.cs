using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservation_Coordinator.Model.Item
{
    public class HallHelper
    {
        private DataGridView dGridv;
        private DataTable dTable = new DataTable();
        private SqlDataAdapter dAdapter = new SqlDataAdapter(
            "SELECT " +
            "[HallID] AS [Hall ID], " +
            "[HallName] AS [Hall Name], " +
            "[HallPartyType] AS [Party Type], " +
            "[HallCapacity] AS [Capacity] " +
            $"FROM {DataHelper.HallT} " +
            "WHERE [HallCapacity] >= @capacity " +
            "AND [Availability] = 'Available' " +
            "OR [HallID] = @crrid", DataHelper.conn);

        public HallHelper(DataGridView dgv, int capacity, string crrID)
        {
            this.dGridv = dgv;
            dGridv.DataSource = dTable;
            dAdapter.SelectCommand.Parameters.AddWithValue("@capacity", capacity);
            dAdapter.SelectCommand.Parameters.AddWithValue("@crrid", (object)crrID ?? DBNull.Value);
            Refresh();
        }

        public void Refresh()
        {
            dTable.Clear();
            dAdapter.Fill(dTable);
        }
    }
}
