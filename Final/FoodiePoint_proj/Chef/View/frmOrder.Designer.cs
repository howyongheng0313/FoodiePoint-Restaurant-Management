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
            this.btnInProgress = new System.Windows.Forms.Button();
            this.gbxOrder = new System.Windows.Forms.GroupBox();
            this.btnCompleted = new System.Windows.Forms.Button();
            this.btnOrderToChef = new System.Windows.Forms.Button();
            this.btnOrderToInventory = new System.Windows.Forms.Button();
            this.btnOrderToProfile = new System.Windows.Forms.Button();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.btnReturnOrder = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnProfileToOrder = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbxOrder.SuspendLayout();
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
            this.gbxOrder.Location = new System.Drawing.Point(64, 8);
            this.gbxOrder.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.gbxOrder.Name = "gbxOrder";
            this.gbxOrder.Padding = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.gbxOrder.Size = new System.Drawing.Size(443, 170);
            this.gbxOrder.TabIndex = 3;
            this.gbxOrder.TabStop = false;
            this.gbxOrder.Text = "Update Order";
            // 
            // btnCompleted
            // 
            this.btnCompleted.Location = new System.Drawing.Point(240, 44);
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
            this.btnOrderToChef.Location = new System.Drawing.Point(10, 323);
            this.btnOrderToChef.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnOrderToChef.Name = "btnOrderToChef";
            this.btnOrderToChef.Size = new System.Drawing.Size(208, 75);
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
            this.btnOrderToInventory.Location = new System.Drawing.Point(10, 98);
            this.btnOrderToInventory.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnOrderToInventory.Name = "btnOrderToInventory";
            this.btnOrderToInventory.Size = new System.Drawing.Size(208, 75);
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
            this.btnOrderToProfile.Location = new System.Drawing.Point(10, 248);
            this.btnOrderToProfile.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnOrderToProfile.Name = "btnOrderToProfile";
            this.btnOrderToProfile.Size = new System.Drawing.Size(208, 75);
            this.btnOrderToProfile.TabIndex = 7;
            this.btnOrderToProfile.Text = "Update Profile Page";
            this.btnOrderToProfile.UseVisualStyleBackColor = true;
            this.btnOrderToProfile.Click += new System.EventHandler(this.btnOrderToProfile_Click);
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.AllowUserToResizeRows = false;
            this.dgvOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(32, 26);
            this.dgvOrders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvOrders.MultiSelect = false;
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.RowHeadersVisible = false;
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.RowTemplate.Height = 24;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(808, 389);
            this.dgvOrders.TabIndex = 7;
            this.dgvOrders.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellContentDoubleClick);
            // 
            // btnReturnOrder
            // 
            this.btnReturnOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturnOrder.Location = new System.Drawing.Point(657, 555);
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
            this.splitContainer1.Panel1.Controls.Add(this.btnProfileToOrder);
            this.splitContainer1.Panel1.Controls.Add(this.btnOrderToInventory);
            this.splitContainer1.Panel1.Controls.Add(this.lblLogo);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel2.Controls.Add(this.btnReturnOrder);
            this.splitContainer1.Panel2.Controls.Add(this.dgvOrders);
            this.splitContainer1.Size = new System.Drawing.Size(1082, 673);
            this.splitContainer1.SplitterDistance = 228;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 8;
            // 
            // btnProfileToOrder
            // 
            this.btnProfileToOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnProfileToOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfileToOrder.Enabled = false;
            this.btnProfileToOrder.FlatAppearance.BorderSize = 0;
            this.btnProfileToOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfileToOrder.Location = new System.Drawing.Point(10, 173);
            this.btnProfileToOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProfileToOrder.Name = "btnProfileToOrder";
            this.btnProfileToOrder.Size = new System.Drawing.Size(208, 75);
            this.btnProfileToOrder.TabIndex = 16;
            this.btnProfileToOrder.Text = "Orders Page";
            this.btnProfileToOrder.UseVisualStyleBackColor = false;
            // 
            // lblLogo
            // 
            this.lblLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogo.Font = new System.Drawing.Font("Jokerman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(10, 0);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(208, 98);
            this.lblLogo.TabIndex = 17;
            this.lblLogo.Text = "Foodie Point";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gbxOrder, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(32, 445);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(616, 199);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // frmOrderPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 673);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmOrderPage";
            this.Text = "Orders Page";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.gbxOrder.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Button btnReturnOrder;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnProfileToOrder;
        private System.Windows.Forms.Label lblLogo;
    }
}