namespace Customers
{
    partial class Admin_Manager
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
            this.lblList = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblManager1 = new System.Windows.Forms.Label();
            this.lblManager2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(36, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(298, 37);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Manage Managers";
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblList.Location = new System.Drawing.Point(38, 94);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(163, 29);
            this.lblList.TabIndex = 9;
            this.lblList.Text = "Managers List";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(80, 141);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(463, 22);
            this.lblHeader.TabIndex = 10;
            this.lblHeader.Text = "ID                    Name                    Age                    Branch";
            // 
            // lblManager1
            // 
            this.lblManager1.AutoSize = true;
            this.lblManager1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManager1.Location = new System.Drawing.Point(80, 181);
            this.lblManager1.Name = "lblManager1";
            this.lblManager1.Size = new System.Drawing.Size(446, 22);
            this.lblManager1.TabIndex = 11;
            this.lblManager1.Text = "M001               Kim                       30                          KL";
            // 
            // lblManager2
            // 
            this.lblManager2.AutoSize = true;
            this.lblManager2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManager2.Location = new System.Drawing.Point(80, 220);
            this.lblManager2.Name = "lblManager2";
            this.lblManager2.Size = new System.Drawing.Size(469, 22);
            this.lblManager2.TabIndex = 12;
            this.lblManager2.Text = "M002               Chee                    40                        Melaka";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(125, 364);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(162, 31);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add Manager";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(499, 364);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(162, 31);
            this.btnRemove.TabIndex = 14;
            this.btnRemove.Text = "Remove Manager";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(313, 364);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(162, 31);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Edit Manager";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // Admin_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblManager2);
            this.Controls.Add(this.lblManager1);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.lblTitle);
            this.Name = "Admin_Manager";
            this.Text = "Admin_Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblManager1;
        private System.Windows.Forms.Label lblManager2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
    }
}