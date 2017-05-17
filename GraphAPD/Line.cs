using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GraphAPD
{
    [Serializable()]
    public abstract class Line
    {
        private int qty;   // The numeric value used to store the amount 
        private string region;
        private int color;  // used to store the colour of the record line

        public Line(int qt, string rgn, int clr)
		{
			qty = qt;
			region = rgn;
			color = clr;
		}

        public void setQty(int quantity)
        {
            qty = quantity;
        }

        public int getQty()
        {
            return qty;
        }

        public void setRegion(string rgn)
        {
            region = rgn;
        }

        public string getRegion()
        {
            return region;
        }

        public void setColor(int col)
        {
            color = col;
        }

        public int getColor()
        {
            return color;
        }

    }
}
