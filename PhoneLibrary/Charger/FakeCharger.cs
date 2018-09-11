using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
   public class FakeCharger:ICharger
    {
        private IOutput Output;
        public FakeCharger(IOutput output)
        {
            Output = output;
        }
        public void Charge(object data)
        {
            Output.WriteLine($"{nameof(FakeCharger)} charger");
        }
    }
}
