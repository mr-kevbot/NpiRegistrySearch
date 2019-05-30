using System;

namespace NpiRegistrySearch.Helpers
{
    internal class DateTimeHelper
    {
        public static DateTime FromUnixTime(long unixTime)
        {
            return epoch.AddSeconds(unixTime);
        }
        private static readonly DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
    }
}
