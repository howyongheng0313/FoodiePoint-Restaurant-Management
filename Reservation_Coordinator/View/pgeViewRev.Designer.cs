namespace Reservation_Coordinator.View
{
    partial class pgeViewRev
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAllRev = new System.Windows.Forms.DataGridView();
            this.cmbRevType = new System.Windows.Forms.ComboBox();
            this.txtHall = new System.Windows.Forms.TextBox();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnNotice = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllRev)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllRev
            // 
            this.dgvAllRev.AllowUserToAddRows = false;
            this.dgvAllRev.AllowUserToDeleteRows = false;
            this.dgvAllRev.AllowUserToResizeColumns = false;
            this.dgvAllRev.AllowUserToResizeRows = false;
            this.dgvAllRev.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAllRev.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllRev.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAllRev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllRev.EnableHeadersVisualStyles = false;
            this.dgvAllRev.Location = new System.Drawing.Point(15, 110);
            this.dgvAllRev.Margin = new System.Windows.Forms.Padding(15);
            this.dgvAllRev.MultiSelect = false;
            this.dgvAllRev.Name = "dgvAllRev";
            this.dgvAllRev.ReadOnly = true;
            this.dgvAllRev.RowHeadersVisible = false;
            this.dgvAllRev.RowHeadersWidth = 51;
            this.dgvAllRev.RowTemplate.Height = 24;
            this.dgvAllRev.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllRev.Size = new System.Drawing.Size(901, 475);
            this.dgvAllRev.TabIndex = 0;
            // 
            // cmbRevType
            // 
            this.cmbRevType.FormattingEnabled = true;
            this.cmbRevType.Location = new System.Drawing.Point(14, 69);
            this.cmbRevType.Name = "cmbRevType";
            this.cmbRevType.Size = new System.Drawing.Size(164, 31);
            this.cmbRevType.TabIndex = 1;
            // 
            // txtHall
            // 
            this.txtHall.Location = new System.Drawing.Point(184, 70);
            this.txtHall.Name = "txtHall";
            this.txtHall.Size = new System.Drawing.Size(112, 30);
            this.txtHall.TabIndex = 2;
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(302, 70);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(201, 30);
            this.txtCustomer.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(736, 600);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 40);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(541, 600);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(180, 40);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnNotice
            // 
            this.btnNotice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNotice.AutoSize = true;
            this.btnNotice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotice.Location = new System.Drawing.Point(836, 15);
            this.btnNotice.Margin = new System.Windows.Forms.Padding(15);
            this.btnNotice.Name = "btnNotice";
            this.btnNotice.Size = new System.Drawing.Size(80, 40);
            this.btnNotice.TabIndex = 7;
            this.btnNotice.Text = "Notice";
            this.btnNotice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNotice.UseVisualStyleBackColor = true;
            // 
            // cmbStatus
            // 
            this.cmbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "All",
            "Pending",
            "Comfirm",
            "Complete"});
            this.cmbStatus.Location = new System.Drawing.Point(761, 69);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbStatus.Size = new System.Drawing.Size(155, 31);
            this.cmbStatus.TabIndex = 8;
            // 
            // pgeViewRev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.btnNotice);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.txtHall);
            this.Controls.Add(this.cmbRevType);
            this.Controls.Add(this.dgvAllRev);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "pgeViewRev";
            this.Size = new System.Drawing.Size(931, 655);
            this.Load += new System.EventHandler(this.pgeViewRev_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllRev)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllRev;
        private System.Windows.Forms.ComboBox cmbRevType;
        private System.Windows.Forms.TextBox txtHall;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnNotice;
        private System.Windows.Forms.ComboBox cmbStatus;
    }
}
