using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    public abstract class Microphone
    {
        private int volume;

        public int Volume
        {
            get { return volume; }
            set { volume = value; }
        }
        public Microphone()
        {
            Volume = 70;
        }
    }
}
