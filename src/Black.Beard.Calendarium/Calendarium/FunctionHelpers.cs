﻿using System;
using System.Collections.Generic;
using System.Globalization;

namespace Bb.Calendarium
{

    internal static class FunctionHelpers
    {

        public static bool EvaluateDayweek(DateTime self, DayOfWeek[] dayOfweeks)
        {

            foreach (var dayOfweek in dayOfweeks)
                if (self.DayOfWeek == dayOfweek)
                    return true;

            return false;

        }

        public static DateTime Translate(this DateTime self, Calendar calendar)
        {
            var day = calendar.GetDayOfMonth(self);
            var month = calendar.GetMonth(self);
            var year = calendar.GetYear(self);
            var date = new DateTime(year, month, day, calendar);
            return date;
        }

        public static DateTime Back(DateTime date, DayOfWeek day)
        {

            var d = new DateTime(date.Year, date.Month, date.Day);

            while (d.DayOfWeek != day)
                d = d.AddDays(-1);

            return d;

        }

        public static DateTime[] Backs(DateTime[] dates, DayOfWeek day)
        {

            List<DateTime> result = new List<DateTime>();

            foreach (var date in dates)
                result.Add(Back(date, day));

            return result.ToArray();

        }

        public static DateTime Next(DateTime date, DayOfWeek day)
        {

            while (date.DayOfWeek != day)
                date = date.AddDays(1);

            return date;

        }

        public static DateTime[] Nexts(DateTime[] dates, DayOfWeek day)
        {

            List<DateTime> result = new List<DateTime>();

            foreach (var date in dates)
                result.Add(Next(date, day));

            return result.ToArray();

        }

        public static DateTime[] OrthodoxEaster(int year)
        {
            return new DateTime[] { EasterHelper.OrthodoxEasterDate(year) };
        }

        public static DateTime[] Easter(int year)
        {
            return new DateTime[] { EasterHelper.EasterDate(year) };
        }

        public static DateTime AddDay(DateTime date, int days)
        {
            return date.AddDays(days);
        }

        public static DateTime[] AddDays(DateTime[] dates, int days)
        {
            List<DateTime> _result = new List<DateTime>();

            foreach (var item in dates)
                _result.Add(item.AddDays(days));

            return _result.ToArray();
        }

        public static DateTime[] Mask(int year, int month, int day, Calendar calendar)
        {
            return new DateTime[] { new DateTime(year, month, day, calendar) };
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

    }

}
