using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phone;

namespace PhoneMessage
{
    public partial class Form1 : Form
    {
        SMSCounter smscounter;
        private delegate string FormatDelegate(string text);
        private FormatDelegate Formatter=new FormatDelegate(SMSFormat.FormatStartWithTime);
        private Mobile Mobile;

        private void OnSMSReceived(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new SMSProvider.SMSReceivedDelegate(OnSMSReceived),message);
                return;
            }
            string formattedMessage = Formatter($"{message}");
            richTextBox1.AppendText($"{formattedMessage}{Environment.NewLine}");
        }

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Enabled = true;
            smscounter = new SMSCounter();
            Mobile = new SimcorpMobile();
            Mobile.SMSProvider.SMSReceived += OnSMSReceived;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string msgtext = "Message #" + smscounter.Count.ToString() + " received!";
            Mobile.SMSProvider.ReceiveSMS(msgtext);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             var formatChoise = (SMSFormat.FormatOption) comboBox1.SelectedIndex;
            switch (formatChoise)
            {
                case SMSFormat.FormatOption.None:
                    Formatter = SMSFormat.FormatNone;
                    break;
                case SMSFormat.FormatOption.StartWithDateTime:
                    Formatter = SMSFormat.FormatStartWithTime;
                    break;
                case SMSFormat.FormatOption.EndWithDateTime:
                    Formatter = SMSFormat.FormatEndWithTime;
                    break;
                case SMSFormat.FormatOption.Custom:
                    Formatter = SMSFormat.FormatCustom;
                    break;
                case SMSFormat.FormatOption.LowerCase:
                    Formatter = SMSFormat.FormatLowerCase;
                    break;
                case SMSFormat.FormatOption.UpperCase:
                    Formatter = SMSFormat.FormatUpperCase;
                    break;
                default:
                    MessageBox.Show("Wrong format message is chosen.");
                    break;
            }
        }
    }
}
