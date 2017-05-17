namespace GraphAPD
{
    partial class Form1 
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
            this.lblPopulation = new System.Windows.Forms.Label();
            this.lblExports = new System.Windows.Forms.Label();
            this.lblVehicles = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnAddPop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPop = new System.Windows.Forms.TextBox();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.btnAddIncm = new System.Windows.Forms.Button();
            this.btnAddVecls = new System.Windows.Forms.Button();
            this.cmboGender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmboVType = new System.Windows.Forms.ComboBox();
            this.cmboIncome = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPopulation
            // 
            this.lblPopulation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblPopulation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPopulation.Location = new System.Drawing.Point(12, 43);
            this.lblPopulation.Name = "lblPopulation";
            this.lblPopulation.Size = new System.Drawing.Size(23, 134);
            this.lblPopulation.TabIndex = 0;
            // 
            // lblExports
            // 
            this.lblExports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblExports.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblExports.Location = new System.Drawing.Point(12, 403);
            this.lblExports.Name = "lblExports";
            this.lblExports.Size = new System.Drawing.Size(23, 134);
            this.lblExports.TabIndex = 1;
            // 
            // lblVehicles
            // 
            this.lblVehicles.BackColor = System.Drawing.Color.Purple;
            this.lblVehicles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVehicles.Location = new System.Drawing.Point(12, 223);
            this.lblVehicles.Name = "lblVehicles";
            this.lblVehicles.Size = new System.Drawing.Size(23, 134);
            this.lblVehicles.TabIndex = 2;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(73, 38);
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
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // btnAddPop
            // 
            this.btnAddPop.Location = new System.Drawing.Point(277, 448);
            this.btnAddPop.Name = "btnAddPop";
            this.btnAddPop.Size = new System.Drawing.Size(92, 23);
            this.btnAddPop.TabIndex = 4;
            this.btnAddPop.Text = "Add Population";
            this.btnAddPop.UseVisualStyleBackColor = true;
            this.btnAddPop.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Population";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Vehicle Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 528);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Income";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Region";
            // 
            // txtPop
            // 
            this.txtPop.Location = new System.Drawing.Point(150, 386);
            this.txtPop.Name = "txtPop";
            this.txtPop.Size = new System.Drawing.Size(100, 20);
            this.txtPop.TabIndex = 9;
            this.txtPop.Text = "15";
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(150, 356);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(100, 20);
            this.txtRegion.TabIndex = 12;
            this.txtRegion.Text = "NZ";
            // 
            // btnAddIncm
            // 
            this.btnAddIncm.Location = new System.Drawing.Point(277, 531);
            this.btnAddIncm.Name = "btnAddIncm";
            this.btnAddIncm.Size = new System.Drawing.Size(92, 23);
            this.btnAddIncm.TabIndex = 13;
            this.btnAddIncm.Text = "Add Income";
            this.btnAddIncm.UseVisualStyleBackColor = true;
            this.btnAddIncm.Click += new System.EventHandler(this.btnAddIncm_Click);
            // 
            // btnAddVecls
            // 
            this.btnAddVecls.Location = new System.Drawing.Point(277, 489);
            this.btnAddVecls.Name = "btnAddVecls";
            this.btnAddVecls.Size = new System.Drawing.Size(92, 23);
            this.btnAddVecls.TabIndex = 14;
            this.btnAddVecls.Text = "Add Vehicles";
            this.btnAddVecls.UseVisualStyleBackColor = true;
            this.btnAddVecls.Click += new System.EventHandler(this.btnAddVecls_Click);
            // 
            // cmboGender
            // 
            this.cmboGender.FormattingEnabled = true;
            this.cmboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmboGender.Location = new System.Drawing.Point(150, 450);
            this.cmboGender.Name = "cmboGender";
            this.cmboGender.Size = new System.Drawing.Size(100, 21);
            this.cmboGender.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(147, 431);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Unique Attribute";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(70, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Ammount";
            // 
            // cmboVType
            // 
            this.cmboVType.FormattingEnabled = true;
            this.cmboVType.Items.AddRange(new object[] {
            "SUV",
            "Car",
            "Van",
            "Sedan",
            "Luxury"});
            this.cmboVType.Location = new System.Drawing.Point(150, 490);
            this.cmboVType.Name = "cmboVType";
            this.cmboVType.Size = new System.Drawing.Size(100, 21);
            this.cmboVType.TabIndex = 18;
            // 
            // cmboIncome
            // 
            this.cmboIncome.FormattingEnabled = true;
            this.cmboIncome.Items.AddRange(new object[] {
            "Milk",
            "Meat",
            "Cheese",
            "Tourism"});
            this.cmboIncome.Location = new System.Drawing.Point(150, 530);
            this.cmboIncome.Name = "cmboIncome";
            this.cmboIncome.Size = new System.Drawing.Size(100, 21);
            this.cmboIncome.TabIndex = 19;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(473, 346);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear Chart";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(558, 346);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 21;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(652, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSave,
            this.mnuOpen});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(152, 22);
            this.mnuSave.Text = "Save";
            this.mnuSave.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // mnuOpen
            // 
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(152, 22);
            this.mnuOpen.Text = "Open";
            this.mnuOpen.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 563);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cmboIncome);
            this.Controls.Add(this.cmboVType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmboGender);
            this.Controls.Add(this.btnAddVecls);
            this.Controls.Add(this.btnAddIncm);
            this.Controls.Add(this.txtRegion);
            this.Controls.Add(this.txtPop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddPop);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lblVehicles);
            this.Controls.Add(this.lblExports);
            this.Controls.Add(this.lblPopulation);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPopulation;
        private System.Windows.Forms.Label lblExports;
        private System.Windows.Forms.Label lblVehicles;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnAddPop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPop;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.Button btnAddIncm;
        private System.Windows.Forms.Button btnAddVecls;
        private System.Windows.Forms.ComboBox cmboGender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmboVType;
        private System.Windows.Forms.ComboBox cmboIncome;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;

    }
}

