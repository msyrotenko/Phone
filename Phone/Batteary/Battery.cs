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
        private int capacity;

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public Battery()
        {
            Capacity = 100;

        }

        public string CheckCapacity()
        {
            if (Capacity==100)
            {
                return "The bettery is fully charged";
            }
            
            else if (Capacity > 0)
            {
                return "The bettery isn't fully charged";
            }
            return "The bettery is full uncharged";


        }

    }
}