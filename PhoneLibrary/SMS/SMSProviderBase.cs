using Phone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneLibrary.SMS
{
    internal abstract class SMSProviderBase
    {
        protected Storage storage;
        protected SMSCounter smscounter;
        protected object lock_obj;

        public abstract void Start();
        public abstract void Stop();

        public SMSProviderBase(Storage storage)
        {
            this.storage = storage;
            smscounter = new SMSCounter();
            lock_obj = new object();
        }

        protected void ReceiveSMS(Message message)
        {
            storage.Add(message);
        }

        protected Message CreateMessage(string fromUser)
        {
            string msgtext;
            lock (lock_obj)
            {
                msgtext = "Message #" + smscounter.Count.ToString() + " received!";
                smscounter.Add();
            }
            return new Phone.Message
            {
                User = fromUser,
                ReceivingTime = DateTime.Now,
                Text = msgtext
            };
        }
    }
}
