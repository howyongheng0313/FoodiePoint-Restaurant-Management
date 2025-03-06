using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void btnAddIngredient_Click(object sender, EventArgs e)
        {
            ingredientID = tbxIngredientID.Text;
            ingredientName = tbxIngredient.Text;
            unit = cbxUnit.Text;

            // 检测Quantity的格式以及是否大于0
            if (!float.TryParse(tbxQuantity.Text, out quantityInStock) || quantityInStock <= 0.0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            // 检测是否有空字段
            if (ingredientID == "" || ingredientName == "" || unit == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // 检测ID是否已经存在 (返回 true，表示数据库中已经存在这个IngredientID)
            if (inventoryService.DetectQuery(ingredientID))
            {
                MessageBox.Show($"Ingredient ID: {ingredientID} already exists.");
                return;
            }

            // 添加Ingredient到Inventory表
            bool isAdded = inventoryService.AddIngredient(ingredientID, ingredientName, quantityInStock, unit);
            if (isAdded)
            {
                MessageBox.Show($"{ingredientName} is succesfully added into the inventory!");

                dgvInventory.DataSource = inventoryService.GetAllInventory();
                dgvInventory.Refresh();

                tbxIngredientID.Clear();
                tbxIngredient.Clear();
                tbxQuantity.Clear();
                cbxUnit.ResetText();
                tbxSearchInput.Clear();
            }
            else
            {
                MessageBox.Show("Ingredient failed to add!");
                return;
            }
        }

        private void btnDeleteIngredient_Click(object sender, EventArgs e)
        {
            ingredientID = tbxIngredientID.Text;

            // 检测ID是否为空
            if (ingredientID == "")
            {
                MessageBox.Show("Please fill in the Ingredient ID.");
                return;
            }

            // 检测ID是否存在于数据库中 (返回 false，表示数据库中不存在这个IngredientID)
            if (!inventoryService.DetectQuery(ingredientID))
            {
                MessageBox.Show($"Ingredient ID: {ingredientID} doe not exists.");
                return;
            }

            // 删除Ingredient
            bool isDeleted = inventoryService.DeleteIngredient(ingredientID);
            if (isDeleted)
            {
                MessageBox.Show($"{ingredientID} is successfully delete from inventory.");

                dgvInventory.DataSource = inventoryService.GetAllInventory();
                dgvInventory.Refresh();

                tbxIngredientID.Clear();
                tbxIngredient.Clear();
                tbxQuantity.Clear();
                cbxUnit.ResetText();
                tbxSearchInput.Clear();
            }
            else
            {
                MessageBox.Show("Ingredient failed to delete!");
                return;
            }
        }


        private void btnEditIngredient_Click(object sender, EventArgs e)
        {
            ingredientID = tbxIngredientID.Text;
            ingredientName = tbxIngredient.Text;
            unit = cbxUnit.Text;

            // 检测ID是否为空
            if (string.IsNullOrEmpty(ingredientID))
            {
                MessageBox.Show("Please enter Ingredient ID.");
                return;
            }

            // 检测ID是否存在于数据库中
            if (!inventoryService.DetectQuery(ingredientID))
            {
                MessageBox.Show($"Ingredient ID: {ingredientID} does not exist.");
                return;
            }

            // 设置变量来储存旧数据
            string pre_ingredientName = "";
            float pre_quantityInStock = 0;
            string pre_unit = "";

            // 查找DataGridView来找到对应的IngredientID，然后获取旧数据
            foreach (DataGridViewRow row in dgvInventory.Rows)
            {
                if (row.Cells["IngredientID"].Value.ToString() == ingredientID)
                {
                    pre_ingredientName = row.Cells["IngredientName"].Value.ToString();
                    pre_quantityInStock = float.Parse(row.Cells["QuantityInStock"].Value.ToString());
                    pre_unit = row.Cells["Unit"].Value.ToString();
                    break;
                }
            }

            // 检测Quantity的格式以及是否大于0 (仅在用户有输入时才检测)
            if (!string.IsNullOrEmpty(tbxQuantity.Text))
            {
                if (!float.TryParse(tbxQuantity.Text, out quantityInStock) || quantityInStock <= 0.0)
                {
                    MessageBox.Show("Please enter a valid quantity.");
                    return;
                }
            }
            else
            {
                quantityInStock = pre_quantityInStock; // 如果没有输入，就保留旧数据
            }

            // 检测是否有数据被修改
            int changedFields = 0;
            if (!string.IsNullOrEmpty(ingredientName) && ingredientName != pre_ingredientName)
            {
                pre_ingredientName = ingredientName;
                changedFields++;
            }
            if (quantityInStock != pre_quantityInStock)
            {
                pre_quantityInStock = quantityInStock;
                changedFields++;
            }
            if(!string.IsNullOrEmpty(unit) && unit != pre_unit)
            {
                pre_unit = unit;
                changedFields++;
            }

            // 至少需要修改一个数据
            if(changedFields < 1)
            {
                MessageBox.Show("Please modify at least one field.");
                return;
            }

            // 执行修改
            bool isEdited = inventoryService.EditIngredient(ingredientID, pre_ingredientName, pre_quantityInStock, pre_unit);
            if (isEdited)
            {
                MessageBox.Show($"Details of {ingredientID} is successfully edited.");
                dgvInventory.DataSource = inventoryService.GetAllInventory();
                dgvInventory.Refresh();

                tbxIngredientID.Clear();
                tbxIngredient.Clear();
                tbxQuantity.Clear();
                cbxUnit.ResetText();
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

            // 检测是否有输入
            if (searchInput == "")
            {
                MessageBox.Show("Please enter the search input.");
                return;
            }

            // 搜索Ingredient
            DataTable searchResult = inventoryService.SearchIngredient(searchInput);

            // 检测是否有结果
            if (searchResult.Rows.Count > 0)
            {
                dgvInventory.DataSource = inventoryService.SearchIngredient(searchInput);
                dgvInventory.Refresh();
                btnReturn.Show();

                tbxIngredientID.Clear();
                tbxIngredient.Clear();
                tbxQuantity.Clear();
                cbxUnit.ResetText();
                tbxSearchInput.Clear();
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
            btnReturn.Hide();
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
