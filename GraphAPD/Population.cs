using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphAPD
{
    [Serializable()]
    class Population:Line
    {
        private string gender;

        public Population(int qt, string rgn, int clr, string gndr) : base(qt, rgn, clr)
        {
            gender = gndr;
            setRegion(rgn);
            setQty(qt);
        }

        public void setGender(string gndr)
        {
            gender = gndr;
        }

        public string getGender()
        {
            return gender;
        }

        public override string ToString()
        {
            string qty = this.getQty().ToString();
            string rgn = this.getRegion().ToString();
            string gender = this.getGender().ToString();

            string dataString = qty +" "+ gender + " population in " + rgn;


            return dataString;
        }
    }
}
