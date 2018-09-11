using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
     public class KeyboardWithLock:Keyboard
    {
     
        private bool keyboardlocked;

        public bool Keyboardlocked
        {
            get { return keyboardlocked; }
            set { keyboardlocked = value; }
        }

        public string KeyboardLockerCheck()
         {
             if (keyboardlocked == true)
             {
                 return ("Keyboard is locked");
             }
             else
             {
                 return ("Keyboard is unlocked");
             }
         }

         public KeyboardWithLock()
         {
             keyboardlocked = false;
         }

    }
}
