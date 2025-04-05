using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Admin.Presenter;
using FoodiePointManagementSystem.Presenter;
using Reservation_Coordinator.Model;

namespace FoodiePointManagementSystem
{
    public partial class frmInventory : Form, UserForm
    {
        private InventoryService inventoryService;

        private string _ingredientID;
        private string _ingredientName;
        private float _quantityInStock;
        private string _unit;
        private string _searchInput;
        private int action = 0;
        private LoginCredent _currentUser;

        public string IngredientID
        {
            get { return _ingredientID; }
            set { _ingredientID = value; tbxIngredientID.Text = value; }
        }

        public string IngredientName
        {
            get { return _ingredientName; }
            set { _ingredientName = value; tbxIngredient.Text = value; }
        }

        public float QuantityInStock
        {
            get { return _quantityInStock; }
            set { _quantityInStock = value; }
        }

        public string Unit
        {
            get { return _unit; }
            set { _unit = value; cbxUnit.Text = value; }
        }

        public string SearchInput
        {
            get { return _searchInput; }
            set { _searchInput = value;}
        }


        public frmInventory()
        {
            InitializeComponent();
            inventoryService = new InventoryService();
        }

        public void SetUser(LoginCredent user)
        {
            _currentUser = user;
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            LockTextBox();

            btnConfirm.Hide();

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
        }

        private void btnAddIngredient_Click(object sender, EventArgs e)
        {
            btnConfirm.Show();
            action = 1; 
            UnlockTextBox(action);
            tbxIngredientID.Text = string.Empty;   
        }

        private void btnEditIngredient_Click(object sender, EventArgs e)
        {
            btnConfirm.Show();
            action = 2; 
            UnlockTextBox(action);
        }

        private void btnDeleteIngredient_Click(object sender, EventArgs e)
        {
            btnConfirm.Show();
            action = 3; 
            UnlockTextBox(action);
        }

