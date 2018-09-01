using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
 public   class MultyTouchScreen:BasicTouchScreen
    {
        private bool multiTouch;

        public bool MultiTouch
        {
            get { return multiTouch; }
            set { multiTouch = value; }
        }
        public void TouchReaction()
        {
            //Action when the user touch the display (multi-touch)
        }
        public override string ToString()
        {
            return "Multy tuch screen";
        }
    }
}
