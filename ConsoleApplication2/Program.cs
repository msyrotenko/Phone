using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication2.Ext;

namespace ConsoleApplication2
{
    static class BufExt
    {
        public static void AddValue(this Program.IIbuffer buff, int i)
        {
            buff.SetValue(buff.GetValue() + i);
        }
    }
    class Program

    {


        public interface IIbuffer
        {
            int GetValue();
            void SetValue(int i);
        }

        public class Buffer1 : IIbuffer
        {
            private int bufvar;
            public int GetValue()
            {
                return bufvar;
            }

            public void SetValue(int i)
            {
                bufvar = i;
            }
        }

        public class Buffer2 : IIbuffer
        {
            private int bufvar;
            public int GetValue()
            {
                return bufvar;
            }

            public void SetValue(int i)
            {
                bufvar = i*3;
            }
        }


        static void Main(string[] args)
        {
            var buff = new Buffer1();
            buff.SetValue(2);

            buff.AddValue(3);
            BufExt.AddValue(buff,3);

            Console.WriteLine(buff.GetValue());
            Console.ReadKey();
        }
    }
}
