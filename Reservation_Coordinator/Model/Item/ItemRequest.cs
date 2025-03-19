using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation_Coordinator.Model.Item
{
    class ItemRequest
    {
        public string RequestID { get; }
        public string ReservationID { get; }
        public string UserRequest { get; }
        public string Reply { get; set; }
    }
}
