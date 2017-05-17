using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace GraphAPD
{
    public partial class Form1 : System.Windows.Forms.Form, IShapeView
    {
        private GraphModel gModel;
        BinaryFormatter binFor;

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            binFor = new BinaryFormatter(); 
            cmboGender.SelectedItem = "Male";
            cmboIncome.SelectedItem = "Milk";
            cmboVType.SelectedItem = "Car"; 
        }

        public GraphModel GModel
        {
            set
            {
                gModel = value;
            }
        }

        public void RefreshView()
        {
            chart1.Series["Record"].Points.Clear();   // Removing all elements from the chart

            // create arrayList from model and convert to array of Lines
            ArrayList theGraphList = gModel.GraphList;
            Line[] theLines = (Line[])theGraphList.ToArray(typeof(Line));

            int i = 0; 
            foreach (Line line in theLines)           
            {
                if (line.GetType().ToString() == "GraphAPD.Population")
                {
                    Population p = line as Population;
                    chart1.Series["Record"].Points.AddXY(p.getGender() +" "+ line.getRegion(), Convert.ToDouble(line.getQty()));
                }

                else if (line.GetType().ToString() == "GraphAPD.Income")
                {
                    Income incm = line as Income;
                    chart1.Series["Record"].Points.AddXY(incm.getSource() + " " + line.getRegion(), Convert.ToDouble(line.getQty()));
                }

                else if (line.GetType().ToString() == "GraphAPD.Vehicles")
                {
                    Vehicles v = line as Vehicles;
                    chart1.Series["Record"].Points.AddXY(v.getVType() + " " + line.getRegion(), Convert.ToDouble(line.getQty()));
                }

                //chart1.Series["Record"].Points.AddXY(line.getRegion(), Convert.ToDouble(line.getQty()));
                Color Barclr = Color.FromArgb(line.getColor());
                chart1.Series["Record"].Points[i].Color = Barclr;

                i++;  // Incrementing the controll variable used for color
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshView();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtRegion.Text != "" || cmboGender.SelectedItem != null)
            {
                //int totRecords = chart1.Series["Record"].Points.Count();   // To count how many values are already in the chart

                int clrCode = Color.Blue.ToArgb(); // convert color to argb to save in the class

                Line newLine = new Population(Convert.ToInt32(txtPop.Text), txtRegion.Text, clrCode, cmboGender.SelectedItem.ToString());
                //chart1.Series["Record"].Points.Clear(); // Clearing all values in the chart before adding data
                gModel.AddRecord(newLine);

            }
            else
            {
                MessageBox.Show("Please Enter a Region and Gender");
            }
        }

        private void btnAddVecls_Click(object sender, EventArgs e)
        {
            if (txtRegion.Text != "" || cmboVType.SelectedItem != null)
            {
                //int totRecords = chart1.Series["Record"].Points.Count();   // To count how many values are already in the chart

                int clrCode = Color.DimGray.ToArgb(); // convert color to argb to save in the class

                Line newLine = new Vehicles(Convert.ToInt32(txtPop.Text), txtRegion.Text, clrCode, cmboVType.SelectedItem.ToString());
                gModel.AddRecord(newLine);

                //chart1.Series["Record"].Points[totRecords].Color = Color.DimGray;  // Setting the color of the newest record 
            }
            else
            {
                MessageBox.Show("Please Enter a Region and Vehicle Type");
            }
        }

        private void btnAddIncm_Click(object sender, EventArgs e)
        {
            if (txtRegion.Text != "" || cmboIncome.SelectedItem != null)
            {
                //int totRecords = chart1.Series["Record"].Points.Count();   // To count how many values are already in the chart

                int clrCode = Color.PaleGreen.ToArgb(); // convert color to argb to save in the class

                Line newLine = new Income(Convert.ToInt32(txtPop.Text), txtRegion.Text, clrCode, cmboIncome.SelectedItem.ToString());
                gModel.AddRecord(newLine);

                //chart1.Series["Record"].Points[totRecords].Color = Color.PaleGreen;  // Setting the color of the newest record 
            }
            else
            {
                MessageBox.Show("Please Enter a Region and Income");
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileInfo finfo = new FileInfo(saveFileDialog1.FileName);
                string stat = gModel.beginSaveThread(finfo);
                if (stat != "true")
                {
                    MessageBox.Show(stat, "Save Failed");
                }
                else
                { 
                    MessageBox.Show("Graph Saved", "Success"); 
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    gModel.ClearAll(); //delete Records from model
                    FileInfo finfo = new FileInfo(openFileDialog1.FileName);
                    Stream strm = finfo.Open(FileMode.Open);
                    while (strm.Position != strm.Length)
                    {
                        gModel.AddFromFile(binFor.Deserialize(strm)); // Deserialized objects are passes to the gModel AddFromFile methode to open one by one 
                    }
                    this.Invalidate();
                    gModel.UpdateViews();   // Updating the model after the records are added
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

    }
}
