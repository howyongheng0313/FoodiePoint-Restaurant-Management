using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Reservation_Coordinator.Model
{
    class DataHelper
    {
        public static readonly string UserT = "[dbo].[Users]";
        public static readonly string RevT = "[dbo].[Reservations]";
        public static readonly string RequestT = "[dbo].[Requests]";
        public static readonly string HallT = "[dbo].[Halls]";

        private static readonly string connStr = ConfigurationManager.ConnectionStrings["FoodiePointDB"].ToString();
        public static readonly SqlConnection conn = new SqlConnection(connStr);
    }
}
