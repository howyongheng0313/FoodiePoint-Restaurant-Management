namespace Admin.View
{
    partial class frmDashboard
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnManager = new System.Windows.Forms.Button();
            this.btnRC = new System.Windows.Forms.Button();
            this.btnChef = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.grrpUsers = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnFeedbacks = new System.Windows.Forms.Button();
            this.grpSales = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grrpUsers.SuspendLayout();
            this.grpSales.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(41, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(320, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Admin Dashboard";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Image = global::FoodiePoint_proj.Properties.Resources.img;
            this.pictureBox1.Location = new System.Drawing.Point(1045, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(43, 81);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 29);
            this.lblWelcome.TabIndex = 8;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Location = new System.Drawing.Point(811, 25);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(201, 46);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update Profile";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnManager
            // 
            this.btnManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManager.Location = new System.Drawing.Point(76, 83);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(171, 61);
            this.btnManager.TabIndex = 10;
            this.btnManager.Text = "Manager";
            this.btnManager.UseVisualStyleBackColor = true;
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            // 
            // btnRC
            // 
            this.btnRC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRC.Location = new System.Drawing.Point(76, 207);
            this.btnRC.Name = "btnRC";
            this.btnRC.Size = new System.Drawing.Size(171, 61);
            this.btnRC.TabIndex = 11;
            this.btnRC.Text = "Reservation Coordinator";
            this.btnRC.UseVisualStyleBackColor = true;
            this.btnRC.Click += new System.EventHandler(this.btnRC_Click);
            // 
            // btnChef
            // 
            this.btnChef.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChef.Location = new System.Drawing.Point(358, 83);
            this.btnChef.Name = "btnChef";
            this.btnChef.Size = new System.Drawing.Size(171, 61);
            this.btnChef.TabIndex = 13;
            this.btnChef.Text = "Chef";
            this.btnChef.UseVisualStyleBackColor = true;
            this.btnChef.Click += new System.EventHandler(this.btnChef_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomer.Location = new System.Drawing.Point(358, 207);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(171, 61);
            this.btnCustomer.TabIndex = 14;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // grrpUsers
            // 
            this.grrpUsers.Controls.Add(this.label1);
            this.grrpUsers.Controls.Add(this.btnCustomer);
            this.grrpUsers.Controls.Add(this.btnChef);
            this.grrpUsers.Controls.Add(this.btnManager);
            this.grrpUsers.Controls.Add(this.btnRC);
            this.grrpUsers.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.grrpUsers.Location = new System.Drawing.Point(48, 200);
            this.grrpUsers.Name = "grrpUsers";
            this.grrpUsers.Size = new System.Drawing.Size(621, 337);
            this.grrpUsers.TabIndex = 15;
            this.grrpUsers.TabStop = false;
            this.grrpUsers.Text = "Management Department";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Add/Edit/View/Remove";
            // 
            // btnSales
            // 
            this.btnSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSales.Location = new System.Drawing.Point(149, 207);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(171, 61);
            this.btnSales.TabIndex = 16;
            this.btnSales.Text = "Sales Report";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnFeedbacks
            // 
            this.btnFeedbacks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFeedbacks.Location = new System.Drawing.Point(149, 83);
            this.btnFeedbacks.Name = "btnFeedbacks";
            this.btnFeedbacks.Size = new System.Drawing.Size(171, 61);
            this.btnFeedbacks.TabIndex = 17;
            this.btnFeedbacks.Text = "Feedbacks";
            this.btnFeedbacks.UseVisualStyleBackColor = true;
            this.btnFeedbacks.Click += new System.EventHandler(this.btnFeedbacks_Click);
            // 
            // grpSales
            // 
            this.grpSales.Controls.Add(this.label2);
            this.grpSales.Controls.Add(this.btnFeedbacks);
            this.grpSales.Controls.Add(this.btnSales);
            this.grpSales.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.grpSales.Location = new System.Drawing.Point(713, 200);
            this.grpSales.Name = "grpSales";
            this.grpSales.Size = new System.Drawing.Size(431, 337);
            this.grpSales.TabIndex = 18;
            this.grpSales.TabStop = false;
            this.grpSales.Text = "Sales Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "View";
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Location = new System.Drawing.Point(811, 81);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(201, 45);
            this.btnLogout.TabIndex = 19;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.grpSales);
            this.Controls.Add(this.grrpUsers);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitle);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adminstrator Page";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grrpUsers.ResumeLayout(false);
            this.grrpUsers.PerformLayout();
            this.grpSales.ResumeLayout(false);
            this.grpSales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnManager;
        private System.Windows.Forms.Button btnRC;
        private System.Windows.Forms.Button btnChef;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.GroupBox grrpUsers;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnFeedbacks;
        private System.Windows.Forms.GroupBox grpSales;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

