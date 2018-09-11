using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    class RetinaScreen:ColorfulScreen
    {
        private bool isAntiReflectiveCover;

        public bool IsAntireflectiveCover
        {
            get { return isAntiReflectiveCover; }
            set { isAntiReflectiveCover = value; }
        }

        public override void Show(IScreenImage screenImage)
        {
            Console.WriteLine("Display Image {0}x{1} on  OLED screen", screenImage.Height, screenImage.Width);
        }
        public override void Show(IScreenImage screenImage,int brightness)
        {
            Console.WriteLine("Display Image {0}x{1}  on  OLED screen with brightness={2}", screenImage.Height, screenImage.Width, brightness);
        }
        public override string ToString()
        {
            string sizeStr = "Size of the scrren is " + Size + " inches. ";
            string resolutionStr = "Resolution is " + Dpi + " dpi. ";  
            string isAntiReflectiveCoverStr = "There is no anti reflective cover.";
            if (isAntiReflectiveCover == true) { isAntiReflectiveCoverStr = "There is anti reflective cover."; }
            return ("Retina Screen" + sizeStr + resolutionStr + isAntiReflectiveCoverStr);
        }

        public RetinaScreen()
        {
            Size = 3;
            Dpi = 300;
            IsAntireflectiveCover = true;
        }
    }
    
}
