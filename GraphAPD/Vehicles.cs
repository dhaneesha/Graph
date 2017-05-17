using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphAPD
{
    [Serializable()]
    class Vehicles:Line
    {
        private string type;

        public Vehicles(int qt, string rgn, int clr, string vType) : base ( qt,  rgn,  clr)
        {
            type = vType;
        }

        public void setVType(string t)
        {
            type = t;
        }

        public string getVType()
        {
            return type;
        }

        public override string ToString()
        {
            string qty = this.getQty().ToString();
            string rgn = this.getRegion().ToString();
            string type = this.getVType().ToString();

            string dataString = qty + " " + type + "s in " + rgn;

            return dataString;
        }
    }
}
