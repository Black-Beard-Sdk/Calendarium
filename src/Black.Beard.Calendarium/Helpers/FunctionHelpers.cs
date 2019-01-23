using System;
using System.Collections.Generic;
using System.Globalization;

namespace Bb.Calendarium.Helpers
{

    internal static class FunctionHelpers
    {

        public static DateTime Translate(this DateTime self, Calendar calendar)
        {
            var date = new DateTime(calendar.GetYear(self), calendar.GetMonth(self), calendar.GetDayOfMonth(self));
            return date;
        }

        public static DateTime[] Back(DateTime[] dates, DayOfWeek day)
        {

            List<DateTime> result = new List<DateTime>();

            foreach (var date in dates)
            {

                var d = new DateTime(date.Year, date.Month, date.Day);

                while (d.DayOfWeek != day)
                    d = d.AddDays(-1);

                result.Add(d);

            }

            return result.ToArray();


        }

        public static DateTime[] Next(DateTime[] dates, DayOfWeek day)
        {

            List<DateTime> result = new List<DateTime>();

            foreach (var date in dates)
            {
                var d = new DateTime(date.Year, date.Month, date.Day);

                while (d.DayOfWeek != day)
                    d = d.AddDays(1);

                result.Add(d);

            }
            return result.ToArray();
        }

        public static DateTime[] Easter(int year)
        {
            return new DateTime[] { EasterHelper.EasterDate(year) };
        }
        public static DateTime[] AddDays(DateTime[] dates, int days)
        {
            List<DateTime> _result = new List<DateTime>();

            foreach (var item in dates)
                _result.Add(item.AddDays(days));

            return _result.ToArray();
        }

        public static DateTime[] Mask(int year, int month, int day)
        {
            return new DateTime[] { new DateTime(year, month, day) };
        }

        public static DateTime[] DayOfWeek(int year, DayOfWeek dayWeek)
        {

            List<DateTime> _dates = new List<DateTime>();

            var date = new DateTime(year, 1, 1);
            for (int i = 0; i < 365; i++)
            {

                if (date.Year != year) // Bisextil
                    break;

                if (date.DayOfWeek == dayWeek)
                    _dates.Add(date);

                date = date.AddDays(1);

            }

            return _dates.ToArray();

        }

        //public static bool IsPrayerandRepentance(DateTime date)
        //{

        //    var d = new DateTime(date.Year, 11, 23);

        //    while (d.DayOfWeek == DayOfWeek.Wednesday)
        //        d.AddDays(-1);

        //    return date == d;
        //}

        //public static bool IsAscension(DateTime date)
        //{
        //    return date == Get(date).Ascension;
        //}

        //public static bool IsEaster(DateTime date)
        //{
        //    return date == Get(date).EasterDate;
        //}

        //public static bool IsEasterMonday(DateTime date)
        //{
        //    return date == Get(date).EasterMonday;
        //}

        //public static bool IsGoodFriday(DateTime date)
        //{
        //    return date == Get(date).GoodFriday;
        //}

        //public static bool IsPentecostSunday(DateTime date)
        //{
        //    return date == Get(date).PentecostSunday;
        //}

        //public static bool IsWhitMonday(DateTime date)
        //{
        //    return date == Get(date).WhitMonday;
        //}

        //private static EasterBlock Get(DateTime date)
        //{
        //    return new EasterBlock(date.Year);
        //}

        //public static bool MaskMatch(DateTime date, int month, int day)
        //{

        //    if (month != date.Month || day != date.Day)
        //        return false;

        //    return true;

        //}


        //public static bool IsDayOfWeek(DateTime date, DayOfWeek dayWeek)
        //{
        //    return date.DayOfWeek == dayWeek;
        //}

    }

}
