using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservation_Coordinator.Model.Item
{
    class RequestBox : Label
    {
        public RequestBox(string content)
        {
            this.Text = content;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Margin = new Padding(10, 10, 80, 10);
            this.MaximumSize = new System.Drawing.Size(350, 0);
            this.MinimumSize = new System.Drawing.Size(150, 0);
            this.Padding = new Padding(20);
        }
    }
}
