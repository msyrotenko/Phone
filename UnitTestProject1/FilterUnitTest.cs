using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MessageFiltering;

namespace UnitTestProject1
{

    [TestClass]
    public class FilterUnitTest
    {
        [TestMethod]
        public void TestFilterAndCond()
        {
            //Assign                        
            IEnumerable<Phone.Message> allmsg = new List<Phone.Message>
            {
                new Phone.Message() {User="Alex",Text="Message #1", ReceivingTime =new DateTime(2018, 1, 1, 0, 0, 0)},
                new Phone.Message() {User="Bob",Text="Message #2", ReceivingTime =new DateTime(2018, 5, 5, 0, 0, 0)},
                new Phone.Message() {User="Alex",Text="Message #3", ReceivingTime =new DateTime(2020, 6, 6, 0, 0, 0)},
                new Phone.Message() {User="Alex",Text="Message #4", ReceivingTime =new DateTime(2018, 7, 7, 0, 0, 0)}
            };
            string srchuser = "Alex";
            string srchmsg = string.Empty;
            DateTime startDate = new DateTime(2017, 1, 1, 0, 0, 0);
            DateTime endDate = new DateTime(2019, 1, 1, 0, 0, 0);
            bool startDateIsChecked = true;
            bool endDateIsChecked = true;
            bool andCondIsChecked = true;

            IEnumerable<Phone.Message> exp_showmsg = new List<Phone.Message>
            {
                new Phone.Message() {User="Alex",Text="Message #1", ReceivingTime =new DateTime(2018, 1, 1, 0, 0, 0)},
                new Phone.Message() {User="Alex",Text="Message #4", ReceivingTime =new DateTime(2018, 7, 7, 0, 0, 0)}
            };


            //Act
            IEnumerable<Phone.Message> act_showmsg = Filter.FilterMsgs(srchuser, srchmsg, startDate, endDate, allmsg, startDateIsChecked, endDateIsChecked, andCondIsChecked);
            
            //Assert
            Assert.IsTrue(Enumerable.SequenceEqual(exp_showmsg, act_showmsg));
        }

        [TestMethod]
        public void TestFilterOrCond()
        {
            //Assign                        
            IEnumerable<Phone.Message> allmsg = new List<Phone.Message>
            {
                new Phone.Message() {User="Alex",Text="Message #1", ReceivingTime =new DateTime(2018, 1, 1, 0, 0, 0)},
                new Phone.Message() {User="Bob",Text="Message #2", ReceivingTime =new DateTime(2018, 5, 5, 0, 0, 0)},
                new Phone.Message() {User="Alex",Text="Message #3", ReceivingTime =new DateTime(2020, 6, 6, 0, 0, 0)},
                new Phone.Message() {User="Alex",Text="Message #4", ReceivingTime =new DateTime(2018, 7, 7, 0, 0, 0)}
            };
            string srchuser = "Alex";
            string srchmsg = string.Empty;
            DateTime startDate = new DateTime(2017, 1, 1, 0, 0, 0);
            DateTime endDate = new DateTime(2019, 1, 1, 0, 0, 0);
            bool startDateIsChecked = true;
            bool endDateIsChecked = true;
            bool andCondIsChecked = false;

            IEnumerable<Phone.Message> exp_showmsg = new List<Phone.Message>
            {
                new Phone.Message() {User="Alex",Text="Message #1", ReceivingTime =new DateTime(2018, 1, 1, 0, 0, 0)},
                new Phone.Message() {User="Bob",Text="Message #2", ReceivingTime =new DateTime(2018, 5, 5, 0, 0, 0)},
                new Phone.Message() {User="Alex",Text="Message #3", ReceivingTime =new DateTime(2020, 6, 6, 0, 0, 0)},
                new Phone.Message() {User="Alex",Text="Message #4", ReceivingTime =new DateTime(2018, 7, 7, 0, 0, 0)}
            };


            //Act
            IEnumerable<Phone.Message> act_showmsg = Filter.FilterMsgs(srchuser, srchmsg, startDate, endDate, allmsg, startDateIsChecked, endDateIsChecked, andCondIsChecked);

            //Assert
            Assert.IsTrue(Enumerable.SequenceEqual(exp_showmsg, act_showmsg));
        }

    }
}
