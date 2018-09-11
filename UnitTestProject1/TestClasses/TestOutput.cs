using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phone;

namespace UnitTestProject1.TestClasses
{
    class TestOutput : IOutput
    {
        public string TestText = string.Empty;
        public void Write(string text)
        {
            TestText = text;
        }

        public void WriteLine(string text)
        {
            TestText = text+'\n';
        }
    }
}
