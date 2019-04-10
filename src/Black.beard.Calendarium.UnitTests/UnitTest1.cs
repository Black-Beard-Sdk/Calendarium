using Bb.Calendarium.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace Bb.Calendarium.UnitTests
{


    // https://www.citipedia.info/fr/holidays/costa-rica

    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestChecked()
        {

            var dir = new System.IO.DirectoryInfo(Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "..", "Black.Beard.Calendarium", "Countries"));
            var loader = new ConfigurationLoader(dir).Load(); //.Where(c => c.Country == "Algeria").ToArray();

            var result = new System.IO.FileInfo(Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "..", "..", "result.md"));

            //CountryDebugger.AutoStop.Rule = RuleEnum.Observed;
            //CountryDebugger.AutoStop.Country = "Algeria";
            //CountryDebugger.AutoStop.DayName = "Hijri New Year";
            //CountryDebugger.AutoStop.Year = 2013;

            var cal = CalendariumConfiguration.GetCalendarium
            (
                loader
            );

            List<string> listErrors = new List<string>();

            StringBuilder sb = new StringBuilder();
            sb.Mark(Mark.H1, "Check configuration result");

            foreach (var item in loader.OfType<CountryConfiguration>())
            {

                sb.Mark(Mark.H2, item.Country);
                sb.AppendLine();

                listErrors.Clear();

                var referential = Helper.Referential[item.Country]
                    .OrderBy(c => c.DayName).ToList();

                if (Check(item.Country, referential, cal, string.Empty, listErrors))
                {
                    if (listErrors.Any())
                    {
                        foreach (var error in listErrors)
                            sb.AppendLine(error);
                    }
                    else
                        sb.AppendLine("all tests are OK");
                }
                else
                    sb.Mark(Mark.Bold, "not implemented");

                sb.MarkHorizontalRule();

            }

            if (result.Exists)
                result.Delete();

            File.AppendAllText(result.FullName, sb.ToString());

        }

        private static bool Check(string country, System.Collections.Generic.List<Referential> referential, CalendariumConfiguration cal, string region, List<string> listErrors)
        {

            if (country != "Algeria")
                return true;

            if (!cal.GetKeys(country).Any())
                return false;

            Trace.WriteLine($"Starting {country.ToString()}");

            var calendar = cal.GetConfigurationByCountry(country)[0].Calendar.GetCalendar();

            foreach (var item in referential)
            {
                item.Date2 = GetExpectedDate(item, calendar);
                if (item.ObservedDate != null)
                    item.ObservedDate.Date2 = GetExpectedDate(item.ObservedDate, calendar);
            }

            foreach (var item in referential.Where(c => c.Reconstitued && c.Date2 == c.ObservedDate.Date2).ToList())
            {
                var it = referential.Where(c => c.DayName == item.DayName && !c.Reconstitued).ToList();
                if (it.Count == 0)
                {

                }
                else
                {
                    var it2 = it.Where(c => c.DayName == item.DayName && !c.Reconstitued).Select(c => ($"{c.Date2.Month}-{c.Date2.Day}")).Distinct().ToList();
                    if (it2.Count == 1)
                        item.Date2 = new DateTime(item.Date2.Year, it[0].Date2.Month, it[0].Date2.Day); //not specify calendar is wrong only if the calendar is not gregorian. 

                    else
                    {

                    }
                }
            }

            var _l2 = referential.OrderBy(c => c.Date2).ToList();

            foreach (var item in _l2)
            {

                var year = item.Date2.Year;
                List<EventDate> dates1 = GetEvents(country, cal, year, CalendarEnum.Default); // flat list
                List<EventDate> dates = GetEvents(dates1, item.DayName);

                if (dates.Count == 0)
                    listErrors.Add($"failed on '{item.DayName.Mark(Mark.Bold)}' expected : {item.Date2.ToString("D")} missing day\r\n");

                else
                {

                    var date = dates.FirstOrDefault(c => c.Date == item.Date2);
                    if (date == null)
                    {

                        if (CountryDebugger.CheckStop(country, item.DayName, item.Date2.Year))
                            System.Diagnostics.Debugger.Break();

                        if (dates.Count == 1)
                            listErrors.Add($"failed on '{item.DayName}' expected : {item.Date2.ToString("D")} and computed : {dates[0].Date.ToString("D")}\r\n");

                        else
                        {

                        }

                    }
                    else
                    {
                        var date1 = dates[0];

                        if (item.ObservedDate != null)
                        {
                            if (date1.Observed.OriginalDate.Date != item.ObservedDate.Date2.Date)
                                listErrors.Add($"failed match observed date on '{item.DayName}' expected : {item.ObservedDate.Date2.ToString("D")} and computed :  {date1.Observed.ToString("D")}\r\n");

                        }
                        else if (date1.Observed != null && date1.Observed.OriginalDate.Date.Date != date1.Date.OriginalDate.Date)
                            listErrors.Add($"missing observed date in expected referential on '{item.DayName}' computed : {date1.Observed.ToString("D")}\r\n");

                    }
                }

            }

            return true;

        }

        private static DateTime GetExpectedDate(Referential item, Calendar calendar)
        {

            var u3 = item.Date.Split('-');
            var year = int.Parse(u3[0]);
            var month = int.Parse(u3[1]);
            var day = int.Parse(u3[2]);


            if (!(calendar is GregorianCalendar))
            {
                if (year > 2010 && year < 2050)
                    calendar = new GregorianCalendar();
            }

            DateTime expected;
            try
            {
                expected = new DateTime(year, month, day, calendar);
            }
            catch (Exception)
            {
                throw;
            }

            return expected;

        }

        private static List<EventDate> GetEvents(string country, CalendariumConfiguration calculated, int year, CalendarEnum calendar = CalendarEnum.Default)
        {

            var dates = calculated.GetDates(year, country, calendar);
            List<EventDate> _events = new List<EventDate>();
            foreach (var _date in dates)
                foreach (var _event in _date.Value.Events)
                    _events.Add(_event);
            return _events.OrderBy(c => c.Date.OriginalDate).ThenByDescending(c => c.Name).ToList();

        }

        private static List<EventDate> GetEvents(List<EventDate> items, string dayName)
        {
            List<EventDate> _events = new List<EventDate>();
            foreach (var _date in items)
                if (_date.Name == dayName)
                    _events.Add(_date);
            return _events;
        }

    }
}
