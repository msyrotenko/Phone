using Phone;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageFiltering
{
    public partial class Form1 : Form
    {
        bool isCharging;
        bool isGeneratingSMS;
        private Mobile mobile;
        private List<string> users;    

        public Form1()
        {
            InitializeComponent();

            mobile = new SimcorpMobile();
            users = new List<string>();

            mobile.Storage.OnSMSAdded += OnSMSReceived;
            
            mobile.Battery.ChargeChanged += SetChargeProgressBar;
            button2.Enabled = false;
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
            bool startDateIsChecked = startDateTime.Checked;
            bool endDateIsChecked = endDateTime.Checked;
            bool andCondIsChecked = AndCondcheckBox.Checked;
            IEnumerable<Phone.Message> allmsg = mobile.Storage.GetMessages();

            IEnumerable<Phone.Message> showmsg = Filter.FilterMsgs(srchuser, srchmsg, startDate, endDate, allmsg.ToList(), startDateIsChecked, endDateIsChecked, andCondIsChecked);
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

        private void Search_Changed(object sender, EventArgs e)
        {
            RefreshMsgListView();
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            RefreshMsgListView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;

            if (isCharging)
            {
                return;
            }

            isCharging =  true;
            mobile.Charger.StartCharge();
        }
     

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button1.Enabled = true;

            if (!isCharging)
            {
                return;
            }

            isCharging = false;
            mobile.Charger.StopCharge();
        }

        private void SetChargeProgressBar(int charge)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<int>(SetChargeProgressBar), charge);
                return;
            }

            progressBar1.Value = mobile.Battery.Charge;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            mobile.Charger.FinalyzeCharge();
            mobile.StopReceiveSMS();
            mobile.Battery.ChargeChanged -= SetChargeProgressBar;
        }

        private void GenerateSmsBtn_Click(object sender, EventArgs e)
        {
            if (isGeneratingSMS)
            {
                GenerateSmsBtn.Text = "Start";
                mobile.StopReceiveSMS();
                isGeneratingSMS = false;
                return;
            }

            GenerateSmsBtn.Text = "Stop";
            mobile.StartReceiveSMS();
            isGeneratingSMS = true;
        }


    }
}
