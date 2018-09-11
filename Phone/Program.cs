using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            SimcorpMobile phone =new SimcorpMobile();
            Console.WriteLine(phone.Screen.ToString());
            Console.WriteLine(phone.GetDescription());

            PlayBackCompShow();
            PlayBackShowInfo(phone);

            ChargerCompShow();
            ChargerShowInfo(phone);

            Console.ReadLine();
        }

        private static void PlayBackShowInfo(SimcorpMobile phone)
        {
            var output = new ConsoleOutput();
            while (true)
            {
                try
                {
                    PlayBackComponents userChoise = (PlayBackComponents) Convert.ToInt32(Console.ReadLine());
                    switch (userChoise)
                    {
                        case PlayBackComponents.iPhoneHeadset:
                            phone.PlaybackComponent = new iPhoneHeadset(output);
                            break;
                        case PlayBackComponents.SamsungHeadset:
                            phone.PlaybackComponent = new SamsungHeadset(output);
                            break;
                        case PlayBackComponents.UnofficaialPhoneHeadset:
                            phone.PlaybackComponent = new UnofficaialPhoneHeadset(output);
                            break;
                        case PlayBackComponents.PhoneSpeaker:
                            phone.PlaybackComponent = new PhoneSpeaker(output);
                            break;
                        default:
                            Console.WriteLine("Unsupported headphones");
                            continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Wrong playback component");
                }
            }

            phone.Play(new object());
        }
        private static void ChargerShowInfo(SimcorpMobile phone)
        {
            var output = new ConsoleOutput();
            while (true)
            {
                try
                {
                    ChargerComponents userChoise = (ChargerComponents)Convert.ToInt32(Console.ReadLine());
                    switch (userChoise)
                    {
                        case ChargerComponents.FakeCharger:
                            phone.ChargerComponent = new FakeCharger(output);
                            break;
                        case ChargerComponents.OriginalCharger:
                            phone.ChargerComponent = new OriginalCharger(output);
                            break;
                        default:
                            Console.WriteLine("Unsupported charger");
                            continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Wrong charger component");
                }
            }

            phone.Charge(new object());
        }

        private static void PlayBackCompShow()
        {
            string playbackstr;
            playbackstr = "Select playback component (specify index):";
            playbackstr += "\n 1 - iPhoneHeadSet";
            playbackstr += "\n 2 - SumsungHeadSet";
            playbackstr += "\n 3 - UnofficailiPhoneHeadSet";
            playbackstr += "\n 4 - PhoneSpeaker";
            Console.WriteLine(playbackstr);
        }

        private static void ChargerCompShow()
        {
            string chargerstr;
            chargerstr = "\nSelect charger component (specify index):";
            chargerstr += "\n 1 - FakeCharger";
            chargerstr += "\n 2 - Original Charger";
            Console.WriteLine(chargerstr);
        }
    }
}
