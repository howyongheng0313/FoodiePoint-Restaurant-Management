using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation_Coordinator.Model.Item
{
    class ItemHall
    {
        public string HallID        { get; }
        public string HallName      { get; }
        public string HallPartyType { get; }
        public int    HallCapacity  { get; }
        public string Availability  { get; set; }

        public static int SetAvailability(string hallID, bool available)
        {
            var avail_cmd = new SqlCommand(
                $"UPDATE {DataHelper.HallT} " +
                $"SET [Availability] = @avail " +
                $"WHERE [HallID] = @halid", DataHelper.conn);
            avail_cmd.Parameters.AddWithValue("@avail", available ? "Available" : "Inavailable");
            avail_cmd.Parameters.AddWithValue("@halid", hallID);

            DataHelper.conn.Open();
            int count = avail_cmd.ExecuteNonQuery();
            DataHelper.conn.Close();

            return count;
        }
    }
}
