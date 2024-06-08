using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_Shop.Services.Helper
{
    public static class BdDateTime
    {
        public static DateTime Now()
        {
            TimeZoneInfo tst = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
            var offset = new DateTimeOffset(DateTime.UtcNow);
            return offset.AddHours(6).DateTime;
        }

        public static DateTime Today()
        {
            TimeZoneInfo tst = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
            var offset = new DateTimeOffset(DateTime.UtcNow);
            return offset.AddHours(6).DateTime.Date;
        }

        public static DateTime FirstDayOfCurrentMonth()
        {
            var now = Now();
            return new DateTime(now.Year, now.Month, 1);
        }

        public static DateTime FirstDayOfMonth(DateTime date)
        {
            return new DateTime(date.Year, date.Month, 1);
        }

        public static DateTime LastDayOfCurrentMonth()
        {
            var now = Now();
            return new DateTime(now.Year, now.Month, 1).AddMonths(1).AddMilliseconds(-1);
        }

        public static DateTime LastDayOfMonth(DateTime date)
        {
            return new DateTime(date.Year, date.Month, 1).AddMonths(1).AddMilliseconds(-1);
        }

        public static int CurrentMonthNoOfDays()
        {
            return DateTime.DaysInMonth(Today().Year, Today().Month);
        }

        public static int DaysInMonth(int year, int month)
        {
            if (month > 12)
            {
                month = 1;
                year += 1;
            }
            return DateTime.DaysInMonth(year, month);
        }

        public static int GetNoOfDaysInMonthForGivenDate(DateTime date)
        {
            return DateTime.DaysInMonth(date.Year, date.Month); ;
        }

        public static DateTime ToDate(DateTime dateTime)
        {
            return dateTime.AddDays(1).AddMilliseconds(-5);
        }

        public static string UnlimitedDateString()
        {
            var vipExDate = new DateTime(9999, 12, 31);
            return vipExDate.ToString("dd/MM/yyyy");
        }

        public static string UnlimitedSQLDateString()
        {
            var vipExDate = new DateTime(9999, 12, 31);
            return vipExDate.ToString("yyyy-MM-dd HH:mm:ss.fff");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date">Format yyyy-MM-dd</param>
        /// <returns></returns>
        public static DateTime ConvertStringToDateForAccounting(string dateString)
        {
            return DateTime.ParseExact(dateString, "yyyy-MM-dd", CultureInfo.InvariantCulture);
        }
        public static DateTime ConvertStringToDate(string dateString)
        {
            return DateTime.ParseExact(dateString, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        }
    }
}
