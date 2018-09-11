using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    public abstract class Keyboard
    {
        private string figures;

        public string Figures
        {
            get { return figures; }
            set { figures = value; }
        }
        private string letters;

        public string  Letters
        {
            get { return letters; }
            set { letters = value; }
        }
        public Keyboard()
        {
            Letters= "ABCDEFGHIKLMNOPQRSTVX";
            Figures = "0123456789";
        }


    }
}
