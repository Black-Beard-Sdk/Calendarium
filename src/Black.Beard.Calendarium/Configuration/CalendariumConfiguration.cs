using Bb.Calendarium.Helpers;
using System;
using System.Collections.Generic;
using System.Globalization;

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
        public (Country, string)[] GetKeys(Country country = Country.Undefined)
        {

            List<(Country, string)> _items = new List<(Country, string)>();

            foreach (var item in _dicRules)
            {
                var k = item.Key.Split('-');

                var _country = Enum.Parse<Country>(k[0]);

                if (country == Country.Undefined || country == _country)
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
        public Dictionary<DateTime, IdentifiedDate> GetNextDates(DateTime date, Country country, int countDays = 365, params string[] regions)
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
                        var dic = GetDates(_date, country, region);
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
        public IdentifiedDate GetDate(DateTime date, Country country, string region)
        {
            var dates = GetDates(date, country, region);
            dates.TryGetValue(date, out IdentifiedDate _date);
            return _date;
        }

        /// <summary>
        /// return all dates info specified year date and region
        /// </summary>
        /// <param name="date"></param>
        /// <param name="country"></param>
        /// <param name="region"></param>
        /// <returns></returns>
        public IDictionary<DateTime, IdentifiedDate> GetDates(DateTime date, Country country, string region)
        {

            string key = country.ToString();
            if (!string.IsNullOrEmpty(region))
                key += "-" + region;

            (int, string) k = (date.Year, key);
            if (!_dicDates.TryGetValue(k, out Dictionary<DateTime, IdentifiedDate> dates))
                lock (_lock)
                    if (!_dicDates.TryGetValue(k, out dates))
                    {

                        dates = new Dictionary<DateTime, IdentifiedDate>();
                        Build(dates, key, date, country, region);
                        _dicDates.Add(k, dates);

                    }

            Dictionary<DateTime, IdentifiedDate> result = new Dictionary<DateTime, IdentifiedDate>();
            foreach (var item in dates)
                result.Add(item.Key, item.Value);

            return result;

        }

        /// <summary>
        /// return all dates info specified year date
        /// All region of the country are merged
        /// </summary>
        /// <param name="date"></param>
        /// <param name="country"></param>
        /// <param name="region"></param>
        /// <returns></returns>

        public IDictionary<DateTime, IdentifiedDate> GetDates(DateTime date, Country country)
        {

            var keys = GetKeys(country);

            Dictionary<DateTime, IdentifiedDate> result = new Dictionary<DateTime, IdentifiedDate>();

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
                            Build(dates, key, date, country, item.Item2);
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
        private void Build(Dictionary<DateTime, IdentifiedDate> dates, string key, DateTime date, Country country, string region)
        {

            var calReference = CultureInfo.CurrentCulture.Calendar;

            if (_dicRules.TryGetValue(key, out List<PeriodConfiguration> periodConfigurations)) // Fetch rules
                foreach (var periodConfiguration in periodConfigurations)
                {

                    if (periodConfiguration.YearStart.HasValue && periodConfiguration.YearStart.Value <= date.Year)
                        continue;

                    if (periodConfiguration.YearEnd.HasValue && periodConfiguration.YearEnd.Value >= date.Year)
                        continue;

                    var cal = periodConfiguration.CalendarInstance;
                    var _dates = periodConfiguration.RuleFunction(cal.GetYear(date));

                    foreach (var _date in _dates)
                    {

                        var d = _date.Translate(calReference);

                        if (!dates.TryGetValue(d, out IdentifiedDate idate))
                            dates.Add(d, (idate = new IdentifiedDate()
                            {
                                Date = d,
                            }));

                        var e = new EventDate()
                        {
                            Name = periodConfiguration.Name,
                            Free = periodConfiguration.Free,
                            Date = _date.Date.Translate(cal),
                            Culture = periodConfiguration.CultureInfo.IetfLanguageTag,
                            Country = country,
                            Region = region ?? string.Empty,
                            Calendar = cal,
                        };

                        e.Observed = periodConfiguration.RuleObservedFunction != null
                            ? periodConfiguration.RuleObservedFunction(date.Date)
                            : e.Date;

                        e.DateEnd = periodConfiguration.RuleDurationFunction != null
                            ? periodConfiguration.RuleDurationFunction(date.Date)
                            : e.Date;

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
