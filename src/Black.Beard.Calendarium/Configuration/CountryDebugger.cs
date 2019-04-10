using System;
using System.Diagnostics;
using System.Linq;

namespace Bb.Calendarium.Configuration
{


    public enum RuleEnum
    {
        Rule = 1,
        Observed = 2,
        Duration = 4
    }

    public static class CountryDebugger
    {


        public static class AutoStop
        {

            public static RuleEnum Rule { get; set; }

            public static string Country { get; set; }
            public static string DayName { get; set; }
            public static int? Year { get; set; }
            public static DateTime? Date { get; set; }

        }

        internal static DateTime DebugObserved(Func<DateTime, DateTime> function, DateTime date, string country, string dayName, string functionBody)
        {

            string context = $"Rule Observed : {country.ToString()} : {dayName}";

            if (((AutoStop.Rule & RuleEnum.Observed) == RuleEnum.Observed) && CheckStop(country, dayName, date))
                System.Diagnostics.Debugger.Break();

            var result = function(date);
            var datas = "'" + result.ToString("d") + "'";
            string msg = context + " : " + functionBody.Replace("_date_", date.ToString()) + " -> " + datas;
            Trace.WriteLine(msg);

            return result;
        }


        internal static DateTime[] Debug(Func<int, DateTime[]> function, int year, string country, string dayName, string functionBody)
        {

            string context = $"Rule : {country.ToString()} : {dayName}";

            if (((AutoStop.Rule & RuleEnum.Rule) == RuleEnum.Rule) && CheckStop(country, dayName, year))
                System.Diagnostics.Debugger.Break();

            var result = function(year);
            var datas = "'" + string.Join("', '", result.Select(c => c.ToString("d"))) + "'";
            string msg = context + " : " + functionBody.Replace("_year_", year.ToString()) + " -> " + datas;
            Trace.WriteLine(msg);

            return result;
        }

        public static bool CheckStop(string country, string dayName, DateTime date)
        {

            bool t = string.IsNullOrEmpty(CountryDebugger.AutoStop.Country)
                  || !string.IsNullOrEmpty(CountryDebugger.AutoStop.DayName)
                  || CountryDebugger.AutoStop.Date.HasValue;

            if (!t) // Nothing specified = dont't stop
                return false;

            var result = (string.IsNullOrEmpty(CountryDebugger.AutoStop.Country) ? CountryDebugger.AutoStop.Country == country : true)
                    && (!string.IsNullOrEmpty(CountryDebugger.AutoStop.DayName) ? CountryDebugger.AutoStop.DayName == dayName : true)
                    && (CountryDebugger.AutoStop.Date.HasValue ? CountryDebugger.AutoStop.Date == date : true);

            return result;

        }

        public static bool CheckStop(string country, string dayName, int year)
        {

            bool t = string.IsNullOrEmpty(CountryDebugger.AutoStop.Country)
                  || !string.IsNullOrEmpty(CountryDebugger.AutoStop.DayName)
                  || CountryDebugger.AutoStop.Year.HasValue;

            if (!t) // Nothing specified = dont't stop
                return false;

            var result = (string.IsNullOrEmpty(CountryDebugger.AutoStop.Country) ? CountryDebugger.AutoStop.Country == country : true)
                    && (!string.IsNullOrEmpty(CountryDebugger.AutoStop.DayName) ? CountryDebugger.AutoStop.DayName == dayName : true)
                    && (CountryDebugger.AutoStop.Year.HasValue ? CountryDebugger.AutoStop.Year == year : true);

            return result;

        }
    }
}
