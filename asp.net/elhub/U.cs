
using System;
using System.Diagnostics;


//Make some change, and another change

namespace EoptNetCore_Console
{
    public class U
    {
        public static void WriteLine(string v)
        {
            Debug.WriteLine(v);
            Console.WriteLine(v);
        }

        public static long DateTimeToUnix(DateTime dt)
        {
            TimeSpan timeSpan = dt.ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0);
            return (long)timeSpan.TotalMilliseconds;
        }

        public static DateTime UnixToDateTimeUtc(long unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp / 1000).ToLocalTime();
            return dtDateTime;
        }


        

    }
}
