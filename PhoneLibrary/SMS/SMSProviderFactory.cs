using Phone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneLibrary.SMS
{
    internal static class SMSProviderFactory
    {
        public static SMSProviderBase GetSMSProvider(Storage storage) => new SMSProviderTask(storage);
    }
}
