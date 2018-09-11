using Phone;
using PhoneForm.Output;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneForm
{
    public partial class Form1 : Form
    {
        private TextBoxOutput textBoxOutput;
        private SimcorpMobile phone;
        public Form1()
        {
            InitializeComponent();
            textBoxOutput = new TextBoxOutput(textBox1);
            phone = new SimcorpMobile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlayBackShowInfo();
        }

        private void PlayBackShowInfo()
        {
            if (radioButton1.Checked == true)
            {
                phone.PlaybackComponent = new iPhoneHeadset(textBoxOutput);
            }
            else if (radioButton2.Checked == true)
            {
                phone.PlaybackComponent = new SamsungHeadset(textBoxOutput);
            }
            else if (radioButton3.Checked == true)
            {
                phone.PlaybackComponent = new UnofficaialPhoneHeadset(textBoxOutput);
            }
            else if (radioButton4.Checked == true)
            {
                phone.PlaybackComponent = new PhoneSpeaker(textBoxOutput);
            }

            phone.Play(new object());
        }
    }
}
