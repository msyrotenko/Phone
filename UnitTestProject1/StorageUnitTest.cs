using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Phone;

namespace UnitTestProject1
{
    [TestClass]
    public class StorageUnitTest
    {
        [TestMethod]
        public void TestStorageIsEmpty()
        {
            //Assign       
            var storage = new Storage();
            IEnumerable<Message> exp_msgs = new List<Message>();

            //Act
            IEnumerable<Message> act_msgs = storage.GetMessages();

            //Assert
            Assert.IsTrue(Enumerable.SequenceEqual(exp_msgs, act_msgs));
        }

        [TestMethod]
        public void TestStorageAddMessages()
        {
            //Assign       
            var storage = new Storage();           
            var msg1 = new Message()
            {
                User = "Alex",
                Text = "Message #1",
                ReceivingTime = new DateTime(2018, 1, 1, 0, 0, 0)
            };
            storage.Add(msg1);
            var msg2 = new Message()
            {
                User = "Bob",
                Text = "Message #4",
                ReceivingTime = new DateTime(2018, 7, 7, 0, 0, 0)
            };
            storage.Add(msg2);

            IEnumerable<Message> exp_msgs = new List<Message>()
            {
                new Message() {User="Alex",Text="Message #1", ReceivingTime =new DateTime(2018, 1, 1, 0, 0, 0)},
                new Message() {User="Bob",Text="Message #4", ReceivingTime =new DateTime(2018, 7, 7, 0, 0, 0)}
            };

            //Act
            IEnumerable<Message> act_msgs = storage.GetMessages();

            //Assert
            Assert.IsTrue(Enumerable.SequenceEqual(exp_msgs, act_msgs));
        }

        [TestMethod]
        public void TestStorageRemoveMessages()
        {
            //Assign       
            var storage = new Storage();
            var msg1 = new Message()
            {
                User = "Alex",
                Text = "Message #1",
                ReceivingTime = new DateTime(2018, 1, 1, 0, 0, 0)
            };
            storage.Add(msg1);
            var msg2 = new Message()
            {
                User = "Bob",
                Text = "Message #4",
                ReceivingTime = new DateTime(2018, 7, 7, 0, 0, 0)
            };
            storage.Add(msg2);
            storage.Remove(msg1);

            IEnumerable<Message> exp_msgs = new List<Message>()
            {                
                new Message() {User="Bob",Text="Message #4", ReceivingTime =new DateTime(2018, 7, 7, 0, 0, 0)}
            };

            //Act
            IEnumerable<Message> act_msgs = storage.GetMessages();

            //Assert
            Assert.IsTrue(Enumerable.SequenceEqual(exp_msgs, act_msgs));
        }
    }
}
