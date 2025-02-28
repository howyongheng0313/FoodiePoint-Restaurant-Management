namespace Customers
{
    partial class FrmAdmin
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHi = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnManager = new System.Windows.Forms.Button();
            this.btnRC = new System.Windows.Forms.Button();
            this.btnChef = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.grrpUsers = new System.Windows.Forms.GroupBox();
            this.btnSalesReport = new System.Windows.Forms.Button();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.grpSales = new System.Windows.Forms.GroupBox();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grrpUsers.SuspendLayout();
            this.grpSales.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(41, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(291, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Admin Dashboard";
            this.lblTitle.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(719, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 67);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblHi
            // 
            this.lblHi.AutoSize = true;
            this.lblHi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHi.Location = new System.Drawing.Point(43, 81);
            this.lblHi.Name = "lblHi";
            this.lblHi.Size = new System.Drawing.Size(99, 29);
            this.lblHi.TabIndex = 8;
            this.lblHi.Text = "Hi, User";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(556, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(136, 31);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update Profile";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnManager
            // 
            this.btnManager.Location = new System.Drawing.Point(36, 35);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(193, 31);
            this.btnManager.TabIndex = 10;
            this.btnManager.Text = "Manager";
            this.btnManager.UseVisualStyleBackColor = true;
            // 
            // btnRC
            // 
            this.btnRC.Location = new System.Drawing.Point(36, 72);
            this.btnRC.Name = "btnRC";
            this.btnRC.Size = new System.Drawing.Size(193, 31);
            this.btnRC.TabIndex = 11;
            this.btnRC.Text = "Reservation Coordinator";
            this.btnRC.UseVisualStyleBackColor = true;
            // 
            // btnChef
            // 
            this.btnChef.Location = new System.Drawing.Point(241, 35);
            this.btnChef.Name = "btnChef";
            this.btnChef.Size = new System.Drawing.Size(193, 31);
            this.btnChef.TabIndex = 13;
            this.btnChef.Text = "Chef";
            this.btnChef.UseVisualStyleBackColor = true;
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(241, 72);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(193, 31);
            this.btnCustomer.TabIndex = 14;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            // 
            // grrpUsers
            // 
            this.grrpUsers.Controls.Add(this.btnCustomer);
            this.grrpUsers.Controls.Add(this.btnChef);
            this.grrpUsers.Controls.Add(this.btnRC);
            this.grrpUsers.Controls.Add(this.btnManager);
            this.grrpUsers.Location = new System.Drawing.Point(48, 149);
            this.grrpUsers.Name = "grrpUsers";
            this.grrpUsers.Size = new System.Drawing.Size(451, 117);
            this.grrpUsers.TabIndex = 15;
            this.grrpUsers.TabStop = false;
            this.grrpUsers.Text = "Management";
            // 
            // btnSalesReport
            // 
            this.btnSalesReport.Location = new System.Drawing.Point(49, 35);
            this.btnSalesReport.Name = "btnSalesReport";
            this.btnSalesReport.Size = new System.Drawing.Size(136, 31);
            this.btnSalesReport.TabIndex = 16;
            this.btnSalesReport.Text = "Sales Report";
            this.btnSalesReport.UseVisualStyleBackColor = true;
            // 
            // btnFeedback
            // 
            this.btnFeedback.Location = new System.Drawing.Point(49, 72);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(136, 31);
            this.btnFeedback.TabIndex = 17;
            this.btnFeedback.Text = "Feedbacks";
            this.btnFeedback.UseVisualStyleBackColor = true;
            // 
            // grpSales
            // 
            this.grpSales.Controls.Add(this.btnFeedback);
            this.grpSales.Controls.Add(this.btnSalesReport);
            this.grpSales.Location = new System.Drawing.Point(520, 149);
            this.grpSales.Name = "grpSales";
            this.grpSales.Size = new System.Drawing.Size(233, 116);
            this.grpSales.TabIndex = 18;
            this.grpSales.TabStop = false;
            this.grpSales.Text = "Sales";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(556, 48);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(136, 31);
            this.btnLogout.TabIndex = 19;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 371);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.grpSales);
            this.Controls.Add(this.grrpUsers);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblHi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmAdmin";
            this.Text = "Adminstrator Page";
            this.Load += new System.EventHandler(this.FrmCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grrpUsers.ResumeLayout(false);
            this.grpSales.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHi;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnManager;
        private System.Windows.Forms.Button btnRC;
        private System.Windows.Forms.Button btnChef;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.GroupBox grrpUsers;
        private System.Windows.Forms.Button btnSalesReport;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.GroupBox grpSales;
        private System.Windows.Forms.Button btnLogout;
    }
}

