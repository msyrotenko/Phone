using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{

    public abstract class Simcard
    {
        private string moboperator;  

        public string Moboperator
        {
            get { return moboperator; }
            set { moboperator = value; }
        }

        public Simcard()
        {
            Moboperator = "Not defined";
        }


    }
}
