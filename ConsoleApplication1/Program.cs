using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder str= new StringBuilder("Hello");
            Console.WriteLine(str);
            Change1(str);
            Console.WriteLine(str);
            Change2(str);
            Console.WriteLine(str);
            Console.ReadKey();

        }

        static void Change1(StringBuilder str)
        {
            str.AppendLine(" world");
        }

        static void Change2(StringBuilder str)
        {
            var SMSRec = new object(); 
            var handler = SMSRec;
            //
            SMSRec = null;
            //
            handler.GetType();

        }
    }
}
