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
            this.cmbRevType = new System.Windows.Forms.ComboBox();
            this.txtHall = new System.Windows.Forms.TextBox();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.chkPending = new System.Windows.Forms.CheckBox();
            this.btnNotice = new System.Windows.Forms.Button();
            this.ReservationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReservationType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HallName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReservationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReservationStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dgvAllRev.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReservationID,
            this.Username,
            this.ReservationType,
            this.HallName,
            this.ReservationDate,
            this.ReservationStatus});
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
            // chkPending
            // 
            this.chkPending.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkPending.AutoSize = true;
            this.chkPending.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPending.Location = new System.Drawing.Point(811, 70);
            this.chkPending.Name = "chkPending";
            this.chkPending.Size = new System.Drawing.Size(105, 32);
            this.chkPending.TabIndex = 6;
            this.chkPending.Text = "Pending";
            this.chkPending.UseVisualStyleBackColor = true;
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
            // ReservationID
            // 
            this.ReservationID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ReservationID.HeaderText = "Reservation ID";
            this.ReservationID.MinimumWidth = 6;
            this.ReservationID.Name = "ReservationID";
            this.ReservationID.ReadOnly = true;
            // 
            // Username
            // 
            this.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Username.HeaderText = "Customer";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // ReservationType
            // 
            this.ReservationType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ReservationType.HeaderText = "Reservation Type";
            this.ReservationType.MinimumWidth = 6;
            this.ReservationType.Name = "ReservationType";
            this.ReservationType.ReadOnly = true;
            // 
            // HallName
            // 
            this.HallName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HallName.HeaderText = "Hall";
            this.HallName.MinimumWidth = 6;
            this.HallName.Name = "HallName";
            this.HallName.ReadOnly = true;
            // 
            // ReservationDate
            // 
            this.ReservationDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ReservationDate.HeaderText = "Date";
            this.ReservationDate.MinimumWidth = 6;
            this.ReservationDate.Name = "ReservationDate";
            this.ReservationDate.ReadOnly = true;
            // 
            // ReservationStatus
            // 
            this.ReservationStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ReservationStatus.HeaderText = "Status";
            this.ReservationStatus.MinimumWidth = 6;
            this.ReservationStatus.Name = "ReservationStatus";
            this.ReservationStatus.ReadOnly = true;
            // 
            // pgeViewRev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnNotice);
            this.Controls.Add(this.chkPending);
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
        private System.Windows.Forms.CheckBox chkPending;
        private System.Windows.Forms.Button btnNotice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReservationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReservationType;
        private System.Windows.Forms.DataGridViewTextBoxColumn HallName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReservationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReservationStatus;
    }
}
