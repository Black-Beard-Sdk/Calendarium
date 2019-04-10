using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Bb.Calendarium.Configuration
{
    public class CalendariumConfiguration : List<CountryConfiguration>
    {

        private CalendariumConfiguration()
        {
            Defaults = new List<DefaultCountryConfiguration>();
        }


        public static CalendariumConfiguration GetCalendarium(params DefaultCountryConfiguration[] defaults)
        {

            CalendariumConfiguration countries = new CalendariumConfiguration();

            foreach (var item in defaults)
                if (item is CountryConfiguration country)
                    countries.Add(country);
                else
                    countries.Defaults.Add(item);

            countries.Initialize();

            return countries;

        }

        private void Initialize()
        {
            ConfigurationEvaluatorVisitor config = new ConfigurationEvaluatorVisitor();
            _dicDates = new Dictionary<(int, string), Dictionary<DateTime, IdentifiedDate>>();
            _dicRules = config.Parse(this);

            var keys = GetKeys();

            DateTime date = DateTime.Now;
            foreach (var item in keys)
                GetDate(date, item.Item1, item.Item2);

        }

        /// <summary>
        /// Return the list keys registered
        /// </summary>
        /// <param name="country">can restrict key form specified country</param>
        /// <returns></returns>
        public CountryConfiguration[] GetConfigurationByCountry(string country)
        {
            return this.Where(c => c.Country == country).ToArray();
        }

        /// <summary>
        /// Return the list keys registered
        /// </summary>
        /// <param name="country">can restrict key form specified country</param>
        /// <returns></returns>
        public (string, string)[] GetKeys(string country = "Undefined")
        {

            List<(string, string)> _items = new List<(string, string)>();

            foreach (var item in _dicRules)
            {

                var k = item.Key.Split('-');
                string _country = k[0];

                if (country == "Undefined" || country == _country)
                {
                    if (k.Length == 1)
                        _items.Add((_country, string.Empty));
                    else
                        _items.Add((_country, k[1]));
                }

            }

            return _items.ToArray();

        }

        /// <summary>
        /// return the list of identified date for next countDays specified
        /// </summary>
        /// <param name="date"></param>
        /// <param name="country">specify country</param>
        /// <param name="region"></param>
        /// <param name="countDays"></param>
        /// <returns></returns>
        public Dictionary<DateTime, IdentifiedDate> GetNextDates(DateTime date, string country, int countDays = 365, params string[] regions)
        {

            var _regions = new List<string>(regions);
            if (_regions.Count == 0)
                _regions.Add(string.Empty);

            var list = new Dictionary<DateTime, IdentifiedDate>();
            int year = 0;

            foreach (var region in _regions)
            {

                var _date = date;
                var _max = date.AddDays(countDays);
                while (_date <= _max)
                {
                    if (_date.Year != year)
                    {
                        var dic = GetDates(_date.Year, country, region);
                        foreach (var item in dic)
                            if (item.Key <= _max)
                                if (!list.TryGetValue(item.Key, out IdentifiedDate dd))
                                    list.Add(item.Key, item.Value.Clone());
                                else
                                    dd.Merge(item.Value);

                        year = _date.Year;
                    }
                    _date = _date.AddDays(1);
                }

            }

            return list;

        }

        /// <summary>
        /// Return infos on the specified date
        /// </summary>
        /// <param name="date"></param>
        /// <param name="country"></param>
        /// <param name="region"></param>
        /// <returns></returns>
        public IdentifiedDate GetDate(DateTime date, string country, string region)
        {
            var dates = GetDates(date.Year, country, region);
            dates.TryGetValue(date, out IdentifiedDate _date);
            return _date;
        }

        /// <summary>
        /// Return infos on the specified date without manage region
        /// </summary>
        /// <param name="date"></param>
        /// <param name="country"></param>
        /// <returns></returns>
        public IdentifiedDate GetDate(DateTime date, string country)
        {
            var keys = GetKeys(country);
            foreach (var item in keys)
            {
                var dates = GetDates(date.Year, country, item.Item2);
                if (dates.TryGetValue(date, out IdentifiedDate _date))
                    return _date;
            }

            return null;

        }

        /// <summary>
        /// return all dates info specified year date and region
        /// </summary>
        /// <param name="date"></param>
        /// <param name="country"></param>
        /// <param name="region"></param>
        /// <returns></returns>
        public IDictionary<DateTime, IdentifiedDate> GetDates(int year, string country, string region)
        {

            string key = country.ToString();
            if (!string.IsNullOrEmpty(region))
                key += "-" + region;

            (int, string) k = (year, key);
            if (!_dicDates.TryGetValue(k, out Dictionary<DateTime, IdentifiedDate> dates))
                lock (_lock)
                    if (!_dicDates.TryGetValue(k, out dates))
                    {

                        dates = new Dictionary<DateTime, IdentifiedDate>();
                        Build(dates, key, year, country, region);
                        _dicDates.Add(k, dates);

                    }

            Dictionary<DateTime, IdentifiedDate> result = new Dictionary<DateTime, IdentifiedDate>();
            foreach (var item in dates)
                result.Add(item.Key, item.Value);

            return result;

        }

        /// <summary>
        /// return all dates info for specified year date
        /// All region of the country are merged
        /// </summary>
        /// <param name="date"></param>
        /// <param name="country"></param>
        /// <param name="region"></param>
        /// <returns></returns>

        /// <summary>
        /// return all dates info for specified year date
        /// All region of the country are merged
        /// </summary>
        /// <param name="date"></param>
        /// <param name="country"></param>
        /// <param name="region"></param>
        /// <returns></returns>

        public IDictionary<DateTime, IdentifiedDate> GetDates(int year, string country, CalendarEnum calendar = CalendarEnum.Default)
        {

            var keys = GetKeys(country);

            Dictionary<DateTime, IdentifiedDate> result = new Dictionary<DateTime, IdentifiedDate>();
            var date = new DateTime(year, 1, 1, calendar.GetCalendar());

            foreach (var item in keys)
            {

                string key = country.ToString();
                if (!string.IsNullOrEmpty(item.Item2))
                    key += "-" + item.Item2;

                (int, string) k = (date.Year, key);
                if (!_dicDates.TryGetValue(k, out Dictionary<DateTime, IdentifiedDate> dates))
                    lock (_lock)
                        if (!_dicDates.TryGetValue(k, out dates))
                        {
                            dates = new Dictionary<DateTime, IdentifiedDate>();
                            Build(dates, key, date.Year, country, item.Item2);
                            _dicDates.Add(k, dates);
                        }

                foreach (var _date in dates)
                {
                    if (!result.TryGetValue(_date.Key, out IdentifiedDate d))
                        result.Add(_date.Key, _date.Value.Clone());
                    else
                        _date.Value.Merge(_date.Value);

                }
            }

            return result;

        }

        /// <summary>
        /// Build
        /// </summary>
        /// <param name="dates"></param>
        /// <param name="key"></param>
        /// <param name="date"></param>
        /// <param name="country"></param>
        /// <param name="region"></param>
        private void Build(Dictionary<DateTime, IdentifiedDate> dates, string key, int year, string country, string region)
        {

            var calReference = CultureInfo.CurrentCulture.Calendar;

            if (_dicRules.TryGetValue(key, out List<PeriodConfiguration> periodConfigurations)) // Fetch rules
                foreach (var periodConfiguration in periodConfigurations)
                {

                    if (periodConfiguration.YearStart.HasValue && year <= periodConfiguration.YearStart.Value)
                        continue;

                    if (periodConfiguration.YearEnd.HasValue && year >= periodConfiguration.YearEnd.Value)
                        continue;

                    var cal = periodConfiguration.CalendarInstance;

                    int year2 = year;
                    bool toTranslate = false;
                    if (cal.GetType() != calReference.GetType())    // calendar from caller != from calendar's rule
                    {
                        var d1 = new DateTime(year, 2, 3, calReference);
                        year2 = periodConfiguration.CalendarInstance.GetYear(d1);
                        toTranslate = true;
                    }

                    var _dates = periodConfiguration.RuleFunction(year2);

                    foreach (var _date in _dates)
                    {

                        var d = toTranslate
                            ? _date.Translate(calReference)
                            : _date;

                        if (!dates.TryGetValue(d, out IdentifiedDate idate))
                            dates.Add(d, (idate = new IdentifiedDate()
                            {
                                Date = d,
                            }));

                        var c = periodConfiguration.Calendar.GetCalendar();

                        var e = new EventDate()
                        {

                            Name = periodConfiguration.Name,
                            Free = periodConfiguration.Free,
                            Date = new Date( _date, c, calReference),
                            Culture = periodConfiguration.CultureInfo.IetfLanguageTag,
                            Country = country,
                            Region = region ?? string.Empty,
                            CalendarUsedToBuild = cal,

                        };

                        var observed = periodConfiguration.RuleObservedFunction != null
                            ? periodConfiguration.RuleObservedFunction(e.Date.OriginalDate)
                            : e.Date.OriginalDate;
                        e.Observed = new Date(observed, c, calReference);

                        var dateEnd = periodConfiguration.RuleDurationFunction != null
                            ? periodConfiguration.RuleDurationFunction(e.Date.OriginalDate)
                            : e.Date.OriginalDate;
                        e.DateEnd = new Date(dateEnd, c, calReference);

                        e.Translations.AddRange(periodConfiguration.Translations);

                        idate.Events.Add(e);

                    }

                }

        }

        private void Build(IdentifiedDate date, string key)
        {
            if (_dicRules.TryGetValue(key, out List<PeriodConfiguration> periodConfigurations))
                foreach (var periodConfiguration in periodConfigurations)
                {
                    var d = date.Date;
                    var g = periodConfiguration.RuleFunction(d.Year);
                    //     Append(periodConfiguration, date);
                }
        }

        public List<DefaultCountryConfiguration> Defaults { get; set; }


        private Dictionary<string, List<PeriodConfiguration>> _dicRules;
        private Dictionary<(int, string), Dictionary<DateTime, IdentifiedDate>> _dicDates;
        private readonly object _lock = new object();

    }

}
