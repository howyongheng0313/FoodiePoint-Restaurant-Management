namespace Customer
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
            this.btnOnlinePayment.Location = new System.Drawing.Point(614, 284);
            this.btnOnlinePayment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOnlinePayment.Name = "btnOnlinePayment";
            this.btnOnlinePayment.Size = new System.Drawing.Size(241, 150);
            this.btnOnlinePayment.TabIndex = 5;
            this.btnOnlinePayment.Text = "Online payment ";
            this.btnOnlinePayment.UseVisualStyleBackColor = true;
            // 
            // btnPayAtCounter
            // 
            this.btnPayAtCounter.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayAtCounter.Location = new System.Drawing.Point(226, 284);
            this.btnPayAtCounter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPayAtCounter.Name = "btnPayAtCounter";
            this.btnPayAtCounter.Size = new System.Drawing.Size(241, 150);
            this.btnPayAtCounter.TabIndex = 4;
            this.btnPayAtCounter.Text = "Pay at counter";
            this.btnPayAtCounter.UseVisualStyleBackColor = true;
            // 
            // lblPayment
            // 
            this.lblPayment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPayment.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.Location = new System.Drawing.Point(13, 146);
            this.lblPayment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(1056, 66);
            this.lblPayment.TabIndex = 3;
            this.lblPayment.Text = "Payment";
            this.lblPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 673);
            this.Controls.Add(this.btnOnlinePayment);
            this.Controls.Add(this.btnPayAtCounter);
            this.Controls.Add(this.lblPayment);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Payment Page";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOnlinePayment;
        private System.Windows.Forms.Button btnPayAtCounter;
        private System.Windows.Forms.Label lblPayment;
    }
}