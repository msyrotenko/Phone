using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    public class SMSCounter
    {
        private int count=1;

        public int Count
        {
            get { return count; }
        }

        public void Add()
        {
            count++;
        }

    }
}
