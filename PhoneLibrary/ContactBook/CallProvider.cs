using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Phone
{  
    public class CallProvider
    {
        private Thread callGenarator;
        private CallStorage storage;
        private Random random;
        private List<Contact> contacts;

        public CallProvider(CallStorage storage)
        {
            this.storage = storage;
            IniConracts();
            random = new Random();
        }

        private void IniConracts()
        {
            contacts = new List<Contact>
            {
                new Contact("Alex"),
                new Contact("Bob"),
            };
        }

        public void Stast()
        {
            Stop();

            callGenarator = new Thread(()=>
            {
                while (true)
                {
                    var contact = GetRandomContact();
                    var direction = GetRandomDirecton();
                    var call = new Call(contact, DateTime.Now, direction);
                    storage.AddCall(call);
                    Thread.Sleep(1000);
                }
            });
            callGenarator.Start();
        }

        public void Stop()
        {
            callGenarator?.Abort();
        }

        private Direction GetRandomDirecton()
        {
            return (Direction)random.Next((int)Direction.Incoming, (int)Direction.Outcoming+1);
        }

        private Contact GetRandomContact()
        {
            return contacts[random.Next(contacts.Count())];
        }

        
    } 
}
