using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservation_Coordinator.Model.Item
{
    public class ItemReservation
    {
        public static readonly string Pending   = "Pending";
        public static readonly string Confirmed = "Confirmed";
        public static readonly string Completed = "Completed";
        public static readonly string Rejected  = "Rejected";

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
                    reader.IsDBNull(1) ? null : reader.GetString(1),
                    reader.GetString(2),
                    (int)reader.GetInt32(3),
                    (DateTime)reader.GetDateTime(4),
                    reader.GetString(5),
                    reader.GetString(6),
                    reader.GetString(7),
                    reader.IsDBNull(8) ? null : reader.GetString(8));
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

        public string UpdateHall(string halID)
        {
            var hall_cmd = new SqlCommand(
                $"UPDATE {DataHelper.RevT} " +
                "SET [HallID] = @halid " +
                "WHERE [ReservationID] = @revid", DataHelper.conn);
            hall_cmd.Parameters.AddWithValue("@halid", (object)halID ?? DBNull.Value);
            hall_cmd.Parameters.AddWithValue("@revid", this.ReservationID);

            DataHelper.conn.Open();
            int count = hall_cmd.ExecuteNonQuery();

            if (count < 1)
            {
                DataHelper.conn.Close();
                return "Failed to update database.";
            }

            var name_cmd = new SqlCommand(
                $"SELECT [HallName] FROM {DataHelper.HallT} " +
                "WHERE [HallID] = @halid", DataHelper.conn);
            name_cmd.Parameters.AddWithValue("@halid", (object)halID ?? DBNull.Value);

            this.HallName = (string)name_cmd.ExecuteScalar();
            DataHelper.conn.Close();

            if (this.HallID != null)
                ItemHall.SetAvailability(this.HallID, true);
            if (halID != null)
                ItemHall.SetAvailability(halID, false);
            this.HallID = halID;

            return null;
        }

        private int UpdateStatus(string status)
        {
            var status_cmd = new SqlCommand(
                $"UPDATE {DataHelper.RevT} " +
                "SET [ReservationStatus] = @status " +
                "WHERE [ReservationID] = @revid", DataHelper.conn);
            status_cmd.Parameters.AddWithValue("@status", status);
            status_cmd.Parameters.AddWithValue("@revid", this.ReservationID);

            DataHelper.conn.Open();
            int count = status_cmd.ExecuteNonQuery();
            DataHelper.conn.Close();

            return count;
        }

        public string Confirm()
        {
            if (this.ReservationStatus != Pending || string.IsNullOrEmpty(this.HallID))
                return "The current status is not allow to move to Confirmed.";

            if (this.UpdateStatus(Confirmed) <= 0)
                return "Failed to update database.";

            this.ReservationStatus = Confirmed;
            return null;
        }

        public string Complete()
        {
            if (this.ReservationStatus != Confirmed)
                return "The current status is not allow to move to Completed.";

            if (this.UpdateStatus(Completed) <= 0)
                return "Failed to update database.";

            this.ReservationStatus = Completed;
            ItemHall.SetAvailability(this.HallID, true);
            return null;
        }

        public string Reject()
        {
            if (this.ReservationStatus != Pending && this.ReservationStatus != Confirmed)
                return "The current status is not allow to move to Rejected.";

            if (this.UpdateStatus(Rejected) <= 0)
                return "Failed to update database.";

            this.ReservationStatus = Rejected;
            UpdateHall(null);
            return null;
        }
    }
}
