using PhoneLibrary.SMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Phone
{
    internal class SMSProviderThread : SMSProviderBase
    {
        private Thread user1;
        private Thread user2;
        private Thread user3;

        public SMSProviderThread(Storage storage) : base(storage)
        {
        }

        public override void Start()
        {
            Stop();

            user1 = new Thread(() => { while (true) { ReceiveSMS(CreateMessage("Alex")); Thread.Sleep(2000); } });
            user1.Start();
            user2 = new Thread(() => { while (true) { ReceiveSMS(CreateMessage("Bob")); Thread.Sleep(3000); } });
            user2.Start();
            user3 = new Thread(() => { while (true) { ReceiveSMS(CreateMessage("Max")); Thread.Sleep(4500); } });
            user3.Start();
        }
        public override void Stop()
        {
            if (user1 != null) user1.Abort();
            if (user2 != null) user2.Abort();
            if (user3 != null) user3.Abort();
        }
    }
}
