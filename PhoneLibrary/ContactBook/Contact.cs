using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{


    public class Contact
    {
        public List<string> phonenumbers;
        public string name;
        public Contact(string name)
        {
            phonenumbers = new List<string>();
            this.name = name;
        }

        public void AddPhoneNumber(string number)
        {
            if (phonenumbers.Contains(number))
            {
                phonenumbers.Add(number);
            }
        }

        public void RemovePhoneNumber(string number)
          {  
              if (phonenumbers.Contains(number))  
             {
                phonenumbers.Remove(number);  
             }            
          }

        public IReadOnlyList<string> GetPhoneNumbers() => phonenumbers.ToList();
        public override bool Equals(object obj)
        {
            Contact contact = obj as Contact;
            if (contact == null) return false;
            if (object.ReferenceEquals(obj, this)) return true;

            if(name == contact.name && Enumerable.SequenceEqual(phonenumbers,contact.phonenumbers))
            {
                return true;
            }
            return false;
        }
    }

}