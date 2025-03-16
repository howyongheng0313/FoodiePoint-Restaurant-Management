using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservation_Coordinator.Model.Item
{
    public class RequestHelper
    {
        private FlowLayoutPanel chatList;
        private TextBox source;
        private string revID;
        private string lasID = "RQ000";

        private Timer chatTimer = new Timer();
        public bool ChatTimer { get => chatTimer.Enabled; set => chatTimer.Enabled = value; }

        public RequestHelper(FlowLayoutPanel chatList, TextBox source, string revID)
        {
            this.chatList = chatList;
            this.source  = source;
            this.revID   = revID;

            chatTimer.Interval = 3000;
            chatTimer.Tick += (s, e) => Refresh();
        }

        public void Refresh()
        {
            var req_cmd = new SqlCommand(
                "SELECT [RequestID], [UserRequest], [Reply] " +
                $"FROM {DataHelper.RequestT}" +
                "WHERE [ReservationID] = @revid AND [RequestID] > @crrid", DataHelper.conn);
            req_cmd.Parameters.AddWithValue("@revid", revID);
            req_cmd.Parameters.AddWithValue("@crrid", lasID);

            DataHelper.conn.Open();
            SqlDataReader reader = req_cmd.ExecuteReader();
            while (reader.Read())
            {
                string reqid = reader.GetString(0);
                string req   = reader.IsDBNull(1) ? null : reader.GetString(1);
                string res   = reader.IsDBNull(2) ? null : reader.GetString(2);
                lasID = reqid;

                chatList.Controls.Add(new RequestBox(req));

                if (res != null)
                {
                    chatList.Controls.Add(new ReplyBox(res));
                    continue;
                }
                int btnPos = chatList.Controls.Count;
                var replyBtn = new ReplyButton();
                replyBtn.Click += (object sender, EventArgs e) =>
                {
                    if (string.IsNullOrEmpty(source.Text)) return;
                    if (ItemRequest.SendReply(reqid, source.Text) < 1)
                    {
                        MessageBox.Show("Failed to Send The Message.");
                        return;
                    }
                    var newReply = new ReplyBox(source.Text);
                    source.Text = string.Empty;
                    chatList.Controls.RemoveAt(btnPos);
                    chatList.Controls.Add(newReply);
                    chatList.Controls.SetChildIndex(newReply, btnPos);
                    replyBtn.Dispose();
                };

                chatList.Controls.Add(replyBtn);
            }
            DataHelper.conn.Close();
        }
    }
}
