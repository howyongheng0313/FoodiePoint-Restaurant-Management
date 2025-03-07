namespace new_customer
{
    partial class frmMenuPage
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button6 = new System.Windows.Forms.Button();
            this.btnMenuToHallReservation = new System.Windows.Forms.Button();
            this.btnMenuToProfile = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.foodiepointDbDataSet = new Customer.FoodiepointDbDataSet();
            this.btnViewOrder = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.menuBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.foodiepointDbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.menuBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.menuBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Customer.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuTableAdapter = new Customer.FoodiepointDbDataSetTableAdapters.MenuTableAdapter();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.Search_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodiepointDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodiepointDbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LightCoral;
            this.splitContainer1.Panel1.Controls.Add(this.button6);
            this.splitContainer1.Panel1.Controls.Add(this.btnMenuToHallReservation);
            this.splitContainer1.Panel1.Controls.Add(this.btnMenuToProfile);
            this.splitContainer1.Panel1.Controls.Add(this.btnMenu);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Search_btn);
            this.splitContainer1.Panel2.Controls.Add(this.search_txt);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Controls.Add(this.btnViewOrder);
            this.splitContainer1.Panel2.Controls.Add(this.btnAddToCart);
            this.splitContainer1.Size = new System.Drawing.Size(776, 426);
            this.splitContainer1.SplitterDistance = 230;
            this.splitContainer1.TabIndex = 4;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(60, 292);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(101, 40);
            this.button6.TabIndex = 12;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // btnMenuToHallReservation
            // 
            this.btnMenuToHallReservation.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMenuToHallReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuToHallReservation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMenuToHallReservation.Location = new System.Drawing.Point(60, 212);
            this.btnMenuToHallReservation.Name = "btnMenuToHallReservation";
            this.btnMenuToHallReservation.Size = new System.Drawing.Size(101, 40);
            this.btnMenuToHallReservation.TabIndex = 11;
            this.btnMenuToHallReservation.Text = "Hall Reservation";
            this.btnMenuToHallReservation.UseVisualStyleBackColor = false;
            this.btnMenuToHallReservation.Click += new System.EventHandler(this.btnMenuToHallReservation_Click);
            // 
            // btnMenuToProfile
            // 
            this.btnMenuToProfile.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMenuToProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuToProfile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMenuToProfile.Location = new System.Drawing.Point(60, 52);
            this.btnMenuToProfile.Name = "btnMenuToProfile";
            this.btnMenuToProfile.Size = new System.Drawing.Size(101, 40);
            this.btnMenuToProfile.TabIndex = 10;
            this.btnMenuToProfile.Text = "Profile";
            this.btnMenuToProfile.UseVisualStyleBackColor = false;
            this.btnMenuToProfile.Click += new System.EventHandler(this.btnMenuToProfile_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMenu.Location = new System.Drawing.Point(60, 134);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(101, 40);
            this.btnMenu.TabIndex = 9;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIDDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.itemPriceDataGridViewTextBoxColumn,
            this.itemCategoryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.menuBindingSource6;
            this.dataGridView1.Location = new System.Drawing.Point(3, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(521, 223);
            this.dataGridView1.TabIndex = 9;
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            this.itemIDDataGridViewTextBoxColumn.DataPropertyName = "ItemID";
            this.itemIDDataGridViewTextBoxColumn.HeaderText = "ItemID";
            this.itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            // 
            // itemPriceDataGridViewTextBoxColumn
            // 
            this.itemPriceDataGridViewTextBoxColumn.DataPropertyName = "ItemPrice";
            this.itemPriceDataGridViewTextBoxColumn.HeaderText = "ItemPrice";
            this.itemPriceDataGridViewTextBoxColumn.Name = "itemPriceDataGridViewTextBoxColumn";
            // 
            // itemCategoryDataGridViewTextBoxColumn
            // 
            this.itemCategoryDataGridViewTextBoxColumn.DataPropertyName = "ItemCategory";
            this.itemCategoryDataGridViewTextBoxColumn.HeaderText = "ItemCategory";
            this.itemCategoryDataGridViewTextBoxColumn.Name = "itemCategoryDataGridViewTextBoxColumn";
            // 
            // menuBindingSource6
            // 
            this.menuBindingSource6.DataMember = "Menu";
            this.menuBindingSource6.DataSource = this.foodiepointDbDataSet;
            // 
            // foodiepointDbDataSet
            // 
            this.foodiepointDbDataSet.DataSetName = "FoodiepointDbDataSet";
            this.foodiepointDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnViewOrder
            // 
            this.btnViewOrder.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnViewOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOrder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnViewOrder.Location = new System.Drawing.Point(138, 358);
            this.btnViewOrder.Name = "btnViewOrder";
            this.btnViewOrder.Size = new System.Drawing.Size(101, 40);
            this.btnViewOrder.TabIndex = 8;
            this.btnViewOrder.Text = "View order";
            this.btnViewOrder.UseVisualStyleBackColor = false;
            this.btnViewOrder.Click += new System.EventHandler(this.btnViewOrder_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddToCart.Location = new System.Drawing.Point(19, 358);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(101, 40);
            this.btnAddToCart.TabIndex = 7;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // menuBindingSource3
            // 
            this.menuBindingSource3.DataMember = "Menu";
            this.menuBindingSource3.DataSource = this.foodiepointDbDataSetBindingSource;
            // 
            // foodiepointDbDataSetBindingSource
            // 
            this.foodiepointDbDataSetBindingSource.DataSource = this.foodiepointDbDataSet;
            this.foodiepointDbDataSetBindingSource.Position = 0;
            // 
            // menuBindingSource4
            // 
            this.menuBindingSource4.DataMember = "Menu";
            this.menuBindingSource4.DataSource = this.foodiepointDbDataSetBindingSource;
            // 
            // menuBindingSource5
            // 
            this.menuBindingSource5.DataMember = "Menu";
            this.menuBindingSource5.DataSource = this.foodiepointDbDataSetBindingSource;
            // 
            // menuBindingSource2
            // 
            this.menuBindingSource2.DataMember = "Menu";
            this.menuBindingSource2.DataSource = this.foodiepointDbDataSet;
            // 
            // menuBindingSource
            // 
            this.menuBindingSource.DataMember = "Menu";
            this.menuBindingSource.DataSource = this.foodiepointDbDataSet;
            // 
            // menuBindingSource1
            // 
            this.menuBindingSource1.DataMember = "Menu";
            this.menuBindingSource1.DataSource = this.foodiepointDbDataSet;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // menuTableAdapter
            // 
            this.menuTableAdapter.ClearBeforeFill = true;
            // 
            // search_txt
            // 
            this.search_txt.Location = new System.Drawing.Point(19, 33);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(100, 20);
            this.search_txt.TabIndex = 10;
            this.search_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Search_btn
            // 
            this.Search_btn.Location = new System.Drawing.Point(185, 33);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(75, 23);
            this.Search_btn.TabIndex = 11;
            this.Search_btn.Text = "Search";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // frmMenuPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmMenuPage";
            this.Text = "Menu Page";
            this.Load += new System.EventHandler(this.frmMenuPage_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodiepointDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodiepointDbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnMenuToHallReservation;
        private System.Windows.Forms.Button btnMenuToProfile;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnViewOrder;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private Customer.DataSet1 dataSet1;
        private Customer.FoodiepointDbDataSet foodiepointDbDataSet;
        private System.Windows.Forms.BindingSource menuBindingSource;
        private Customer.FoodiepointDbDataSetTableAdapters.MenuTableAdapter menuTableAdapter;
        private System.Windows.Forms.BindingSource menuBindingSource1;
        private System.Windows.Forms.BindingSource menuBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource menuBindingSource3;
        private System.Windows.Forms.BindingSource foodiepointDbDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource menuBindingSource6;
        private System.Windows.Forms.BindingSource menuBindingSource4;
        private System.Windows.Forms.BindingSource menuBindingSource5;
        private System.Windows.Forms.TextBox search_txt;
        private System.Windows.Forms.Button Search_btn;
    }
}