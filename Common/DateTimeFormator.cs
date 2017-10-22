using System;

namespace TravletAgence.Common
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
                return "9999/99/99";
            }
            catch (Exception)
            {
                return null;
                throw;
            }
            
        }
    }
}