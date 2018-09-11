using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    public class OriginalCharger:ICharger
    {
        private IOutput Output;
        public OriginalCharger(IOutput output)
        {
            Output = output;
        }
        public void Charge(object data)
        {
            Output.WriteLine($"{nameof(OriginalCharger)} charger");
        }
    }
}
