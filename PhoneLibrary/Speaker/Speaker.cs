using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    public abstract class Speaker
    {
        private int volume;

        public int Volume
        {
            get { return volume; }
            set { volume = value; }
        }

        public Speaker()
        {
            Volume = 40;
        }
    } 
}
