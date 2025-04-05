using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Customer
{
    public class Reservation
    {

        public string ReservationID { get; set; }
        public string HallID { get; set; }
        public string UserID { get; set; }
        public int GuestCount { get; set; }
        public string ReservationStatus { get; set; }
        public string ReservationDate { get; set; }
        public string Request { get; set; }
        public string ReservationType { get; set; }


        public Reservation() //parameterless initialization ??? from gpt
        {

        }

        


    }
}
