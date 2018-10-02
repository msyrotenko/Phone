using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phone;
using System.Threading;

namespace PhoneLibrary.SMS
{
    internal class SMSProviderTask : SMSProviderBase
    {
        private CancellationTokenSource cancelTokenSource;
        private CancellationToken token;

        public SMSProviderTask(Storage storage) : base(storage)
        {
        }

        public override void Start()
        {
            Stop();
            cancelTokenSource = new CancellationTokenSource();
            token = cancelTokenSource.Token;

            Task user1 = Task.Run(async ()=> { while (true) { if (token.IsCancellationRequested) return; ReceiveSMS(CreateMessage("Alex")); await Task.Delay(2000); } });
            Task user2 = Task.Run(async () => { while (true) { if (token.IsCancellationRequested) return; ReceiveSMS(CreateMessage("Bob")); await Task.Delay(3000); } });
            Task user3 = Task.Run(async () => { while (true) { if (token.IsCancellationRequested) return; ReceiveSMS(CreateMessage("Max")); await Task.Delay(4500); } });
        }

        public override void Stop()
        {
            if (cancelTokenSource!=null)
            {
                cancelTokenSource.Cancel();
            }            
        }
    }
}
