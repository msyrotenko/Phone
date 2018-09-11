using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            SimcorpMobile phone =new SimcorpMobile();
         //   Console.WriteLine(phone.Screen.ToString());
            Console.WriteLine(phone.GetDescription());
            Console.ReadLine();
        }
    }
}
