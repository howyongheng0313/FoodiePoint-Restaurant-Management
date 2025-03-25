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
        public string ReservationID;
        public string HallID;
        public string UserID;   
        public string GuestCount;
        public string ReservationStatus;        
        public string ReservationDate;
        public string Request;
        public string ReservationType;


        public Reservation(string reservationID, string hallID, string userID, string reservationstatus) //parameterless initialization ??? from gpt
        {
            //string reservationID, string hallID, string userID, string reservationstatus
            ReservationID = reservationID;
            HallID = hallID;
            UserID = userID;
            ReservationStatus = reservationstatus;
        }

        


    }
}
