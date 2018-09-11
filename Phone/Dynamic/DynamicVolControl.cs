using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    public class DynamicVolControl:Dynamic
    {
       public void ChangeVolume(int volumeUpd)
       {
           Volume = volumeUpd;
       }

    }
}
