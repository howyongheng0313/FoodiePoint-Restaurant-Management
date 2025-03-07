namespace FoodieUI
{
    partial class EditHalls
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
            this.foodieDbDataSet = new FoodieUI.FoodieDbDataSet();
            this.hallsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hallsTableAdapter = new FoodieUI.FoodieDbDataSetTableAdapters.HallsTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.availabilityCmb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.hallCapacityTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.hallPartyTypeTxt = new System.Windows.Forms.TextBox();
            this.hallNametxt = new System.Windows.Forms.TextBox();
            this.hallIdTxt = new System.Windows.Forms.TextBox();
            this.userIdLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.hallsTableAdapter1 = new FoodieUI.FoodieDbDataSetTableAdapters.HallsTableAdapter();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.foodieDbDataSet1 = new FoodieUI.FoodieDbDataSet();
            this.foodieDbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hallIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hallNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hallPartyTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hallCapacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availabilityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.foodieDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hallsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodieDbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodieDbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // foodieDbDataSet
            // 
            this.foodieDbDataSet.DataSetName = "FoodieDbDataSet";
            this.foodieDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hallsBindingSource
            // 
            this.hallsBindingSource.DataMember = "Halls";
            this.hallsBindingSource.DataSource = this.foodieDbDataSet;
            // 
            // hallsTableAdapter
            // 
            this.hallsTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(421, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 34);
            this.button2.TabIndex = 25;
            this.button2.Text = "Save Changes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome, Mr. David";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(13, 73);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 31);
            this.button3.TabIndex = 12;
            this.button3.TabStop = false;
            this.button3.Text = "Menu";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(13, 235);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(144, 31);
            this.button10.TabIndex = 11;
            this.button10.TabStop = false;
            this.button10.Text = "My Profile";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.button10);
            this.splitContainer1.Panel1.Controls.Add(this.button9);
            this.splitContainer1.Panel1.Controls.Add(this.button8);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Controls.Add(this.availabilityCmb);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.hallCapacityTxt);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.hallPartyTypeTxt);
            this.splitContainer1.Panel2.Controls.Add(this.hallNametxt);
            this.splitContainer1.Panel2.Controls.Add(this.hallIdTxt);
            this.splitContainer1.Panel2.Controls.Add(this.userIdLbl);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 171;
            this.splitContainer1.TabIndex = 9;
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(13, 181);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(144, 31);
            this.button9.TabIndex = 10;
            this.button9.TabStop = false;
            this.button9.Text = "Reservations";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(13, 127);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(144, 31);
            this.button8.TabIndex = 9;
            this.button8.TabStop = false;
            this.button8.Text = "Hall Mgmt";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Foodie Point";
            // 
            // availabilityCmb
            // 
            this.availabilityCmb.FormattingEnabled = true;
            this.availabilityCmb.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
            this.availabilityCmb.Location = new System.Drawing.Point(439, 337);
            this.availabilityCmb.Name = "availabilityCmb";
            this.availabilityCmb.Size = new System.Drawing.Size(85, 21);
            this.availabilityCmb.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(436, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 18);
            this.label9.TabIndex = 49;
            this.label9.Text = "Availability";
            // 
            // hallCapacityTxt
            // 
            this.hallCapacityTxt.Location = new System.Drawing.Point(323, 338);
            this.hallCapacityTxt.Name = "hallCapacityTxt";
            this.hallCapacityTxt.Size = new System.Drawing.Size(91, 20);
            this.hallCapacityTxt.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(320, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 18);
            this.label6.TabIndex = 45;
            this.label6.Text = "Hall Capacity";
            // 
            // hallPartyTypeTxt
            // 
            this.hallPartyTypeTxt.Location = new System.Drawing.Point(194, 337);
            this.hallPartyTypeTxt.Name = "hallPartyTypeTxt";
            this.hallPartyTypeTxt.Size = new System.Drawing.Size(104, 20);
            this.hallPartyTypeTxt.TabIndex = 44;
            // 
            // hallNametxt
            // 
            this.hallNametxt.Location = new System.Drawing.Point(95, 338);
            this.hallNametxt.Name = "hallNametxt";
            this.hallNametxt.Size = new System.Drawing.Size(74, 20);
            this.hallNametxt.TabIndex = 43;
            // 
            // hallIdTxt
            // 
            this.hallIdTxt.Location = new System.Drawing.Point(22, 337);
            this.hallIdTxt.Name = "hallIdTxt";
            this.hallIdTxt.Size = new System.Drawing.Size(48, 20);
            this.hallIdTxt.TabIndex = 42;
            // 
            // userIdLbl
            // 
            this.userIdLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userIdLbl.AutoSize = true;
            this.userIdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdLbl.Location = new System.Drawing.Point(191, 316);
            this.userIdLbl.Name = "userIdLbl";
            this.userIdLbl.Size = new System.Drawing.Size(107, 18);
            this.userIdLbl.TabIndex = 41;
            this.userIdLbl.Text = "Hall Party Type";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 40;
            this.label4.Text = "Hall Name";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 18);
            this.label7.TabIndex = 39;
            this.label7.Text = "Hall ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Edit Halls";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // hallsTableAdapter1
            // 
            this.hallsTableAdapter1.ClearBeforeFill = true;
            // 
            // foodieDbDataSet1
            // 
            this.foodieDbDataSet1.DataSetName = "FoodieDbDataSet";
            this.foodieDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // foodieDbDataSetBindingSource
            // 
            this.foodieDbDataSetBindingSource.DataSource = this.foodieDbDataSet1;
            this.foodieDbDataSetBindingSource.Position = 0;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Halls";
            this.bindingSource1.DataSource = this.foodieDbDataSetBindingSource;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hallIDDataGridViewTextBoxColumn,
            this.hallNameDataGridViewTextBoxColumn,
            this.hallPartyTypeDataGridViewTextBoxColumn,
            this.hallCapacityDataGridViewTextBoxColumn,
            this.availabilityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hallsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(540, 239);
            this.dataGridView1.TabIndex = 52;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // hallIDDataGridViewTextBoxColumn
            // 
            this.hallIDDataGridViewTextBoxColumn.DataPropertyName = "HallID";
            this.hallIDDataGridViewTextBoxColumn.HeaderText = "HallID";
            this.hallIDDataGridViewTextBoxColumn.Name = "hallIDDataGridViewTextBoxColumn";
            // 
            // hallNameDataGridViewTextBoxColumn
            // 
            this.hallNameDataGridViewTextBoxColumn.DataPropertyName = "HallName";
            this.hallNameDataGridViewTextBoxColumn.HeaderText = "HallName";
            this.hallNameDataGridViewTextBoxColumn.Name = "hallNameDataGridViewTextBoxColumn";
            // 
            // hallPartyTypeDataGridViewTextBoxColumn
            // 
            this.hallPartyTypeDataGridViewTextBoxColumn.DataPropertyName = "HallPartyType";
            this.hallPartyTypeDataGridViewTextBoxColumn.HeaderText = "HallPartyType";
            this.hallPartyTypeDataGridViewTextBoxColumn.Name = "hallPartyTypeDataGridViewTextBoxColumn";
            // 
            // hallCapacityDataGridViewTextBoxColumn
            // 
            this.hallCapacityDataGridViewTextBoxColumn.DataPropertyName = "HallCapacity";
            this.hallCapacityDataGridViewTextBoxColumn.HeaderText = "HallCapacity";
            this.hallCapacityDataGridViewTextBoxColumn.Name = "hallCapacityDataGridViewTextBoxColumn";
            // 
            // availabilityDataGridViewTextBoxColumn
            // 
            this.availabilityDataGridViewTextBoxColumn.DataPropertyName = "Availability";
            this.availabilityDataGridViewTextBoxColumn.HeaderText = "Availability";
            this.availabilityDataGridViewTextBoxColumn.Name = "availabilityDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(520, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 34);
            this.button1.TabIndex = 53;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditHalls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "EditHalls";
            this.Text = "EditHalls";
            this.Load += new System.EventHandler(this.EditHalls_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foodieDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hallsBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodieDbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodieDbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FoodieDbDataSet foodieDbDataSet;
        private System.Windows.Forms.BindingSource hallsBindingSource;
        private FoodieDbDataSetTableAdapters.HallsTableAdapter hallsTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hallIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hallNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hallPartyTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hallCapacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availabilityDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox availabilityCmb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox hallCapacityTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox hallPartyTypeTxt;
        private System.Windows.Forms.TextBox hallNametxt;
        private System.Windows.Forms.TextBox hallIdTxt;
        private System.Windows.Forms.Label userIdLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private FoodieDbDataSetTableAdapters.HallsTableAdapter hallsTableAdapter1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private FoodieDbDataSet foodieDbDataSet1;
        private System.Windows.Forms.BindingSource foodieDbDataSetBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button1;
    }
}