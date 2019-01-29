using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Bb.Calendarium.Configuration
{

    internal class ConfigurationEvaluatorVisitor
    {

        public ConfigurationEvaluatorVisitor()
        {
            _parser = new CalendriumParser(null, null);
            _dic = new Dictionary<string, List<PeriodConfiguration>>();
        }

        internal Dictionary<string, List<PeriodConfiguration>> Parse(CalendariumConfiguration countries)
        {

            _defaults = countries.Defaults.ToDictionary(c => c.Name);

            foreach (var country in countries)
                Parse(country);

            return _dic;

        }

        private void Parse(CountryConfiguration country)
        {

            CultureInfo culture = System.Threading.Thread.CurrentThread.CurrentCulture;

            if (!string.IsNullOrEmpty(country.Culture))
                culture = country.GetCulture();

            // Append defaults dates
            if (!string.IsNullOrEmpty(country.Defaults))
            {

                var defaults = country.Defaults.Split(',').Select(c => c.Trim()).Where(c => !string.IsNullOrEmpty(c)).ToArray();
                foreach (var defaultName in defaults)
                {

                    var dd = _defaults[defaultName];

                    CultureInfo culture2 = culture;
                    if (!string.IsNullOrEmpty(dd.Culture))
                        culture2 = dd.GetCulture();

                    var list1 = ParsePeriods(dd.Periods, culture2, country.Calendar, country.Country, null);

                    foreach (var period in list1)
                        period.Tags.Add(defaultName);

                }
            }

            // Add country dates

            var list = ParsePeriods(country.Periods, culture, country.Calendar, country.Country, null);


            Dictionary<string, RegionConfiguration> _reg = new Dictionary<string, RegionConfiguration>();
            foreach (var region in country.Regions)
            {
                var list2 = ParsePeriods(region.Periods, culture, country.Calendar, country.Country, region.Key);
                list2.AddRange(list);
                _reg.Add(region.Key, region);
            }

            foreach (var region in country.Regions)
                if (!string.IsNullOrEmpty(region.From))
                    ParsePeriods(_reg[region.From].Periods, culture, country.Calendar, country.Country, region.Key);

        }

        private List<PeriodConfiguration> ParsePeriods(List<PeriodConfiguration> periods, CultureInfo culture, CalendarEnum calendar, Country country, string key)
        {

            List<PeriodConfiguration> list;
            var _calendar = calendar.GetCalendar(culture);

            if (string.IsNullOrEmpty(key))
                list = GetList(country.ToString());
            else
                list = GetList($"{country.ToString()}-{key}");

            foreach (var periodReference in periods)
            {

                if (periodReference.RuleDate != null && periodReference.RuleFunction == null)
                    periodReference.RuleFunction = _parser.ParseRuleString(periodReference.RuleDate.ToUpper(), periodReference.Name, country, _calendar);

                if (periodReference.RuleDuration != null && periodReference.RuleDurationFunction == null)
                {
                    if (System.Diagnostics.Debugger.IsAttached)
                        System.Diagnostics.Debugger.Break();
                    //periodReference.RuleDurationFunction = _parser.ParseRuleString(periodReference.RuleDuration.ToUpper());
                }

                if (periodReference.RuleObserved != null && periodReference.RuleObservedFunction == null)
                {
                    if (System.Diagnostics.Debugger.IsAttached)
                        System.Diagnostics.Debugger.Break();
                    //periodReference.RuleObservedFunction = _parser.ParseRuleString(periodReference.RuleObserved.ToUpper());
                }

                var newPeriod = periodReference.Clone();

                newPeriod.CultureInfo = culture;

                if (newPeriod.Calendar != CalendarEnum.Default)
                    newPeriod.Calendar = calendar;

                list.Add(newPeriod);

            }

            return list;

        }

        private List<PeriodConfiguration> GetList(string key)
        {
            if (!_dic.TryGetValue(key, out List<PeriodConfiguration> list))
                _dic.Add(key, list = new List<PeriodConfiguration>());
            return list;
        }

        private readonly CalendriumParser _parser;
        private readonly Dictionary<string, List<PeriodConfiguration>> _dic;
        private Dictionary<string, DefaultCountryConfiguration> _defaults;
    }

}

/*
 
    GregorianCalendar

    HebrewCalendar    
    UmAlQuraCalendar
    
    EastAsianLunisolarCalendar
    HijriCalendar 
    JapaneseCalendar 
    JapaneseLunisolarCalendar 
    JulianCalendar
    KoreanCalendar 
    KoreanLunisolarCalendar 
    PersianCalendar 
    TaiwanCalendar 
    TaiwanLunisolarCalendar 
    ThaiBuddhistCalendar 
     

 */
