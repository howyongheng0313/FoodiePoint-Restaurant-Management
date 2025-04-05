namespace Admin.View
{
    partial class frmFeedbacks
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
            this.lblAveRating = new System.Windows.Forms.Label();
            this.btn1star = new System.Windows.Forms.Button();
            this.btn2star = new System.Windows.Forms.Button();
            this.btn3star = new System.Windows.Forms.Button();
            this.btn4star = new System.Windows.Forms.Button();
            this.btn5star = new System.Windows.Forms.Button();
            this.grpRating = new System.Windows.Forms.GroupBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.dgvFeedbacks = new System.Windows.Forms.DataGridView();
            this.grpAverage = new System.Windows.Forms.GroupBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.grpRating.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedbacks)).BeginInit();
            this.grpAverage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(387, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(306, 31);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Customers Feedbacks";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAveRating
            // 
            this.lblAveRating.AutoSize = true;
            this.lblAveRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAveRating.Location = new System.Drawing.Point(15, 25);
            this.lblAveRating.Name = "lblAveRating";
            this.lblAveRating.Size = new System.Drawing.Size(0, 54);
            this.lblAveRating.TabIndex = 10;
            // 
            // btn1star
            // 
            this.btn1star.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1star.Font = new System.Drawing.Font("Modern No. 20", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1star.Location = new System.Drawing.Point(10, 38);
            this.btn1star.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn1star.Name = "btn1star";
            this.btn1star.Size = new System.Drawing.Size(59, 25);
            this.btn1star.TabIndex = 21;
            this.btn1star.Text = "1⭐";
            this.btn1star.UseVisualStyleBackColor = true;
            this.btn1star.Click += new System.EventHandler(this.btn1star_Click);
            // 
            // btn2star
            // 
            this.btn2star.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2star.Font = new System.Drawing.Font("Modern No. 20", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2star.Location = new System.Drawing.Point(86, 38);
            this.btn2star.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn2star.Name = "btn2star";
            this.btn2star.Size = new System.Drawing.Size(59, 25);
            this.btn2star.TabIndex = 22;
            this.btn2star.Text = "2⭐";
            this.btn2star.UseVisualStyleBackColor = true;
            this.btn2star.Click += new System.EventHandler(this.btn2star_Click);
            // 
            // btn3star
            // 
            this.btn3star.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3star.Font = new System.Drawing.Font("Modern No. 20", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3star.Location = new System.Drawing.Point(164, 38);
            this.btn3star.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn3star.Name = "btn3star";
            this.btn3star.Size = new System.Drawing.Size(59, 25);
            this.btn3star.TabIndex = 23;
            this.btn3star.Text = "3⭐";
            this.btn3star.UseVisualStyleBackColor = true;
            this.btn3star.Click += new System.EventHandler(this.btn3star_Click);
            // 
            // btn4star
            // 
            this.btn4star.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4star.Font = new System.Drawing.Font("Modern No. 20", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4star.Location = new System.Drawing.Point(243, 38);
            this.btn4star.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn4star.Name = "btn4star";
            this.btn4star.Size = new System.Drawing.Size(59, 25);
            this.btn4star.TabIndex = 24;
            this.btn4star.Text = "4⭐";
            this.btn4star.UseVisualStyleBackColor = true;
            this.btn4star.Click += new System.EventHandler(this.btn4star_Click);
            // 
            // btn5star
            // 
            this.btn5star.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5star.Font = new System.Drawing.Font("Modern No. 20", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5star.Location = new System.Drawing.Point(318, 38);
            this.btn5star.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn5star.Name = "btn5star";
            this.btn5star.Size = new System.Drawing.Size(59, 25);
            this.btn5star.TabIndex = 25;
            this.btn5star.Text = "5⭐";
            this.btn5star.UseVisualStyleBackColor = true;
            this.btn5star.Click += new System.EventHandler(this.btn5star_Click);
            // 
            // grpRating
            // 
            this.grpRating.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRating.Controls.Add(this.btnShowAll);
            this.grpRating.Controls.Add(this.btn5star);
            this.grpRating.Controls.Add(this.btn4star);
            this.grpRating.Controls.Add(this.btn3star);
            this.grpRating.Controls.Add(this.btn2star);
            this.grpRating.Controls.Add(this.btn1star);
            this.grpRating.Location = new System.Drawing.Point(569, 70);
            this.grpRating.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpRating.Name = "grpRating";
            this.grpRating.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpRating.Size = new System.Drawing.Size(462, 87);
            this.grpRating.TabIndex = 26;
            this.grpRating.TabStop = false;
            this.grpRating.Text = "Sort by:";
            // 
            // btnShowAll
            // 
            this.btnShowAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowAll.Font = new System.Drawing.Font("Modern No. 20", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.Location = new System.Drawing.Point(393, 38);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnShowAll.Size = new System.Drawing.Size(59, 25);
            this.btnShowAll.TabIndex = 26;
            this.btnShowAll.Text = "All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // dgvFeedbacks
            // 
            this.dgvFeedbacks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFeedbacks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeedbacks.Location = new System.Drawing.Point(50, 187);
            this.dgvFeedbacks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvFeedbacks.Name = "dgvFeedbacks";
            this.dgvFeedbacks.RowHeadersWidth = 62;
            this.dgvFeedbacks.RowTemplate.Height = 28;
            this.dgvFeedbacks.Size = new System.Drawing.Size(981, 437);
            this.dgvFeedbacks.TabIndex = 31;
            // 
            // grpAverage
            // 
            this.grpAverage.Controls.Add(this.lblAveRating);
            this.grpAverage.Location = new System.Drawing.Point(50, 70);
            this.grpAverage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAverage.Name = "grpAverage";
            this.grpAverage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAverage.Size = new System.Drawing.Size(174, 87);
            this.grpAverage.TabIndex = 32;
            this.grpAverage.TabStop = false;
            this.grpAverage.Text = "Average Rating";
            // 
            // picLogo
            // 
            this.picLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogo.Image = global::FoodiePoint_proj.Properties.Resources.output_onlinepngtools;
            this.picLogo.Location = new System.Drawing.Point(50, 13);
            this.picLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(244, 40);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 33;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // frmFeedbacks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 673);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.grpAverage);
            this.Controls.Add(this.dgvFeedbacks);
            this.Controls.Add(this.grpRating);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmFeedbacks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Feedbacks";
            this.Load += new System.EventHandler(this.frmFeedbacks_Load);
            this.grpRating.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedbacks)).EndInit();
            this.grpAverage.ResumeLayout(false);
            this.grpAverage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAveRating;
        private System.Windows.Forms.Button btn1star;
        private System.Windows.Forms.Button btn2star;
        private System.Windows.Forms.Button btn3star;
        private System.Windows.Forms.Button btn4star;
        private System.Windows.Forms.Button btn5star;
        private System.Windows.Forms.GroupBox grpRating;
        private System.Windows.Forms.DataGridView dgvFeedbacks;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.GroupBox grpAverage;
        private System.Windows.Forms.PictureBox picLogo;
    }
}