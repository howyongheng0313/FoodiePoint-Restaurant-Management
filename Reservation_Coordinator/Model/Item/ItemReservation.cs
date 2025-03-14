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
        public static ItemReservation GetByID(string revID)
        {
            var get_cmd = new SqlCommand(
                "SELECT " +
                "[ReservationID], " +
                "[RevTB].[HallID], " +
                "[RevTB].[UserID], " +
                "[GuestCount], " +
                "[ReservationDate], " +
                "[ReservationType], " +
                "[ReservationStatus], " +
                "[FullName], " +
                "[HallName] " +
                $"FROM {DataHelper.RevT} AS [RevTB]" +
                $"LEFT JOIN {DataHelper.UserT} AS [UsrTB] ON [RevTB].[UserID] = [UsrTB].[UserID] " +
                $"LEFT JOIN {DataHelper.HallT} AS [HalTB] ON [RevTB].[HallID] = [HalTB].[HallID] " +
                "WHERE [ReservationID] = @revid", DataHelper.conn);
            get_cmd.Parameters.AddWithValue("@revid", revID);

            DataHelper.conn.Open();
            SqlDataReader reader = get_cmd.ExecuteReader();

            if (reader.Read())
            {
                var reservation = new ItemReservation(
                    reader.GetString(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    (int)reader.GetInt32(3),
                    (DateTime)reader.GetDateTime(4),
                    reader.GetString(5),
                    reader.GetString(6),
                    reader.GetString(7),
                    reader.GetString(8));
                DataHelper.conn.Close();
                return reservation;
            }
            else
            {
                DataHelper.conn.Close();
                return null;
            }
        }

        public string   ReservationID     { get; }
        public string   HallID            { get; set; }
        public string   UserID            { get; }
        public int      GuestCount        { get; }
        public DateTime ReservationDate   { get; }
        public string   ReservationType   { get; }
        public string   ReservationStatus { get; set; }
        public string   FullName          { get; }
        public string   HallName          { get; set; }

        public ItemReservation(
            string   reservationID,
            string   hallID,
            string   userID,
            int      guestCount,
            DateTime reservationDate,
            string   reservationType,
            string   reservationStatus,
            string   fullName,
            string   hallName)
        {
            ReservationID     = reservationID;
            HallID            = hallID;
            UserID            = userID;
            GuestCount        = guestCount;
            ReservationDate   = reservationDate;
            ReservationType   = reservationType;
            ReservationStatus = reservationStatus;
            FullName          = fullName;
            HallName          = hallName;
        }
    }
}
