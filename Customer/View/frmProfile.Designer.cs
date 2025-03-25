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
            this.btnCutomerToHallReservation = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnCustomerToMenu = new System.Windows.Forms.Button();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.rtbxFeedback = new System.Windows.Forms.RichTextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.btnSendFeedback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.splitContainer1.Panel1.Controls.Add(this.btnCutomerToHallReservation);
            this.splitContainer1.Panel1.Controls.Add(this.btnProfile);
            this.splitContainer1.Panel1.Controls.Add(this.btnCustomerToMenu);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblFeedback);
            this.splitContainer1.Panel2.Controls.Add(this.rtbxFeedback);
            this.splitContainer1.Panel2.Controls.Add(this.button7);
            this.splitContainer1.Panel2.Controls.Add(this.btnSendFeedback);
            this.splitContainer1.Size = new System.Drawing.Size(776, 426);
            this.splitContainer1.SplitterDistance = 230;
            this.splitContainer1.TabIndex = 5;
            // 
            // btnCutomerToHallReservation
            // 
            this.btnCutomerToHallReservation.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCutomerToHallReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCutomerToHallReservation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCutomerToHallReservation.Location = new System.Drawing.Point(3, 327);
            this.btnCutomerToHallReservation.Name = "btnCutomerToHallReservation";
            this.btnCutomerToHallReservation.Size = new System.Drawing.Size(224, 96);
            this.btnCutomerToHallReservation.TabIndex = 11;
            this.btnCutomerToHallReservation.Text = "Hall Reservation";
            this.btnCutomerToHallReservation.UseVisualStyleBackColor = false;
            this.btnCutomerToHallReservation.Click += new System.EventHandler(this.btnCustomerToHallReservation_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProfile.Location = new System.Drawing.Point(3, 123);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(224, 96);
            this.btnProfile.TabIndex = 10;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnCustomerToMenu
            // 
            this.btnCustomerToMenu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCustomerToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerToMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCustomerToMenu.Location = new System.Drawing.Point(3, 225);
            this.btnCustomerToMenu.Name = "btnCustomerToMenu";
            this.btnCustomerToMenu.Size = new System.Drawing.Size(224, 96);
            this.btnCustomerToMenu.TabIndex = 9;
            this.btnCustomerToMenu.Text = "Menu";
            this.btnCustomerToMenu.UseVisualStyleBackColor = false;
            this.btnCustomerToMenu.Click += new System.EventHandler(this.btnCustomerToMenu_Click);
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Location = new System.Drawing.Point(19, 228);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(55, 13);
            this.lblFeedback.TabIndex = 16;
            this.lblFeedback.Text = "Feedback";
            this.lblFeedback.Click += new System.EventHandler(this.lblFeedback_Click);
            // 
            // rtbxFeedback
            // 
            this.rtbxFeedback.Location = new System.Drawing.Point(22, 257);
            this.rtbxFeedback.Name = "rtbxFeedback";
            this.rtbxFeedback.Size = new System.Drawing.Size(486, 75);
            this.rtbxFeedback.TabIndex = 10;
            this.rtbxFeedback.Text = "";
            this.rtbxFeedback.TextChanged += new System.EventHandler(this.rtbxFeedback_TextChanged);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.Location = new System.Drawing.Point(41, 79);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(431, 95);
            this.button7.TabIndex = 9;
            this.button7.Text = "Welcome to FoodiePoint Restaurant!";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // btnSendFeedback
            // 
            this.btnSendFeedback.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSendFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendFeedback.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSendFeedback.Location = new System.Drawing.Point(407, 338);
            this.btnSendFeedback.Name = "btnSendFeedback";
            this.btnSendFeedback.Size = new System.Drawing.Size(101, 40);
            this.btnSendFeedback.TabIndex = 7;
            this.btnSendFeedback.Text = "Send Feedback";
            this.btnSendFeedback.UseVisualStyleBackColor = false;
            this.btnSendFeedback.Click += new System.EventHandler(this.btnSendFeedback_Click);
            // 
            // frmCustomerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmCustomerMain";
            this.Text = "Customer Main Page";
            this.Load += new System.EventHandler(this.frmCustomerMain_Load);
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
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnSendFeedback;
    }
}

