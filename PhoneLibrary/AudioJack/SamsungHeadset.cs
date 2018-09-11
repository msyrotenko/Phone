using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
   public class SamsungHeadset:IPlayback
    {
        private IOutput Output;
        public SamsungHeadset(IOutput output)
        {
            Output = output;
        }
        public void Play(object data)
        {
            string playinfostr;
            playinfostr = $"{nameof(SamsungHeadset)} playback selected";
            playinfostr += "\nSet playback to Mobile...";
            playinfostr += "\nPlay sound in Mobile:";
            playinfostr += $"\n{nameof(SamsungHeadset)} sound";
            Output.WriteLine(playinfostr);
        }
    }
}
