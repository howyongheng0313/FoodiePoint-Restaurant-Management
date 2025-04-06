using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservation_Coordinator.Model.Item
{
    class NoticeBox : Label
    {
        public NoticeBox(string revID, string request)
        {
            this.Text = $"[ {revID} ]\n{request}";
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Margin = new Padding(10, 10, 10, 0);
            this.Size = new System.Drawing.Size(275, 80);
        }
    }
}
