using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
 public   class MultyTouchScreen:BasicTouchScreen
    {
        private int multiTouchNum;

        public int MultiTouchNum
        {
            get { return multiTouchNum; }
            set { multiTouchNum = value; }
        }
        public void TouchReaction()
        {
            //Action when the user touch the display (multi-touch)
        }
        public override string ToString()
        {
            return "Multy tuch screen with " + MultiTouchNum +" simultaneous touches are supported.";
        }

     public MultyTouchScreen()
     {
         MultiTouchNum = 3;
     }
    
    }
}
