using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodiePointManagementSystem.Model
{
    internal class Inventory
    {
        private int IngredientID { get; set; }
        private string IngredientName { get; set; }
        private int QuantityInStock { get; set; }
        private string Unit { get; set; }
    }
}
