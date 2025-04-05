namespace Reservation_Coordinator.View
{
    partial class frmMainTool
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
            this.splMain = new System.Windows.Forms.SplitContainer();
            this.btnViewRev = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splMain)).BeginInit();
            this.splMain.Panel1.SuspendLayout();
            this.splMain.Panel2.SuspendLayout();
            this.splMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // splMain
            // 
            this.splMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splMain.IsSplitterFixed = true;
            this.splMain.Location = new System.Drawing.Point(0, 0);
            this.splMain.Margin = new System.Windows.Forms.Padding(2);
            this.splMain.Name = "splMain";
            // 
            // splMain.Panel1
            // 
            this.splMain.Panel1.AutoScroll = true;
            this.splMain.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splMain.Panel1.Controls.Add(this.btnViewRev);
            this.splMain.Panel1.Controls.Add(this.btnProfile);
            this.splMain.Panel1.Controls.Add(this.lblLogo);
            this.splMain.Panel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            // 
            // splMain.Panel2
            // 
            this.splMain.Panel2.Controls.Add(this.pnlContent);
            this.splMain.Panel2.Controls.Add(this.lblTitle);
            this.splMain.Size = new System.Drawing.Size(1082, 673);
            this.splMain.SplitterDistance = 228;
            this.splMain.SplitterWidth = 1;
            this.splMain.TabIndex = 0;
            // 
            // btnViewRev
            // 
            this.btnViewRev.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnViewRev.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewRev.FlatAppearance.BorderSize = 0;
            this.btnViewRev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewRev.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewRev.Location = new System.Drawing.Point(10, 178);
            this.btnViewRev.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewRev.Name = "btnViewRev";
            this.btnViewRev.Size = new System.Drawing.Size(208, 80);
            this.btnViewRev.TabIndex = 4;
            this.btnViewRev.Text = "View Reservations";
            this.btnViewRev.UseVisualStyleBackColor = true;
            this.btnViewRev.Click += new System.EventHandler(this.btnViewRev_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.Location = new System.Drawing.Point(10, 98);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(2);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(208, 80);
            this.btnProfile.TabIndex = 3;
            this.btnProfile.Text = "Owner Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogo.Font = new System.Drawing.Font("Jokerman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(10, 0);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(208, 98);
            this.lblLogo.TabIndex = 1;
            this.lblLogo.Text = "Foodie Point";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlContent
            // 
            this.pnlContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContent.Location = new System.Drawing.Point(0, 98);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(862, 575);
            this.pnlContent.TabIndex = 9;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(3, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(856, 67);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "TITLE";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMainTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1082, 673);
            this.Controls.Add(this.splMain);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmMainTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Template";
            this.splMain.Panel1.ResumeLayout(false);
            this.splMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splMain)).EndInit();
            this.splMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splMain;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnViewRev;
    }
}