using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphAPD
{
    [Serializable()]
    class Income:Line
    {
        private string income_Source;

        public Income(int qt, string rgn, int clr, string srce) : base ( qt,  rgn,  clr)
        {
            income_Source = srce;
        }

        public void setSource(string srce)
        {
            income_Source = srce;
        }

        public string getSource()
        {
            return income_Source;
        }

        public override string ToString()
        {
            string qty = this.getQty().ToString();
            string rgn = this.getRegion().ToString();
            string type = this.getSource().ToString();

            string dataString = "$"+ qty + " Million made from " + type + " in " + rgn;

            return dataString;
        }
    }
}
