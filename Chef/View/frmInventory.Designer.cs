namespace FoodiePointManagementSystem
{
    partial class frmInventory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.tbxIngredient = new System.Windows.Forms.TextBox();
            this.lblIngredient = new System.Windows.Forms.Label();
            this.btnAddIngredient = new System.Windows.Forms.Button();
            this.btnEditIngredient = new System.Windows.Forms.Button();
            this.gbxAddEdit = new System.Windows.Forms.GroupBox();
            this.tbx = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.gbxSearchDelete = new System.Windows.Forms.GroupBox();
            this.btnDeleteIngredient = new System.Windows.Forms.Button();
            this.tbxSearchDelete = new System.Windows.Forms.TextBox();
            this.lblSearchDelete = new System.Windows.Forms.Label();
            this.btnSearchIngredient = new System.Windows.Forms.Button();
            this.btnInventoryToChef = new System.Windows.Forms.Button();
            this.btnInventoryToProfile = new System.Windows.Forms.Button();
            this.btnInventoryToOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.gbxAddEdit.SuspendLayout();
            this.gbxSearchDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInventory
            // 
            this.dgvInventory.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Location = new System.Drawing.Point(145, 10);
            this.dgvInventory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.RowHeadersWidth = 51;
            this.dgvInventory.RowTemplate.Height = 24;
            this.dgvInventory.Size = new System.Drawing.Size(246, 346);
            this.dgvInventory.TabIndex = 0;
            // 
            // tbxIngredient
            // 
            this.tbxIngredient.Location = new System.Drawing.Point(85, 27);
            this.tbxIngredient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxIngredient.Name = "tbxIngredient";
            this.tbxIngredient.Size = new System.Drawing.Size(93, 20);
            this.tbxIngredient.TabIndex = 1;
            // 
            // lblIngredient
            // 
            this.lblIngredient.AutoSize = true;
            this.lblIngredient.Location = new System.Drawing.Point(24, 29);
            this.lblIngredient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIngredient.Name = "lblIngredient";
            this.lblIngredient.Size = new System.Drawing.Size(57, 13);
            this.lblIngredient.TabIndex = 2;
            this.lblIngredient.Text = "Ingredient:";
            // 
            // btnAddIngredient
            // 
            this.btnAddIngredient.Location = new System.Drawing.Point(5, 91);
            this.btnAddIngredient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddIngredient.Name = "btnAddIngredient";
            this.btnAddIngredient.Size = new System.Drawing.Size(79, 41);
            this.btnAddIngredient.TabIndex = 3;
            this.btnAddIngredient.Text = "Add ";
            this.btnAddIngredient.UseVisualStyleBackColor = true;
            this.btnAddIngredient.Click += new System.EventHandler(this.btnAddIngredient_Click);
            // 
            // btnEditIngredient
            // 
            this.btnEditIngredient.Location = new System.Drawing.Point(93, 90);
            this.btnEditIngredient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditIngredient.Name = "btnEditIngredient";
            this.btnEditIngredient.Size = new System.Drawing.Size(88, 41);
            this.btnEditIngredient.TabIndex = 5;
            this.btnEditIngredient.Text = "Edit ";
            this.btnEditIngredient.UseVisualStyleBackColor = true;
            // 
            // gbxAddEdit
            // 
            this.gbxAddEdit.Controls.Add(this.tbx);
            this.gbxAddEdit.Controls.Add(this.lblAmount);
            this.gbxAddEdit.Controls.Add(this.btnEditIngredient);
            this.gbxAddEdit.Controls.Add(this.tbxIngredient);
            this.gbxAddEdit.Controls.Add(this.lblIngredient);
            this.gbxAddEdit.Controls.Add(this.btnAddIngredient);
            this.gbxAddEdit.Location = new System.Drawing.Point(405, 24);
            this.gbxAddEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxAddEdit.Name = "gbxAddEdit";
            this.gbxAddEdit.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxAddEdit.Size = new System.Drawing.Size(186, 141);
            this.gbxAddEdit.TabIndex = 8;
            this.gbxAddEdit.TabStop = false;
            this.gbxAddEdit.Text = "Add/ Edit Ingredients";
            // 
            // tbx
            // 
            this.tbx.Location = new System.Drawing.Point(85, 52);
            this.tbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbx.Name = "tbx";
            this.tbx.Size = new System.Drawing.Size(93, 20);
            this.tbx.TabIndex = 7;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(34, 52);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(46, 13);
            this.lblAmount.TabIndex = 6;
            this.lblAmount.Text = "Amount:";
            // 
            // gbxSearchDelete
            // 
            this.gbxSearchDelete.Controls.Add(this.btnDeleteIngredient);
            this.gbxSearchDelete.Controls.Add(this.tbxSearchDelete);
            this.gbxSearchDelete.Controls.Add(this.lblSearchDelete);
            this.gbxSearchDelete.Controls.Add(this.btnSearchIngredient);
            this.gbxSearchDelete.Location = new System.Drawing.Point(405, 188);
            this.gbxSearchDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxSearchDelete.Name = "gbxSearchDelete";
            this.gbxSearchDelete.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxSearchDelete.Size = new System.Drawing.Size(186, 142);
            this.gbxSearchDelete.TabIndex = 9;
            this.gbxSearchDelete.TabStop = false;
            this.gbxSearchDelete.Text = "Search/ Delete Ingredients";
            // 
            // btnDeleteIngredient
            // 
            this.btnDeleteIngredient.Location = new System.Drawing.Point(93, 92);
            this.btnDeleteIngredient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteIngredient.Name = "btnDeleteIngredient";
            this.btnDeleteIngredient.Size = new System.Drawing.Size(88, 41);
            this.btnDeleteIngredient.TabIndex = 5;
            this.btnDeleteIngredient.Text = "Delete ";
            this.btnDeleteIngredient.UseVisualStyleBackColor = true;
            this.btnDeleteIngredient.Click += new System.EventHandler(this.btnDeleteIngredient_Click);
            // 
            // tbxSearchDelete
            // 
            this.tbxSearchDelete.Location = new System.Drawing.Point(26, 54);
            this.tbxSearchDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxSearchDelete.Name = "tbxSearchDelete";
            this.tbxSearchDelete.Size = new System.Drawing.Size(93, 20);
            this.tbxSearchDelete.TabIndex = 1;
            // 
            // lblSearchDelete
            // 
            this.lblSearchDelete.AutoSize = true;
            this.lblSearchDelete.Location = new System.Drawing.Point(24, 26);
            this.lblSearchDelete.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchDelete.Name = "lblSearchDelete";
            this.lblSearchDelete.Size = new System.Drawing.Size(165, 13);
            this.lblSearchDelete.TabIndex = 2;
            this.lblSearchDelete.Text = "Enter ingredient to search/ delete";
            this.lblSearchDelete.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSearchIngredient
            // 
            this.btnSearchIngredient.Location = new System.Drawing.Point(7, 92);
            this.btnSearchIngredient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchIngredient.Name = "btnSearchIngredient";
            this.btnSearchIngredient.Size = new System.Drawing.Size(77, 41);
            this.btnSearchIngredient.TabIndex = 3;
            this.btnSearchIngredient.Text = "Search";
            this.btnSearchIngredient.UseVisualStyleBackColor = true;
            // 
            // btnInventoryToChef
            // 
            this.btnInventoryToChef.Location = new System.Drawing.Point(20, 62);
            this.btnInventoryToChef.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInventoryToChef.Name = "btnInventoryToChef";
            this.btnInventoryToChef.Size = new System.Drawing.Size(108, 39);
            this.btnInventoryToChef.TabIndex = 6;
            this.btnInventoryToChef.Text = "Chef Main Page";
            this.btnInventoryToChef.UseVisualStyleBackColor = true;
            this.btnInventoryToChef.Click += new System.EventHandler(this.btnInventoryToChef_Click);
            // 
            // btnInventoryToProfile
            // 
            this.btnInventoryToProfile.Location = new System.Drawing.Point(20, 188);
            this.btnInventoryToProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInventoryToProfile.Name = "btnInventoryToProfile";
            this.btnInventoryToProfile.Size = new System.Drawing.Size(108, 39);
            this.btnInventoryToProfile.TabIndex = 10;
            this.btnInventoryToProfile.Text = "Update Profile Page";
            this.btnInventoryToProfile.UseVisualStyleBackColor = true;
            this.btnInventoryToProfile.Click += new System.EventHandler(this.btnInventoryToProfile_Click);
            // 
            // btnInventoryToOrder
            // 
            this.btnInventoryToOrder.Location = new System.Drawing.Point(20, 125);
            this.btnInventoryToOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInventoryToOrder.Name = "btnInventoryToOrder";
            this.btnInventoryToOrder.Size = new System.Drawing.Size(108, 39);
            this.btnInventoryToOrder.TabIndex = 11;
            this.btnInventoryToOrder.Text = "Orders Page";
            this.btnInventoryToOrder.UseVisualStyleBackColor = true;
            this.btnInventoryToOrder.Click += new System.EventHandler(this.btnInventoryToOrder_Click);
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnInventoryToOrder);
            this.Controls.Add(this.btnInventoryToProfile);
            this.Controls.Add(this.btnInventoryToChef);
            this.Controls.Add(this.gbxSearchDelete);
            this.Controls.Add(this.gbxAddEdit);
            this.Controls.Add(this.dgvInventory);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmInventory";
            this.Text = "Inventory Page";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.gbxAddEdit.ResumeLayout(false);
            this.gbxAddEdit.PerformLayout();
            this.gbxSearchDelete.ResumeLayout(false);
            this.gbxSearchDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.TextBox tbxIngredient;
        private System.Windows.Forms.Label lblIngredient;
        private System.Windows.Forms.Button btnAddIngredient;
        private System.Windows.Forms.Button btnEditIngredient;
        private System.Windows.Forms.GroupBox gbxAddEdit;
        private System.Windows.Forms.GroupBox gbxSearchDelete;
        private System.Windows.Forms.Button btnDeleteIngredient;
        private System.Windows.Forms.TextBox tbxSearchDelete;
        private System.Windows.Forms.Label lblSearchDelete;
        private System.Windows.Forms.Button btnSearchIngredient;
        private System.Windows.Forms.Button btnInventoryToChef;
        private System.Windows.Forms.TextBox tbx;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnInventoryToProfile;
        private System.Windows.Forms.Button btnInventoryToOrder;
    }
}