using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;


namespace Phone
{
    public abstract class Mobile
    {
        public Battery Battery;
        public Simcard Simcard;
        public abstract Speaker Speaker { get; }
        public abstract Microphone Microphone { get; }
        public abstract ScreenBase Screen { get; }
        public abstract  Keyboard Keyboard { get; }
        public abstract BasicTouchScreen ControlTouch { get; }

        public Mobile()
        {
            Battery = new Battery();
            Simcard = new Simcard();
        }
        private void Show(IScreenImage screenImage)
       {
           Screen.Show(screenImage);
       }

        public string GetDescription()
        {

            var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine($"Generl status of components in the phone:");
            descriptionBuilder.AppendLine($"Screen Type: {Screen.ToString()}");
            descriptionBuilder.AppendLine($"Screen touch control: {ControlTouch.ToString()}");
            descriptionBuilder.AppendLine($"The volume of dynamic is set to: {Speaker.Volume}");
            descriptionBuilder.AppendLine($"The power of the speaker is: {((SpeakerMono)Speaker).PowerWatts}");
            descriptionBuilder.AppendLine($"The microphone setting: {((MicrophoneWithMute)Microphone).isMetedCheck()}");
            descriptionBuilder.AppendLine($"The volume of microphone is set to: {Microphone.Volume}");
            descriptionBuilder.AppendLine($"Simcard: {Simcard.MobOperator}");
            descriptionBuilder.AppendLine($"Simcard type: {Simcard.SimForm}");
            descriptionBuilder.AppendLine($"Battery: {Battery.CheckCapacity()}");
            descriptionBuilder.AppendLine($"Keyboard status: {((KeyboardWithLock) Keyboard).KeyboardLockerCheck()}");
            descriptionBuilder.AppendLine($"Supported figures on the phone: {((KeyboardWithLock)Keyboard).Figures}");
            descriptionBuilder.AppendLine($"Supported letters on the phone: {((KeyboardWithLock)Keyboard).Letters}");
            return descriptionBuilder.ToString();

        }
    }
}
