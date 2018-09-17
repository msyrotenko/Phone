using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneLibrary.Ev
{
    class MKSK
    {
        private VZL vzl;
        public MKSK(VZL vzl)
        {
            this.vzl = vzl;
            vzl.OnFreeTime += AskVzl;
        }

        public void StartWork()
        {
         //   vzl.OnFreeTime();
          //  vzl.OnFreeTime = null;
           // vzl.OnWork += (o,r=> ;
           
        }

        private void AskVzl()
        {
            vzl.OnFreeTime -= AskVzl;
        }
    }
}
