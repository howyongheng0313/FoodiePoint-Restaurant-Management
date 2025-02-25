namespace FoodiePointManagementSystem
{
    partial class frmChefProfile
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
            this.lblChefNewUsername = new System.Windows.Forms.Label();
            this.lblChefNewPassword = new System.Windows.Forms.Label();
            this.lblChefNewName = new System.Windows.Forms.Label();
            this.lblChefNewEmail = new System.Windows.Forms.Label();
            this.tbxChefNewUsername = new System.Windows.Forms.TextBox();
            this.tbxChefNewName = new System.Windows.Forms.TextBox();
            this.tbxChefNewPassword = new System.Windows.Forms.TextBox();
            this.tbxChefNewEmail = new System.Windows.Forms.TextBox();
            this.btnProfileToChef = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnProfileToInventory = new System.Windows.Forms.Button();
            this.btnProfileToOrder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblChefNewUsername
            // 
            this.lblChefNewUsername.AutoSize = true;
            this.lblChefNewUsername.Location = new System.Drawing.Point(25, 50);
            this.lblChefNewUsername.Name = "lblChefNewUsername";
            this.lblChefNewUsername.Size = new System.Drawing.Size(103, 16);
            this.lblChefNewUsername.TabIndex = 3;
            this.lblChefNewUsername.Text = "New Username:";

            // 
            // lblChefNewPassword
            // 
            this.lblChefNewPassword.AutoSize = true;
            this.lblChefNewPassword.Location = new System.Drawing.Point(25, 108);
            this.lblChefNewPassword.Name = "lblChefNewPassword";
            this.lblChefNewPassword.Size = new System.Drawing.Size(100, 16);
            this.lblChefNewPassword.TabIndex = 4;
            this.lblChefNewPassword.Text = "New Password:";
            // 
            // lblChefNewName
            // 
            this.lblChefNewName.AutoSize = true;
            this.lblChefNewName.Location = new System.Drawing.Point(25, 219);
            this.lblChefNewName.Name = "lblChefNewName";
            this.lblChefNewName.Size = new System.Drawing.Size(77, 16);
            this.lblChefNewName.TabIndex = 5;
            this.lblChefNewName.Text = "New Name:";
            // 
            // lblChefNewEmail
            // 
            this.lblChefNewEmail.AutoSize = true;
            this.lblChefNewEmail.Location = new System.Drawing.Point(25, 269);
            this.lblChefNewEmail.Name = "lblChefNewEmail";
            this.lblChefNewEmail.Size = new System.Drawing.Size(74, 16);
            this.lblChefNewEmail.TabIndex = 6;
            this.lblChefNewEmail.Text = "New Email:";
            // 
            // tbxChefNewUsername
            // 
            this.tbxChefNewUsername.Location = new System.Drawing.Point(192, 50);
            this.tbxChefNewUsername.Name = "tbxChefNewUsername";
            this.tbxChefNewUsername.Size = new System.Drawing.Size(200, 22);
            this.tbxChefNewUsername.TabIndex = 7;
            // 
            // tbxChefNewName
            // 
            this.tbxChefNewName.Location = new System.Drawing.Point(192, 213);
            this.tbxChefNewName.Name = "tbxChefNewName";
            this.tbxChefNewName.Size = new System.Drawing.Size(200, 22);
            this.tbxChefNewName.TabIndex = 8;
            // 
            // tbxChefNewPassword
            // 
            this.tbxChefNewPassword.Location = new System.Drawing.Point(192, 108);
            this.tbxChefNewPassword.Name = "tbxChefNewPassword";
            this.tbxChefNewPassword.Size = new System.Drawing.Size(200, 22);
            this.tbxChefNewPassword.TabIndex = 9;
            // 
            // tbxChefNewEmail
            // 
            this.tbxChefNewEmail.Location = new System.Drawing.Point(192, 269);
            this.tbxChefNewEmail.Name = "tbxChefNewEmail";
            this.tbxChefNewEmail.Size = new System.Drawing.Size(200, 22);
            this.tbxChefNewEmail.TabIndex = 10;
            // 
            // btnProfileToChef
            // 
            this.btnProfileToChef.Location = new System.Drawing.Point(31, 76);
            this.btnProfileToChef.Name = "btnProfileToChef";
            this.btnProfileToChef.Size = new System.Drawing.Size(144, 48);
            this.btnProfileToChef.TabIndex = 11;
            this.btnProfileToChef.Text = "Chef Main Page";
            this.btnProfileToChef.UseVisualStyleBackColor = true;
            this.btnProfileToChef.Click += new System.EventHandler(this.btnProfileToChef_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Confirm New Password:";

            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(192, 161);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 22);
            this.textBox1.TabIndex = 13;
            // 
            // btnProfileToInventory
            // 
            this.btnProfileToInventory.Location = new System.Drawing.Point(31, 245);
            this.btnProfileToInventory.Name = "btnProfileToInventory";
            this.btnProfileToInventory.Size = new System.Drawing.Size(144, 48);
            this.btnProfileToInventory.TabIndex = 14;
            this.btnProfileToInventory.Text = "Inventory Page";
            this.btnProfileToInventory.UseVisualStyleBackColor = true;
            this.btnProfileToInventory.Click += new System.EventHandler(this.btnProfileToInventory_Click);
            // 
            // btnProfileToOrder
            // 
            this.btnProfileToOrder.Location = new System.Drawing.Point(31, 160);
            this.btnProfileToOrder.Name = "btnProfileToOrder";
            this.btnProfileToOrder.Size = new System.Drawing.Size(144, 48);
            this.btnProfileToOrder.TabIndex = 15;
            this.btnProfileToOrder.Text = "Orders Page";
            this.btnProfileToOrder.UseVisualStyleBackColor = true;
            this.btnProfileToOrder.Click += new System.EventHandler(this.btnProfileToOrder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblChefNewUsername);
            this.groupBox1.Controls.Add(this.lblChefNewPassword);
            this.groupBox1.Controls.Add(this.lblChefNewName);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lblChefNewEmail);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxChefNewUsername);
            this.groupBox1.Controls.Add(this.tbxChefNewName);
            this.groupBox1.Controls.Add(this.tbxChefNewEmail);
            this.groupBox1.Controls.Add(this.tbxChefNewPassword);
            this.groupBox1.Location = new System.Drawing.Point(279, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 354);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Profile";
            // 
            // frmChefProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnProfileToOrder);
            this.Controls.Add(this.btnProfileToInventory);
            this.Controls.Add(this.btnProfileToChef);
            this.Name = "frmChefProfile";
            this.Text = "Chef Update Profile Page";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblChefNewUsername;
        private System.Windows.Forms.Label lblChefNewPassword;
        private System.Windows.Forms.Label lblChefNewName;
        private System.Windows.Forms.Label lblChefNewEmail;
        private System.Windows.Forms.TextBox tbxChefNewUsername;
        private System.Windows.Forms.TextBox tbxChefNewName;
        private System.Windows.Forms.TextBox tbxChefNewPassword;
        private System.Windows.Forms.TextBox tbxChefNewEmail;
        private System.Windows.Forms.Button btnProfileToChef;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnProfileToInventory;
        private System.Windows.Forms.Button btnProfileToOrder;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}