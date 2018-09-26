using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    public class SMSProviderMesg
    {
        private Storage storage;

        public SMSProviderMesg(Storage storage)
        {
            this.storage = storage;
        }

        public void ReceiveSMS(Message message)
        {
            storage.Add(message);
        }

    }
}
