namespace new_customer
{
    partial class frmPayment
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
            this.btnOnlinePayment = new System.Windows.Forms.Button();
            this.btnPayAtCounter = new System.Windows.Forms.Button();
            this.lblPayment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOnlinePayment
            // 
            this.btnOnlinePayment.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnlinePayment.Location = new System.Drawing.Point(455, 198);
            this.btnOnlinePayment.Name = "btnOnlinePayment";
            this.btnOnlinePayment.Size = new System.Drawing.Size(181, 122);
            this.btnOnlinePayment.TabIndex = 5;
            this.btnOnlinePayment.Text = "Online payment ";
            this.btnOnlinePayment.UseVisualStyleBackColor = true;
            // 
            // btnPayAtCounter
            // 
            this.btnPayAtCounter.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayAtCounter.Location = new System.Drawing.Point(164, 198);
            this.btnPayAtCounter.Name = "btnPayAtCounter";
            this.btnPayAtCounter.Size = new System.Drawing.Size(181, 122);
            this.btnPayAtCounter.TabIndex = 4;
            this.btnPayAtCounter.Text = "Pay at counter";
            this.btnPayAtCounter.UseVisualStyleBackColor = true;
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.Location = new System.Drawing.Point(351, 131);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(98, 43);
            this.lblPayment.TabIndex = 3;
            this.lblPayment.Text = "Payment";
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOnlinePayment);
            this.Controls.Add(this.btnPayAtCounter);
            this.Controls.Add(this.lblPayment);
            this.Name = "frmPayment";
            this.Text = "Payment Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOnlinePayment;
        private System.Windows.Forms.Button btnPayAtCounter;
        private System.Windows.Forms.Label lblPayment;
    }
}