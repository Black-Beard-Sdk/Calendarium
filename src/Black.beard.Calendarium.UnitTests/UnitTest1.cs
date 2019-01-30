using Bb.Calendarium.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace Bb.Calendarium.UnitTests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestChecked()
        {

            var dir = new System.IO.DirectoryInfo(Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "..", "Black.Beard.Calendarium", "Countries"));
            var loader = new ConfigurationLoader(dir).Load();
            
            var result = new System.IO.FileInfo(Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "..", "..", "result.md"));

            //CountryDebugger.AutoStop.Country = Country.Ecuador ;
            //CountryDebugger.AutoStop.DayName = ;
            //CountryDebugger.AutoStop.Year = ;

            var cal = CalendariumConfiguration.GetCalendarium
            (
                loader
            );

            List<string> listErrors = new List<string>();

            StringBuilder sb = new StringBuilder();
            sb.Mark(Mark.H1, "Check configuration result");

            foreach (var item in loader.OfType<CountryConfiguration>())
            {

                sb.Mark(Mark.H2, item.Country.ToString());
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

        private static bool Check(Country country, System.Collections.Generic.List<Referential> referential, CalendariumConfiguration cal, string region, List<string> listErrors)
        {

            if (!cal.GetKeys(country).Any())
                return false;

            var calendar = cal.GetConfigurationByCountry(country)[0].Calendar.GetCalendar();

            List<Referential> _lObserved = referential.Where(c => c.Observed).ToList();
            List<Referential> _l2 = referential.Where(c => !c.Observed).ToList();

            foreach (var item in referential)
                item.Date2 = GetExpectedDate(item, calendar);

            foreach (var item in _lObserved)
            {
                var d = _l2.FirstOrDefault(c => c.DayName.ToLower().Replace("day", "").Trim() == item.DayName.ToLower().Replace("day", "").Trim() && c.Date2.Year == item.Date2.Year);
                if (d != null)
                    d.ObservedDate = item;
                else
                {


                }
            }


            _l2 = _l2.OrderBy(c => c.Date2).ToList();

            foreach (var item in _l2)
            {

                var year = item.Date2.Year;
                List<EventDate> dates1 = GetEvents(country, cal, year, CalendarEnum.Default);
                List<EventDate> dates = GetEvents(dates1, item.DayName);

                if (dates.Count == 0)
                    listErrors.Add($"failed on '{item.DayName.Mark(Mark.Bold)}' expected : {item.Date2.ToString("d")} missing day\r\n");

                else
                {

                    var date = dates.FirstOrDefault(c => c.Date == item.Date2);
                    if (date == null)
                    {

                        if (CountryDebugger.CheckStop(country, item.DayName, item.Date2.Year))
                            System.Diagnostics.Debugger.Break();

                        if (dates.Count == 1)
                            listErrors.Add($"failed on '{item.DayName}' expected : {item.Date2.ToString("d")} and computed : {dates[0].Date.ToString("d")}\r\n");

                        else
                        {

                        }

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

        private static List<EventDate> GetEvents(Country country, CalendariumConfiguration cal, int year, CalendarEnum calendar = CalendarEnum.Default)
        {
            var dates = cal.GetDates(year, country, calendar);
            List<EventDate> _events = new List<EventDate>();
            foreach (var _date in dates)
                foreach (var _event in _date.Value.Events)
                    _events.Add(_event);
            return _events.OrderBy(c => c.Date).ThenByDescending(c => c.Name).ToList();
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
