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
        public abstract Dynamic Dynamic { get; }
        public abstract Microphone Microphone { get; }
        public abstract Simcard Simcard { get; }
        public abstract ScreenBase Screen { get; }
        public abstract  Keyboard Keyboard { get; }
        public abstract BasicTouchScreen ControlTouch { get; }

        public Mobile()
        {
            Battery = new Battery();
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
            descriptionBuilder.AppendLine($"The volume of dynamic is set to: {Dynamic.Volume}");
            descriptionBuilder.AppendLine($"The volume of microphone is set to: {Microphone.Volume}");
            descriptionBuilder.AppendLine($"Simcard: {Simcard.Moboperator}");
            descriptionBuilder.AppendLine($"Simcard type: {((SimcardNano) Simcard).Simtype}");
            descriptionBuilder.AppendLine($"Battery: {Battery.CheckCapacity()}");
            descriptionBuilder.AppendLine($"Keyboard status: {((KeyboardWithLock) Keyboard).KeyboardLockerCheck()}");
            return descriptionBuilder.ToString();

        }
    }
}
