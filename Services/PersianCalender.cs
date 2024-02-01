using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public static class PersianCalender
    {
        public static string ToPersianDate(this DateTime greDate)
        {
            PersianCalendar pc = new PersianCalendar();
            return string.Format("{0}/{1}/{2}", pc.GetYear(greDate), pc.GetMonth(greDate), pc.GetDayOfMonth(greDate));
        }
    }
}
