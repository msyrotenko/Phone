using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
  public  class BasicTouchScreen
    {
        private bool isTouchEnabled;

        public bool IsTouchEnabled
        {
            get { return isTouchEnabled; }
            set { isTouchEnabled = value; }
        }

        public override string ToString()
        {
            return "Basic tuch screen";
        }

      public string IsTouchEnableCheck()
      {
          if (isTouchEnabled)
          {
              return "Tocuh functionlity is enabled";
          }
          else
          {
              return "Tocuh functionlity is discabled";
          }
            
       }

      public BasicTouchScreen()
      {
          IsTouchEnabled = true;
      }

    }
}
