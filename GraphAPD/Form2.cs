using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace GraphAPD
{
    public partial class Form2 : System.Windows.Forms.Form, IShapeView
    {
        private GraphModel gModel;
        Line[] updateLines; // Array used to store all the lines for use with listBox
        Line updateLine; // The currently selected Line which is to be updated
        ArrayList theUpdateGraphList;
        public Form2()
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



        public void RefreshView()
        {
            listBox1.Items.Clear();
            // create arrayList from model and convert to array of shapes
            ArrayList theGraphList = gModel.GraphList;
            Line[] theLines = (Line[])theGraphList.ToArray(typeof(Line));

            theUpdateGraphList = gModel.GraphList; // This is a local graphlist stored for operation of the form

            updateLines = (Line[])theUpdateGraphList.ToArray(typeof(Line)); // Converting the list into an array

            foreach (Line line in theLines)
            {
                listBox1.Items.Add(line);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            RefreshView();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            lblTest.Text = "";
            cmboGender.SelectedItem = "Male";
            cmboVType.SelectedItem = "Car";
            cmboIncome.SelectedItem = "Milk";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {              

                int index = listBox1.SelectedIndex;

                updateLine = updateLines[index];

                txtUpRegion.Text = updateLine.getRegion();
                txtUpQty.Text = updateLine.getQty().ToString();

                lblTest.Text = ""; // Changing the message of lblTest to blank

                if (updateLine.GetType().ToString() == "GraphAPD.Population") // Based on the value selected comboUnique and label will be populated with relevent data
                {
                    lblUniqueAtt.Text = "Gender";
                    cmboUnique.Items.Clear();
                    cmboUnique.Items.Add("Male");
                    cmboUnique.Items.Add("Female");
                    cmboUnique.SelectedItem = "Male";   // Selecting a defauld value to avoid null errors
                }
                if (updateLine.GetType().ToString() == "GraphAPD.Vehicles")
                {
                    lblUniqueAtt.Text = "Vehicle Types";
                    cmboUnique.Items.Clear();
                    cmboUnique.Items.Add("SUV");
                    cmboUnique.Items.Add("Car");
                    cmboUnique.Items.Add("Van");
                    cmboUnique.Items.Add("Sedan");
                    cmboUnique.Items.Add("Luxury");
                    cmboUnique.SelectedItem = "Car";   // Selecting a default value to avoid null errors
                }
                if (updateLine.GetType().ToString() == "GraphAPD.Income")
                {
                    lblUniqueAtt.Text = "Income Sources";
                    cmboUnique.Items.Clear();
                    cmboUnique.Items.Add("Milk");
                    cmboUnique.Items.Add("Meat");
                    cmboUnique.Items.Add("Cheese");
                    cmboUnique.Items.Add("Tourism");
                    cmboUnique.SelectedItem = "Milk";   // Selecting a defauld value to avoid null errors

                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;

            if (index == -1)
            {
                MessageBox.Show("Please select a record to Update");
                return;
            }

            if (cmboUnique.SelectedItem == null)
            {
                MessageBox.Show("Please select a record to Update");
                return;
            }

            if (txtRegion.Text != "" || cmboUnique.SelectedItem != null)
            {
                Line newLine= null;   // Made this null to avoid compilation error unassigned variable

                try
                {
                    if (updateLine.GetType().ToString() == "GraphAPD.Population") // Based on the selected tine type the relevent class object will be created
                    {
                        newLine = new Population(Convert.ToInt32(txtUpQty.Text), txtUpRegion.Text, updateLine.getColor(), cmboUnique.SelectedItem.ToString());
                    }
                    if (updateLine.GetType().ToString() == "GraphAPD.Vehicles")
                    {
                        newLine = new Vehicles(Convert.ToInt32(txtUpQty.Text), txtUpRegion.Text, updateLine.getColor(), cmboUnique.SelectedItem.ToString());
                    }
                    if (updateLine.GetType().ToString() == "GraphAPD.Income")
                    {
                        newLine = new Income(Convert.ToInt32(txtUpQty.Text), txtUpRegion.Text, updateLine.getColor(), cmboUnique.SelectedItem.ToString());  // Change thsi line to income Line
                    }

                    gModel.UpdateRecord(newLine, index);
                    lblTest.Text = "Record Updated";
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please Enter a Region and Gender");
            }
        }

        private void btnAddPop_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRegion.Text != "" || cmboGender.SelectedItem != null)
                {
                    Line newLine = new Population(Convert.ToInt32(txtAddQty.Text), txtRegion.Text, 123, cmboGender.SelectedItem.ToString());
                    gModel.AddRecord(newLine);
                    lblTest.Text = "Record Added";
                }
                else
                {
                    MessageBox.Show("Please Enter a Region and Gender");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddVecls_Click(object sender, EventArgs e)
        {
            if (txtRegion.Text != "" || cmboVType.SelectedItem != null)
            {
                Line newLine = new Vehicles(Convert.ToInt32(txtAddQty.Text), txtRegion.Text, 123, cmboVType.SelectedItem.ToString());
                gModel.AddRecord(newLine);

                lblTest.Text = "Record Added";
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
                Line newLine = new Income(Convert.ToInt32(txtAddQty.Text), txtRegion.Text, 123, cmboIncome.SelectedItem.ToString());
                gModel.AddRecord(newLine);
            }
            else
            {
                MessageBox.Show("Please Enter a Region and Income");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a reord to delete");
                return; // Returing if a record is not selscted
            }
            
            try
            {
                gModel.DeleteRecord(listBox1.SelectedIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }


}
