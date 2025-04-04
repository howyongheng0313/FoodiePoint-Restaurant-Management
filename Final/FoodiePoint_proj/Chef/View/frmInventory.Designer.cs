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
            this.btnInventoryToChef = new System.Windows.Forms.Button();
            this.btnInventoryToProfile = new System.Windows.Forms.Button();
            this.btnInventoryToOrder = new System.Windows.Forms.Button();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnOrderToInventory = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbxSearchInput = new System.Windows.Forms.TextBox();
            this.btnSearchIngredient = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.gbxActions = new System.Windows.Forms.GroupBox();
            this.btnAddIngredient = new System.Windows.Forms.Button();
            this.btnEditIngredient = new System.Windows.Forms.Button();
            this.btnDeleteIngredient = new System.Windows.Forms.Button();
            this.lblIngredientID = new System.Windows.Forms.Label();
            this.cbxUnit = new System.Windows.Forms.ComboBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.tbxQuantity = new System.Windows.Forms.TextBox();
            this.lblIngredient = new System.Windows.Forms.Label();
            this.tbxIngredient = new System.Windows.Forms.TextBox();
            this.tbxIngredientID = new System.Windows.Forms.TextBox();
            this.lblLogo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbxActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.AllowUserToResizeRows = false;
            this.dgvInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventory.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Location = new System.Drawing.Point(31, 91);
            this.dgvInventory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvInventory.MultiSelect = false;
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.RowHeadersVisible = false;
            this.dgvInventory.RowHeadersWidth = 51;
            this.dgvInventory.RowTemplate.Height = 24;
            this.dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventory.Size = new System.Drawing.Size(791, 267);
            this.dgvInventory.TabIndex = 0;
            // 
            // btnInventoryToChef
            // 
            this.btnInventoryToChef.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventoryToChef.FlatAppearance.BorderSize = 0;
            this.btnInventoryToChef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventoryToChef.Location = new System.Drawing.Point(10, 323);
            this.btnInventoryToChef.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInventoryToChef.Name = "btnInventoryToChef";
            this.btnInventoryToChef.Size = new System.Drawing.Size(208, 75);
            this.btnInventoryToChef.TabIndex = 6;
            this.btnInventoryToChef.Text = "Chef Main Page";
            this.btnInventoryToChef.UseVisualStyleBackColor = true;
            this.btnInventoryToChef.Click += new System.EventHandler(this.btnInventoryToChef_Click);
            // 
            // btnInventoryToProfile
            // 
            this.btnInventoryToProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventoryToProfile.FlatAppearance.BorderSize = 0;
            this.btnInventoryToProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventoryToProfile.Location = new System.Drawing.Point(10, 248);
            this.btnInventoryToProfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInventoryToProfile.Name = "btnInventoryToProfile";
            this.btnInventoryToProfile.Size = new System.Drawing.Size(208, 75);
            this.btnInventoryToProfile.TabIndex = 10;
            this.btnInventoryToProfile.Text = "Update Profile Page";
            this.btnInventoryToProfile.UseVisualStyleBackColor = true;
            this.btnInventoryToProfile.Click += new System.EventHandler(this.btnInventoryToProfile_Click);
            // 
            // btnInventoryToOrder
            // 
            this.btnInventoryToOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventoryToOrder.FlatAppearance.BorderSize = 0;
            this.btnInventoryToOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventoryToOrder.Location = new System.Drawing.Point(10, 173);
            this.btnInventoryToOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInventoryToOrder.Name = "btnInventoryToOrder";
            this.btnInventoryToOrder.Size = new System.Drawing.Size(208, 75);
            this.btnInventoryToOrder.TabIndex = 11;
            this.btnInventoryToOrder.Text = "Orders Page";
            this.btnInventoryToOrder.UseVisualStyleBackColor = true;
            this.btnInventoryToOrder.Click += new System.EventHandler(this.btnInventoryToOrder_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnInventoryToChef);
            this.splitContainer1.Panel1.Controls.Add(this.btnInventoryToProfile);
            this.splitContainer1.Panel1.Controls.Add(this.btnInventoryToOrder);
            this.splitContainer1.Panel1.Controls.Add(this.btnOrderToInventory);
            this.splitContainer1.Panel1.Controls.Add(this.lblLogo);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnConfirm);
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel2.Controls.Add(this.gbxActions);
            this.splitContainer1.Panel2.Controls.Add(this.lblIngredientID);
            this.splitContainer1.Panel2.Controls.Add(this.dgvInventory);
            this.splitContainer1.Panel2.Controls.Add(this.cbxUnit);
            this.splitContainer1.Panel2.Controls.Add(this.lblAmount);
            this.splitContainer1.Panel2.Controls.Add(this.lblUnit);
            this.splitContainer1.Panel2.Controls.Add(this.tbxQuantity);
            this.splitContainer1.Panel2.Controls.Add(this.lblIngredient);
            this.splitContainer1.Panel2.Controls.Add(this.tbxIngredient);
            this.splitContainer1.Panel2.Controls.Add(this.tbxIngredientID);
            this.splitContainer1.Size = new System.Drawing.Size(1082, 673);
            this.splitContainer1.SplitterDistance = 228;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 13;
            // 
            // btnOrderToInventory
            // 
            this.btnOrderToInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnOrderToInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrderToInventory.Enabled = false;
            this.btnOrderToInventory.FlatAppearance.BorderSize = 0;
            this.btnOrderToInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderToInventory.Location = new System.Drawing.Point(10, 98);
            this.btnOrderToInventory.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnOrderToInventory.Name = "btnOrderToInventory";
            this.btnOrderToInventory.Size = new System.Drawing.Size(208, 75);
            this.btnOrderToInventory.TabIndex = 12;
            this.btnOrderToInventory.Text = "Inventory Page";
            this.btnOrderToInventory.UseVisualStyleBackColor = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.Location = new System.Drawing.Point(676, 571);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(146, 59);
            this.btnConfirm.TabIndex = 14;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tbxSearchInput, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSearchIngredient, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnReturn, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(831, 40);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // tbxSearchInput
            // 
            this.tbxSearchInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxSearchInput.Location = new System.Drawing.Point(4, 5);
            this.tbxSearchInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxSearchInput.Name = "tbxSearchInput";
            this.tbxSearchInput.Size = new System.Drawing.Size(503, 30);
            this.tbxSearchInput.TabIndex = 11;
            // 
            // btnSearchIngredient
            // 
            this.btnSearchIngredient.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearchIngredient.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchIngredient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchIngredient.Location = new System.Drawing.Point(515, 5);
            this.btnSearchIngredient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchIngredient.Name = "btnSearchIngredient";
            this.btnSearchIngredient.Size = new System.Drawing.Size(152, 30);
            this.btnSearchIngredient.TabIndex = 3;
            this.btnSearchIngredient.Text = "Search";
            this.btnSearchIngredient.UseVisualStyleBackColor = false;
            this.btnSearchIngredient.Click += new System.EventHandler(this.btnSearchIngredient_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReturn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReturn.Location = new System.Drawing.Point(675, 5);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(152, 30);
            this.btnReturn.TabIndex = 12;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // gbxActions
            // 
            this.gbxActions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbxActions.Controls.Add(this.btnAddIngredient);
            this.gbxActions.Controls.Add(this.btnEditIngredient);
            this.gbxActions.Controls.Add(this.btnDeleteIngredient);
            this.gbxActions.Location = new System.Drawing.Point(31, 377);
            this.gbxActions.Name = "gbxActions";
            this.gbxActions.Size = new System.Drawing.Size(488, 134);
            this.gbxActions.TabIndex = 15;
            this.gbxActions.TabStop = false;
            this.gbxActions.Text = "Select 1 Action: ";
            // 
            // btnAddIngredient
            // 
            this.btnAddIngredient.Location = new System.Drawing.Point(16, 43);
            this.btnAddIngredient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddIngredient.Name = "btnAddIngredient";
            this.btnAddIngredient.Size = new System.Drawing.Size(146, 59);
            this.btnAddIngredient.TabIndex = 3;
            this.btnAddIngredient.Text = "Add ";
            this.btnAddIngredient.UseVisualStyleBackColor = true;
            this.btnAddIngredient.Click += new System.EventHandler(this.btnAddIngredient_Click);
            // 
            // btnEditIngredient
            // 
            this.btnEditIngredient.Location = new System.Drawing.Point(170, 43);
            this.btnEditIngredient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditIngredient.Name = "btnEditIngredient";
            this.btnEditIngredient.Size = new System.Drawing.Size(146, 59);
            this.btnEditIngredient.TabIndex = 5;
            this.btnEditIngredient.Text = "Edit ";
            this.btnEditIngredient.UseVisualStyleBackColor = true;
            this.btnEditIngredient.Click += new System.EventHandler(this.btnEditIngredient_Click);
            // 
            // btnDeleteIngredient
            // 
            this.btnDeleteIngredient.Location = new System.Drawing.Point(324, 43);
            this.btnDeleteIngredient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteIngredient.Name = "btnDeleteIngredient";
            this.btnDeleteIngredient.Size = new System.Drawing.Size(146, 59);
            this.btnDeleteIngredient.TabIndex = 5;
            this.btnDeleteIngredient.Text = "Delete ";
            this.btnDeleteIngredient.UseVisualStyleBackColor = true;
            this.btnDeleteIngredient.Click += new System.EventHandler(this.btnDeleteIngredient_Click);
            // 
            // lblIngredientID
            // 
            this.lblIngredientID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblIngredientID.AutoSize = true;
            this.lblIngredientID.Location = new System.Drawing.Point(34, 554);
            this.lblIngredientID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIngredientID.Name = "lblIngredientID";
            this.lblIngredientID.Size = new System.Drawing.Size(123, 25);
            this.lblIngredientID.TabIndex = 2;
            this.lblIngredientID.Text = "IngredientID:";
            // 
            // cbxUnit
            // 
            this.cbxUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxUnit.FormattingEnabled = true;
            this.cbxUnit.Items.AddRange(new object[] {
            "kilogram",
            "pieces",
            "litre"});
            this.cbxUnit.Location = new System.Drawing.Point(476, 597);
            this.cbxUnit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxUnit.Name = "cbxUnit";
            this.cbxUnit.Size = new System.Drawing.Size(180, 33);
            this.cbxUnit.TabIndex = 9;
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(66, 600);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(91, 25);
            this.lblAmount.TabIndex = 6;
            this.lblAmount.Text = "Quantity:";
            // 
            // lblUnit
            // 
            this.lblUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(416, 600);
            this.lblUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(52, 25);
            this.lblUnit.TabIndex = 8;
            this.lblUnit.Text = "Unit:";
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxQuantity.Location = new System.Drawing.Point(165, 600);
            this.tbxQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.Size = new System.Drawing.Size(182, 30);
            this.tbxQuantity.TabIndex = 7;
            // 
            // lblIngredient
            // 
            this.lblIngredient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblIngredient.AutoSize = true;
            this.lblIngredient.Location = new System.Drawing.Point(364, 552);
            this.lblIngredient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIngredient.Name = "lblIngredient";
            this.lblIngredient.Size = new System.Drawing.Size(104, 25);
            this.lblIngredient.TabIndex = 2;
            this.lblIngredient.Text = "Ingredient:";
            // 
            // tbxIngredient
            // 
            this.tbxIngredient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxIngredient.Location = new System.Drawing.Point(476, 549);
            this.tbxIngredient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxIngredient.Name = "tbxIngredient";
            this.tbxIngredient.Size = new System.Drawing.Size(182, 30);
            this.tbxIngredient.TabIndex = 1;
            // 
            // tbxIngredientID
            // 
            this.tbxIngredientID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxIngredientID.Location = new System.Drawing.Point(165, 549);
            this.tbxIngredientID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxIngredientID.Name = "tbxIngredientID";
            this.tbxIngredientID.Size = new System.Drawing.Size(182, 30);
            this.tbxIngredientID.TabIndex = 1;
            // 
            // lblLogo
            // 
            this.lblLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogo.Font = new System.Drawing.Font("Jokerman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(10, 0);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(208, 98);
            this.lblLogo.TabIndex = 13;
            this.lblLogo.Text = "Foodie Point";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 673);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmInventory";
            this.Text = "Inventory Page";
            this.Load += new System.EventHandler(this.frmInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gbxActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.Button btnInventoryToChef;
        private System.Windows.Forms.Button btnInventoryToProfile;
        private System.Windows.Forms.Button btnInventoryToOrder;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox tbxSearchInput;
        private System.Windows.Forms.Button btnAddIngredient;
        private System.Windows.Forms.Label lblIngredientID;
        private System.Windows.Forms.ComboBox cbxUnit;
        private System.Windows.Forms.Button btnSearchIngredient;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.TextBox tbxQuantity;
        private System.Windows.Forms.Button btnEditIngredient;
        private System.Windows.Forms.Button btnDeleteIngredient;
        private System.Windows.Forms.Label lblIngredient;
        private System.Windows.Forms.TextBox tbxIngredient;
        private System.Windows.Forms.TextBox tbxIngredientID;
        private System.Windows.Forms.GroupBox gbxActions;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnOrderToInventory;
        private System.Windows.Forms.Label lblLogo;
    }
}