using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    class SimcorpMobile : Mobile
    {
        public override Dynamic Dynamic {get { return dynamicVolControl; }}
        public override Microphone Microphone { get { return microphoneVolControl; } }
        public override ScreenBase Screen { get { return vOLEDScreen; } }
        public override Simcard Simcard { get { return sim; } }
        public override Keyboard Keyboard { get { return key; } }
        public override BasicTouchScreen ControlTouch { get { return control; } }

        private readonly OLEDScreen vOLEDScreen = new OLEDScreen();
        private readonly DynamicVolControl dynamicVolControl = new DynamicVolControl();
        private readonly MicrophoneVolControl microphoneVolControl = new MicrophoneVolControl();
        private readonly SimcardNano sim = new SimcardNano();
        private readonly KeyboardWithLock key = new KeyboardWithLock();
        private readonly BasicTouchScreen control = new MultyTouchScreen();
    }  
}
