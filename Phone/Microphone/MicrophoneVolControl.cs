using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    class MicrophoneVolControl:Microphone
    {
        public void ChangeVolume(int volumeUpd)
        {
            Volume = volumeUpd;
        }
    }
}
