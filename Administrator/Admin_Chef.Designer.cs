namespace Customers
{
    partial class Admin_Chef
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblChef2 = new System.Windows.Forms.Label();
            this.lblChef1 = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblList = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(313, 360);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(162, 31);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "Edit Chef";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(499, 360);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(162, 31);
            this.btnRemove.TabIndex = 22;
            this.btnRemove.Text = "Remove Chef";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(125, 360);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(162, 31);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add Chef";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lblChef2
            // 
            this.lblChef2.AutoSize = true;
            this.lblChef2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChef2.Location = new System.Drawing.Point(80, 216);
            this.lblChef2.Name = "lblChef2";
            this.lblChef2.Size = new System.Drawing.Size(472, 22);
            this.lblChef2.TabIndex = 20;
            this.lblChef2.Text = "C002               Bob                       40                        Melaka";
            // 
            // lblChef1
            // 
            this.lblChef1.AutoSize = true;
            this.lblChef1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChef1.Location = new System.Drawing.Point(80, 177);
            this.lblChef1.Name = "lblChef1";
            this.lblChef1.Size = new System.Drawing.Size(445, 22);
            this.lblChef1.TabIndex = 19;
            this.lblChef1.Text = "C001               Lee                       45                          KL";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(80, 137);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(463, 22);
            this.lblHeader.TabIndex = 18;
            this.lblHeader.Text = "ID                    Name                    Age                    Branch";
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblList.Location = new System.Drawing.Point(38, 90);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(118, 29);
            this.lblList.TabIndex = 17;
            this.lblList.Text = "Chefs List";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(36, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(236, 37);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "Manage Chefs";
            // 
            // Admin_Chef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblChef2);
            this.Controls.Add(this.lblChef1);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.lblTitle);
            this.Name = "Admin_Chef";
            this.Text = "Chef";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblChef2;
        private System.Windows.Forms.Label lblChef1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Label lblTitle;
    }
}