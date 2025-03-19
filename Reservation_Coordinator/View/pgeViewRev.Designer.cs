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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAllRev = new System.Windows.Forms.DataGridView();
            this.txtRevID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllRev.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllRev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllRev.EnableHeadersVisualStyles = false;
            this.dgvAllRev.Location = new System.Drawing.Point(17, 59);
            this.dgvAllRev.Margin = new System.Windows.Forms.Padding(15);
            this.dgvAllRev.MultiSelect = false;
            this.dgvAllRev.Name = "dgvAllRev";
            this.dgvAllRev.ReadOnly = true;
            this.dgvAllRev.RowHeadersVisible = false;
            this.dgvAllRev.RowHeadersWidth = 51;
            this.dgvAllRev.RowTemplate.Height = 24;
            this.dgvAllRev.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllRev.Size = new System.Drawing.Size(832, 490);
            this.dgvAllRev.TabIndex = 0;
            this.dgvAllRev.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllRev_CellDoubleClick);
            // 
            // txtRevID
            // 
            this.txtRevID.Location = new System.Drawing.Point(17, 19);
            this.txtRevID.Name = "txtRevID";
            this.txtRevID.Size = new System.Drawing.Size(112, 30);
            this.txtRevID.TabIndex = 2;
            this.txtRevID.TextChanged += new System.EventHandler(this.txtRevID_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(135, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(211, 30);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // cmbStatus
            // 
            this.cmbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "All",
            "Pending",
            "Confirmed",
            "Completed",
            "Rejected"});
            this.cmbStatus.Location = new System.Drawing.Point(694, 18);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbStatus.Size = new System.Drawing.Size(155, 31);
            this.cmbStatus.TabIndex = 8;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // pgeViewRev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtRevID);
            this.Controls.Add(this.dgvAllRev);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "pgeViewRev";
            this.Size = new System.Drawing.Size(862, 575);
            this.Load += new System.EventHandler(this.pgeViewRev_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllRev)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllRev;
        private System.Windows.Forms.TextBox txtRevID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbStatus;
    }
}
