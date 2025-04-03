namespace Reservation_Coordinator.View
{
    partial class frmSubReservationDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSubReservationDetail));
            this.lblRevIDTitle = new System.Windows.Forms.Label();
            this.lblRevID = new System.Windows.Forms.Label();
            this.lblStatusTitle = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblFullNameTitle = new System.Windows.Forms.Label();
            this.lblUserIDTitle = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblDateTimeTitle = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.grpDetail = new System.Windows.Forms.GroupBox();
            this.lblGuestCount = new System.Windows.Forms.Label();
            this.lblRevTypeTitle = new System.Windows.Forms.Label();
            this.lblRevType = new System.Windows.Forms.Label();
            this.lblGuestCountTitle = new System.Windows.Forms.Label();
            this.grpHall = new System.Windows.Forms.GroupBox();
            this.lblHallNameTitle = new System.Windows.Forms.Label();
            this.lblHallName = new System.Windows.Forms.Label();
            this.btnMatch = new System.Windows.Forms.Button();
            this.lblHallIDTitle = new System.Windows.Forms.Label();
            this.lblHallID = new System.Windows.Forms.Label();
            this.btnComfirm = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.tblStatusBar = new System.Windows.Forms.TableLayoutPanel();
            this.floChatList = new System.Windows.Forms.FlowLayoutPanel();
            this.lblFlowSpace = new System.Windows.Forms.Label();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.tblInfoBar = new System.Windows.Forms.TableLayoutPanel();
            this.grpCustomer.SuspendLayout();
            this.grpDetail.SuspendLayout();
            this.grpHall.SuspendLayout();
            this.tblStatusBar.SuspendLayout();
            this.floChatList.SuspendLayout();
            this.tblInfoBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRevIDTitle
            // 
            this.lblRevIDTitle.AutoSize = true;
            this.lblRevIDTitle.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevIDTitle.Location = new System.Drawing.Point(26, 32);
            this.lblRevIDTitle.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.lblRevIDTitle.Name = "lblRevIDTitle";
            this.lblRevIDTitle.Size = new System.Drawing.Size(245, 45);
            this.lblRevIDTitle.TabIndex = 0;
            this.lblRevIDTitle.Text = "Reservation ID :";
            // 
            // lblRevID
            // 
            this.lblRevID.AutoSize = true;
            this.lblRevID.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevID.Location = new System.Drawing.Point(284, 32);
            this.lblRevID.Name = "lblRevID";
            this.lblRevID.Size = new System.Drawing.Size(112, 45);
            this.lblRevID.TabIndex = 1;
            this.lblRevID.Text = "RS001";
            // 
            // lblStatusTitle
            // 
            this.lblStatusTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatusTitle.AutoSize = true;
            this.lblStatusTitle.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusTitle.Location = new System.Drawing.Point(745, 32);
            this.lblStatusTitle.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.lblStatusTitle.Name = "lblStatusTitle";
            this.lblStatusTitle.Size = new System.Drawing.Size(125, 45);
            this.lblStatusTitle.TabIndex = 2;
            this.lblStatusTitle.Text = "Status :";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(883, 32);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(138, 45);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Pending";
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.lblFullName);
            this.grpCustomer.Controls.Add(this.lblFullNameTitle);
            this.grpCustomer.Controls.Add(this.lblUserIDTitle);
            this.grpCustomer.Controls.Add(this.lblUserID);
            this.grpCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpCustomer.Location = new System.Drawing.Point(3, 3);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.grpCustomer.Size = new System.Drawing.Size(387, 110);
            this.grpCustomer.TabIndex = 4;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "CUSTOMER";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(158, 73);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(125, 23);
            this.lblFullName.TabIndex = 3;
            this.lblFullName.Text = "Kuek Zheng Yu";
            // 
            // lblFullNameTitle
            // 
            this.lblFullNameTitle.Location = new System.Drawing.Point(25, 72);
            this.lblFullNameTitle.Margin = new System.Windows.Forms.Padding(15, 7, 15, 7);
            this.lblFullNameTitle.Name = "lblFullNameTitle";
            this.lblFullNameTitle.Size = new System.Drawing.Size(115, 25);
            this.lblFullNameTitle.TabIndex = 2;
            this.lblFullNameTitle.Text = "Full Name :";
            this.lblFullNameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUserIDTitle
            // 
            this.lblUserIDTitle.Location = new System.Drawing.Point(25, 33);
            this.lblUserIDTitle.Margin = new System.Windows.Forms.Padding(15, 7, 15, 7);
            this.lblUserIDTitle.Name = "lblUserIDTitle";
            this.lblUserIDTitle.Size = new System.Drawing.Size(115, 25);
            this.lblUserIDTitle.TabIndex = 0;
            this.lblUserIDTitle.Text = "User ID :";
            this.lblUserIDTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(158, 34);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(49, 23);
            this.lblUserID.TabIndex = 1;
            this.lblUserID.Text = "U001";
            // 
            // lblDateTimeTitle
            // 
            this.lblDateTimeTitle.Location = new System.Drawing.Point(25, 111);
            this.lblDateTimeTitle.Margin = new System.Windows.Forms.Padding(15, 7, 15, 7);
            this.lblDateTimeTitle.Name = "lblDateTimeTitle";
            this.lblDateTimeTitle.Size = new System.Drawing.Size(115, 25);
            this.lblDateTimeTitle.TabIndex = 0;
            this.lblDateTimeTitle.Text = "Date Time :";
            this.lblDateTimeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(148, 111);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(155, 23);
            this.lblDateTime.TabIndex = 1;
            this.lblDateTime.Text = "2025-08-21 T 06:30";
            // 
            // grpDetail
            // 
            this.grpDetail.Controls.Add(this.lblGuestCount);
            this.grpDetail.Controls.Add(this.lblDateTimeTitle);
            this.grpDetail.Controls.Add(this.lblRevTypeTitle);
            this.grpDetail.Controls.Add(this.lblDateTime);
            this.grpDetail.Controls.Add(this.lblRevType);
            this.grpDetail.Controls.Add(this.lblGuestCountTitle);
            this.grpDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDetail.Location = new System.Drawing.Point(3, 134);
            this.grpDetail.Name = "grpDetail";
            this.grpDetail.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.grpDetail.Size = new System.Drawing.Size(387, 153);
            this.grpDetail.TabIndex = 5;
            this.grpDetail.TabStop = false;
            this.grpDetail.Text = "DETAIL";
            // 
            // lblGuestCount
            // 
            this.lblGuestCount.AutoSize = true;
            this.lblGuestCount.Location = new System.Drawing.Point(148, 73);
            this.lblGuestCount.Name = "lblGuestCount";
            this.lblGuestCount.Size = new System.Drawing.Size(37, 23);
            this.lblGuestCount.TabIndex = 3;
            this.lblGuestCount.Text = "123";
            // 
            // lblRevTypeTitle
            // 
            this.lblRevTypeTitle.Location = new System.Drawing.Point(25, 33);
            this.lblRevTypeTitle.Margin = new System.Windows.Forms.Padding(15, 7, 15, 7);
            this.lblRevTypeTitle.Name = "lblRevTypeTitle";
            this.lblRevTypeTitle.Size = new System.Drawing.Size(115, 25);
            this.lblRevTypeTitle.TabIndex = 0;
            this.lblRevTypeTitle.Text = "Rev Type :";
            this.lblRevTypeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRevType
            // 
            this.lblRevType.AutoSize = true;
            this.lblRevType.Location = new System.Drawing.Point(148, 33);
            this.lblRevType.Name = "lblRevType";
            this.lblRevType.Size = new System.Drawing.Size(94, 23);
            this.lblRevType.TabIndex = 1;
            this.lblRevType.Text = "Small Party";
            // 
            // lblGuestCountTitle
            // 
            this.lblGuestCountTitle.Location = new System.Drawing.Point(25, 72);
            this.lblGuestCountTitle.Margin = new System.Windows.Forms.Padding(15, 7, 15, 7);
            this.lblGuestCountTitle.Name = "lblGuestCountTitle";
            this.lblGuestCountTitle.Size = new System.Drawing.Size(115, 25);
            this.lblGuestCountTitle.TabIndex = 2;
            this.lblGuestCountTitle.Text = "Guest Count :";
            this.lblGuestCountTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpHall
            // 
            this.grpHall.Controls.Add(this.lblHallNameTitle);
            this.grpHall.Controls.Add(this.lblHallName);
            this.grpHall.Controls.Add(this.btnMatch);
            this.grpHall.Controls.Add(this.lblHallIDTitle);
            this.grpHall.Controls.Add(this.lblHallID);
            this.grpHall.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpHall.Location = new System.Drawing.Point(3, 317);
            this.grpHall.Name = "grpHall";
            this.grpHall.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.grpHall.Size = new System.Drawing.Size(387, 153);
            this.grpHall.TabIndex = 5;
            this.grpHall.TabStop = false;
            this.grpHall.Text = "HALL";
            // 
            // lblHallNameTitle
            // 
            this.lblHallNameTitle.Location = new System.Drawing.Point(25, 72);
            this.lblHallNameTitle.Margin = new System.Windows.Forms.Padding(15, 7, 15, 7);
            this.lblHallNameTitle.Name = "lblHallNameTitle";
            this.lblHallNameTitle.Size = new System.Drawing.Size(115, 25);
            this.lblHallNameTitle.TabIndex = 9;
            this.lblHallNameTitle.Text = "Hall Name :";
            this.lblHallNameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHallName
            // 
            this.lblHallName.AutoSize = true;
            this.lblHallName.Location = new System.Drawing.Point(148, 74);
            this.lblHallName.Name = "lblHallName";
            this.lblHallName.Size = new System.Drawing.Size(82, 23);
            this.lblHallName.TabIndex = 10;
            this.lblHallName.Text = "Party Hall";
            // 
            // btnMatch
            // 
            this.btnMatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMatch.Location = new System.Drawing.Point(271, 107);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(106, 33);
            this.btnMatch.TabIndex = 8;
            this.btnMatch.Text = "Match";
            this.btnMatch.UseVisualStyleBackColor = true;
            this.btnMatch.Click += new System.EventHandler(this.btnMatch_Click);
            // 
            // lblHallIDTitle
            // 
            this.lblHallIDTitle.Location = new System.Drawing.Point(25, 33);
            this.lblHallIDTitle.Margin = new System.Windows.Forms.Padding(15, 7, 15, 7);
            this.lblHallIDTitle.Name = "lblHallIDTitle";
            this.lblHallIDTitle.Size = new System.Drawing.Size(115, 25);
            this.lblHallIDTitle.TabIndex = 0;
            this.lblHallIDTitle.Text = "Hall ID :";
            this.lblHallIDTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHallID
            // 
            this.lblHallID.AutoSize = true;
            this.lblHallID.Location = new System.Drawing.Point(148, 35);
            this.lblHallID.Name = "lblHallID";
            this.lblHallID.Size = new System.Drawing.Size(49, 23);
            this.lblHallID.TabIndex = 1;
            this.lblHallID.Text = "H001";
            // 
            // btnComfirm
            // 
            this.btnComfirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnComfirm.Location = new System.Drawing.Point(15, 3);
            this.btnComfirm.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.btnComfirm.Name = "btnComfirm";
            this.btnComfirm.Size = new System.Drawing.Size(393, 39);
            this.btnComfirm.TabIndex = 13;
            this.btnComfirm.Text = "Comfirm";
            this.btnComfirm.UseVisualStyleBackColor = true;
            this.btnComfirm.Click += new System.EventHandler(this.btnComfirm_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnComplete.Location = new System.Drawing.Point(438, 3);
            this.btnComplete.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(393, 39);
            this.btnComplete.TabIndex = 14;
            this.btnComplete.Text = "Complete";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // btnReject
            // 
            this.btnReject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReject.Location = new System.Drawing.Point(861, 3);
            this.btnReject.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(182, 39);
            this.btnReject.TabIndex = 15;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = true;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // tblStatusBar
            // 
            this.tblStatusBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblStatusBar.ColumnCount = 3;
            this.tblStatusBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblStatusBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblStatusBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblStatusBar.Controls.Add(this.btnReject, 2, 0);
            this.tblStatusBar.Controls.Add(this.btnComfirm, 0, 0);
            this.tblStatusBar.Controls.Add(this.btnComplete, 1, 0);
            this.tblStatusBar.Location = new System.Drawing.Point(12, 616);
            this.tblStatusBar.Name = "tblStatusBar";
            this.tblStatusBar.RowCount = 1;
            this.tblStatusBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblStatusBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tblStatusBar.Size = new System.Drawing.Size(1058, 45);
            this.tblStatusBar.TabIndex = 16;
            // 
            // floChatList
            // 
            this.floChatList.AllowDrop = true;
            this.floChatList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.floChatList.AutoScroll = true;
            this.floChatList.AutoScrollMinSize = new System.Drawing.Size(0, 800);
            this.floChatList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.floChatList.Controls.Add(this.lblFlowSpace);
            this.floChatList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.floChatList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floChatList.Location = new System.Drawing.Point(437, 101);
            this.floChatList.Name = "floChatList";
            this.floChatList.Size = new System.Drawing.Size(618, 423);
            this.floChatList.TabIndex = 17;
            this.floChatList.WrapContents = false;
            // 
            // lblFlowSpace
            // 
            this.lblFlowSpace.AutoSize = true;
            this.lblFlowSpace.Location = new System.Drawing.Point(3, 3);
            this.lblFlowSpace.Margin = new System.Windows.Forms.Padding(3);
            this.lblFlowSpace.MaximumSize = new System.Drawing.Size(0, 1);
            this.lblFlowSpace.Name = "lblFlowSpace";
            this.lblFlowSpace.Size = new System.Drawing.Size(607, 1);
            this.lblFlowSpace.TabIndex = 2;
            this.lblFlowSpace.Text = resources.GetString("lblFlowSpace.Text");
            // 
            // txtChat
            // 
            this.txtChat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChat.Location = new System.Drawing.Point(437, 542);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(618, 58);
            this.txtChat.TabIndex = 18;
            // 
            // tblInfoBar
            // 
            this.tblInfoBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tblInfoBar.ColumnCount = 1;
            this.tblInfoBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblInfoBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblInfoBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblInfoBar.Controls.Add(this.grpCustomer, 0, 0);
            this.tblInfoBar.Controls.Add(this.grpDetail, 0, 1);
            this.tblInfoBar.Controls.Add(this.grpHall, 0, 2);
            this.tblInfoBar.Location = new System.Drawing.Point(27, 101);
            this.tblInfoBar.Name = "tblInfoBar";
            this.tblInfoBar.RowCount = 3;
            this.tblInfoBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.44F));
            this.tblInfoBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.78F));
            this.tblInfoBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.78F));
            this.tblInfoBar.Size = new System.Drawing.Size(393, 499);
            this.tblInfoBar.TabIndex = 19;
            // 
            // frmSubReservationDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1082, 673);
            this.Controls.Add(this.tblInfoBar);
            this.Controls.Add(this.txtChat);
            this.Controls.Add(this.floChatList);
            this.Controls.Add(this.tblStatusBar);
            this.Controls.Add(this.lblRevID);
            this.Controls.Add(this.lblRevIDTitle);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblStatusTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmSubReservationDetail";
            this.Text = "Reservation Detail";
            this.Load += new System.EventHandler(this.frmSubReservationDetail_Load);
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.grpDetail.ResumeLayout(false);
            this.grpDetail.PerformLayout();
            this.grpHall.ResumeLayout(false);
            this.grpHall.PerformLayout();
            this.tblStatusBar.ResumeLayout(false);
            this.floChatList.ResumeLayout(false);
            this.floChatList.PerformLayout();
            this.tblInfoBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRevIDTitle;
        private System.Windows.Forms.Label lblRevID;
        private System.Windows.Forms.Label lblStatusTitle;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblFullNameTitle;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblUserIDTitle;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblDateTimeTitle;
        private System.Windows.Forms.GroupBox grpDetail;
        private System.Windows.Forms.Label lblGuestCount;
        private System.Windows.Forms.Label lblGuestCountTitle;
        private System.Windows.Forms.Label lblRevType;
        private System.Windows.Forms.Label lblRevTypeTitle;
        private System.Windows.Forms.GroupBox grpHall;
        private System.Windows.Forms.Label lblHallID;
        private System.Windows.Forms.Label lblHallIDTitle;
        private System.Windows.Forms.Button btnMatch;
        private System.Windows.Forms.Button btnComfirm;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Label lblHallNameTitle;
        private System.Windows.Forms.Label lblHallName;
        private System.Windows.Forms.TableLayoutPanel tblStatusBar;
        private System.Windows.Forms.FlowLayoutPanel floChatList;
        private System.Windows.Forms.Label lblFlowSpace;
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.TableLayoutPanel tblInfoBar;
    }
}