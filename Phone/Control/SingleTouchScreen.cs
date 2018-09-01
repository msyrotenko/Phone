using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
   public class SingleTouchScreen:BasicTouchScreen
    { 
        private bool singleTouch;

        public bool SingleTouch
        {
            get { return singleTouch; }
            set { singleTouch = value; }
        }
        public void TouchReaction()
        {
            //Action when the user touch the display (single-touch)
        }
        public override string ToString()
        {
            return "Single tuch screen";
        }
    }
}
