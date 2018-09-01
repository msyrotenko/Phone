using System;
using System.Collections.Generic;
using System.Linq;
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
        private int pixels;

        public int Pixels
        {
            get { return pixels; }
            set { pixels = value; }
        }


        public abstract void Show(IScreenImage screenImage);
        public abstract void Show(IScreenImage screenImage, int brightness);
    }
}
