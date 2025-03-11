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
            this.lblRevIDTitle = new System.Windows.Forms.Label();
            this.lblRevID = new System.Windows.Forms.Label();
            this.lblStatusTitle = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grpInformation = new System.Windows.Forms.GroupBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblContactTitle = new System.Windows.Forms.Label();
            this.lblCustomerTitle = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.grpTime = new System.Windows.Forms.GroupBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblDateTimeTitle = new System.Windows.Forms.Label();
            this.lblDurationTitle = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.grpType = new System.Windows.Forms.GroupBox();
            this.lblPartyType = new System.Windows.Forms.Label();
            this.lblRevTypeTitle = new System.Windows.Forms.Label();
            this.lblRevType = new System.Windows.Forms.Label();
            this.lblPartyTypeTitle = new System.Windows.Forms.Label();
            this.grpPlanning = new System.Windows.Forms.GroupBox();
            this.btnMatch = new System.Windows.Forms.Button();
            this.lblHallTitle = new System.Windows.Forms.Label();
            this.lblHall = new System.Windows.Forms.Label();
            this.lblRequestTitle = new System.Windows.Forms.Label();
            this.lblResponseTitle = new System.Windows.Forms.Label();
            this.txtResponse = new System.Windows.Forms.RichTextBox();
            this.lblRequest = new System.Windows.Forms.Label();
            this.btnComfirm = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.grpInformation.SuspendLayout();
            this.grpTime.SuspendLayout();
            this.grpType.SuspendLayout();
            this.grpPlanning.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRevIDTitle
            // 
            this.lblRevIDTitle.AutoSize = true;
            this.lblRevIDTitle.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevIDTitle.Location = new System.Drawing.Point(55, 51);
            this.lblRevIDTitle.Name = "lblRevIDTitle";
            this.lblRevIDTitle.Size = new System.Drawing.Size(245, 45);
            this.lblRevIDTitle.TabIndex = 0;
            this.lblRevIDTitle.Text = "Reservation ID :";
            // 
            // lblRevID
            // 
            this.lblRevID.AutoSize = true;
            this.lblRevID.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevID.Location = new System.Drawing.Point(380, 51);
            this.lblRevID.Name = "lblRevID";
            this.lblRevID.Size = new System.Drawing.Size(76, 45);
            this.lblRevID.TabIndex = 1;
            this.lblRevID.Text = "R01";
            // 
            // lblStatusTitle
            // 
            this.lblStatusTitle.AutoSize = true;
            this.lblStatusTitle.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusTitle.Location = new System.Drawing.Point(750, 51);
            this.lblStatusTitle.Name = "lblStatusTitle";
            this.lblStatusTitle.Size = new System.Drawing.Size(125, 45);
            this.lblStatusTitle.TabIndex = 2;
            this.lblStatusTitle.Text = "Status :";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(944, 51);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(138, 45);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Pending";
            // 
            // grpInformation
            // 
            this.grpInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpInformation.Controls.Add(this.lblContact);
            this.grpInformation.Controls.Add(this.lblContactTitle);
            this.grpInformation.Controls.Add(this.lblCustomerTitle);
            this.grpInformation.Controls.Add(this.lblCustomer);
            this.grpInformation.Location = new System.Drawing.Point(29, 142);
            this.grpInformation.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.grpInformation.Name = "grpInformation";
            this.grpInformation.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.grpInformation.Size = new System.Drawing.Size(350, 110);
            this.grpInformation.TabIndex = 4;
            this.grpInformation.TabStop = false;
            this.grpInformation.Text = "INFORMATION";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(148, 74);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(100, 23);
            this.lblContact.TabIndex = 3;
            this.lblContact.Text = "0123456789";
            // 
            // lblContactTitle
            // 
            this.lblContactTitle.Location = new System.Drawing.Point(25, 72);
            this.lblContactTitle.Margin = new System.Windows.Forms.Padding(15, 7, 15, 7);
            this.lblContactTitle.Name = "lblContactTitle";
            this.lblContactTitle.Size = new System.Drawing.Size(110, 25);
            this.lblContactTitle.TabIndex = 2;
            this.lblContactTitle.Text = "Contact :";
            this.lblContactTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomerTitle
            // 
            this.lblCustomerTitle.Location = new System.Drawing.Point(25, 33);
            this.lblCustomerTitle.Margin = new System.Windows.Forms.Padding(15, 7, 15, 7);
            this.lblCustomerTitle.Name = "lblCustomerTitle";
            this.lblCustomerTitle.Size = new System.Drawing.Size(110, 25);
            this.lblCustomerTitle.TabIndex = 0;
            this.lblCustomerTitle.Text = "Customer :";
            this.lblCustomerTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(148, 35);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(123, 23);
            this.lblCustomer.TabIndex = 1;
            this.lblCustomer.Text = "What The Fuck";
            // 
            // grpTime
            // 
            this.grpTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTime.Controls.Add(this.lblDuration);
            this.grpTime.Controls.Add(this.lblDateTimeTitle);
            this.grpTime.Controls.Add(this.lblDurationTitle);
            this.grpTime.Controls.Add(this.lblDateTime);
            this.grpTime.Location = new System.Drawing.Point(416, 142);
            this.grpTime.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.grpTime.Name = "grpTime";
            this.grpTime.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.grpTime.Size = new System.Drawing.Size(350, 110);
            this.grpTime.TabIndex = 5;
            this.grpTime.TabStop = false;
            this.grpTime.Text = "TIME";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(148, 74);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(60, 23);
            this.lblDuration.TabIndex = 3;
            this.lblDuration.Text = "1 hour";
            // 
            // lblDateTimeTitle
            // 
            this.lblDateTimeTitle.Location = new System.Drawing.Point(25, 33);
            this.lblDateTimeTitle.Margin = new System.Windows.Forms.Padding(15, 7, 15, 7);
            this.lblDateTimeTitle.Name = "lblDateTimeTitle";
            this.lblDateTimeTitle.Size = new System.Drawing.Size(110, 25);
            this.lblDateTimeTitle.TabIndex = 0;
            this.lblDateTimeTitle.Text = "Date Time :";
            this.lblDateTimeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDurationTitle
            // 
            this.lblDurationTitle.Location = new System.Drawing.Point(25, 72);
            this.lblDurationTitle.Margin = new System.Windows.Forms.Padding(15, 7, 15, 7);
            this.lblDurationTitle.Name = "lblDurationTitle";
            this.lblDurationTitle.Size = new System.Drawing.Size(110, 25);
            this.lblDurationTitle.TabIndex = 2;
            this.lblDurationTitle.Text = "Duration :";
            this.lblDurationTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(148, 33);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(155, 23);
            this.lblDateTime.TabIndex = 1;
            this.lblDateTime.Text = "2025-08-21 T 06:30";
            // 
            // grpType
            // 
            this.grpType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpType.Controls.Add(this.lblPartyType);
            this.grpType.Controls.Add(this.lblRevTypeTitle);
            this.grpType.Controls.Add(this.lblRevType);
            this.grpType.Controls.Add(this.lblPartyTypeTitle);
            this.grpType.Location = new System.Drawing.Point(803, 142);
            this.grpType.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.grpType.Name = "grpType";
            this.grpType.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.grpType.Size = new System.Drawing.Size(350, 110);
            this.grpType.TabIndex = 5;
            this.grpType.TabStop = false;
            this.grpType.Text = "TYPE";
            // 
            // lblPartyType
            // 
            this.lblPartyType.AutoSize = true;
            this.lblPartyType.Location = new System.Drawing.Point(148, 73);
            this.lblPartyType.Name = "lblPartyType";
            this.lblPartyType.Size = new System.Drawing.Size(73, 23);
            this.lblPartyType.TabIndex = 3;
            this.lblPartyType.Text = "Birthday";
            // 
            // lblRevTypeTitle
            // 
            this.lblRevTypeTitle.Location = new System.Drawing.Point(25, 33);
            this.lblRevTypeTitle.Margin = new System.Windows.Forms.Padding(15, 7, 15, 7);
            this.lblRevTypeTitle.Name = "lblRevTypeTitle";
            this.lblRevTypeTitle.Size = new System.Drawing.Size(110, 25);
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
            // lblPartyTypeTitle
            // 
            this.lblPartyTypeTitle.Location = new System.Drawing.Point(25, 72);
            this.lblPartyTypeTitle.Margin = new System.Windows.Forms.Padding(15, 7, 15, 7);
            this.lblPartyTypeTitle.Name = "lblPartyTypeTitle";
            this.lblPartyTypeTitle.Size = new System.Drawing.Size(110, 25);
            this.lblPartyTypeTitle.TabIndex = 2;
            this.lblPartyTypeTitle.Text = "Party Type :";
            this.lblPartyTypeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpPlanning
            // 
            this.grpPlanning.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPlanning.Controls.Add(this.btnMatch);
            this.grpPlanning.Controls.Add(this.lblHallTitle);
            this.grpPlanning.Controls.Add(this.lblHall);
            this.grpPlanning.Location = new System.Drawing.Point(29, 287);
            this.grpPlanning.Name = "grpPlanning";
            this.grpPlanning.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.grpPlanning.Size = new System.Drawing.Size(350, 110);
            this.grpPlanning.TabIndex = 5;
            this.grpPlanning.TabStop = false;
            this.grpPlanning.Text = "PLANNING";
            // 
            // btnMatch
            // 
            this.btnMatch.Location = new System.Drawing.Point(232, 68);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(106, 33);
            this.btnMatch.TabIndex = 8;
            this.btnMatch.Text = "Match";
            this.btnMatch.UseVisualStyleBackColor = true;
            // 
            // lblHallTitle
            // 
            this.lblHallTitle.Location = new System.Drawing.Point(25, 33);
            this.lblHallTitle.Margin = new System.Windows.Forms.Padding(15, 7, 15, 7);
            this.lblHallTitle.Name = "lblHallTitle";
            this.lblHallTitle.Size = new System.Drawing.Size(110, 25);
            this.lblHallTitle.TabIndex = 0;
            this.lblHallTitle.Text = "Hall :";
            this.lblHallTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHall
            // 
            this.lblHall.AutoSize = true;
            this.lblHall.Location = new System.Drawing.Point(148, 35);
            this.lblHall.Name = "lblHall";
            this.lblHall.Size = new System.Drawing.Size(40, 23);
            this.lblHall.TabIndex = 1;
            this.lblHall.Text = "H01";
            // 
            // lblRequestTitle
            // 
            this.lblRequestTitle.Location = new System.Drawing.Point(25, 436);
            this.lblRequestTitle.Name = "lblRequestTitle";
            this.lblRequestTitle.Size = new System.Drawing.Size(160, 25);
            this.lblRequestTitle.TabIndex = 6;
            this.lblRequestTitle.Text = "Customer Request :";
            this.lblRequestTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblResponseTitle
            // 
            this.lblResponseTitle.Location = new System.Drawing.Point(624, 436);
            this.lblResponseTitle.Name = "lblResponseTitle";
            this.lblResponseTitle.Size = new System.Drawing.Size(160, 25);
            this.lblResponseTitle.TabIndex = 10;
            this.lblResponseTitle.Text = "Response :";
            this.lblResponseTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(628, 464);
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.Size = new System.Drawing.Size(525, 155);
            this.txtResponse.TabIndex = 11;
            this.txtResponse.Text = "";
            // 
            // lblRequest
            // 
            this.lblRequest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRequest.Location = new System.Drawing.Point(29, 464);
            this.lblRequest.Name = "lblRequest";
            this.lblRequest.Size = new System.Drawing.Size(525, 155);
            this.lblRequest.TabIndex = 12;
            // 
            // btnComfirm
            // 
            this.btnComfirm.Location = new System.Drawing.Point(29, 668);
            this.btnComfirm.Name = "btnComfirm";
            this.btnComfirm.Size = new System.Drawing.Size(437, 47);
            this.btnComfirm.TabIndex = 13;
            this.btnComfirm.Text = "Comfirm";
            this.btnComfirm.UseVisualStyleBackColor = true;
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(504, 668);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(437, 47);
            this.btnComplete.TabIndex = 14;
            this.btnComplete.Text = "Complete";
            this.btnComplete.UseVisualStyleBackColor = true;
            // 
            // btnReject
            // 
            this.btnReject.Location = new System.Drawing.Point(977, 668);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(176, 47);
            this.btnReject.TabIndex = 15;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = true;
            // 
            // frmSubReservationDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 673);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.btnComfirm);
            this.Controls.Add(this.lblRequest);
            this.Controls.Add(this.lblRevID);
            this.Controls.Add(this.lblRevIDTitle);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.lblResponseTitle);
            this.Controls.Add(this.lblRequestTitle);
            this.Controls.Add(this.lblStatusTitle);
            this.Controls.Add(this.grpPlanning);
            this.Controls.Add(this.grpTime);
            this.Controls.Add(this.grpType);
            this.Controls.Add(this.grpInformation);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSubReservationDetail";
            this.Text = "Reservation Detail";
            this.grpInformation.ResumeLayout(false);
            this.grpInformation.PerformLayout();
            this.grpTime.ResumeLayout(false);
            this.grpTime.PerformLayout();
            this.grpType.ResumeLayout(false);
            this.grpType.PerformLayout();
            this.grpPlanning.ResumeLayout(false);
            this.grpPlanning.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRevIDTitle;
        private System.Windows.Forms.Label lblRevID;
        private System.Windows.Forms.Label lblStatusTitle;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox grpInformation;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblContactTitle;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblCustomerTitle;
        private System.Windows.Forms.GroupBox grpTime;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblDurationTitle;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblDateTimeTitle;
        private System.Windows.Forms.GroupBox grpType;
        private System.Windows.Forms.Label lblPartyType;
        private System.Windows.Forms.Label lblPartyTypeTitle;
        private System.Windows.Forms.Label lblRevType;
        private System.Windows.Forms.Label lblRevTypeTitle;
        private System.Windows.Forms.GroupBox grpPlanning;
        private System.Windows.Forms.Label lblHall;
        private System.Windows.Forms.Label lblHallTitle;
        private System.Windows.Forms.Button btnMatch;
        private System.Windows.Forms.Label lblRequestTitle;
        private System.Windows.Forms.Label lblResponseTitle;
        private System.Windows.Forms.RichTextBox txtResponse;
        private System.Windows.Forms.Label lblRequest;
        private System.Windows.Forms.Button btnComfirm;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnReject;
    }
}