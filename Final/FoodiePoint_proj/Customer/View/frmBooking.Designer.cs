﻿namespace Customer
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
            this.components = new System.ComponentModel.Container();
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
            this.reservationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foodieDbDataSet = new Manager.FoodieDbDataSet();
            this.reservationsTableAdapter = new Manager.FoodieDbDataSetTableAdapters.ReservationsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodieDbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(695, 107);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(330, 358);
            this.richTextBox1.TabIndex = 35;
            this.richTextBox1.Text = "";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 404);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "HallID";
            // 
            // HallID
            // 
            this.HallID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HallID.AutoSize = true;
            this.HallID.Location = new System.Drawing.Point(320, 404);
            this.HallID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HallID.Name = "HallID";
            this.HallID.Size = new System.Drawing.Size(0, 20);
            this.HallID.TabIndex = 33;
            // 
            // lblreservationStatus
            // 
            this.lblreservationStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblreservationStatus.AutoSize = true;
            this.lblreservationStatus.Location = new System.Drawing.Point(320, 354);
            this.lblreservationStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblreservationStatus.Name = "lblreservationStatus";
            this.lblreservationStatus.Size = new System.Drawing.Size(0, 20);
            this.lblreservationStatus.TabIndex = 32;
            // 
            // lblresID
            // 
            this.lblresID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblresID.AutoSize = true;
            this.lblresID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresID.Location = new System.Drawing.Point(158, 145);
            this.lblresID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblresID.Name = "lblresID";
            this.lblresID.Size = new System.Drawing.Size(0, 29);
            this.lblresID.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(986, 483);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 30);
            this.button1.TabIndex = 30;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reqtxtbox
            // 
            this.reqtxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.reqtxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqtxtbox.Location = new System.Drawing.Point(695, 483);
            this.reqtxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.reqtxtbox.Name = "reqtxtbox";
            this.reqtxtbox.Size = new System.Drawing.Size(283, 30);
            this.reqtxtbox.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 354);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Reservation Status";
            // 
            // txtResType
            // 
            this.txtResType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtResType.Location = new System.Drawing.Point(324, 201);
            this.txtResType.Margin = new System.Windows.Forms.Padding(4);
            this.txtResType.Name = "txtResType";
            this.txtResType.Size = new System.Drawing.Size(215, 27);
            this.txtResType.TabIndex = 25;
            this.txtResType.Text = "Put date here...";
            // 
            // txtGuestCount
            // 
            this.txtGuestCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGuestCount.Location = new System.Drawing.Point(324, 301);
            this.txtGuestCount.Margin = new System.Windows.Forms.Padding(4);
            this.txtGuestCount.Name = "txtGuestCount";
            this.txtGuestCount.Size = new System.Drawing.Size(215, 27);
            this.txtGuestCount.TabIndex = 23;
            this.txtGuestCount.Text = "Put amount of people here...";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 304);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Gueast Count*";
            // 
            // txtResDate
            // 
            this.txtResDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtResDate.Location = new System.Drawing.Point(324, 251);
            this.txtResDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtResDate.Name = "txtResDate";
            this.txtResDate.Size = new System.Drawing.Size(215, 27);
            this.txtResDate.TabIndex = 21;
            this.txtResDate.Text = "Put date here...";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 254);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Reservation Date*";
            // 
            // lblFeedback
            // 
            this.lblFeedback.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Location = new System.Drawing.Point(691, 68);
            this.lblFeedback.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(71, 20);
            this.lblFeedback.TabIndex = 16;
            this.lblFeedback.Text = "Request";
            // 
            // btnReservationBook
            // 
            this.btnReservationBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReservationBook.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReservationBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservationBook.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReservationBook.Location = new System.Drawing.Point(890, 556);
            this.btnReservationBook.Margin = new System.Windows.Forms.Padding(4);
            this.btnReservationBook.Name = "btnReservationBook";
            this.btnReservationBook.Size = new System.Drawing.Size(135, 58);
            this.btnReservationBook.TabIndex = 13;
            this.btnReservationBook.Text = "Book now";
            this.btnReservationBook.UseVisualStyleBackColor = false;
            this.btnReservationBook.Click += new System.EventHandler(this.btnReservationStatus_Click);
            // 
            // lblReservationType
            // 
            this.lblReservationType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReservationType.AutoSize = true;
            this.lblReservationType.Location = new System.Drawing.Point(158, 204);
            this.lblReservationType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReservationType.Name = "lblReservationType";
            this.lblReservationType.Size = new System.Drawing.Size(145, 20);
            this.lblReservationType.TabIndex = 15;
            this.lblReservationType.Text = "Reservation Type*";
            this.lblReservationType.Click += new System.EventHandler(this.lblReservationType_Click);
            // 
            // reservationsBindingSource
            // 
            this.reservationsBindingSource.DataMember = "Reservations";
            this.reservationsBindingSource.DataSource = this.foodieDbDataSet;
            // 
            // foodieDbDataSet
            // 
            this.foodieDbDataSet.DataSetName = "FoodieDbDataSet";
            this.foodieDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservationsTableAdapter
            // 
            this.reservationsTableAdapter.ClearBeforeFill = true;
            // 
            // frmBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 673);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGuestCount);
            this.Controls.Add(this.txtResType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reqtxtbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblresID);
            this.Controls.Add(this.lblreservationStatus);
            this.Controls.Add(this.btnReservationBook);
            this.Controls.Add(this.lblReservationType);
            this.Controls.Add(this.HallID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmBooking";
            this.Load += new System.EventHandler(this.frmBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reservationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodieDbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private Manager.FoodieDbDataSet foodieDbDataSet;
        private System.Windows.Forms.BindingSource reservationsBindingSource;
        private Manager.FoodieDbDataSetTableAdapters.ReservationsTableAdapter reservationsTableAdapter;
    }
}