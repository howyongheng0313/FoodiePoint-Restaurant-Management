using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservation_Coordinator.Model
{
    public class Jumper
    {
        private static Form current;
        private static Size size;
        private static FormWindowState state;
        private static Point location;

        private static void SetPos(Form next)
        {
            next.StartPosition = FormStartPosition.Manual;
            next.Size = size;
            next.WindowState = state;
            next.Location = location;
        }

        private static void SavePos(Form current)
        {
            size = current.Size;
            state = current.WindowState;
            location = current.Location;
        }

        public static void Look(Form myForm)
        {
            current = myForm;
            current.FormClosing += (s, e) => {
                SavePos(current);
                current = null;
            };
        }

        public static DialogResult Dive(Form myForm)
        {
            Form parent = current;
            SavePos(parent);
            parent.Hide();

            DialogResult result = DialogResult.None;
            Look(myForm);
            while (current != null)
            {
                SetPos(current);
                result = current.ShowDialog();
            }

            current = parent;
            SetPos(parent);
            parent.Show();
            return result;
        }

        public static void Shift(Form myForm)
        {
            current.Close();
            Look(myForm);
            SetPos(myForm);
        }
    }
}
