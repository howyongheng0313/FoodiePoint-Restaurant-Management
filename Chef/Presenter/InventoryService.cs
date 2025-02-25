using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FoodiePointManagementSystem.Presenter
{
    // Chef (view, update) and update and customer (view, update, edit, delete)
    public class InventoryService 
    {

        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\heeth\OneDrive - Asia Pacific University\Degree 1st Year (Sem 2)\Object-oriented\Chef\Chef\Database\FoodiePoint.mdf;Integrated Security = True";
        

        //私有字段，使用属性访问
        private int OrderID;
        private int UserID;
        private DateTime OrderDate;
        private string OrderStatus;

        public int orderID { get => OrderID; set => OrderID = value; }
        public int userID {get => UserID; set => UserID = value; }
        public DateTime orderDate { get => OrderDate; set => OrderDate = value; }
        public string orderStatus { get => OrderStatus; set => OrderStatus = value; }


        //构造函数
        public InventoryService()
        {
        }

        public void viewOrder() 
        {

        }

        public void updateOrder()
        {

        }

        public void editOrder()
        {

        }

        public void deleteOrder()
        {

        }
    }
}
