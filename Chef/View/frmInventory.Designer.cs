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
            this.btnDeleteIngredient = new System.Windows.Forms.Button();
            this.tbxIngredientID = new System.Windows.Forms.TextBox();
            this.lblIngredientID = new System.Windows.Forms.Label();
            this.btnSearchIngredient = new System.Windows.Forms.Button();
            this.btnInventoryToChef = new System.Windows.Forms.Button();
            this.btnInventoryToProfile = new System.Windows.Forms.Button();
            this.btnInventoryToOrder = new System.Windows.Forms.Button();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.btnAddIngredient = new System.Windows.Forms.Button();
            this.lblIngredient = new System.Windows.Forms.Label();
            this.tbxIngredient = new System.Windows.Forms.TextBox();
            this.btnEditIngredient = new System.Windows.Forms.Button();
            this.lblAmount = new System.Windows.Forms.Label();
            this.tbxQuantity = new System.Windows.Forms.TextBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.cbxUnit = new System.Windows.Forms.ComboBox();
            this.gbxInventoryManagement = new System.Windows.Forms.GroupBox();
            this.tbxSearchInput = new System.Windows.Forms.TextBox();
            this.lblSearchIngredient = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.feedbacksTableAdapter1 = new FoodiePointManagementSystem.FoodiePointDataSetTableAdapters.FeedbacksTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.gbxInventoryManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInventory
            // 
            this.dgvInventory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventory.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Location = new System.Drawing.Point(19, 26);
            this.dgvInventory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.RowHeadersWidth = 51;
            this.dgvInventory.RowTemplate.Height = 24;
            this.dgvInventory.Size = new System.Drawing.Size(874, 385);
            this.dgvInventory.TabIndex = 0;
            // 
            // btnDeleteIngredient
            // 
            this.btnDeleteIngredient.Location = new System.Drawing.Point(554, 224);
            this.btnDeleteIngredient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteIngredient.Name = "btnDeleteIngredient";
            this.btnDeleteIngredient.Size = new System.Drawing.Size(177, 80);
            this.btnDeleteIngredient.TabIndex = 5;
            this.btnDeleteIngredient.Text = "Delete ";
            this.btnDeleteIngredient.UseVisualStyleBackColor = true;
            this.btnDeleteIngredient.Click += new System.EventHandler(this.btnDeleteIngredient_Click);
            // 
            // tbxIngredientID
            // 
            this.tbxIngredientID.Location = new System.Drawing.Point(207, 106);
            this.tbxIngredientID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxIngredientID.Name = "tbxIngredientID";
            this.tbxIngredientID.Size = new System.Drawing.Size(182, 30);
            this.tbxIngredientID.TabIndex = 1;
            // 
            // lblIngredientID
            // 
            this.lblIngredientID.AutoSize = true;
            this.lblIngredientID.Location = new System.Drawing.Point(76, 109);
            this.lblIngredientID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIngredientID.Name = "lblIngredientID";
            this.lblIngredientID.Size = new System.Drawing.Size(123, 25);
            this.lblIngredientID.TabIndex = 2;
            this.lblIngredientID.Text = "IngredientID:";
            // 
            // btnSearchIngredient
            // 
            this.btnSearchIngredient.Location = new System.Drawing.Point(392, 224);
            this.btnSearchIngredient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchIngredient.Name = "btnSearchIngredient";
            this.btnSearchIngredient.Size = new System.Drawing.Size(154, 80);
            this.btnSearchIngredient.TabIndex = 3;
            this.btnSearchIngredient.Text = "Search";
            this.btnSearchIngredient.UseVisualStyleBackColor = true;
            this.btnSearchIngredient.Click += new System.EventHandler(this.btnSearchIngredient_Click);
            // 
            // btnInventoryToChef
            // 
            this.btnInventoryToChef.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventoryToChef.FlatAppearance.BorderSize = 0;
            this.btnInventoryToChef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventoryToChef.Location = new System.Drawing.Point(10, 150);
            this.btnInventoryToChef.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInventoryToChef.Name = "btnInventoryToChef";
            this.btnInventoryToChef.Size = new System.Drawing.Size(225, 75);
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
            this.btnInventoryToProfile.Location = new System.Drawing.Point(10, 75);
            this.btnInventoryToProfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInventoryToProfile.Name = "btnInventoryToProfile";
            this.btnInventoryToProfile.Size = new System.Drawing.Size(225, 75);
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
            this.btnInventoryToOrder.Location = new System.Drawing.Point(10, 0);
            this.btnInventoryToOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInventoryToOrder.Name = "btnInventoryToOrder";
            this.btnInventoryToOrder.Size = new System.Drawing.Size(225, 75);
            this.btnInventoryToOrder.TabIndex = 11;
            this.btnInventoryToOrder.Text = "Orders Page";
            this.btnInventoryToOrder.UseVisualStyleBackColor = true;
            this.btnInventoryToOrder.Click += new System.EventHandler(this.btnInventoryToOrder_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // btnAddIngredient
            // 
            this.btnAddIngredient.Location = new System.Drawing.Point(41, 224);
            this.btnAddIngredient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddIngredient.Name = "btnAddIngredient";
            this.btnAddIngredient.Size = new System.Drawing.Size(158, 78);
            this.btnAddIngredient.TabIndex = 3;
            this.btnAddIngredient.Text = "Add ";
            this.btnAddIngredient.UseVisualStyleBackColor = true;
            this.btnAddIngredient.Click += new System.EventHandler(this.btnAddIngredient_Click);
            // 
            // lblIngredient
            // 
            this.lblIngredient.AutoSize = true;
            this.lblIngredient.Location = new System.Drawing.Point(428, 109);
            this.lblIngredient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIngredient.Name = "lblIngredient";
            this.lblIngredient.Size = new System.Drawing.Size(104, 25);
            this.lblIngredient.TabIndex = 2;
            this.lblIngredient.Text = "Ingredient:";
            // 
            // tbxIngredient
            // 
            this.tbxIngredient.Location = new System.Drawing.Point(541, 104);
            this.tbxIngredient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxIngredient.Name = "tbxIngredient";
            this.tbxIngredient.Size = new System.Drawing.Size(182, 30);
            this.tbxIngredient.TabIndex = 1;
            // 
            // btnEditIngredient
            // 
            this.btnEditIngredient.Location = new System.Drawing.Point(207, 224);
            this.btnEditIngredient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditIngredient.Name = "btnEditIngredient";
            this.btnEditIngredient.Size = new System.Drawing.Size(177, 80);
            this.btnEditIngredient.TabIndex = 5;
            this.btnEditIngredient.Text = "Edit ";
            this.btnEditIngredient.UseVisualStyleBackColor = true;
            this.btnEditIngredient.Click += new System.EventHandler(this.btnEditIngredient_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(108, 170);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(91, 25);
            this.lblAmount.TabIndex = 6;
            this.lblAmount.Text = "Quantity:";
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.Location = new System.Drawing.Point(207, 170);
            this.tbxQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.Size = new System.Drawing.Size(182, 30);
            this.tbxQuantity.TabIndex = 7;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(482, 170);
            this.lblUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(52, 25);
            this.lblUnit.TabIndex = 8;
            this.lblUnit.Text = "Unit:";
            // 
            // cbxUnit
            // 
            this.cbxUnit.FormattingEnabled = true;
            this.cbxUnit.Items.AddRange(new object[] {
            "kilogram",
            "pieces",
            "litre"});
            this.cbxUnit.Location = new System.Drawing.Point(541, 165);
            this.cbxUnit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxUnit.Name = "cbxUnit";
            this.cbxUnit.Size = new System.Drawing.Size(180, 33);
            this.cbxUnit.TabIndex = 9;
            // 
            // gbxInventoryManagement
            // 
            this.gbxInventoryManagement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxInventoryManagement.Controls.Add(this.tbxSearchInput);
            this.gbxInventoryManagement.Controls.Add(this.lblSearchIngredient);
            this.gbxInventoryManagement.Controls.Add(this.cbxUnit);
            this.gbxInventoryManagement.Controls.Add(this.btnDeleteIngredient);
            this.gbxInventoryManagement.Controls.Add(this.lblIngredient);
            this.gbxInventoryManagement.Controls.Add(this.btnSearchIngredient);
            this.gbxInventoryManagement.Controls.Add(this.btnEditIngredient);
            this.gbxInventoryManagement.Controls.Add(this.tbxIngredient);
            this.gbxInventoryManagement.Controls.Add(this.lblAmount);
            this.gbxInventoryManagement.Controls.Add(this.btnAddIngredient);
            this.gbxInventoryManagement.Controls.Add(this.lblIngredientID);
            this.gbxInventoryManagement.Controls.Add(this.tbxQuantity);
            this.gbxInventoryManagement.Controls.Add(this.tbxIngredientID);
            this.gbxInventoryManagement.Controls.Add(this.lblUnit);
            this.gbxInventoryManagement.Location = new System.Drawing.Point(-1, 5);
            this.gbxInventoryManagement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxInventoryManagement.Name = "gbxInventoryManagement";
            this.gbxInventoryManagement.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxInventoryManagement.Size = new System.Drawing.Size(792, 312);
            this.gbxInventoryManagement.TabIndex = 12;
            this.gbxInventoryManagement.TabStop = false;
            this.gbxInventoryManagement.Text = "Inventory Management";
            // 
            // tbxSearchInput
            // 
            this.tbxSearchInput.Location = new System.Drawing.Point(207, 47);
            this.tbxSearchInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxSearchInput.Name = "tbxSearchInput";
            this.tbxSearchInput.Size = new System.Drawing.Size(516, 30);
            this.tbxSearchInput.TabIndex = 11;
            // 
            // lblSearchIngredient
            // 
            this.lblSearchIngredient.AutoSize = true;
            this.lblSearchIngredient.Location = new System.Drawing.Point(27, 50);
            this.lblSearchIngredient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchIngredient.Name = "lblSearchIngredient";
            this.lblSearchIngredient.Size = new System.Drawing.Size(172, 25);
            this.lblSearchIngredient.TabIndex = 10;
            this.lblSearchIngredient.Text = "Search Ingredient:";
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
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);

            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel2.Controls.Add(this.dgvInventory);
            this.splitContainer1.Size = new System.Drawing.Size(1182, 753);
            this.splitContainer1.SplitterDistance = 245;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnReturn);
            this.panel1.Location = new System.Drawing.Point(833, 649);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(85, 87);
            this.panel1.TabIndex = 13;
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturn.Location = new System.Drawing.Point(4, 5);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(81, 80);
            this.btnReturn.TabIndex = 12;
            this.btnReturn.Text = "Return ";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 800F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gbxInventoryManagement, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(19, 419);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(790, 322);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // feedbacksTableAdapter1
            // 
            this.feedbacksTableAdapter1.ClearBeforeFill = true;
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmInventory";
            this.Text = "Inventory Page";
            this.Load += new System.EventHandler(this.frmInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.gbxInventoryManagement.ResumeLayout(false);
            this.gbxInventoryManagement.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.Button btnDeleteIngredient;
        private System.Windows.Forms.TextBox tbxIngredientID;
        private System.Windows.Forms.Label lblIngredientID;
        private System.Windows.Forms.Button btnSearchIngredient;
        private System.Windows.Forms.Button btnInventoryToChef;
        private System.Windows.Forms.Button btnInventoryToProfile;
        private System.Windows.Forms.Button btnInventoryToOrder;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Button btnEditIngredient;
        private System.Windows.Forms.ComboBox cbxUnit;
        private System.Windows.Forms.Button btnAddIngredient;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.TextBox tbxQuantity;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox tbxIngredient;
        private System.Windows.Forms.Label lblIngredient;
        private System.Windows.Forms.GroupBox gbxInventoryManagement;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FoodiePointDataSetTableAdapters.FeedbacksTableAdapter feedbacksTableAdapter1;
        private System.Windows.Forms.TextBox tbxSearchInput;
        private System.Windows.Forms.Label lblSearchIngredient;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel panel1;
    }
}