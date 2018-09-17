using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
   public static class SMSFormat
    {
        public static string FormatNone(string message)
        {
            return message;
        }
        public static string FormatStartWithTime(string message)
        {
            return $"[{DateTime.Now}]{message}";
        }
        public static string FormatEndWithTime(string message)
        {
            return $"{message}[{DateTime.Now}]";
        }
        public static string FormatCustom(string message)
        {
            return $"[{DateTime.Today}]{message}";
        }
        public static string FormatLowerCase(string message)
        {
            return $"[{DateTime.Now}]{message.ToLower()}";
        }
        public static string FormatUpperCase(string message)
        {
           return $"[{DateTime.Now}]{message.ToUpper()}";
           
        }
        public enum FormatOption
        {
            None = 0, StartWithDateTime, EndWithDateTime, Custom, LowerCase, UpperCase
        }
    }
}
