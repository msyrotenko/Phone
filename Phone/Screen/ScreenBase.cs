using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    public abstract class ScreenBase
    {
        private int size;

        public int Size
        {
            get { return size; }
            set { size = value; }
        }
        private int dpi;

        public int Dpi
        {
            get { return dpi; }
            set { dpi = value; }
        }

        public abstract void Show(IScreenImage screenImage);
        public abstract void Show(IScreenImage screenImage, int brightness);

        public ScreenBase()
        {
            Size = 2;
            Dpi = 50;
        }
    }
}
