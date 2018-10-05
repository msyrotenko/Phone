using Phone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    public class CallStorage
    {
        public event Action<Call> CallAdded;
        public event Action<Call> CallRemoved;

        private List<Call> Calls;
        public CallStorage()
        {
            Calls = new List<Call>(); 
        }

        public void AddCall(Call call)
        {
            Calls.Add(call);
            Calls.Sort();
            CallAdded?.Invoke(call);
        }

        public void RemoveCall(Call call)
        {
            Calls.Remove(call);
            Calls.Sort();
            CallRemoved?.Invoke(call);
        }

        public IReadOnlyList<Call> GetCallList()
        {
            return Calls.ToList();
        }


    }
}


