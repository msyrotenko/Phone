using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Phone;
using UnitTestProject1.TestClasses;

namespace UnitTestProject1
{
    [TestClass]
    public class IPhoneHeadsetUnitTest
    {
        [TestMethod]
        public void TestPlay()
        {
            //Assign
            var output = new TestOutput();
            var iPhoneHeadset = new iPhoneHeadset(output);
            string exp_playbackinfo;
            exp_playbackinfo = $"{nameof(iPhoneHeadset)} playback selected";
            exp_playbackinfo += "\nSet playback to Mobile...";
            exp_playbackinfo += "\nPlay sound in Mobile:";
            exp_playbackinfo += $"\n{nameof(iPhoneHeadset)} sound\n";

            //Act
            iPhoneHeadset.Play(new object());
            var act_playbackinfo = output.TestText;

            //Assert
            Assert.AreEqual(exp_playbackinfo, act_playbackinfo);
        }

        [TestMethod]
        public void TestCharge()
        {
            //Assign
            var output = new TestOutput();
            var originalCharger = new OriginalCharger(output);
            string exp_chargerinfo;
            exp_chargerinfo = $"{nameof(OriginalCharger)} charger\n";

            //Act
            originalCharger.Charge(new object());
            var act_chargerinfo = output.TestText;

            //Assert
            Assert.AreEqual(exp_chargerinfo, act_chargerinfo);
        }


    }
}
