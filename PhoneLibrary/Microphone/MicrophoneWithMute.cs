using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    class MicrophoneWithMute:Microphone
    {
        private bool isMuted;

        public bool IsMuted
        {
            get { return isMuted; }
            set { isMuted = value; }
        }

        public string isMetedCheck()
        {
            if (IsMuted == false)
            {
                return "Microphone is unmuted";
            }
            else
            {
                return "Microphone is muted";
            }
        }
       public MicrophoneWithMute()
       {
           isMuted = false;
       }

    }
}
