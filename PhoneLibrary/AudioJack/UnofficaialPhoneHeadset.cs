using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
   public class UnofficaialPhoneHeadset:IPlayback
    {
        private IOutput Output;
        public UnofficaialPhoneHeadset(IOutput output)
        {
            Output = output;
        }
        public void Play(object data)
        {
            string playinfostr;
            playinfostr = $"{nameof(UnofficaialPhoneHeadset)} playback selected";
            playinfostr += "\nSet playback to Mobile...";
            playinfostr += "\nPlay sound in Mobile:";
            playinfostr += $"\n{nameof(UnofficaialPhoneHeadset)} sound";
            Output.WriteLine(playinfostr);
        }
    }
}
