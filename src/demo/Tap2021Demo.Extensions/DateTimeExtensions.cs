using System;

namespace Tap2021Demo.Extensions
{
    public static class DateTimeExtensions
    {
        public static string ToIsoShortDate(this DateTime date)
        {
            return date.ToString("yyyy-MM-dd");
        }
    }
}
