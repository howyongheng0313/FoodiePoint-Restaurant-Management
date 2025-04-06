using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservation_Coordinator.Model.Item
{
    class ReplyBox : Label
    {
        public ReplyBox(string content)
        {
            this.Text = content;
            this.AutoSize = true;
            this.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.Margin = new Padding(80, 10, 10, 10);
            this.MaximumSize = new System.Drawing.Size(350, 0);
            this.MinimumSize = new System.Drawing.Size(150, 0);
            this.Padding = new Padding(20);
        }
    }
}
