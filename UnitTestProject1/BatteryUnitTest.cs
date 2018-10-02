using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Phone;

namespace UnitTestProject1
{

    [TestClass]
    public class BatteryUnitTest
    {
        [TestMethod]
        public void TestChargeAbove100()
        {
            //Assign
            Battery battery = new Battery();

            //Act
            battery.Charge = 150;

            //Assert
            Assert.AreEqual(battery.Charge, 100);
        }

        [TestMethod]
        public void TestChargeBelow0()
        {
            //Assign
            Battery battery = new Battery();

            //Act
            battery.Charge = -10;

            //Assert
            Assert.AreEqual(battery.Charge, 0);
        }
    }
}
