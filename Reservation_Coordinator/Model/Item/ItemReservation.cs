using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservation_Coordinator.Model.Item
{
    public class ItemReservation
    {
        public static readonly string tb_code = "[dbo].[Reservations]";

        public static ItemReservation NewReservation()
        {
            string newID;
            var holder_cmd = new SqlCommand(
                $"INSERT INTO {tb_code} " +
                "OUTPUT INSERTED.[ReservationID] " +
                "DEFAULT VALUES", DataHelper.conn);

            DataHelper.conn.Open();
            newID = (string)holder_cmd.ExecuteScalar();
            DataHelper.conn.Close();

            return new ItemReservation(newID);
        }

        public string ReservationID     { get; }
        public string HallID            { get; set; }
        public string UserID            { get; }
        public object ReservationDate   { get; }
        public string ReservationType   { get; }
        public string ReservationStatus { get; set; }
        public string FullName          { get; }
        public string HallName          { get; set; }

        public ItemReservation(string reservationID)
        {
            ReservationID = reservationID;
        }
    }
}
