using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation_Coordinator.Model.Item
{
    class ItemRequest
    {
        public static int SendReply(string reqID, string content)
        {
            var send_cmd = new SqlCommand(
                $"UPDATE {DataHelper.RequestT} " +
                "SET [Reply] = @reply " +
                "WHERE [RequestID] = @reqid", DataHelper.conn);
            send_cmd.Parameters.AddWithValue("@reqid", reqID);
            send_cmd.Parameters.AddWithValue("@reply", content);

            DataHelper.conn.Open();
            int count = send_cmd.ExecuteNonQuery();
            DataHelper.conn.Close();

            return count;
        }
    }
}
