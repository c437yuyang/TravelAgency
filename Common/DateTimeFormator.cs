using System;

namespace TravletAgence.Common
{
    public static class DateTimeFormator
    {
        public static string DateTimeToString(DateTime? dateTime)
        {
            try
            {
                DateTime dt = (DateTime)dateTime;
                return dt.ToString("yyyy/MM/dd");
            }
            catch (Exception)
            {
                return null;
                throw;
            }
            
        }
    }
}