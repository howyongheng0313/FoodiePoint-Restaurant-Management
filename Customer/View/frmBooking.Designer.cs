namespace Customer
{
    partial class frmBooking
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.HallID = new System.Windows.Forms.Label();
            this.lblreservationStatus = new System.Windows.Forms.Label();
            this.lblresID = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.reqtxtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResType = new System.Windows.Forms.TextBox();
            this.txtGuestCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.btnReservationBook = new System.Windows.Forms.Button();
            this.lblReservationType = new System.Windows.Forms.Label();
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
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.HallID);
            this.splitContainer1.Panel2.Controls.Add(this.lblreservationStatus);
            this.splitContainer1.Panel2.Controls.Add(this.lblresID);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.reqtxtbox);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.txtResType);
            this.splitContainer1.Panel2.Controls.Add(this.txtGuestCount);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.txtResDate);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.lblFeedback);
            this.splitContainer1.Panel2.Controls.Add(this.btnReservationBook);
            this.splitContainer1.Panel2.Controls.Add(this.lblReservationType);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(776, 426);
            this.splitContainer1.SplitterDistance = 230;
            this.splitContainer1.TabIndex = 6;
            // 
            // btnCutomerToHallReservation
            // 
            this.btnCutomerToHallReservation.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCutomerToHallReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCutomerToHallReservation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCutomerToHallReservation.Location = new System.Drawing.Point(3, 327);
            this.btnCutomerToHallReservation.Name = "btnCutomerToHallReservation";
            this.btnCutomerToHallReservation.Size = new System.Drawing.Size(224, 96);
            this.btnCutomerToHallReservation.TabIndex = 11;
            this.btnCutomerToHallReservation.Text = "Hall Reservation";
            this.btnCutomerToHallReservation.UseVisualStyleBackColor = false;
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.SystemColors.ButtonFace;
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
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(302, 71);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(206, 222);
            this.richTextBox1.TabIndex = 35;
            this.richTextBox1.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "HallID";
            // 
            // HallID
            // 
            this.HallID.AutoSize = true;
            this.HallID.Location = new System.Drawing.Point(150, 244);
            this.HallID.Name = "HallID";
            this.HallID.Size = new System.Drawing.Size(0, 13);
            this.HallID.TabIndex = 33;
            // 
            // lblreservationStatus
            // 
            this.lblreservationStatus.AutoSize = true;
            this.lblreservationStatus.Location = new System.Drawing.Point(140, 209);
            this.lblreservationStatus.Name = "lblreservationStatus";
            this.lblreservationStatus.Size = new System.Drawing.Size(0, 13);
            this.lblreservationStatus.TabIndex = 32;
            // 
            // lblresID
            // 
            this.lblresID.AutoSize = true;
            this.lblresID.Location = new System.Drawing.Point(19, 65);
            this.lblresID.Name = "lblresID";
            this.lblresID.Size = new System.Drawing.Size(0, 13);
            this.lblresID.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(481, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reqtxtbox
            // 
            this.reqtxtbox.Location = new System.Drawing.Point(302, 309);
            this.reqtxtbox.Name = "reqtxtbox";
            this.reqtxtbox.Size = new System.Drawing.Size(148, 20);
            this.reqtxtbox.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Reservation Status";
            // 
            // txtResType
            // 
            this.txtResType.Location = new System.Drawing.Point(143, 114);
            this.txtResType.Name = "txtResType";
            this.txtResType.Size = new System.Drawing.Size(121, 20);
            this.txtResType.TabIndex = 25;
            this.txtResType.Text = "Put date here...";
            // 
            // txtGuestCount
            // 
            this.txtGuestCount.Location = new System.Drawing.Point(143, 178);
            this.txtGuestCount.Name = "txtGuestCount";
            this.txtGuestCount.Size = new System.Drawing.Size(121, 20);
            this.txtGuestCount.TabIndex = 23;
            this.txtGuestCount.Text = "Put amount of people here...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Gueast Count*";
            // 
            // txtResDate
            // 
            this.txtResDate.Location = new System.Drawing.Point(143, 147);
            this.txtResDate.Name = "txtResDate";
            this.txtResDate.Size = new System.Drawing.Size(121, 20);
            this.txtResDate.TabIndex = 21;
            this.txtResDate.Text = "Put date here...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Reservation Date*";
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Location = new System.Drawing.Point(299, 42);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(47, 13);
            this.lblFeedback.TabIndex = 16;
            this.lblFeedback.Text = "Request";
            // 
            // btnReservationBook
            // 
            this.btnReservationBook.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReservationBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservationBook.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReservationBook.Location = new System.Drawing.Point(407, 357);
            this.btnReservationBook.Name = "btnReservationBook";
            this.btnReservationBook.Size = new System.Drawing.Size(101, 47);
            this.btnReservationBook.TabIndex = 13;
            this.btnReservationBook.Text = "Book now";
            this.btnReservationBook.UseVisualStyleBackColor = false;
            this.btnReservationBook.Click += new System.EventHandler(this.btnReservationStatus_Click);
            // 
            // lblReservationType
            // 
            this.lblReservationType.AutoSize = true;
            this.lblReservationType.Location = new System.Drawing.Point(19, 114);
            this.lblReservationType.Name = "lblReservationType";
            this.lblReservationType.Size = new System.Drawing.Size(95, 13);
            this.lblReservationType.TabIndex = 15;
            this.lblReservationType.Text = "Reservation Type*";
            // 
            // frmBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmBooking";
            this.Text = "frmBooking";
            this.Load += new System.EventHandler(this.frmBooking_Load);
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
        private System.Windows.Forms.Button btnReservationBook;
        private System.Windows.Forms.Label lblReservationType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResDate;
        private System.Windows.Forms.TextBox txtGuestCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox reqtxtbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblresID;
        private System.Windows.Forms.Label lblreservationStatus;
        private System.Windows.Forms.Label HallID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}