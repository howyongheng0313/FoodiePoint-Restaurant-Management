using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodiePointManagementSystem.Presenter;

namespace FoodiePointManagementSystem
{
    public partial class frmInventory : Form
    {
        // InventoryService object
        private InventoryService inventoryService;

        // Variables
        private string ingredientID;
        private string ingredientName;
        private float quantityInStock;
        private string unit;

        // Constructor
        public frmInventory()
        {
            InitializeComponent();
            inventoryService = new InventoryService();
        }

        // Load the Inventory table
        private void frmInventory_Load(object sender, EventArgs e)
        {
            dgvInventory.AutoGenerateColumns = false;
            dgvInventory.Columns.Clear();

            dgvInventory.Columns.Add("IngredientID", "Ingredient ID");
            dgvInventory.Columns["IngredientID"].DataPropertyName = "IngredientID";

            dgvInventory.Columns.Add("IngredientName", "Ingredient Name");
            dgvInventory.Columns["IngredientName"].DataPropertyName = "IngredientName";

            dgvInventory.Columns.Add("QuantityInStock", "Quantity In Stock");
            dgvInventory.Columns["QuantityInStock"].DataPropertyName = "QuantityInStock";

            dgvInventory.Columns.Add("Unit", "Unit");
            dgvInventory.Columns["Unit"].DataPropertyName = "Unit";

            dgvInventory.DataSource = inventoryService.GetAllInventory();
            dgvInventory.Refresh();

            btnReturn.Hide();
        }

        // Add ingredient into Inventory table
        private void btnAddIngredient_Click(object sender, EventArgs e)
        {
            ingredientID = tbxIngredientID.Text;
            ingredientName = tbxIngredient.Text;
            quantityInStock = float.Parse(tbxQuantity.Text);
            unit = cbxUnit.Text;

            // Check if the fields are empty  
            if (ingredientID == "" || ingredientName == "" || quantityInStock <= 0 || unit == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Looping through Inventory table to find duplicate ingredient ID
            bool isDuplicate = false;

            foreach (DataGridViewRow row in dgvInventory.Rows)
            {
                if (row.Cells["IngredientID"].Value?.ToString() == ingredientID)
                {
                    isDuplicate = true;
                    break;
                }
            }

            if (isDuplicate)
            {
                MessageBox.Show("Ingredient ID already exists.");
                return;
            }

            // Add ingredient into Inventory table
            bool isAdded = inventoryService.AddIngredient(ingredientID, ingredientName, quantityInStock, unit);

            // Check if the ingredient is added successfully
            if (isAdded)
            {
                MessageBox.Show($"{ingredientName} is succesfully added into the inventory!");

                dgvInventory.DataSource = inventoryService.GetAllInventory();
                dgvInventory.Refresh();

                tbxIngredientID.Clear();
                tbxIngredient.Clear();
                tbxQuantity.Clear();
                cbxUnit.ResetText();
            }
            else
            {
                MessageBox.Show("Ingredient failed to add!");
                return;
            }
        }

        // Delete ingredient from Inventory table
        private void btnDeleteIngredient_Click(object sender, EventArgs e)
        {
            ingredientID = tbxIngredientID.Text;

            // Check if the fields are empty
            if (ingredientID == "")
            {
                MessageBox.Show("Please fill in the Ingredient ID.");
                return;
            }

            // Looping through Inventory table to find the ingredient ID
            bool isFound = false;
            foreach (DataGridViewRow row in dgvInventory.Rows)
            {
                if (row.Cells["IngredientID"].Value?.ToString() == ingredientID)
                {
                    isFound = true;
                    break;
                }
            }

            if (!isFound) 
            {
                MessageBox.Show($"Ingredient ID: {ingredientID} does not exists. Please enter the right Ingredient ID. ");
                return;
            }

            // Delete ingredient from Inventory table
            bool isDeleted = inventoryService.DeleteIngredient(ingredientID);

            // Check if the ingredient is deleted successfully
            if (isDeleted)
            {
                MessageBox.Show($"{ingredientID} is successfully delete from inventory.");

                dgvInventory.DataSource = inventoryService.GetAllInventory();
                dgvInventory.Refresh();

                tbxIngredientID.Clear();
            }
            else
            {
                MessageBox.Show("Ingredient failed to delete!");
                return;
            }
        }

        // Edit ingredient in Inventory table
        private void btnEditIngredient_Click(object sender, EventArgs e)
        {
            ingredientID = tbxIngredientID.Text;
            ingredientName = tbxIngredient.Text;
            unit = cbxUnit.Text;

            // Validate quantity
            if(!float.TryParse(tbxQuantity.Text, out quantityInStock) || quantityInStock <= 0.0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }
            
            // Check if the fields are empty
            if (ingredientID == "" || ingredientName == "" || unit == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Looping through Inventory table to find the ingredient ID
            bool isFound = false;
            foreach (DataGridViewRow row in dgvInventory.Rows)
            {
                if (row.Cells["IngredientID"].Value?.ToString() == ingredientID)
                {
                    isFound = true;
                    break;
                }
            }

            if (!isFound)
            {
                MessageBox.Show($"Ingredient ID: {ingredientID} does not exists. Please enter the right Ingredient ID. ");
                return;
            }

            bool isEdited = inventoryService.EditIngredient(ingredientID, ingredientName, quantityInStock, unit);

            if (isEdited)
            {
                MessageBox.Show($"Details of {ingredientID} is successfully edited.");
                dgvInventory.DataSource = inventoryService.GetAllInventory();
                dgvInventory.Refresh();

                tbxSearchInput.Clear();
            }
            else
            {
                MessageBox.Show("Order status failed to edit!");
                return;
            }
        }

        private void btnSearchIngredient_Click(object sender, EventArgs e)
        {
            string searchInput = tbxSearchInput.Text; 
            if (searchInput == "")
            {
                MessageBox.Show("Please enter the search input.");
                return;
            }

            DataTable searchResult = inventoryService.SearchIngredient(searchInput);

            if (searchResult.Rows.Count > 0)
            {
                dgvInventory.DataSource = inventoryService.SearchIngredient(searchInput);
                dgvInventory.Refresh();
                btnReturn.Show();
            }
            else
            {
                MessageBox.Show("No result found.");
                return;
            }
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            dgvInventory.DataSource = inventoryService.GetAllInventory();
            dgvInventory.Refresh();

            MessageBox.Show("Inventory list is returned!");
        }

        private void btnInventoryToChef_Click(object sender, EventArgs e)
        {
            frmChef frmChef = new frmChef();
            frmChef.Show();
            this.Hide();
        }

        private void btnInventoryToOrder_Click(object sender, EventArgs e)
        {
            frmOrderPage frmOrder = new frmOrderPage();
            frmOrder.Show();
            this.Hide();
        }

        private void btnInventoryToProfile_Click(object sender, EventArgs e)
        {
            frmChefProfile frmChefProfile = new frmChefProfile();
            frmChefProfile.Show();
            this.Hide();
        }
    }
}
