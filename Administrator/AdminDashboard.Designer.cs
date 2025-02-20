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
            this.lblManager = new System.Windows.Forms.Label();
            this.lblChef = new System.Windows.Forms.Label();
            this.lblRC = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblVSR = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHi = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(324, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(242, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Admin Dashboard";
            this.lblTitle.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblManager
            // 
            this.lblManager.AutoSize = true;
            this.lblManager.BackColor = System.Drawing.SystemColors.Info;
            this.lblManager.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManager.Location = new System.Drawing.Point(271, 241);
            this.lblManager.Name = "lblManager";
            this.lblManager.Size = new System.Drawing.Size(100, 29);
            this.lblManager.TabIndex = 2;
            this.lblManager.Text = "Manager";
            // 
            // lblChef
            // 
            this.lblChef.AutoSize = true;
            this.lblChef.BackColor = System.Drawing.SystemColors.Info;
            this.lblChef.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChef.Location = new System.Drawing.Point(401, 241);
            this.lblChef.Name = "lblChef";
            this.lblChef.Size = new System.Drawing.Size(60, 29);
            this.lblChef.TabIndex = 3;
            this.lblChef.Text = "Chef";
            // 
            // lblRC
            // 
            this.lblRC.AutoSize = true;
            this.lblRC.BackColor = System.Drawing.SystemColors.Info;
            this.lblRC.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRC.Location = new System.Drawing.Point(204, 309);
            this.lblRC.Name = "lblRC";
            this.lblRC.Size = new System.Drawing.Size(257, 29);
            this.lblRC.TabIndex = 4;
            this.lblRC.Text = "Reservation Coordinator";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.BackColor = System.Drawing.SystemColors.Info;
            this.lblCustomer.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(137, 243);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(112, 29);
            this.lblCustomer.TabIndex = 5;
            this.lblCustomer.Text = "Customer";
            // 
            // lblVSR
            // 
            this.lblVSR.AutoSize = true;
            this.lblVSR.BackColor = System.Drawing.SystemColors.Info;
            this.lblVSR.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVSR.Location = new System.Drawing.Point(581, 402);
            this.lblVSR.Name = "lblVSR";
            this.lblVSR.Size = new System.Drawing.Size(192, 29);
            this.lblVSR.TabIndex = 6;
            this.lblVSR.Text = "View Sales Report";
            this.lblVSR.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(39, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 90);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblHi
            // 
            this.lblHi.AutoSize = true;
            this.lblHi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHi.Location = new System.Drawing.Point(171, 66);
            this.lblHi.Name = "lblHi";
            this.lblHi.Size = new System.Drawing.Size(99, 29);
            this.lblHi.TabIndex = 8;
            this.lblHi.Text = "Hi, User";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 31);
            this.button1.TabIndex = 9;
            this.button1.Text = "Update Profile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Users";
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblHi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblVSR);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.lblRC);
            this.Controls.Add(this.lblChef);
            this.Controls.Add(this.lblManager);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmAdmin";
            this.Text = "Adminstrator Page";
            this.Load += new System.EventHandler(this.FrmCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblManager;
        private System.Windows.Forms.Label lblChef;
        private System.Windows.Forms.Label lblRC;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblVSR;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

