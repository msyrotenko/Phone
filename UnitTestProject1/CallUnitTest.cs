using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Phone;
using System.Linq;

namespace UnitTestProject1
{

    [TestClass]
    public class CallUnitTest
    {
        [TestMethod]
        public void AddTest()
        {
            var contact1 = new Contact("Bob");
            var contact2 = new Contact("Alex");
            Call[] calls = new Call[]
            {
                new Call(contact1, new DateTime(2018, 10, 3), Direction.Incoming),
                new Call(contact2,new DateTime(2018,9,3), Direction.Outcoming),
                new Call(contact1,new DateTime(2018,9,13), Direction.Incoming),
                new Call(contact2,new DateTime(2018,10,2), Direction.Outcoming)
            };

            var callslist = new List<Call>();
            callslist.Add(calls[0]);
            callslist.Add(calls[1]);
            callslist.Add(calls[2]);
            callslist.Add(calls[3]);

            callslist.Sort();

            var exp_callslist = new List<Call>
            {
                calls[1],calls[2],calls[3],calls[0],
            };
            Assert.IsTrue(Enumerable.SequenceEqual(exp_callslist, callslist));
        }

    }
}
