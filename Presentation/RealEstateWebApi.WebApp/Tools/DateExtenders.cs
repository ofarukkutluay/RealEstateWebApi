using System;
namespace RealEstateWebApi.WebApp.Tools
{
	public static class DateExtenders
	{
        public static DateTime UtcToLocalTR(this DateTime utcDateTime)
        {
            //TimeZoneInfo trTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Europe/Istanbul");           
            //return TimeZoneInfo.ConvertTimeFromUtc(UtcDateTime, trTimeZone);
            return utcDateTime.AddHours(3);
        }
    }
}

