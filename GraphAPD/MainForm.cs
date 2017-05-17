using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GraphAPD
{
    public partial class MainForm : Form
    {
        private GraphModel theModel;
        private GraphController theController;
        private Form1 myViewForm1;
        private Form2 myViewForm2;
        private Form3 myViewForm3;
        public MainForm()
        {
            InitializeComponent();
        }



        private void completeSetUp()
        {
            // make controller
            theController = new GraphController();
            // make model
            theModel = new GraphModel(theController);
            // make views
            myViewForm1 = new Form1();
            myViewForm2 = new Form2();
            myViewForm3 = new Form3();

            myViewForm1.GModel = theModel;
            myViewForm2.GModel = theModel;
            myViewForm3.GModel = theModel;

            theController.AddView(myViewForm1);
            theController.AddView(myViewForm2);
            theController.AddView(myViewForm3);

            //show views
            myViewForm1.Show();
            myViewForm2.Show();
            myViewForm3.Show();


        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            completeSetUp();
        }
    }
}
