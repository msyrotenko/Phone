using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
  public  class BasicTouchScreen
    {
        private bool touchScreen;

        public bool TouchScreen
        {
            get { return touchScreen; }
            set { touchScreen = value; }
        }
        public override string ToString()
        {
            return "Basic tuch screen";
        }

    }
}
