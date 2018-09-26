using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Phone;

namespace UnitTestProject1
{
    [TestClass]
    public class SMSProviderUnitTest
    {
        [TestMethod]
        public void TestPlay()
        {
            //Assign
            string message = "Message 1 is received";
            string exp_message = message;

            //Act
            string act_message = SMSFormat.FormatNone(message);

            //Assert
            Assert.AreEqual(exp_message, act_message);
            

        }

    }
    
}
