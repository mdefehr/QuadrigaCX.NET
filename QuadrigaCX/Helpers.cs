using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrigaCX
{
    public static class Helpers
    {
        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp, bool localTime)
        {
            // Unix timestamp is seconds past epoch
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            if (localTime)
                dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            else
                dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToUniversalTime();
            return dtDateTime;
        }
    }
}
