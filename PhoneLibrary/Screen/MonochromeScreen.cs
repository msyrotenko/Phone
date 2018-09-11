using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    public class MonochromeScreen : ScreenBase
    {
        private bool isBackLightEnabled;

        public bool IsBackLightEnabled
        {
            get { return isBackLightEnabled; }
            set { isBackLightEnabled = value; }
        }

        public override void Show(IScreenImage screenImage)
        {
            Console.WriteLine("Display Image {0}x{1} on monochrme screen", screenImage.Height,screenImage.Width);
        }

        public override void Show(IScreenImage screenImage, int brightness)
        {
            Console.WriteLine("Display Image {0}x{1} on monochrme screen with brightness={2}", screenImage.Height, screenImage.Width, brightness);
        }

        public override string ToString()
        {
            string IsBackLightEnabledStr = "BackLight is terned on.";
            if (IsBackLightEnabled)
            {
                IsBackLightEnabledStr = "BackLight is terned off.";
            }
            return "Monochrome Screen. " + IsBackLightEnabledStr;
        }

        public MonochromeScreen() : base()
        {
            IsBackLightEnabled = true;
        }
    }
    
}
