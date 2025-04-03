using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservation_Coordinator.Model
{
    public class Jumper
    {
        private static Form current;

        private static void SetPos(Form next)
        {
            next.Size = current.Size;
            next.WindowState = current.WindowState;
            next.Location = current.Location;
        }

        public static void Look(Form myForm)
        {
            current = myForm;
            current.FormClosing += (s, e) => current = null;
        }

        public static void Dive(Form myForm)
        {
            SetPos(myForm);

            Form parent = current;
            parent.Hide();

            Look(myForm);
            while (current != null) current.ShowDialog();

            current = parent;
            parent.Show();
        }

        public static void Shift(Form myForm)
        {
            SetPos(myForm);

            current.Close();
            Look(myForm);
        }
    }
}
