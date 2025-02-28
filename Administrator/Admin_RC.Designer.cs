namespace Customers
{
    partial class Admin_RC
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
            this.lblRC2 = new System.Windows.Forms.Label();
            this.lblRC1 = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblList = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(316, 360);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(162, 31);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "Edit RC";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(502, 360);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(162, 31);
            this.btnRemove.TabIndex = 22;
            this.btnRemove.Text = "Remove RC";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(128, 360);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(162, 31);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add RC";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lblRC2
            // 
            this.lblRC2.AutoSize = true;
            this.lblRC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRC2.Location = new System.Drawing.Point(83, 216);
            this.lblRC2.Name = "lblRC2";
            this.lblRC2.Size = new System.Drawing.Size(478, 22);
            this.lblRC2.TabIndex = 20;
            this.lblRC2.Text = "RC002            George                   25                        Melaka";
            // 
            // lblRC1
            // 
            this.lblRC1.AutoSize = true;
            this.lblRC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRC1.Location = new System.Drawing.Point(83, 177);
            this.lblRC1.Name = "lblRC1";
            this.lblRC1.Size = new System.Drawing.Size(455, 22);
            this.lblRC1.TabIndex = 19;
            this.lblRC1.Text = "RC001            Sean                       22                          KL";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(83, 137);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(463, 22);
            this.lblHeader.TabIndex = 18;
            this.lblHeader.Text = "ID                    Name                    Age                    Branch";
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblList.Location = new System.Drawing.Point(41, 90);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(90, 29);
            this.lblList.TabIndex = 17;
            this.lblList.Text = "RC List";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(39, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(625, 37);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "Manage Reservation Coordinators  (RC)";
            // 
            // Admin_RC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblRC2);
            this.Controls.Add(this.lblRC1);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.lblTitle);
            this.Name = "Admin_RC";
            this.Text = "Admin_RC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblRC2;
        private System.Windows.Forms.Label lblRC1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Label lblTitle;
    }
}