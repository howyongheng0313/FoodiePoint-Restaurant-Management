namespace FoodiePointManagementSystem
{
    partial class frmOrder
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
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.btnInProgress = new System.Windows.Forms.Button();
            this.gbxOrder = new System.Windows.Forms.GroupBox();
            this.btnCompleted = new System.Windows.Forms.Button();
            this.btnOrderToChef = new System.Windows.Forms.Button();
            this.btnOrderToInventory = new System.Windows.Forms.Button();
            this.btnOrderToProfile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.gbxOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOrder
            // 
            this.dgvOrder.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(202, 28);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.RowTemplate.Height = 24;
            this.dgvOrder.Size = new System.Drawing.Size(404, 395);
            this.dgvOrder.TabIndex = 0;
            // 
            // btnInProgress
            // 
            this.btnInProgress.Location = new System.Drawing.Point(25, 36);
            this.btnInProgress.Name = "btnInProgress";
            this.btnInProgress.Size = new System.Drawing.Size(113, 57);
            this.btnInProgress.TabIndex = 2;
            this.btnInProgress.Text = "In Progress";
            this.btnInProgress.UseVisualStyleBackColor = true;
            this.btnInProgress.Click += new System.EventHandler(this.btnInProgress_Click);
            // 
            // gbxOrder
            // 
            this.gbxOrder.Controls.Add(this.btnCompleted);
            this.gbxOrder.Controls.Add(this.btnInProgress);
            this.gbxOrder.Location = new System.Drawing.Point(622, 65);
            this.gbxOrder.Name = "gbxOrder";
            this.gbxOrder.Size = new System.Drawing.Size(166, 192);
            this.gbxOrder.TabIndex = 3;
            this.gbxOrder.TabStop = false;
            this.gbxOrder.Text = "Update Order";
            // 
            // btnCompleted
            // 
            this.btnCompleted.Location = new System.Drawing.Point(25, 115);
            this.btnCompleted.Name = "btnCompleted";
            this.btnCompleted.Size = new System.Drawing.Size(113, 57);
            this.btnCompleted.TabIndex = 3;
            this.btnCompleted.Text = "Completed";
            this.btnCompleted.UseVisualStyleBackColor = true;
            // 
            // btnOrderToChef
            // 
            this.btnOrderToChef.Location = new System.Drawing.Point(28, 82);
            this.btnOrderToChef.Name = "btnOrderToChef";
            this.btnOrderToChef.Size = new System.Drawing.Size(144, 48);
            this.btnOrderToChef.TabIndex = 4;
            this.btnOrderToChef.Text = "Chef Main Page";
            this.btnOrderToChef.UseVisualStyleBackColor = true;
            this.btnOrderToChef.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOrderToInventory
            // 
            this.btnOrderToInventory.Location = new System.Drawing.Point(28, 167);
            this.btnOrderToInventory.Name = "btnOrderToInventory";
            this.btnOrderToInventory.Size = new System.Drawing.Size(144, 48);
            this.btnOrderToInventory.TabIndex = 6;
            this.btnOrderToInventory.Text = "Inventory Page";
            this.btnOrderToInventory.UseVisualStyleBackColor = true;
            // 
            // btnOrderToProfile
            // 
            this.btnOrderToProfile.Location = new System.Drawing.Point(28, 249);
            this.btnOrderToProfile.Name = "btnOrderToProfile";
            this.btnOrderToProfile.Size = new System.Drawing.Size(144, 48);
            this.btnOrderToProfile.TabIndex = 7;
            this.btnOrderToProfile.Text = "Update Profile Page";
            this.btnOrderToProfile.UseVisualStyleBackColor = true;
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOrderToProfile);
            this.Controls.Add(this.btnOrderToInventory);
            this.Controls.Add(this.btnOrderToChef);
            this.Controls.Add(this.gbxOrder);
            this.Controls.Add(this.dgvOrder);
            this.Name = "frmOrder";
            this.Text = "Orders Page";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.gbxOrder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Button btnInProgress;
        private System.Windows.Forms.GroupBox gbxOrder;
        private System.Windows.Forms.Button btnCompleted;
        private System.Windows.Forms.Button btnOrderToChef;
        private System.Windows.Forms.Button btnOrderToInventory;
        private System.Windows.Forms.Button btnOrderToProfile;
    }
}