using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    public enum Direction { Incoming, Outcoming};
    public class Call: IComparable<Call>
    {
        public readonly Contact contact;
        public DateTime calltime;
        public readonly Direction calldirection;

        public Call(Contact contact, DateTime calltime,Direction calldirection)
        {
            this.contact = contact;
            this.calltime = calltime;
            this.calldirection = calldirection;
        }

        public int CompareTo(Call other)
        {            
            return this.calltime.CompareTo(other.calltime);            
        }

        public override bool Equals(object obj)
        {
            Call call = obj as Call;
            if (call == null) return false;
            if (object.ReferenceEquals(obj,this)) return true;
            if (contact.Equals(call.contact) && calldirection == call.calldirection)
            {
                return true;
            }
            return false;
        }
    }
}


