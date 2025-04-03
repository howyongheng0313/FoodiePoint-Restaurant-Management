namespace Admin
{
    partial class frmFeedback
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
            this.lblRating = new System.Windows.Forms.Label();
            this.lbloverall = new System.Windows.Forms.Label();
            this.btn1star = new System.Windows.Forms.Button();
            this.btn2star = new System.Windows.Forms.Button();
            this.btn3star = new System.Windows.Forms.Button();
            this.btn4star = new System.Windows.Forms.Button();
            this.btn5star = new System.Windows.Forms.Button();
            this.grpRating = new System.Windows.Forms.GroupBox();
            this.lblCustomer1 = new System.Windows.Forms.Label();
            this.lblFeedback1 = new System.Windows.Forms.Label();
            this.lblFeedback2 = new System.Windows.Forms.Label();
            this.lblCustomer2 = new System.Windows.Forms.Label();
            this.grpRating.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(36, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(356, 37);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Customers Feedbacks";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.Location = new System.Drawing.Point(89, 103);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(160, 64);
            this.lblRating.TabIndex = 10;
            this.lblRating.Text = "4.5 ⭐";
            // 
            // lbloverall
            // 
            this.lbloverall.AutoSize = true;
            this.lbloverall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloverall.Location = new System.Drawing.Point(84, 167);
            this.lbloverall.Name = "lbloverall";
            this.lbloverall.Size = new System.Drawing.Size(165, 29);
            this.lbloverall.TabIndex = 11;
            this.lbloverall.Text = "Overall Rating";
            // 
            // btn1star
            // 
            this.btn1star.Font = new System.Drawing.Font("Modern No. 20", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1star.Location = new System.Drawing.Point(11, 36);
            this.btn1star.Name = "btn1star";
            this.btn1star.Size = new System.Drawing.Size(66, 31);
            this.btn1star.TabIndex = 21;
            this.btn1star.Text = "1⭐";
            this.btn1star.UseVisualStyleBackColor = true;
            // 
            // btn2star
            // 
            this.btn2star.Font = new System.Drawing.Font("Modern No. 20", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2star.Location = new System.Drawing.Point(97, 36);
            this.btn2star.Name = "btn2star";
            this.btn2star.Size = new System.Drawing.Size(66, 31);
            this.btn2star.TabIndex = 22;
            this.btn2star.Text = "2⭐";
            this.btn2star.UseVisualStyleBackColor = true;
            // 
            // btn3star
            // 
            this.btn3star.Font = new System.Drawing.Font("Modern No. 20", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3star.Location = new System.Drawing.Point(185, 36);
            this.btn3star.Name = "btn3star";
            this.btn3star.Size = new System.Drawing.Size(66, 31);
            this.btn3star.TabIndex = 23;
            this.btn3star.Text = "3⭐";
            this.btn3star.UseVisualStyleBackColor = true;
            // 
            // btn4star
            // 
            this.btn4star.Font = new System.Drawing.Font("Modern No. 20", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4star.Location = new System.Drawing.Point(273, 36);
            this.btn4star.Name = "btn4star";
            this.btn4star.Size = new System.Drawing.Size(66, 31);
            this.btn4star.TabIndex = 24;
            this.btn4star.Text = "4⭐";
            this.btn4star.UseVisualStyleBackColor = true;
            // 
            // btn5star
            // 
            this.btn5star.Font = new System.Drawing.Font("Modern No. 20", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5star.Location = new System.Drawing.Point(358, 36);
            this.btn5star.Name = "btn5star";
            this.btn5star.Size = new System.Drawing.Size(66, 31);
            this.btn5star.TabIndex = 25;
            this.btn5star.Text = "5⭐";
            this.btn5star.UseVisualStyleBackColor = true;
            // 
            // grpRating
            // 
            this.grpRating.Controls.Add(this.btn5star);
            this.grpRating.Controls.Add(this.btn4star);
            this.grpRating.Controls.Add(this.btn3star);
            this.grpRating.Controls.Add(this.btn2star);
            this.grpRating.Controls.Add(this.btn1star);
            this.grpRating.Location = new System.Drawing.Point(285, 103);
            this.grpRating.Name = "grpRating";
            this.grpRating.Size = new System.Drawing.Size(448, 92);
            this.grpRating.TabIndex = 26;
            this.grpRating.TabStop = false;
            this.grpRating.Text = "Sort by:";
            // 
            // lblCustomer1
            // 
            this.lblCustomer1.AutoSize = true;
            this.lblCustomer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer1.Location = new System.Drawing.Point(85, 239);
            this.lblCustomer1.Name = "lblCustomer1";
            this.lblCustomer1.Size = new System.Drawing.Size(66, 22);
            this.lblCustomer1.TabIndex = 27;
            this.lblCustomer1.Text = "CU001";
            // 
            // lblFeedback1
            // 
            this.lblFeedback1.AutoSize = true;
            this.lblFeedback1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedback1.Location = new System.Drawing.Point(85, 271);
            this.lblFeedback1.Name = "lblFeedback1";
            this.lblFeedback1.Size = new System.Drawing.Size(289, 22);
            this.lblFeedback1.TabIndex = 28;
            this.lblFeedback1.Text = "The food was geat! Very authentic!";
            // 
            // lblFeedback2
            // 
            this.lblFeedback2.AutoSize = true;
            this.lblFeedback2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedback2.Location = new System.Drawing.Point(85, 350);
            this.lblFeedback2.Name = "lblFeedback2";
            this.lblFeedback2.Size = new System.Drawing.Size(328, 22);
            this.lblFeedback2.TabIndex = 30;
            this.lblFeedback2.Text = "Great service, relaxing environment too!";
            // 
            // lblCustomer2
            // 
            this.lblCustomer2.AutoSize = true;
            this.lblCustomer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer2.Location = new System.Drawing.Point(85, 318);
            this.lblCustomer2.Name = "lblCustomer2";
            this.lblCustomer2.Size = new System.Drawing.Size(66, 22);
            this.lblCustomer2.TabIndex = 29;
            this.lblCustomer2.Text = "CU002";
            // 
            // frmFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.lblFeedback2);
            this.Controls.Add(this.lblCustomer2);
            this.Controls.Add(this.lblFeedback1);
            this.Controls.Add(this.lblCustomer1);
            this.Controls.Add(this.grpRating);
            this.Controls.Add(this.lbloverall);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmFeedback";
            this.Text = "Admin_Feedback";
            this.grpRating.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lbloverall;
        private System.Windows.Forms.Button btn1star;
        private System.Windows.Forms.Button btn2star;
        private System.Windows.Forms.Button btn3star;
        private System.Windows.Forms.Button btn4star;
        private System.Windows.Forms.Button btn5star;
        private System.Windows.Forms.GroupBox grpRating;
        private System.Windows.Forms.Label lblCustomer1;
        private System.Windows.Forms.Label lblFeedback1;
        private System.Windows.Forms.Label lblFeedback2;
        private System.Windows.Forms.Label lblCustomer2;
    }
}