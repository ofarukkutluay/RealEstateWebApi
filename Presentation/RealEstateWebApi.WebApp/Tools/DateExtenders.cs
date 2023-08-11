using System;
namespace RealEstateWebApi.WebApp.Tools
{
	public static class DateExtenders
	{
        public static DateTime UtcToLocalTR(this DateTime UtcDateTime)
        {
            TimeZoneInfo trTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Europe/Istanbul");           
            return TimeZoneInfo.ConvertTimeFromUtc(UtcDateTime, trTimeZone);
        }
    }
}

