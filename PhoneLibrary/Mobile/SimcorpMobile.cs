using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    public class SimcorpMobile : Mobile
    {
        public override Speaker Speaker {get { return speaker; }}
        public override Microphone Microphone { get { return microphoneVolControl; } }
        public override ScreenBase Screen { get { return vOLEDScreen; } }
        public override Keyboard Keyboard { get { return key; } }
        public override BasicTouchScreen ControlTouch { get { return control; } }

        private readonly OLEDScreen vOLEDScreen;
        private readonly SpeakerMono speaker;
        private readonly MicrophoneWithMute microphoneVolControl;
        private readonly KeyboardWithLock key;
        private readonly BasicTouchScreen control;

        public SimcorpMobile()
        {
          vOLEDScreen = new OLEDScreen();
          speaker = new SpeakerMono();
          microphoneVolControl = new MicrophoneWithMute();
          key = new KeyboardWithLock();
          control = new MultyTouchScreen();
        }
    }  
}
