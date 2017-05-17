using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GraphAPD
{
    public partial class Form3 : System.Windows.Forms.Form, IShapeView
    {
        private GraphModel gModel;
        public Form3()
        {
            InitializeComponent();
        }

        public GraphModel GModel
        {
            set
            {
                gModel = value;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            RefreshView();
        }

        public void RefreshView()
        {
            chart1.Series["Record"].Points.Clear();   // Removing all elements from the chart

            // create arrayList from model and convert to array of Lines
            ArrayList theGraphList = gModel.GraphList;
            Line[] theLines = (Line[])theGraphList.ToArray(typeof(Line));

            //Line[] showList = new Line[theGraphList.Count];

            int i = 0;
            
            foreach (Line line in theLines)
            {
                if (line.GetType().ToString() == "GraphAPD.Population" && chkPopulation.Checked)
                {
                    Population p = line as Population;
                    chart1.Series["Record"].Points.AddXY(p.getGender() + " " + line.getRegion(), Convert.ToDouble(line.getQty()));
                    Color Barclr = Color.FromArgb(line.getColor());
                    chart1.Series["Record"].Points[i].Color = Barclr;
                    i++;  // Incrementing the controll variable used for color
                }

                if (line.GetType().ToString() == "GraphAPD.Income" && chkIncome.Checked)
                {
                    Income incm = line as Income;
                    chart1.Series["Record"].Points.AddXY(incm.getSource()+" "+ line.getRegion(), Convert.ToDouble(line.getQty()));
                    Color Barclr = Color.FromArgb(line.getColor());
                    chart1.Series["Record"].Points[i].Color = Barclr;
                    i++;  // Incrementing the controll variable used for color
                }
                if (line.GetType().ToString() == "GraphAPD.Vehicles" && chkVehicles.Checked)
                {
                    Vehicles v = line as Vehicles;
                    chart1.Series["Record"].Points.AddXY(v.getVType() +" "+ line.getRegion(), Convert.ToDouble(line.getQty()));
                    Color Barclr = Color.FromArgb(line.getColor());
                    chart1.Series["Record"].Points[i].Color = Barclr;
                    i++;  // Incrementing the controll variable used for color
                }
            }
        }
    }
}