        private void btnSearchIngredient_Click(object sender, EventArgs e)
        {
            SearchInput = tbxSearchInput.Text;

            // Ensure that the search input is not empty
            if (string.IsNullOrEmpty(SearchInput))
            {
                MessageBox.Show("Please enter something on search bar.");
                return;
            }

            DataTable searchResult = inventoryService.SearchIngredient(SearchInput);

            // Check if the search result is not empty
            if (searchResult.Rows.Count > 0)
            {
                dgvInventory.DataSource = inventoryService.SearchIngredient(SearchInput);
                dgvInventory.Refresh();
                btnReturn.Show();

                tbxSearchInput.Clear();
            }
            else
            {
                MessageBox.Show("No ingredient found.");
                return;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Add ingredient
            if (action == 1)
            {
                IngredientName = tbxIngredient.Text;
                Unit = cbxUnit.Text;

                // Ensure that the quantity is not empty and is a valid float
                if (!float.TryParse(tbxQuantity.Text, out float quantityInStock))
                {
                    MessageBox.Show("Please enter quantity in the correct format.");
                    return;
                }
                QuantityInStock = quantityInStock;

                // Ensure that the ingredient name and unit are not empty
                if (string.IsNullOrEmpty(IngredientName) || string.IsNullOrEmpty(Unit))  
                    {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                // Call the AddIngredient method with the provided values
                bool isAdded = inventoryService.AddIngredient(IngredientName, quantityInStock, Unit);                 
                if (isAdded)
                {
                    MessageBox.Show($"{IngredientName} is successfully added into the inventory!");
                    dgvInventory.DataSource = inventoryService.GetAllInventory();
                    dgvInventory.Refresh();

                    ClearAllInput();
                    LockTextBox();
                }
                else
                {
                    MessageBox.Show("Ingredient failed to add!");
                }
            }

            // Edit ingredient
            else if (action == 2)
            {
                IngredientID = tbxIngredientID.Text;
                IngredientName = tbxIngredient.Text;
                Unit = cbxUnit.Text;

                // Ensure that the ingredient ID is not empty
                if (string.IsNullOrEmpty(IngredientID))
                {
                    MessageBox.Show("Please enter Ingredient ID");
                    return;
                }

                // Ensure that the ingredient ID exists
                if (!inventoryService.DetectID(IngredientID))
                {
                    MessageBox.Show("Ingredient ID does not exists. Please change Ingredient ID.");
                    return;
                }

                string store_IngredientName = "";
                float store_QuantityInStock = 0;
                string store_Unit = "";

                // Loop through the DataGridView to find the selected ingredient ID
                foreach (DataGridViewRow row in dgvInventory.Rows)
                {
                    if (row.Cells["IngredientID"].Value.ToString() == IngredientID)
                    {
                        store_IngredientName = row.Cells["IngredientName"].Value.ToString();
                        store_QuantityInStock = float.Parse(row.Cells["QuantityInStock"].Value.ToString());
                        store_Unit = row.Cells["Unit"].Value.ToString();
                        break;
                    }
                }

                // Ensure the quantity is a valid float and not negative
                float quantityInStock = store_QuantityInStock;
                if (!string.IsNullOrEmpty(tbxQuantity.Text))
                {
                    if (!float.TryParse(tbxQuantity.Text, out quantityInStock) || quantityInStock <= 0.0)
                    {
                        MessageBox.Show("Please enter a valid quantity.");
                        return;
                    }
                }
                QuantityInStock = quantityInStock; // Assign value to global variable

                
                int changedFields = 0; // Initialize a counter for changed fields

                // Check if the fields have changed
                if (!string.IsNullOrEmpty(IngredientName) && IngredientName != store_IngredientName)
                {
                    store_IngredientName = IngredientName;
                    changedFields++;
                }
                if (quantityInStock != store_QuantityInStock)
                {
                    store_QuantityInStock = quantityInStock;
                    changedFields++;
                }
                if (!string.IsNullOrEmpty(Unit) && Unit != store_Unit)
                {
                    store_Unit = Unit;
                    changedFields++;
                }

                // Ensure that at least one field has changed
                if (changedFields < 1)
                {
                    MessageBox.Show("Please modify at least one field.");
                    return;
                }

                // Call the EditIngredient method with the updated values
                bool isEdited = inventoryService.EditIngredient(IngredientID, store_IngredientName, store_QuantityInStock, store_Unit);
                if (isEdited)
                {
                    MessageBox.Show($"Details of {IngredientID} is successfully edited.");
                    dgvInventory.DataSource = inventoryService.GetAllInventory();
                    dgvInventory.Refresh();

                    ClearAllInput();
                    LockTextBox();
                }
                else
                {
                    MessageBox.Show("Ingredient failed to edit!");
                    return;
                }

            }

            // Delete ingredient
            else if (action == 3)
            {
                IngredientID = tbxIngredientID.Text;

                // Ensure that the ingredient ID is not empty
                if (string.IsNullOrEmpty(IngredientID))
                {
                    MessageBox.Show("Please enter Ingredient ID.");
                    return;
                }

                // Ensure that the ingredient ID exists
                if (!inventoryService.DetectID(IngredientID))
                {
                    MessageBox.Show("Ingredient ID not exists. Please change Ingredient ID.");
                    return;
                }

                // Call the DeleteIngredient method with the provided ingredient ID
                bool isDeleted = inventoryService.DeleteIngredient(IngredientID);
                if (isDeleted)
                {
                    MessageBox.Show("Ingredient is successfully deleted.");
                    dgvInventory.DataSource = inventoryService.GetAllInventory();
                    dgvInventory.Refresh();

                    ClearAllInput();
                    LockTextBox();
                }
                else
                {
                    MessageBox.Show("Failed to delete ingredient.");
                }
            }
        }

        // Button to return to the full inventory list
        private void btnReturn_Click(object sender, EventArgs e)
        {
            dgvInventory.DataSource = inventoryService.GetAllInventory();
            dgvInventory.Refresh();
            MessageBox.Show("Inventory list is returned!");
        }

        // Method to clear all input fields
        private void ClearAllInput()
        {
            tbxIngredientID.Clear();
            tbxIngredient.Clear();
            tbxQuantity.Clear();
            cbxUnit.ResetText();
            tbxSearchInput.Clear();
        }

        // Method to lock the text box after an action is completed
        private void LockTextBox()
        {
            tbxIngredientID.ReadOnly = true;
            tbxIngredient.ReadOnly = true;
            tbxQuantity.ReadOnly = true;
            cbxUnit.Enabled = false;

            tbxIngredientID.Text = "ING";
            tbxIngredientID.SelectionStart = tbxIngredientID.Text.Length;
        }

        // Method to unlock the text box for different actions (add, edit, delete)
        private void UnlockTextBox(int action)
        {
            LockTextBox();

            switch(action)
            {
                case 1: 
                    tbxIngredient.ReadOnly = false;
                    tbxQuantity.ReadOnly = false;
                    cbxUnit.Enabled = true;
                    break;

                case 2:
                    tbxIngredientID.ReadOnly = false;
                    tbxIngredient.ReadOnly = false;
                    tbxQuantity.ReadOnly = false;
                    cbxUnit.Enabled = true;
                    break;

                case 3:
                    tbxIngredientID.ReadOnly = false;
                    break;
            }     
        }

        private void btnInventoryToChef_Click(object sender, EventArgs e)
        {
            frmChef frmChef = new frmChef();
            frmChef.SetUser(_currentUser);
            Jumper.Shift(frmChef);
        }

        private void btnInventoryToOrder_Click(object sender, EventArgs e)
        {
            frmOrderPage frmOrder = new frmOrderPage();
            frmOrder.SetUser(_currentUser);
            Jumper.Shift(frmOrder);
        }

        private void btnInventoryToProfile_Click(object sender, EventArgs e)
        {
            Admin.View.frmUpdate frmChefProfile = new Admin.View.frmUpdate();
            frmChefProfile.SetUser(_currentUser);
            Jumper.Dive(frmChefProfile);
        }
    }
}
