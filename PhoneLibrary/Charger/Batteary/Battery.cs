using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    public class Battery
    {
        public event Action<int> ChargeChanged;

        private int charge;
        public int Charge
        {
            get { return charge; }
            set
            {
                if (value < 0) { charge = 0; }
                else if (value > 100) { charge = 100; }
                else {charge = value;}
                ChargeChanged?.Invoke(charge);
             }

        }
        public Battery()
        {
            Charge = 100;
        }

        public string CheckCapacity()
        {
            if (Charge == 100)
            {
                return "The bettery is fully charged";
            }

            else if (Charge > 0)
            {
                return "The bettery isn't fully charged";
            }
            return "The bettery is full uncharged";

        }

    }
}