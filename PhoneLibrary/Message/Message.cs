using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
   public class Message
    {
        public string User { get; set; }
        public string Text { get; set;  }
        public DateTime ReceivingTime { get; set; }

        public override bool Equals(object obj)
        {
            var msg = obj as Message;
            if (msg == null) return false;
            if (object.ReferenceEquals(msg, this)) return true;

            return User == msg.User && Text == msg.Text && ReceivingTime == msg.ReceivingTime;
        }
    }
     
}
