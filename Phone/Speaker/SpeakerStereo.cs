using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    class SpeakerStereo:Speaker
    {
        private int powerWattsSpkr1;

        public int PowerWattsSpkr1
        {
            get { return powerWattsSpkr1; }
            set { powerWattsSpkr1 = value; }
        }
        private int powerWattsSpkr2;

        public int PowerWattsSpkr2
        {
            get { return powerWattsSpkr2; }
            set { powerWattsSpkr2 = value; }
        }

        public SpeakerStereo()
        {
            PowerWattsSpkr1 = 2;
            PowerWattsSpkr2 = 2;
        }
    }
}
