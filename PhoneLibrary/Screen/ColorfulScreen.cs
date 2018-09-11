using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    public class ColorfulScreen:ScreenBase
    {            
        public override void Show(IScreenImage screenImage)
        {
            Console.WriteLine("Display Image {0}x{1}  on  colorfull screen", screenImage.Height, screenImage.Width);
        }
        public override void Show(IScreenImage screenImage, int brightness)
        {
            Console.WriteLine("Display Image {0}x{1}  quality on  colorfull screen with brightness={2}", screenImage.Height, screenImage.Width,brightness);
        }
        public override string ToString()
        {
            return "Colorfull Screen."+"Number of colors "+ColorsQnt;
        }
        private int colorsQnt;

        public int ColorsQnt
        {
            get { return colorsQnt; }
            set { colorsQnt = value; }
        }

        public ColorfulScreen()
        {
            Size = 3;
            Dpi = 100;
            ColorsQnt = 256000;
        }
    }
}
