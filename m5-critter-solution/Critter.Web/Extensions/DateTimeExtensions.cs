using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Critter.Web.Extensions
{
    public static class DateTimeExtensions
    {
        public static string TimeAgo(this DateTime dt)
        {
            TimeSpan timeSince = DateTime.Now.Subtract(dt);

            if (timeSince.TotalMilliseconds < 1)
                return "not yet";
            if (timeSince.TotalMinutes < 1)
                return "just now";
            if (timeSince.TotalMinutes < 2)
                return "1 minute ago";
            if (timeSince.TotalMinutes < 60)
                return $"{timeSince.Minutes} minutes ago";
            if (timeSince.TotalMinutes < 120)
                return "1 hour ago";
            if (timeSince.TotalHours < 24)
                return $"{timeSince.Hours} hours ago";
            if (timeSince.TotalDays < 2)
                return "yesterday";
            if (timeSince.TotalDays < 7)
                return $"{timeSince.Days} days ago";
            if (timeSince.TotalDays < 14)
                return "last week";
            if (timeSince.TotalDays < 21)
                return "2 weeks ago";
            if (timeSince.TotalDays < 28)
                return "3 weeks ago";
            if (timeSince.TotalDays < 60)
                return "last month";
            if (timeSince.TotalDays < 365)
                return $"{Math.Round(timeSince.TotalDays / 30)} months ago";
            if (timeSince.TotalDays < 730)
                return "last year"; //last but not least...

            return $"{Math.Round(timeSince.TotalDays / 365)} years ago";
        }
    }
}