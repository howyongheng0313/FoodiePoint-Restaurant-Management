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
using FoodiePointManagementSystem.Presenter;

namespace FoodiePointManagementSystem
{
    public partial class frmInventory : Form
    {
        private InventoryService inventoryService;

        private string _ingredientID;
        private string _ingredientName;
        private float _quantityInStock;
        private string _unit;
        private string _searchInput;
        private int action = 0;

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
            action = 1; UnlockTextBox(action);

            string newId = GetNextIngredientId();
            tbxIngredientID.Text = newId;
        }

        private void btnEditIngredient_Click(object sender, EventArgs e)
        {
            btnConfirm.Show();
            action = 2; UnlockTextBox(action);
        }

        private void btnDeleteIngredient_Click(object sender, EventArgs e)
        {
            btnConfirm.Show();
            action = 3; UnlockTextBox(action);
        }

        private void btnSearchIngredient_Click(object sender, EventArgs e)
        {
            SearchInput = tbxSearchInput.Text;

            if (string.IsNullOrEmpty(SearchInput))
            {
                MessageBox.Show("Please enter something on search bar.");
                return;
            }

            DataTable searchResult = inventoryService.SearchIngredient(SearchInput);

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
            if (action == 1)
            {
                IngredientID = tbxIngredientID.Text;
                IngredientName = tbxIngredient.Text;
                Unit = cbxUnit.Text;

                // Validate quantity input.
                // If not valid, show message box and return, else assign value to QuantityInStock (Global variable)
                if (!float.TryParse(tbxQuantity.Text, out float quantityInStock))
                {
                    MessageBox.Show("Please enter quantity in the correct format.");
                    return;
                }
                QuantityInStock = quantityInStock;

                if (string.IsNullOrEmpty(IngredientID) || string.IsNullOrEmpty(IngredientName) || string.IsNullOrEmpty(Unit))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                if (inventoryService.DetectID(IngredientID))
                {
                    MessageBox.Show("Ingredient ID already exists. Please change Ingredient ID.");
                    return;
                }

                bool isAdded = inventoryService.AddIngredient(IngredientID, IngredientName, quantityInStock, Unit);
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


            else if (action == 2)
            {
                IngredientID = tbxIngredientID.Text;
                IngredientName = tbxIngredient.Text;
                Unit = cbxUnit.Text;

                if (string.IsNullOrEmpty(IngredientID))
                {
                    MessageBox.Show("Please enter Ingredient ID");
                    return;
                }

                if (!inventoryService.DetectID(IngredientID))
                {
                    MessageBox.Show("Ingredient ID does not exists. Please change Ingredient ID.");
                    return;
                }

                string store_IngredientName = "";
                float store_QuantityInStock = 0;
                string store_Unit = "";

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


                int changedFields = 0;
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

                if (changedFields < 1)
                {
                    MessageBox.Show("Please modify at least one field.");
                    return;
                }

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

            else if (action == 3)
            {
                //ingredientID = tbxIngredientID.Text;

                if (string.IsNullOrEmpty(IngredientID))
                {
                    MessageBox.Show("Please enter Ingredient ID.");
                    return;
                }

                if (!inventoryService.DetectID(IngredientID))
                {
                    MessageBox.Show("Ingredient ID not exists. Please change Ingredient ID.");
                    return;
                }

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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            dgvInventory.DataSource = inventoryService.GetAllInventory();
            dgvInventory.Refresh();
            MessageBox.Show("Inventory list is returned!");
        }

        private void ClearAllInput()
        {
            tbxIngredientID.Clear();
            tbxIngredient.Clear();
            tbxQuantity.Clear();
            cbxUnit.ResetText();
            tbxSearchInput.Clear();
        }

        private void LockTextBox()
        {
            tbxIngredientID.ReadOnly = true;
            tbxIngredient.ReadOnly = true;
            tbxQuantity.ReadOnly = true;
            cbxUnit.Enabled = false;

            tbxIngredientID.Text = "ING";
            tbxIngredientID.SelectionStart = tbxIngredientID.Text.Length;
        }

        private void UnlockTextBox(int action)
        {
            LockTextBox();

            switch(action)
            {
                case 1: 
                    tbxIngredientID.ReadOnly = false;
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

        private string GetNextIngredientId()
        {
            string prefix = "ING";
            int newNumber = 1;

            if (dgvInventory.Rows.Count > 0)
            {
                var lastRow = dgvInventory.Rows[dgvInventory.Rows.Count - 2];
                if (lastRow.Cells[0].Value != null)
                {
                    string lastId = lastRow.Cells[0].Value.ToString();

                    if (lastId.StartsWith(prefix))
                    {
                        string numberPart = lastId.Substring(prefix.Length);
                        if(int.TryParse(numberPart, out int lastNumber))
                        {
                            newNumber = lastNumber + 1;
                        }
                    }
                }
            }
            return $"{prefix}{newNumber:D2}" ;
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
