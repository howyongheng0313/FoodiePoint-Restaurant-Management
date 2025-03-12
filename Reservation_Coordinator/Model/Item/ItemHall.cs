using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation_Coordinator.Model.Item
{
    class ItemHall
    {
        public static readonly string tb_code = "[dbo].[Halls]";

        public string HallID        { get; }
        public string HallName      { get; }
        public string HallPartyType { get; }
        public int    HallCapacity  { get; }
        public string Availability  { get; set; }
    }
}
