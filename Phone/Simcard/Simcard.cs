using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{

    public class Simcard
    {
        public enum Simcardtype { Mini, Macro, Nano };

        
        private string mobOperator;  

        public string MobOperator
        {
            get { return mobOperator; }
            set { mobOperator = value; }
        }
        private Simcardtype simForm;
        public Simcardtype SimForm
        {
            get { return simForm; }
            set { simForm = value; }
        }
        public Simcard()
        {
            MobOperator = "Not defined";
            SimForm = Simcardtype.Nano;
        }


    }
}
