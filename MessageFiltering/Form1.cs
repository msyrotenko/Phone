using Phone;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageFiltering
{
    public partial class Form1 : Form
    {
        private Mobile mobile;
        private SMSCounter smscounter;
        private List<string> users;

        public Form1()
        {
            InitializeComponent();
            mobile = new SimcorpMobile();
            smscounter = new SMSCounter();
            users = new List<string>();

            mobile.Storage.OnSMSAdded += OnSMSReceived;
        }

        private void OnSMSReceived(Phone.Message message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<Phone.Message>(OnSMSReceived), message);
                return;
            }
            AnalysMsg(message);
        }

        private void AnalysMsg(Phone.Message message)
        {
            if (!users.Contains(message.User))
            {
                users.Add(message.User);
                comboBox1.Items.Add(message.User);
            }
        }


        private void RefreshMsgListView()
        {
            string srchuser = comboBox1.SelectedItem as string;
            string srchmsg = SrchMsgtextBox.Text;
            DateTime startDate = startDateTime.Value.Date;
            DateTime endDate = new DateTime(endDateTime.Value.Year, endDateTime.Value.Month, endDateTime.Value.Day, 23, 59, 59);
            bool startDateIsChecked=startDateTime.Checked;
            bool endDateIsChecked = endDateTime.Checked;
            bool andCondIsChecked = AndCondcheckBox.Checked;
            IEnumerable<Phone.Message> allmsg = mobile.Storage.GetMessages();

            IEnumerable<Phone.Message> showmsg = Filter.FilterMsgs(srchuser, srchmsg, startDate, endDate, allmsg, startDateIsChecked, endDateIsChecked, andCondIsChecked);
            ShowMessages(showmsg);
        }


        private void ShowMessages(IEnumerable<Phone.Message> messages)
        {
            MessageListView.Items.Clear();

            foreach (var msg in messages)
            {
                MessageListView.Items.Add(new ListViewItem(new[] { msg.User, msg.Text }));
            }
        }

        private void User1Timer_Tick(object sender, EventArgs e)
        {
            string msgtext = "Message #" + smscounter.Count.ToString() + " received!";
            smscounter.Add();
            var msg = new Phone.Message
            {
                User = "Alex",
                ReceivingTime = DateTime.Now,
                Text = msgtext
            };
            mobile.ReceiveSMS(msg);
        }

        private void User2Timer_Tick(object sender, EventArgs e)
        {
            string msgtext = "Message #" + smscounter.Count.ToString() + " received!";
            smscounter.Add();
            var msg = new Phone.Message
            {
                User = "Bob",
                ReceivingTime = DateTime.Now,
                Text = msgtext
            };
            mobile.ReceiveSMS(msg); ;
        }

        private void User3Timer_Tick(object sender, EventArgs e)
        {
            string msgtext = "Message #" + smscounter.Count.ToString() + " received!";
            smscounter.Add();
            var msg = new Phone.Message
            {
                User = "John",
                ReceivingTime = DateTime.Now,
                Text = msgtext
            };
            mobile.ReceiveSMS(msg);
        }

        private void Search_Changed(object sender, EventArgs e)
        {
            RefreshMsgListView();
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            RefreshMsgListView();
        }
    }
}
