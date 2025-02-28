namespace Customers
{
    partial class Admin_Sales
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
            this.btnChef = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnMonth = new System.Windows.Forms.Button();
            this.chartReport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartReport)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(35, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(212, 37);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Sales Report";
            // 
            // grpReport
            // 
            this.grpReport.Controls.Add(this.chartReport);
            this.grpReport.Controls.Add(this.btnMonth);
            this.grpReport.Controls.Add(this.btnCategory);
            this.grpReport.Controls.Add(this.btnChef);
            this.grpReport.Location = new System.Drawing.Point(59, 82);
            this.grpReport.Name = "grpReport";
            this.grpReport.Size = new System.Drawing.Size(678, 418);
            this.grpReport.TabIndex = 27;
            this.grpReport.TabStop = false;
            this.grpReport.Text = "Generate by:";
            // 
            // btnChef
            // 
            this.btnChef.Location = new System.Drawing.Point(463, 44);
            this.btnChef.Name = "btnChef";
            this.btnChef.Size = new System.Drawing.Size(162, 31);
            this.btnChef.TabIndex = 14;
            this.btnChef.Text = "Chef";
            this.btnChef.UseVisualStyleBackColor = true;
            // 
            // btnCategory
            // 
            this.btnCategory.Location = new System.Drawing.Point(257, 44);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(162, 31);
            this.btnCategory.TabIndex = 15;
            this.btnCategory.Text = "Dish Category";
            this.btnCategory.UseVisualStyleBackColor = true;
            // 
            // btnMonth
            // 
            this.btnMonth.Location = new System.Drawing.Point(45, 44);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(162, 31);
            this.btnMonth.TabIndex = 16;
            this.btnMonth.Text = "Month";
            this.btnMonth.UseVisualStyleBackColor = true;
            // 
            // chartReport
            // 
            this.chartReport.BackColor = System.Drawing.Color.DarkGray;
            chartArea1.Name = "ChartArea1";
            this.chartReport.ChartAreas.Add(chartArea1);
            legend1.Name = "Sales (RM)";
            legend1.Title = "Sales (RM)";
            this.chartReport.Legends.Add(legend1);
            this.chartReport.Location = new System.Drawing.Point(45, 89);
            this.chartReport.Name = "chartReport";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Sales (RM)";
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            this.chartReport.Series.Add(series1);
            this.chartReport.Size = new System.Drawing.Size(580, 313);
            this.chartReport.TabIndex = 17;
            this.chartReport.Text = "chart1";
            this.chartReport.Click += new System.EventHandler(this.chartReport_Click);
            // 
            // Admin_Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 512);
            this.Controls.Add(this.grpReport);
            this.Controls.Add(this.lblTitle);
            this.Name = "Admin_Sales";
            this.Text = "Admin_Sales";
            this.grpReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpReport;
        private System.Windows.Forms.Button btnMonth;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnChef;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartReport;
    }
}