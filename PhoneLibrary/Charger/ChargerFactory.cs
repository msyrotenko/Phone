using Phone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneLibrary.Charger
{
    public static class ChargerFactory
    {
        public static ChargerBase GetCharger(Battery battery) => new ChargerTask(battery);
    }
}
