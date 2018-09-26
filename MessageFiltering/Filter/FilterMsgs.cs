using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageFiltering
{
    public static class Filter
    {
        public static IEnumerable<Phone.Message> FilterMsgs(string srchuser, string srchmsg, DateTime startDate, DateTime endDate, IEnumerable<Phone.Message> allmsg, bool startDateIsChecked, bool endDateIsChecked, bool andCondIsChecked)
        {
            IEnumerable<Phone.Message> showmsg;
            if (andCondIsChecked)
            {
                showmsg = allmsg.Where(x => ((srchuser == null) || (x.User == srchuser)) &&
                        ((srchmsg == string.Empty) || x.Text.Contains(srchmsg)) &&
                        ((!startDateIsChecked) || (x.ReceivingTime >= startDate)) &&
                        ((!endDateIsChecked) || (x.ReceivingTime <= endDate)));
            }
            else
            {
                showmsg = allmsg.Where(x => ((srchuser == null) || (x.User == srchuser)) ||
                        ((srchmsg == string.Empty) || x.Text.Contains(srchmsg)) ||
                        ((!startDateIsChecked) || (x.ReceivingTime >= startDate)) ||
                        ((!endDateIsChecked) || (x.ReceivingTime <= endDate)));
            }
            return showmsg;
        }
    }
}
