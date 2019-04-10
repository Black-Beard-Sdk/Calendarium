using System;
using System.Globalization;
using System.Text;

namespace Bb.Calendarium
{

    internal static class EasterHelper
    {

                /// <summary>
        /// Algorithm for calculating the date of Easter Sunday
        /// (Meeus/Jones/Butcher Gregorian algorithm)
        /// https://en.wikipedia.org/wiki/Computus#Meeus.2FJones.2FButcher_Gregorian_algorithm
        /// A valid julian year
        /// Easter Sunday
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns></returns>
        public static DateTime OrthodoxEasterDate(int year)
        {
            int a = year % 4;
            int b = year % 7;
            int c = year % 19;
            int d = ((19*c) +15) % 30;
            int e = (((2 * a) + (4 * b)) - d + 34) % 7;
            int month = (d + e + 114) / 31;
            int day = ((d + e + 114) % 31) + 1;
            DateTime dt = new DateTime(year, month, day, new JulianCalendar());
            return dt;
        }


        /// <summary>
        /// Algorithm for calculating the date of Easter Sunday
        /// (Meeus/Jones/Butcher Gregorian algorithm)
        /// http://en.wikipedia.org/wiki/Computus#Meeus.2FJones.2FButcher_Gregorian_algorithm
        /// A valid Gregorian year
        /// Easter Sunday
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns></returns>
        public static DateTime EasterDate(int year)
        {
            int a = year % 19;
            int b = year / 100;
            int c = year % 100;
            int d = b / 4;
            int e = b % 4;
            int f = (b + 8) / 25;
            int g = (b - f + 1) / 3;
            int h = (19 * a + b - d - g + 15) % 30;
            int i = c / 4;
            int k = c % 4;
            int L = (32 + 2 * e + 2 * i - h - k) % 7;
            int m = (a + 11 * h + 22 * L) / 451;
            int month = (h + L - 7 * m + 114) / 31;
            int day = ((h + L - 7 * m + 114) % 31) + 1;
            DateTime dt = new DateTime(year, month, day, new GregorianCalendar());
            return dt;
        }
      
    }
}
