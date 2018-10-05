using Phone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallForm.CallView
{
    class CallViewModel : Call
    {
        public int count;
        public CallViewModel(Call call) : base(call.contact, call.calltime, call.calldirection)
        {
            count = 1;
        }

        public void AddNewCall(Call call)
        {
            if (call.calltime > this.calltime) this.calltime = call.calltime;
            this.count++;
        }
    }
}
