using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Phone;
using PhoneLibrary.Charger;
using System.Threading;

namespace UnitTestProject1
{

    [TestClass]
    public class ChargerUnitTest
    {
        [TestMethod]
        public void ChargerThreadDischargeTest()
        {
            var battery = new Battery();
            Assert.AreEqual(100, battery.Charge);
            var charger = new ChargerThread(battery);
            Thread.Sleep(2000);
            Assert.IsTrue(100>battery.Charge);
            charger.FinalyzeCharge();
        }

        [TestMethod]
        public void ChargerThreadChargeTest()
        {
            var battery = new Battery();
            Assert.AreEqual(100, battery.Charge);
            var charger = new ChargerThread(battery);
            charger.StartCharge();
            Thread.Sleep(5000);
            Assert.IsTrue(99<=battery.Charge);
            charger.FinalyzeCharge();
        }

        [TestMethod]
        public void ChargerTaskDischargeTest()
        {
            var battery = new Battery();
            Assert.AreEqual(100, battery.Charge);
            var charger = new ChargerTask(battery);
            Thread.Sleep(2000);
            Assert.IsTrue(100 > battery.Charge);
            charger.FinalyzeCharge();
        }

        [TestMethod]
        public void ChargerTaskChargeTest()
        {
            var battery = new Battery();
            Assert.AreEqual(100, battery.Charge);
            var charger = new ChargerTask(battery);
            charger.StartCharge();
            Thread.Sleep(5000);
            Assert.IsTrue(99 <= battery.Charge);
            charger.FinalyzeCharge();
        }
    }
}
