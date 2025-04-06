namespace Manager
{
    partial class frmHall
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
            this.button3 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHallID = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.availabilityCmb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.hallCapacityTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.hallPartyTypeTxt = new System.Windows.Forms.TextBox();
            this.hallNametxt = new System.Windows.Forms.TextBox();
            this.userIdLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewHall = new System.Windows.Forms.DataGridView();
            this.hallIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hallNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hallPartyTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hallCapacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availabilityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hallsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foodieDbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foodieDbDataSet = new Manager.FoodieDbDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.hallsTableAdapter = new Manager.FoodieDbDataSetTableAdapters.HallsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hallsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodieDbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodieDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(10, 98);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(208, 60);
            this.button3.TabIndex = 12;
            this.button3.TabStop = false;
            this.button3.Text = "Menu";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button10.Dock = System.Windows.Forms.DockStyle.Top;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(10, 278);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(208, 60);
            this.button10.TabIndex = 11;
            this.button10.TabStop = false;
            this.button10.Text = "My Profile";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.button10);
            this.splitContainer1.Panel1.Controls.Add(this.button9);
            this.splitContainer1.Panel1.Controls.Add(this.button8);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblHallID);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.availabilityCmb);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.hallCapacityTxt);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.hallPartyTypeTxt);
            this.splitContainer1.Panel2.Controls.Add(this.hallNametxt);
            this.splitContainer1.Panel2.Controls.Add(this.userIdLbl);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewHall);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(1082, 673);
            this.splitContainer1.SplitterDistance = 228;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 7;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(10, 218);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(208, 60);
            this.button9.TabIndex = 10;
            this.button9.TabStop = false;
            this.button9.Text = "Reservations";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(161)))), ((int)(((byte)(188)))));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.Enabled = false;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(10, 158);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(208, 60);
            this.button8.TabIndex = 9;
            this.button8.TabStop = false;
            this.button8.Text = "Hall Mgmt";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Jokerman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Size = new System.Drawing.Size(208, 98);
            this.label2.TabIndex = 0;
            this.label2.Text = "Foodie Point";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHallID
            // 
            this.lblHallID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHallID.AutoSize = true;
            this.lblHallID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHallID.Location = new System.Drawing.Point(25, 537);
            this.lblHallID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHallID.Name = "lblHallID";
            this.lblHallID.Size = new System.Drawing.Size(0, 24);
            this.lblHallID.TabIndex = 52;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(724, 616);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 42);
            this.button1.TabIndex = 51;
            this.button1.Text = "Edit Halls";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // availabilityCmb
            // 
            this.availabilityCmb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.availabilityCmb.FormattingEnabled = true;
            this.availabilityCmb.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
            this.availabilityCmb.Location = new System.Drawing.Point(585, 534);
            this.availabilityCmb.Margin = new System.Windows.Forms.Padding(4);
            this.availabilityCmb.Name = "availabilityCmb";
            this.availabilityCmb.Size = new System.Drawing.Size(112, 28);
            this.availabilityCmb.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(581, 508);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 24);
            this.label9.TabIndex = 49;
            this.label9.Text = "Availability";
            // 
            // hallCapacityTxt
            // 
            this.hallCapacityTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hallCapacityTxt.Location = new System.Drawing.Point(431, 535);
            this.hallCapacityTxt.Margin = new System.Windows.Forms.Padding(4);
            this.hallCapacityTxt.Name = "hallCapacityTxt";
            this.hallCapacityTxt.Size = new System.Drawing.Size(120, 27);
            this.hallCapacityTxt.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(427, 508);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 24);
            this.label6.TabIndex = 45;
            this.label6.Text = "Hall Capacity";
            // 
            // hallPartyTypeTxt
            // 
            this.hallPartyTypeTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hallPartyTypeTxt.Location = new System.Drawing.Point(259, 534);
            this.hallPartyTypeTxt.Margin = new System.Windows.Forms.Padding(4);
            this.hallPartyTypeTxt.Name = "hallPartyTypeTxt";
            this.hallPartyTypeTxt.Size = new System.Drawing.Size(137, 27);
            this.hallPartyTypeTxt.TabIndex = 44;
            // 
            // hallNametxt
            // 
            this.hallNametxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hallNametxt.Location = new System.Drawing.Point(127, 535);
            this.hallNametxt.Margin = new System.Windows.Forms.Padding(4);
            this.hallNametxt.Name = "hallNametxt";
            this.hallNametxt.Size = new System.Drawing.Size(97, 27);
            this.hallNametxt.TabIndex = 43;
            // 
            // userIdLbl
            // 
            this.userIdLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.userIdLbl.AutoSize = true;
            this.userIdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdLbl.Location = new System.Drawing.Point(255, 508);
            this.userIdLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userIdLbl.Name = "userIdLbl";
            this.userIdLbl.Size = new System.Drawing.Size(136, 24);
            this.userIdLbl.TabIndex = 41;
            this.userIdLbl.Text = "Hall Party Type";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(123, 508);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 24);
            this.label4.TabIndex = 40;
            this.label4.Text = "Hall Name";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 508);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 24);
            this.label7.TabIndex = 39;
            this.label7.Text = "Hall ID";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(592, 616);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 42);
            this.button2.TabIndex = 25;
            this.button2.Text = "Add Halls";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewHall
            // 
            this.dataGridViewHall.AllowUserToAddRows = false;
            this.dataGridViewHall.AllowUserToDeleteRows = false;
            this.dataGridViewHall.AllowUserToResizeColumns = false;
            this.dataGridViewHall.AllowUserToResizeRows = false;
            this.dataGridViewHall.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewHall.AutoGenerateColumns = false;
            this.dataGridViewHall.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHall.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hallIDDataGridViewTextBoxColumn,
            this.hallNameDataGridViewTextBoxColumn,
            this.hallPartyTypeDataGridViewTextBoxColumn,
            this.hallCapacityDataGridViewTextBoxColumn,
            this.availabilityDataGridViewTextBoxColumn});
            this.dataGridViewHall.DataSource = this.hallsBindingSource;
            this.dataGridViewHall.Location = new System.Drawing.Point(22, 90);
            this.dataGridViewHall.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewHall.MultiSelect = false;
            this.dataGridViewHall.Name = "dataGridViewHall";
            this.dataGridViewHall.ReadOnly = true;
            this.dataGridViewHall.RowHeadersVisible = false;
            this.dataGridViewHall.RowHeadersWidth = 51;
            this.dataGridViewHall.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHall.Size = new System.Drawing.Size(818, 400);
            this.dataGridViewHall.TabIndex = 13;
            // 
            // hallIDDataGridViewTextBoxColumn
            // 
            this.hallIDDataGridViewTextBoxColumn.DataPropertyName = "HallID";
            this.hallIDDataGridViewTextBoxColumn.HeaderText = "HallID";
            this.hallIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hallIDDataGridViewTextBoxColumn.Name = "hallIDDataGridViewTextBoxColumn";
            this.hallIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hallNameDataGridViewTextBoxColumn
            // 
            this.hallNameDataGridViewTextBoxColumn.DataPropertyName = "HallName";
            this.hallNameDataGridViewTextBoxColumn.HeaderText = "HallName";
            this.hallNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hallNameDataGridViewTextBoxColumn.Name = "hallNameDataGridViewTextBoxColumn";
            this.hallNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hallPartyTypeDataGridViewTextBoxColumn
            // 
            this.hallPartyTypeDataGridViewTextBoxColumn.DataPropertyName = "HallPartyType";
            this.hallPartyTypeDataGridViewTextBoxColumn.HeaderText = "HallPartyType";
            this.hallPartyTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hallPartyTypeDataGridViewTextBoxColumn.Name = "hallPartyTypeDataGridViewTextBoxColumn";
            this.hallPartyTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hallCapacityDataGridViewTextBoxColumn
            // 
            this.hallCapacityDataGridViewTextBoxColumn.DataPropertyName = "HallCapacity";
            this.hallCapacityDataGridViewTextBoxColumn.HeaderText = "HallCapacity";
            this.hallCapacityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hallCapacityDataGridViewTextBoxColumn.Name = "hallCapacityDataGridViewTextBoxColumn";
            this.hallCapacityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // availabilityDataGridViewTextBoxColumn
            // 
            this.availabilityDataGridViewTextBoxColumn.DataPropertyName = "Availability";
            this.availabilityDataGridViewTextBoxColumn.HeaderText = "Availability";
            this.availabilityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.availabilityDataGridViewTextBoxColumn.Name = "availabilityDataGridViewTextBoxColumn";
            this.availabilityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hallsBindingSource
            // 
            this.hallsBindingSource.DataMember = "Halls";
            this.hallsBindingSource.DataSource = this.foodieDbDataSetBindingSource;
            // 
            // foodieDbDataSetBindingSource
            // 
            this.foodieDbDataSetBindingSource.DataSource = this.foodieDbDataSet;
            this.foodieDbDataSetBindingSource.Position = 0;
            // 
            // foodieDbDataSet
            // 
            this.foodieDbDataSet.DataSetName = "FoodieDbDataSet";
            this.foodieDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(332, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Hall Management Overview";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome, Mr. David";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // hallsTableAdapter
            // 
            this.hallsTableAdapter.ClearBeforeFill = true;
            // 
            // frmHall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 673);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmHall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Halls";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hallsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodieDbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodieDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dataGridViewHall;
        private System.Windows.Forms.BindingSource foodieDbDataSetBindingSource;
        private FoodieDbDataSet foodieDbDataSet;
        private System.Windows.Forms.BindingSource hallsBindingSource;
        private FoodieDbDataSetTableAdapters.HallsTableAdapter hallsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hallIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hallNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hallPartyTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hallCapacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availabilityDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox hallCapacityTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox hallPartyTypeTxt;
        private System.Windows.Forms.TextBox hallNametxt;
        private System.Windows.Forms.Label userIdLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox availabilityCmb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblHallID;
    }
}