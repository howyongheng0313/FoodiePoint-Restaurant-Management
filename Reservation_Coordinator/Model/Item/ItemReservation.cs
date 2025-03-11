using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservation_Coordinator.Model.Item
{
    public class ItemReservation
    {
        public static ItemReservation NewReservation()
        {
            
        }

        public string ReservationID     { get; }
        public string HallID            { get; set; }
        public string UserID            { get; }
        public object ReservationDate   { get; }
        public string ReservationType   { get; }
        public string ReservationStatus { get; set; }
        public string FullName          { get; }
        public string HallName          { get; set; }
    }
}
