using Reservation_Coordinator.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservation_Coordinator.Model.Item
{
    public class NoticeHelper
    {
        private FlowLayoutPanel noticeList;

        public NoticeHelper(FlowLayoutPanel noticeList)
        {
            this.noticeList = noticeList;
        }

        public void Refresh()
        {
            noticeList.Controls.Clear();
            var notice_cmd = new SqlCommand(
                "SELECT [ReservationID], [UserRequest] " +
                $"FROM {DataHelper.RequestT} " +
                "WHERE [Reply] IS NULL", DataHelper.conn);

            DataHelper.conn.Open();
            SqlDataReader reader = notice_cmd.ExecuteReader();
            while (reader.Read())
            {
                string revID = reader.GetString(0);
                string request = reader.IsDBNull(1) ? null : reader.GetString(1);
                var box = new NoticeBox(revID, request);
                box.Click += (s, e) =>
                {
                    ItemReservation rev = ItemReservation.GetByID(revID);
                    var revPage = new frmSubReservationDetail();
                    revPage.SetRev(rev);
                    Jumper.Dive(revPage);
                };

                noticeList.Controls.Add(box);
            }
            DataHelper.conn.Close();
        }
    }
}
