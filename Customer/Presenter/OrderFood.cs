using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Customer.Presenter;


namespace Customer.Presenter
{
    class OrderFood
    {
        private DatabaseHelper dbHelper;

        public OrderFood()
        {
            dbHelper = new DatabaseHelper();
        }

        public DataTable GetAllItem()
        {
            string query = "SELECT * FROM Menu";
            return dbHelper.ExecuteQuery(query);
        }

        public DataTable searchItem(string searchItemName)
        {
            string query = $"SELECT * FROM Menu WHERE ItemName = '{searchItemName}' " ;
            return dbHelper.ExecuteQuery(query);
        }

        public bool addItem()
        {
            string query = "" ;
            return;
        }

        public bool editItem()
        {
            string query = "UPDATE" ;
            return;
        }

        public bool deleteItem()
        {
            string query = "DELETE FROM  ";
            return;
        }
    }
}
