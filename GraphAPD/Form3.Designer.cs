namespace GraphAPD
{
    partial class Form3
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chkPopulation = new System.Windows.Forms.CheckBox();
            this.chkIncome = new System.Windows.Forms.CheckBox();
            this.chkVehicles = new System.Windows.Forms.CheckBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chkPopulation
            // 
            this.chkPopulation.AutoSize = true;
            this.chkPopulation.Location = new System.Drawing.Point(12, 328);
            this.chkPopulation.Name = "chkPopulation";
            this.chkPopulation.Size = new System.Drawing.Size(106, 17);
            this.chkPopulation.TabIndex = 0;
            this.chkPopulation.Text = "Show Population";
            this.chkPopulation.UseVisualStyleBackColor = true;
            // 
            // chkIncome
            // 
            this.chkIncome.AutoSize = true;
            this.chkIncome.Location = new System.Drawing.Point(12, 351);
            this.chkIncome.Name = "chkIncome";
            this.chkIncome.Size = new System.Drawing.Size(91, 17);
            this.chkIncome.TabIndex = 1;
            this.chkIncome.Text = "Show Income";
            this.chkIncome.UseVisualStyleBackColor = true;
            // 
            // chkVehicles
            // 
            this.chkVehicles.AutoSize = true;
            this.chkVehicles.Location = new System.Drawing.Point(12, 374);
            this.chkVehicles.Name = "chkVehicles";
            this.chkVehicles.Size = new System.Drawing.Size(96, 17);
            this.chkVehicles.TabIndex = 2;
            this.chkVehicles.Text = "Show Vehicles";
            this.chkVehicles.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty,
        System.Drawing.Color.White,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))))};
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.DarkBlue;
            series1.Legend = "Legend1";
            series1.Name = "Record";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.DimGray;
            series2.Legend = "Legend1";
            series2.Name = "Vehicle";
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.PaleGreen;
            series3.Legend = "Legend1";
            series3.Name = "Income";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(557, 300);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(197, 328);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 402);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.chkVehicles);
            this.Controls.Add(this.chkIncome);
            this.Controls.Add(this.chkPopulation);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkPopulation;
        private System.Windows.Forms.CheckBox chkIncome;
        private System.Windows.Forms.CheckBox chkVehicles;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnShow;
    }
}