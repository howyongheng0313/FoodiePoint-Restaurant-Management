namespace Customer
{
    partial class frmCustomerMain
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.btnCutomerToHallReservation = new System.Windows.Forms.Button();
            this.btnCustomerToMenu = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.lblFoodiePoint = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.cmbRating = new System.Windows.Forms.ComboBox();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.rtbxFeedback = new System.Windows.Forms.RichTextBox();
            this.btnSendFeedback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.btnUpdateProfile);
            this.splitContainer1.Panel1.Controls.Add(this.btnCutomerToHallReservation);
            this.splitContainer1.Panel1.Controls.Add(this.btnCustomerToMenu);
            this.splitContainer1.Panel1.Controls.Add(this.btnProfile);
            this.splitContainer1.Panel1.Controls.Add(this.lblFoodiePoint);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblWelcome);
            this.splitContainer1.Panel2.Controls.Add(this.lblRating);
            this.splitContainer1.Panel2.Controls.Add(this.cmbRating);
            this.splitContainer1.Panel2.Controls.Add(this.lblFeedback);
            this.splitContainer1.Panel2.Controls.Add(this.rtbxFeedback);
            this.splitContainer1.Panel2.Controls.Add(this.btnSendFeedback);
            this.splitContainer1.Size = new System.Drawing.Size(1082, 673);
            this.splitContainer1.SplitterDistance = 228;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 5;
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateProfile.FlatAppearance.BorderSize = 0;
            this.btnUpdateProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProfile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdateProfile.Location = new System.Drawing.Point(10, 338);
            this.btnUpdateProfile.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(208, 80);
            this.btnUpdateProfile.TabIndex = 13;
            this.btnUpdateProfile.Text = "Update Profile";
            this.btnUpdateProfile.UseVisualStyleBackColor = false;
            this.btnUpdateProfile.Click += new System.EventHandler(this.btnUpdateProfile_Click);
            // 
            // btnCutomerToHallReservation
            // 
            this.btnCutomerToHallReservation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCutomerToHallReservation.FlatAppearance.BorderSize = 0;
            this.btnCutomerToHallReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCutomerToHallReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCutomerToHallReservation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCutomerToHallReservation.Location = new System.Drawing.Point(10, 258);
            this.btnCutomerToHallReservation.Margin = new System.Windows.Forms.Padding(2);
            this.btnCutomerToHallReservation.Name = "btnCutomerToHallReservation";
            this.btnCutomerToHallReservation.Size = new System.Drawing.Size(208, 80);
            this.btnCutomerToHallReservation.TabIndex = 11;
            this.btnCutomerToHallReservation.Text = "Hall Reservation";
            this.btnCutomerToHallReservation.UseVisualStyleBackColor = false;
            this.btnCutomerToHallReservation.Click += new System.EventHandler(this.btnCustomerToHallReservation_Click);
            // 
            // btnCustomerToMenu
            // 
            this.btnCustomerToMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomerToMenu.FlatAppearance.BorderSize = 0;
            this.btnCustomerToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerToMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCustomerToMenu.Location = new System.Drawing.Point(10, 178);
            this.btnCustomerToMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustomerToMenu.Name = "btnCustomerToMenu";
            this.btnCustomerToMenu.Size = new System.Drawing.Size(208, 80);
            this.btnCustomerToMenu.TabIndex = 9;
            this.btnCustomerToMenu.Text = "Menu";
            this.btnCustomerToMenu.UseVisualStyleBackColor = false;
            this.btnCustomerToMenu.Click += new System.EventHandler(this.btnCustomerToMenu_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(161)))), ((int)(((byte)(188)))));
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProfile.Location = new System.Drawing.Point(10, 98);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(2);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(208, 80);
            this.btnProfile.TabIndex = 10;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            // 
            // lblFoodiePoint
            // 
            this.lblFoodiePoint.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFoodiePoint.Font = new System.Drawing.Font("Jokerman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodiePoint.Location = new System.Drawing.Point(10, 0);
            this.lblFoodiePoint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFoodiePoint.Name = "lblFoodiePoint";
            this.lblFoodiePoint.Size = new System.Drawing.Size(208, 98);
            this.lblFoodiePoint.TabIndex = 15;
            this.lblFoodiePoint.Text = "Foodie Point";
            this.lblFoodiePoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(50, 98);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(330, 25);
            this.lblWelcome.TabIndex = 19;
            this.lblWelcome.Text = "Welcome to FoodiePoint Restaurant!";
            // 
            // lblRating
            // 
            this.lblRating.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(602, 265);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(62, 20);
            this.lblRating.TabIndex = 18;
            this.lblRating.Text = "Rating:";
            // 
            // cmbRating
            // 
            this.cmbRating.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmbRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRating.FormattingEnabled = true;
            this.cmbRating.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbRating.Location = new System.Drawing.Point(670, 262);
            this.cmbRating.Name = "cmbRating";
            this.cmbRating.Size = new System.Drawing.Size(133, 28);
            this.cmbRating.Sorted = true;
            this.cmbRating.TabIndex = 17;
            // 
            // lblFeedback
            // 
            this.lblFeedback.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Location = new System.Drawing.Point(51, 265);
            this.lblFeedback.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(81, 20);
            this.lblFeedback.TabIndex = 16;
            this.lblFeedback.Text = "Feedback";
            // 
            // rtbxFeedback
            // 
            this.rtbxFeedback.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbxFeedback.Location = new System.Drawing.Point(55, 305);
            this.rtbxFeedback.Margin = new System.Windows.Forms.Padding(4);
            this.rtbxFeedback.Name = "rtbxFeedback";
            this.rtbxFeedback.Size = new System.Drawing.Size(748, 122);
            this.rtbxFeedback.TabIndex = 10;
            this.rtbxFeedback.Text = "";
            // 
            // btnSendFeedback
            // 
            this.btnSendFeedback.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSendFeedback.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSendFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendFeedback.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSendFeedback.Location = new System.Drawing.Point(668, 476);
            this.btnSendFeedback.Margin = new System.Windows.Forms.Padding(4);
            this.btnSendFeedback.Name = "btnSendFeedback";
            this.btnSendFeedback.Size = new System.Drawing.Size(135, 49);
            this.btnSendFeedback.TabIndex = 7;
            this.btnSendFeedback.Text = "Send Feedback";
            this.btnSendFeedback.UseVisualStyleBackColor = false;
            this.btnSendFeedback.Click += new System.EventHandler(this.btnSendFeedback_Click);
            // 
            // frmCustomerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 673);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmCustomerMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Customer Main Page";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnCutomerToHallReservation;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnCustomerToMenu;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.RichTextBox rtbxFeedback;
        private System.Windows.Forms.Button btnSendFeedback;
        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.Label lblFoodiePoint;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.ComboBox cmbRating;
        private System.Windows.Forms.Label lblWelcome;
    }
}

