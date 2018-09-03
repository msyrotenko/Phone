using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    public class OLEDScreen: ColorfulScreen
    {
        private int angleView;

        public int AngleView
        {
            get { return angleView; }
            set { angleView = value; }
        }

        public override void Show(IScreenImage screenImage)
        {
            Console.WriteLine("Display Image {0}x{1}  on  OLED screen", screenImage.Height, screenImage.Width);
        }
        public override void Show(IScreenImage screenImage,int brightness)
        {
            Console.WriteLine("Display Image {0}x{1} on  OLED screen with brightness={2}", screenImage.Height, screenImage.Width,brightness);
        }
        public override string ToString()
        {
            string sizestr = "Size of the scrren is " + Size + " inches. ";
            string resolutionstr = "Resolution is " + Dpi + " dpi. ";
            string angleViewstr = "Angle view is " + AngleView + " degrees.";
            return ("OLED Screen." + sizestr + resolutionstr + angleViewstr);
        }
        
        public OLEDScreen()
        {
            Size = 3;
            Dpi = 100;
            AngleView = 150;
        }
    }
}
