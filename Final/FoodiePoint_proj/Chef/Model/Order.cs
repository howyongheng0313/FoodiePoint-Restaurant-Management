using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodiePointManagementSystem.Model
{
    public class Order
    {
        private int OrderID { get; set; }
        private int UserID { get; set; }
        private DateTime DateTime { get; set; }
        private string OrderStatus { get; set; }
        private List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
