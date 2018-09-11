using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
   public class iPhoneHeadset : IPlayback
   {
        private IOutput Output;
        public iPhoneHeadset(IOutput output)
        {
            Output = output;
        }

        public void Play(object data)
        {
            string playinfostr;
            playinfostr = $"{nameof(iPhoneHeadset)} playback selected";
            playinfostr += "\nSet playback to Mobile...";
            playinfostr += "\nPlay sound in Mobile:";
            playinfostr += $"\n{nameof(iPhoneHeadset)} sound";
            Output.WriteLine(playinfostr);
        }
    }
}
