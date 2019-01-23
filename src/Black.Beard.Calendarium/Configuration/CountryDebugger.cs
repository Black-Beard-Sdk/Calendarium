using System;
using System.Diagnostics;
using System.Linq;

namespace Bb.Calendarium.Configuration
{

    public static class CountryDebugger
    {


        public static class AutoStop
        {

            public static Country? Country { get; set; }
            public static string DayName { get; set; }
            public static int? Year { get; set; }

        }

        internal static DateTime[] Debug(Func<int, DateTime[]> function, int year, Country country, string dayName, string functionBody)
        {

            string context = $"{country.ToString()} : {dayName}";

            if (CheckStop(country, dayName, year))
                System.Diagnostics.Debugger.Break();

            var result = function(year);
            var datas = "'" + string.Join("', '", result.Select(c => c.ToString("d"))) + "'";
            string msg = context + " : " + functionBody.Replace("_year_", year.ToString()) + " -> " + datas;
            Trace.WriteLine(msg);

            return result;
        }

        public static bool CheckStop(Country country, string dayName, int year)
        {

            bool t = CountryDebugger.AutoStop.Country.HasValue
                  || !string.IsNullOrEmpty(CountryDebugger.AutoStop.DayName)
                  || CountryDebugger.AutoStop.Year.HasValue;

            if (!t) // Nothing specified = dont't stop
                return false;

            var result = (CountryDebugger.AutoStop.Country.HasValue ? CountryDebugger.AutoStop.Country == country : true)
                    && (!string.IsNullOrEmpty(CountryDebugger.AutoStop.DayName) ? CountryDebugger.AutoStop.DayName == dayName : true)
                    &&  (CountryDebugger.AutoStop.Year.HasValue ? CountryDebugger.AutoStop.Year == year : true);

            return result;

        }
    }
}
