using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    class SpeakerMono:Speaker
    {
        private int powerWatts;

        public int PowerWatts
        {
            get { return powerWatts; }
            set { powerWatts = value; }
        }

        public SpeakerMono()
        {
            powerWatts = 2;
        }

    }
}
