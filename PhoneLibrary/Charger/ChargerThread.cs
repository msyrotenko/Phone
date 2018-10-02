using Phone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PhoneLibrary.Charger
{
    public class ChargerThread : ChargerBase
    {
        private Thread charge;
        private Thread discharge;       

        public ChargerThread(Battery battery) : base(battery)
        {
            discharge = new Thread(Discharging);
            discharge.Name = "discharge";
            discharge.Start();
        }

        public override void StartCharge()
        {
            if (charge == null)
            {
                charge = new Thread(Chargeing);
                charge.Start();
            }
            isCharging = true;
        }

        public override void FinalyzeCharge()
        {
            if (charge != null) charge.Abort();
            if (discharge != null) discharge.Abort();
        }

        protected void Chargeing()
        {
            while (true)
            {
                lock (lock_obj)
                {
                    if (isCharging)
                    {
                        battery.Charge++;
                    }
                }
                Thread.Sleep(1000);
            }
        }

        protected void Discharging()
        {
            while (true)
            {
                lock (lock_obj)
                {
                    battery.Charge--;
                }
                Thread.Sleep(2000);

            }
        }


    }
}
