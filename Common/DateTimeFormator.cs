using System;
using System.Globalization;

namespace TravelAgency.Common
{
    public static class DateTimeFormator
    {
        public static string DateTimeToString(DateTime? dateTime)
        {
            try
            {
                if (dateTime != null)
                {
                    DateTime dt = (DateTime)dateTime;
                    return dt.ToString("yyyy/MM/dd");
                }
                return "";
            }
            catch (Exception)
            {
                return null;
                throw;
            }
            
        }

        public static string DateTimeToStringOfThailand(DateTime? dateTime)
        {
            try
            {
                if (dateTime != null)
                {
                    DateTime dt = (DateTime)dateTime;
                    return dt.ToString("dd-MMM-yyyy", new CultureInfo("en-US"));
                    //return dt.ToString("yy");
                }
                return "";
            }
            catch (Exception)
            {
                return null;
                throw;
            }

        }

        public static string DateTimeToStringOfChinese(DateTime? dateTime)
        {
            try
            {
                if (dateTime != null)
                {
                    DateTime dt = (DateTime)dateTime;
                    return dt.ToString("yyyy年MM月dd日");
                    //return dt.ToString("yy");
                }
                return "";
            }
            catch (Exception)
            {
                return null;
                throw;
            }

        }

        public static  DateTime GetNextWorkDate(DateTime time)
        {
            if (time.DayOfWeek == DayOfWeek.Saturday)
            {
              return  time.AddDays((double) 2);
            }
            if (time.DayOfWeek == DayOfWeek.Sunday)
            {
               return time.AddDays((double) 1);
            }
            return time;
        }

    }
}