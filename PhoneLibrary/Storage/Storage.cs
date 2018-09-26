using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
   public class Storage
    {
        public event Action<Message> OnSMSAdded;
        public event Action<Message> OnSMSRemoved;

        List<Message> messages;

        public Storage()
        {
            messages = new List<Message>();
        }

        public void Add(Message message)
        {
            messages.Add(message);
            OnSMSAdded?.Invoke(message);
        }
        public void Remove(Message message)
        {
            if (messages.Contains(message))
            {
                messages.Remove(message);
                OnSMSRemoved?.Invoke(message);
            } 
        }

        public IEnumerable<Message> GetMessages()
        {
            return messages;
        }
    }
}
