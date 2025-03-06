using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using FoodiePointManagementSystem.Database;
using System.Windows.Forms;

namespace FoodiePointManagementSystem.Presenter
{
    // Chef (view, update) and update and customer (view, update, edit, delete)
    public class InventoryService 
    {
        private DatabaseHelper dbHelper;

        public InventoryService()
        {
            dbHelper = new DatabaseHelper();
        }

        public DataTable GetAllInventory()
        {
            string query = "SELECT * FROM Inventory";
            return dbHelper.ExecuteQuery(query);
        }

        public bool DetectQuery(string ingredientID)
        {
            string query = $"SELECT COUNT (*) FROM Inventory WHERE IngredientID = '{ingredientID}' ";
            DataTable dt =  dbHelper.ExecuteQuery(query);

            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0][0]) > 0 ; 
            }
            return false; // No duplicate Ingredient ID
        }

        public bool AddIngredient(string ingredientID, string ingredientName, float quantity, string unit)
        {
            string detectQuery = $"SELECT * FROM Inventory WHERE IngredientID = '{ingredientID}' ";
                
            string query = $"INSERT INTO Inventory(IngredientID, IngredientName, QuantityInStock, Unit) VALUES ('{ingredientID}', '{ingredientName}', '{quantity}', '{unit}')" ;
            return dbHelper.ExecuteNonQuery(query);
        }

        public bool EditIngredient(string ingredientID, string ingredientName, float quantity, string unit)
        {
            string query = $"UPDATE Inventory SET IngredientName = '{ingredientName}', QuantityInStock = '{quantity}', Unit = '{unit}' WHERE IngredientID = '{ingredientID}' ";
            return dbHelper.ExecuteNonQuery(query);
        }

        public bool DeleteIngredient(string ingredientID)
        {
            string query = $"DELETE FROM Inventory WHERE IngredientID = '{ingredientID}' ";
            return dbHelper.ExecuteNonQuery(query);
        }

        public DataTable SearchIngredient(string searchInput)
        {
            string query = $"SELECT * FROM Inventory WHERE IngredientID LIKE '{searchInput}' OR IngredientName LIKE '{searchInput}' OR QuantityInStock LIKE '{searchInput}' OR Unit LIKE '{searchInput}' ";
            return dbHelper.ExecuteQuery(query);
        }
    }
}
