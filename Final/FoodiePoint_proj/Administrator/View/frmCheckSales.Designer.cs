namespace Admin.View
{
    partial class frmCheckSales
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpReport = new System.Windows.Forms.GroupBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.chartReport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnCategory = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.grpReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(448, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(183, 31);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Sales Report";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpReport
            // 
            this.grpReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpReport.Controls.Add(this.btnGenerate);
            this.grpReport.Controls.Add(this.cmbYear);
            this.grpReport.Controls.Add(this.chartReport);
            this.grpReport.Controls.Add(this.btnCategory);
            this.grpReport.Location = new System.Drawing.Point(52, 66);
            this.grpReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpReport.Name = "grpReport";
            this.grpReport.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpReport.Size = new System.Drawing.Size(974, 572);
            this.grpReport.TabIndex = 27;
            this.grpReport.TabStop = false;
            this.grpReport.Text = "Generate by:";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.Location = new System.Drawing.Point(202, 25);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(144, 33);
            this.btnGenerate.TabIndex = 35;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // cmbYear
            // 
            this.cmbYear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbYear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(74, 30);
            this.cmbYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbYear.Size = new System.Drawing.Size(108, 24);
            this.cmbYear.TabIndex = 20;
            this.cmbYear.Text = "Year";
            // 
            // chartReport
            // 
            this.chartReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartReport.BackColor = System.Drawing.Color.DarkGray;
            chartArea1.Name = "ChartArea1";
            this.chartReport.ChartAreas.Add(chartArea1);
            legend1.Name = "Sales (RM)";
            legend1.Title = "Sales (RM)";
            this.chartReport.Legends.Add(legend1);
            this.chartReport.Location = new System.Drawing.Point(74, 71);
            this.chartReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartReport.Name = "chartReport";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Sales (RM)";
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            this.chartReport.Series.Add(series1);
            this.chartReport.Size = new System.Drawing.Size(832, 477);
            this.chartReport.TabIndex = 17;
            this.chartReport.Text = "chart1";
            // 
            // btnCategory
            // 
            this.btnCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategory.Location = new System.Drawing.Point(762, 25);
            this.btnCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(144, 33);
            this.btnCategory.TabIndex = 15;
            this.btnCategory.Text = "Dish Category";
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // picLogo
            // 
            this.picLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogo.Image = global::FoodiePoint_proj.Properties.Resources.output_onlinepngtools;
            this.picLogo.Location = new System.Drawing.Point(52, 16);
            this.picLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(244, 40);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 34;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // frmCheckSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 673);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.grpReport);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmCheckSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Report Visualization";
            this.grpReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpReport;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartReport;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ComboBox cmbYear;
    }
}