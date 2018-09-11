using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    public class PhoneSpeaker:IPlayback
    {
        private IOutput Output;
        public PhoneSpeaker(IOutput output)
        {
            Output = output;
        }
        public void Play(object data)
        {
            string playinfostr;
            playinfostr = $"{nameof(PhoneSpeaker)} playback selected";
            playinfostr += "\nSet playback to Mobile...";
            playinfostr += "\nPlay sound in Mobile:";
            playinfostr += $"\n{nameof(PhoneSpeaker)} sound";
            Output.WriteLine(playinfostr);
        }
    }
}
