namespace GraphAPD
{
    partial class Form2
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cmboIncome = new System.Windows.Forms.ComboBox();
            this.cmboVType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmboGender = new System.Windows.Forms.ComboBox();
            this.btnAddVecls = new System.Windows.Forms.Button();
            this.btnAddIncm = new System.Windows.Forms.Button();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.txtAddQty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddPop = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblTest = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmboUnique = new System.Windows.Forms.ComboBox();
            this.txtUpRegion = new System.Windows.Forms.TextBox();
            this.txtUpQty = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblUniqueAtt = new System.Windows.Forms.Label();
            this.Edit = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(365, 304);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(382, 322);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cmboIncome
            // 
            this.cmboIncome.FormattingEnabled = true;
            this.cmboIncome.Items.AddRange(new object[] {
            "Milk",
            "Meat",
            "Cheese",
            "Tourism"});
            this.cmboIncome.Location = new System.Drawing.Point(110, 520);
            this.cmboIncome.Name = "cmboIncome";
            this.cmboIncome.Size = new System.Drawing.Size(100, 21);
            this.cmboIncome.TabIndex = 33;
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
            this.cmboVType.Location = new System.Drawing.Point(110, 480);
            this.cmboVType.Name = "cmboVType";
            this.cmboVType.Size = new System.Drawing.Size(100, 21);
            this.cmboVType.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Ammount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(107, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Unique Attribute";
            // 
            // cmboGender
            // 
            this.cmboGender.FormattingEnabled = true;
            this.cmboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmboGender.Location = new System.Drawing.Point(110, 440);
            this.cmboGender.Name = "cmboGender";
            this.cmboGender.Size = new System.Drawing.Size(100, 21);
            this.cmboGender.TabIndex = 29;
            // 
            // btnAddVecls
            // 
            this.btnAddVecls.Location = new System.Drawing.Point(237, 479);
            this.btnAddVecls.Name = "btnAddVecls";
            this.btnAddVecls.Size = new System.Drawing.Size(92, 23);
            this.btnAddVecls.TabIndex = 28;
            this.btnAddVecls.Text = "Add Vehicles";
            this.btnAddVecls.UseVisualStyleBackColor = true;
            this.btnAddVecls.Click += new System.EventHandler(this.btnAddVecls_Click);
            // 
            // btnAddIncm
            // 
            this.btnAddIncm.Location = new System.Drawing.Point(237, 521);
            this.btnAddIncm.Name = "btnAddIncm";
            this.btnAddIncm.Size = new System.Drawing.Size(92, 23);
            this.btnAddIncm.TabIndex = 27;
            this.btnAddIncm.Text = "Add Income";
            this.btnAddIncm.UseVisualStyleBackColor = true;
            this.btnAddIncm.Click += new System.EventHandler(this.btnAddIncm_Click);
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(110, 346);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(100, 20);
            this.txtRegion.TabIndex = 26;
            this.txtRegion.Text = "NZ";
            // 
            // txtAddQty
            // 
            this.txtAddQty.Location = new System.Drawing.Point(110, 376);
            this.txtAddQty.Name = "txtAddQty";
            this.txtAddQty.Size = new System.Drawing.Size(100, 20);
            this.txtAddQty.TabIndex = 25;
            this.txtAddQty.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Region";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 518);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Income";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 482);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Vehicle Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Population";
            // 
            // btnAddPop
            // 
            this.btnAddPop.Location = new System.Drawing.Point(237, 438);
            this.btnAddPop.Name = "btnAddPop";
            this.btnAddPop.Size = new System.Drawing.Size(92, 23);
            this.btnAddPop.TabIndex = 20;
            this.btnAddPop.Text = "Add Population";
            this.btnAddPop.UseVisualStyleBackColor = true;
            this.btnAddPop.Click += new System.EventHandler(this.btnAddPop_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.lblTest);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmboUnique);
            this.panel1.Controls.Add(this.txtUpRegion);
            this.panel1.Controls.Add(this.txtUpQty);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lblUniqueAtt);
            this.panel1.Controls.Add(this.Edit);
            this.panel1.Location = new System.Drawing.Point(383, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 303);
            this.panel1.TabIndex = 34;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(126, 201);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 41;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest.ForeColor = System.Drawing.Color.Red;
            this.lblTest.Location = new System.Drawing.Point(21, 204);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(0, 16);
            this.lblTest.TabIndex = 40;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(126, 160);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 39;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "Ammount";
            // 
            // cmboUnique
            // 
            this.cmboUnique.FormattingEnabled = true;
            this.cmboUnique.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmboUnique.Location = new System.Drawing.Point(126, 107);
            this.cmboUnique.Name = "cmboUnique";
            this.cmboUnique.Size = new System.Drawing.Size(100, 21);
            this.cmboUnique.TabIndex = 36;
            // 
            // txtUpRegion
            // 
            this.txtUpRegion.Location = new System.Drawing.Point(124, 42);
            this.txtUpRegion.Name = "txtUpRegion";
            this.txtUpRegion.Size = new System.Drawing.Size(100, 20);
            this.txtUpRegion.TabIndex = 35;
            this.txtUpRegion.Text = "NZ";
            // 
            // txtUpQty
            // 
            this.txtUpQty.Location = new System.Drawing.Point(124, 72);
            this.txtUpQty.Name = "txtUpQty";
            this.txtUpQty.Size = new System.Drawing.Size(100, 20);
            this.txtUpQty.TabIndex = 34;
            this.txtUpQty.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 33;
            this.label9.Text = "Region";
            // 
            // lblUniqueAtt
            // 
            this.lblUniqueAtt.AutoSize = true;
            this.lblUniqueAtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUniqueAtt.Location = new System.Drawing.Point(21, 107);
            this.lblUniqueAtt.Name = "lblUniqueAtt";
            this.lblUniqueAtt.Size = new System.Drawing.Size(54, 16);
            this.lblUniqueAtt.TabIndex = 32;
            this.lblUniqueAtt.Text = "Unique ";
            // 
            // Edit
            // 
            this.Edit.AutoSize = true;
            this.Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.Location = new System.Drawing.Point(4, 4);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(42, 24);
            this.Edit.TabIndex = 0;
            this.Edit.Text = "Edit";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 555);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmboIncome);
            this.Controls.Add(this.cmboVType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmboGender);
            this.Controls.Add(this.btnAddVecls);
            this.Controls.Add(this.btnAddIncm);
            this.Controls.Add(this.txtRegion);
            this.Controls.Add(this.txtAddQty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddPop);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.listBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cmboIncome;
        private System.Windows.Forms.ComboBox cmboVType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmboGender;
        private System.Windows.Forms.Button btnAddVecls;
        private System.Windows.Forms.Button btnAddIncm;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.TextBox txtAddQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddPop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Edit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmboUnique;
        private System.Windows.Forms.TextBox txtUpRegion;
        private System.Windows.Forms.TextBox txtUpQty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblUniqueAtt;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Button btnDelete;
    }
}