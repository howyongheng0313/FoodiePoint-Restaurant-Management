namespace FoodiePointManagementSystem
{
    partial class frmOrderPage
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
            this.components = new System.ComponentModel.Container();
            this.btnInProgress = new System.Windows.Forms.Button();
            this.gbxOrder = new System.Windows.Forms.GroupBox();
            this.btnCompleted = new System.Windows.Forms.Button();
            this.btnOrderToChef = new System.Windows.Forms.Button();
            this.btnOrderToInventory = new System.Windows.Forms.Button();
            this.btnOrderToProfile = new System.Windows.Forms.Button();
            this.foodiePointDataSet = new FoodiePointManagementSystem.FoodiePointDataSet();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new FoodiePointManagementSystem.FoodiePointDataSetTableAdapters.OrdersTableAdapter();
            this.tableAdapterManager = new FoodiePointManagementSystem.FoodiePointDataSetTableAdapters.TableAdapterManager();
            this.foodiePointDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.btnReturnOrder = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodiePointDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodiePointDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInProgress
            // 
            this.btnInProgress.Location = new System.Drawing.Point(33, 44);
            this.btnInProgress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInProgress.Name = "btnInProgress";
            this.btnInProgress.Size = new System.Drawing.Size(170, 89);
            this.btnInProgress.TabIndex = 2;
            this.btnInProgress.Text = "In Progress";
            this.btnInProgress.UseVisualStyleBackColor = true;
            this.btnInProgress.Click += new System.EventHandler(this.btnInProgress_Click);
            // 
            // gbxOrder
            // 
            this.gbxOrder.Controls.Add(this.btnCompleted);
            this.gbxOrder.Controls.Add(this.btnInProgress);
            this.gbxOrder.Location = new System.Drawing.Point(18, 8);
            this.gbxOrder.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.gbxOrder.Name = "gbxOrder";
            this.gbxOrder.Padding = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.gbxOrder.Size = new System.Drawing.Size(410, 170);
            this.gbxOrder.TabIndex = 3;
            this.gbxOrder.TabStop = false;
            this.gbxOrder.Text = "Update Order";
            // 
            // btnCompleted
            // 
            this.btnCompleted.Location = new System.Drawing.Point(212, 44);
            this.btnCompleted.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCompleted.Name = "btnCompleted";
            this.btnCompleted.Size = new System.Drawing.Size(170, 89);
            this.btnCompleted.TabIndex = 3;
            this.btnCompleted.Text = "Completed";
            this.btnCompleted.UseVisualStyleBackColor = true;
            this.btnCompleted.Click += new System.EventHandler(this.btnCompleted_Click);
            // 
            // btnOrderToChef
            // 
            this.btnOrderToChef.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrderToChef.FlatAppearance.BorderSize = 0;
            this.btnOrderToChef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderToChef.Location = new System.Drawing.Point(10, 150);
            this.btnOrderToChef.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnOrderToChef.Name = "btnOrderToChef";
            this.btnOrderToChef.Size = new System.Drawing.Size(290, 75);
            this.btnOrderToChef.TabIndex = 4;
            this.btnOrderToChef.Text = "Chef Main Page";
            this.btnOrderToChef.UseVisualStyleBackColor = true;
            this.btnOrderToChef.Click += new System.EventHandler(this.btnOrderToChef_Click);
            // 
            // btnOrderToInventory
            // 
            this.btnOrderToInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrderToInventory.FlatAppearance.BorderSize = 0;
            this.btnOrderToInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderToInventory.Location = new System.Drawing.Point(10, 0);
            this.btnOrderToInventory.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnOrderToInventory.Name = "btnOrderToInventory";
            this.btnOrderToInventory.Size = new System.Drawing.Size(290, 75);
            this.btnOrderToInventory.TabIndex = 6;
            this.btnOrderToInventory.Text = "Inventory Page";
            this.btnOrderToInventory.UseVisualStyleBackColor = true;
            this.btnOrderToInventory.Click += new System.EventHandler(this.btnOrderToInventory_Click);
            // 
            // btnOrderToProfile
            // 
            this.btnOrderToProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrderToProfile.FlatAppearance.BorderSize = 0;
            this.btnOrderToProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderToProfile.Location = new System.Drawing.Point(10, 75);
            this.btnOrderToProfile.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnOrderToProfile.Name = "btnOrderToProfile";
            this.btnOrderToProfile.Size = new System.Drawing.Size(290, 75);
            this.btnOrderToProfile.TabIndex = 7;
            this.btnOrderToProfile.Text = "Update Profile Page";
            this.btnOrderToProfile.UseVisualStyleBackColor = true;
            this.btnOrderToProfile.Click += new System.EventHandler(this.btnOrderToProfile_Click);
            // 
            // foodiePointDataSet
            // 
            this.foodiePointDataSet.DataSetName = "FoodiePointDataSet";
            this.foodiePointDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.foodiePointDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FeedbacksTableAdapter = null;
            this.tableAdapterManager.HallsTableAdapter = null;
            this.tableAdapterManager.InventoryTableAdapter = null;
            this.tableAdapterManager.MenuTableAdapter = null;
            this.tableAdapterManager.OrderItemTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = this.ordersTableAdapter;
            this.tableAdapterManager.RecipesTableAdapter = null;
            this.tableAdapterManager.RequestsTableAdapter = null;
            this.tableAdapterManager.ReservationsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FoodiePointManagementSystem.FoodiePointDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // foodiePointDataSetBindingSource
            // 
            this.foodiePointDataSetBindingSource.DataSource = this.foodiePointDataSet;
            this.foodiePointDataSetBindingSource.Position = 0;
            // 
            // dgvOrders
            // 
            this.dgvOrders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrders.AutoGenerateColumns = false;
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.dateTimeDataGridViewTextBoxColumn,
            this.orderStatusDataGridViewTextBoxColumn});
            this.dgvOrders.DataSource = this.ordersBindingSource;
            this.dgvOrders.Location = new System.Drawing.Point(32, 26);
            this.dgvOrders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.RowTemplate.Height = 24;
            this.dgvOrders.Size = new System.Drawing.Size(894, 389);
            this.dgvOrders.TabIndex = 7;
            this.dgvOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellContentClick);
            // 
            // btnReturnOrder
            // 
            this.btnReturnOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturnOrder.Location = new System.Drawing.Point(743, 550);
            this.btnReturnOrder.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnReturnOrder.Name = "btnReturnOrder";
            this.btnReturnOrder.Size = new System.Drawing.Size(183, 89);
            this.btnReturnOrder.TabIndex = 4;
            this.btnReturnOrder.Text = "Return Order List";
            this.btnReturnOrder.UseVisualStyleBackColor = true;
            this.btnReturnOrder.Click += new System.EventHandler(this.btnReturnOrder_Click);
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
            this.splitContainer1.Panel1.Controls.Add(this.btnOrderToChef);
            this.splitContainer1.Panel1.Controls.Add(this.btnOrderToProfile);
            this.splitContainer1.Panel1.Controls.Add(this.btnOrderToInventory);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel2.Controls.Add(this.btnReturnOrder);
            this.splitContainer1.Panel2.Controls.Add(this.dgvOrders);
            this.splitContainer1.Size = new System.Drawing.Size(1262, 753);
            this.splitContainer1.SplitterDistance = 310;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gbxOrder, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(32, 498);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(525, 199);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            // 
            // dateTimeDataGridViewTextBoxColumn
            // 
            this.dateTimeDataGridViewTextBoxColumn.DataPropertyName = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn.HeaderText = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateTimeDataGridViewTextBoxColumn.Name = "dateTimeDataGridViewTextBoxColumn";
            // 
            // orderStatusDataGridViewTextBoxColumn
            // 
            this.orderStatusDataGridViewTextBoxColumn.DataPropertyName = "OrderStatus";
            this.orderStatusDataGridViewTextBoxColumn.HeaderText = "OrderStatus";
            this.orderStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderStatusDataGridViewTextBoxColumn.Name = "orderStatusDataGridViewTextBoxColumn";
            // 
            // frmOrderPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 753);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmOrderPage";
            this.Text = "Orders Page";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.gbxOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.foodiePointDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodiePointDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnInProgress;
        private System.Windows.Forms.GroupBox gbxOrder;
        private System.Windows.Forms.Button btnCompleted;
        private System.Windows.Forms.Button btnOrderToChef;
        private System.Windows.Forms.Button btnOrderToInventory;
        private System.Windows.Forms.Button btnOrderToProfile;
        private FoodiePointDataSet foodiePointDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private FoodiePointDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private FoodiePointDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource foodiePointDataSetBindingSource;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Button btnReturnOrder;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderStatusDataGridViewTextBoxColumn;
    }
}