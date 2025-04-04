using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservation_Coordinator.Model.Item
{
    class ReplyButton : Button
    {
        public ReplyButton()
        {
            this.Text = "Reply";
            this.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Margin = new Padding(10);
            this.Size = new System.Drawing.Size(150, 50);
            this.UseVisualStyleBackColor = false;
        }
    }
}
