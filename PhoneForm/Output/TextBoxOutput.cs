using Phone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneForm.Output
{
    class TextBoxOutput : IOutput
    {
        private TextBox TextBox;
        public TextBoxOutput(TextBox textBox)
        {
            TextBox = textBox;
        }
        public void Write(string text)
        {
            TextBox.Clear();
            TextBox.AppendText(text);
        }

        public void WriteLine(string text)
        {
            text=text.Replace("\n", "\r\n");
            TextBox.Clear();
            TextBox.AppendText(text +"\r\n");
        }
    }
}
