using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneLibrary.Ev
{
    public delegate void SomeDelegate();
    class VZL
    {
        public event SomeDelegate OnFreeTime;

        public void StartWork()
        {
            Working();
            StopWork();
        }

        private void Working()
        {
            OnFreeTime = null;
        }

        private void StopWork()
        {
            if (OnFreeTime != null)
            {
                OnFreeTime();
            }
        }
    }
}
