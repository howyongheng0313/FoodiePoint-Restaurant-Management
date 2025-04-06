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
    public class InventoryService 
    {
        private DatabaseHelper dbHelper;

        // Constructor of InventoryService
        public InventoryService()
        {
            dbHelper = new DatabaseHelper();
        }

        // Method to get all inventory
        public DataTable GetAllInventory()
        {
            string query = "SELECT * FROM Inventory";
            return dbHelper.ExecuteQuery(query);
        }

        // Method to detect if an ingredient ID exists
        public bool DetectID(string ingredientID)
        {
            string query = $"SELECT COUNT (*) FROM Inventory WHERE IngredientID = '{ingredientID}' ";
            DataTable dt =  dbHelper.ExecuteQuery(query);
            return dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) > 0; 
        }

        // Method to add an ingredient
        public bool AddIngredient(string ingredientName, float quantity, string unit)                          
        {
            string query = $"INSERT INTO Inventory(IngredientName, QuantityInStock, Unit) VALUES ('{ingredientName}', '{quantity}', '{unit}')" ;                                  
            return dbHelper.ExecuteNonQuery(query);
        }

        // Method to edit an ingredient
        public bool EditIngredient(string ingredientID, string ingredientName, float quantity, string unit)
        {
            string query = $"UPDATE Inventory SET IngredientName = '{ingredientName}', QuantityInStock = '{quantity}', Unit = '{unit}' WHERE IngredientID = '{ingredientID}' ";
            return dbHelper.ExecuteNonQuery(query);
        }

        // Method to delete an ingredient
        public bool DeleteIngredient(string ingredientID)
        {
            string query = $"DELETE FROM Inventory WHERE IngredientID = '{ingredientID}' ";
            return dbHelper.ExecuteNonQuery(query);
        }

        // Method to search for an ingredient
        public DataTable SearchIngredient(string searchInput)
        {
            string query = $"SELECT * FROM Inventory WHERE IngredientID LIKE '%{searchInput}%' OR IngredientName LIKE '%{searchInput}%' OR QuantityInStock LIKE '%{searchInput}%' OR Unit LIKE '%{searchInput}%' ";
            return dbHelper.ExecuteQuery(query);
        }
    }
}
