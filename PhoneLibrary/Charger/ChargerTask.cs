using Phone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PhoneLibrary.Charger
{
    public class ChargerTask : ChargerBase
    {
        private CancellationTokenSource cancelTokenSource;
        private CancellationToken token;
        private Task charge;
        public ChargerTask(Battery battery) : base(battery)
        {
            cancelTokenSource = new CancellationTokenSource();
            token = cancelTokenSource.Token;

            Task discharge = Task.Run(async ()=>await Discharging());
        }

        public override void StartCharge()
        {
            if (charge == null)
            {
                charge = Task.Run(async () => await Charging());
            }          
            
            isCharging = true;
        }

        public override void FinalyzeCharge()
        {
            cancelTokenSource.Cancel();
        }

        protected async Task Charging()
        {
            while (true)
            {
                if (token.IsCancellationRequested) return;

                lock (lock_obj)
                {
                    if (isCharging)
                    {
                        battery.Charge++;
                    }
                }
                await Task.Delay(1000);
            }
        }

        protected async Task Discharging()
        {
            while (true)
            {
                if (token.IsCancellationRequested) return;

                lock (lock_obj)
                {
                    battery.Charge--;
                }
                await Task.Delay(2000);

            }
        }

    }
}
