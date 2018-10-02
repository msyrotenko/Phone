using Phone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PhoneLibrary.Charger
{
    public abstract class ChargerBase
    {
        protected object lock_obj;
        protected Battery battery;
        protected bool isCharging;

        public ChargerBase(Battery battery)
        {
            this.battery = battery;
            lock_obj = new object();
        }

        public abstract void StartCharge();               
        public abstract void FinalyzeCharge();

        public virtual void StopCharge()
        {
            isCharging = false;
        }
    }
}
