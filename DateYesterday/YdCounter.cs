using System;

namespace DateYesterday
{
    public static class YdCounter
    {
        public static DateTime GetYesterday()
        {
            return DateTime.Today.AddDays(-1);
        }
    }
}
