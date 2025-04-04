using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin.Presenter
{
    public class DataHelper
    {
        private static string _connStr;
        private static SqlConnection _conn;

        public static SqlConnection conn
        {
            get
            {
                if (_conn == null)
                {
                    _connStr = ConfigurationManager.ConnectionStrings["FoodiePointDB"]?.ConnectionString;

                    _conn = new SqlConnection(_connStr);
                }
                return _conn;
            }
        }
    }
}