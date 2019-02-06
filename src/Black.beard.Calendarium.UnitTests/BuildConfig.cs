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
    public class BuildConfig
    {

        [TestMethod]
        public void GenerateShemas()
        {

            var dir = Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "..", "Black.Beard.Calendarium", "Countries");

            var filename = Path.Combine(dir, "_schema.CountryConfiguration.json");
            if (File.Exists(filename))
                File.Delete(filename);
            File.AppendAllText(filename, CountryConfiguration.SerializeSchema().ToString());

            filename = Path.Combine(dir, "_schema.DefaultCountryConfiguration.json");
            if (File.Exists(filename))
                File.Delete(filename);
            File.AppendAllText(filename, DefaultCountryConfiguration.SerializeSchema().ToString());

        }

        [TestMethod]
        public void GenerateConfig()
        {

            var dirChecked = new System.IO.DirectoryInfo(Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "..", "Black.Beard.Calendarium", "Countries"));
            var dirNotChecked = new System.IO.DirectoryInfo(Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "..", "Black.Beard.Calendarium", "Countries", "NotChecked"));
            var dirNotCheckedClean = new System.IO.DirectoryInfo(Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "..", "Black.Beard.Calendarium", "Countries", "NotCheckedClean"));

            if (!dirNotChecked.Exists)
                dirNotChecked.Create();

            if (!dirNotCheckedClean.Exists)
                dirNotCheckedClean.Create();

            var referential = Helper.Referential;

            foreach (var countryItem in referential)
            {

                StringBuilder sb = new StringBuilder(2000);
                var infos = CountryHelper.GetInfos(countryItem.Key);
                bool clean = true;

                if (infos.Item3.Length == 0)
                    continue;

                var config = new CountryConfiguration()
                {
                    Country = countryItem.Key,
                    Calendar = infos.Item3[0],
                };

                if (!string.IsNullOrEmpty(infos.Item1))
                {

                    config.Culture = infos.Item2;
                    config.Calendar = infos.Item3[0];

                    foreach (var calendar in infos.Item3)
                        sb.AppendLine($"// calendar : {calendar}");

                    sb.AppendLine(string.Empty);

                }

                Dictionary<string, Dictionary<string, Liststring>> _doc = new Dictionary<string, Dictionary<string, Liststring>>();
                foreach (var date in countryItem.Value)
                {

                    if (date.Reconstitued)
                    {
                        clean = false;
                        sb.AppendLine($"// Orphan observed date {date.DayName} : {date.ObservedDate.Date}");
                        continue;
                    }

                    if (!_doc.TryGetValue(date.DayName, out Dictionary<string, Liststring> _dic))
                        _doc.Add(date.DayName, _dic = new Dictionary<string, Liststring>());

                    var u3 = date.Date.Split('-');

                    string rule = $"{int.Parse(u3[u3.Length - 2])}-{int.Parse(u3[u3.Length - 1])}";

                    if (!_dic.TryGetValue(rule, out Liststring years))
                        _dic.Add(rule, years = new Liststring());

                    years.Years.Add(int.Parse(u3[0]).ToString());

                    if (date.ObservedDate != null)
                        years.Observeds.Add($"{date.DayName},{date.Date.Split('-')[2]},{date.ObservedDate.Date.Split('-')[2]}");

                }


                foreach (var day in _doc)
                {

                    var _h = new HashSet<string>();

                    foreach (var rule in day.Value)
                    {

                        PeriodConfiguration p = null;

                        if (rule.Value.Years.Count > 5)
                        {

                            p = new PeriodConfiguration(day.Key, true, rule.Key)
                            {
                                CultureInfo = CultureInfo.GetCultureInfo(infos.Item2),
                            };

                            config.Periods.Add(p);

                            if (int.Parse(rule.Value.Years[0]) < 2000)
                                p.Calendar = CalendarEnum.Hijri;
                            else if (int.Parse(rule.Value.Years[0]) > 3000)
                                p.Calendar = CalendarEnum.Julian;

                        }
                        else
                        {

                            var _rule = Helper.GetRule(day.Key);
                            if (string.IsNullOrEmpty(_rule))
                            {
                                clean = false;
                                var dates = string.Join(',', rule.Value);
                                sb.AppendLine($"// Date : {day.Key}, {rule.Key}, {dates}");
                            }

                            else if (_rule == "<<NotImplemented>>") { }
                            else
                            {
                                if (_h.Add(day.Key + " - " + _rule))
                                {
                                    p = new PeriodConfiguration(day.Key, true, _rule)
                                    {
                                        CultureInfo = CultureInfo.GetCultureInfo(infos.Item2),
                                    };

                                    config.Periods.Add(p);
                                }
                            }
                        }

                        if (rule.Value.Observeds.Count > 0)
                        {

                            foreach (var item in rule.Value.Observeds)
                            {

                                var days = item.Split(',');

                                string name = days[0];
                                int d1 = int.Parse(days[1]);
                                int d2 = int.Parse(days[2]);

                                var ds = d2 - d1;

                                if (d2 == 31 && d1 == 1)
                                    ds = 1;

                                if (ds > 2)
                                {

                                    clean = false;
                                    sb.AppendLine($"// Observed date {item}");

                                }

                                var it = config.Periods.First(c => c.Name == name);

                                if (string.IsNullOrEmpty(it.RuleObserved) || ds > 1)
                                    it.RuleObserved = ds == 1
                                        ? "? (SUNDAY) : >> MONDAY"
                                        : "? (SATURDAY | SUNDAY) : >> MONDAY"
                                        ;

                            }

                        }

                    }

                }

                if (!File.Exists(config.GetFilname(dirChecked)))
                {

                    sb = config.Serialize(sb);

                    if (clean)
                        config.Save(dirNotCheckedClean, sb);
                    else
                        config.Save(dirNotChecked, sb);

                }

            }

        }


        //private static DateTime GetExpectedDate(Referential item, Calendar calendar)
        //{

        //    var u3 = item.Date.Split('-');
        //    var year = int.Parse(u3[0]);
        //    var month = int.Parse(u3[1]);
        //    var day = int.Parse(u3[2]);

        //    if (calendar is GregorianCalendar && year < 1900)
        //        calendar = new HijriCalendar();

        //    DateTime expected;
        //    try
        //    {
        //        expected = new DateTime(year, month, day, calendar);
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }

        //    item.Date2 = expected;

        //    return expected;

        //}

        private class Liststring
        {

            public Liststring()
            {
                Years = new List<string>();
                Observeds = new List<string>();
            }

            public List<string> Years { get; }
            public List<string> Observeds { get; }

            public override string ToString()
            {
                return string.Join(',', Years);
            }

        }

        [TestMethod]
        public void GenerateReligiousTags()
        {

            var _items = GetDaysWithTags();
            List<CountryConfiguration> _countries = GetCountriesFromSolution();
            var dateCountries = CalendariumConfiguration.GetCalendarium(_countries.ToArray());


            foreach (var item in _items)
            {


                foreach (var item2 in item.Value)
                {
                    foreach (var item3 in item2.Value.Dates)
                    {

                        dateCountries.GetDate(item3, item.Key);

                    }
                }
            }


            foreach (var country in _countries)
            {
                var trads = _items[country.Country];
                foreach (var period in country.Periods)
                {

                    var day = trads[period.Name] ?? trads[Helper.GetA(period.Name)];
                    if (day == null)
                    {
                        foreach (var item in trads)
                        {
                            if (item.Value.IsFix)
                            {
                                var dte = dateCountries.GetDate(item.Value.Dates.First(), country.Country, null);
                            }
                        }
                    }
                }



            }


            //foreach (var country in _c)
            //{
            //    //var _country = _items[country.Value.Country];
            //    foreach (var item in country.Value.Periods)
            //        _h.Add(item.Name);
            //}
            //foreach (var item in _h.OrderBy(c => c))
            //    Debug.WriteLine($"case \"{item}\":");
            //_h.Clear();


            //foreach (var item1 in _items)
            //    foreach (var item2 in item1.Value)
            //        foreach (var item3 in item2.Value.Translations.Where(c => c.Key == Language.English))
            //            _h.Add(item3.Value.Name.Trim('"').Trim());


            //foreach (var item in _h.OrderBy(c => c))
            //    Debug.WriteLine($"return \"{item}\";");

            //StringBuilder sb = new StringBuilder();
            //List<religious> religious = new List<religious>();
            //foreach (var item1 in _items.Values)
            //    foreach (var item2 in item1)
            //    {

            //        StringBuilder sb2 = new StringBuilder();

            //        foreach (var item in item2.Value.Translations)
            //        {
            //            sb2.Append(item.Key.ToString());
            //            sb2.Append("=");
            //            sb2.Append(item.Value.Name);
            //            int c = 0;
            //            do
            //            {
            //                c = sb2.Length;
            //                var ch = sb2[sb2.Length - 1];
            //                if (char.IsNumber(ch) || char.IsWhiteSpace(ch) || ch == '#')
            //                    sb2.Remove(sb2.Length - 1, 1);

            //            } while (sb2.Length != c);
            //            sb2.Append(",");
            //        }
            //        sb2.Append(";");

            //        sb2.Append(string.Join(',', item2.Value.Tags));
            //        sb2.Append(";");

            //        if (item2.Value.IsFix)
            //        {
            //            var dt = item2.Value.Dates.First();
            //            sb2.Append($"{dt.Month}-{dt.Day};");
            //        }
            //        else
            //        {
            //            foreach (var item3 in item2.Value.Dates)
            //            {
            //                sb2.Append(item3.ToString("d"));
            //                sb2.Append(",");
            //            }
            //        }

            //        sb2.Append(";");

            //        if (_h.Add(sb2.ToString()))
            //            sb.AppendLine(sb2.ToString());

            //        sb2.Clear();


            //    }

            //var fileReligious = Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "Output", "religious.csv");
            //if (File.Exists(fileReligious))
            //    File.Delete(fileReligious);
            //File.AppendAllText(fileReligious, sb.ToString());




            //var txt = JsonConvert.SerializeObject(religious, Formatting.Indented);
            //File.AppendAllText(fileReligious, txt);






        }

        private List<CountryConfiguration> GetCountriesFromSolution()
        {
            var dirCountries = new System.IO.DirectoryInfo(Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "..", "Black.Beard.Calendarium", "Countries"));
            List<CountryConfiguration> _c = new List<CountryConfiguration>();
            foreach (var file in dirCountries.GetFiles("date_*.json", SearchOption.AllDirectories))
            {
                var config = DefaultCountryConfiguration.Load(file) as CountryConfiguration;
                _c.Add(config);
            }

            return _c;

        }

        private Dictionary<Country, Dictionary<string, religious>> GetDaysWithTags()
        {

            var dirCvs = Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "..", "..", "csvs");
            var csv = Path.Combine(dirCvs, "gevc5010_religious_events_calendar.csv");
            var lines = File.ReadAllLines(csv, Encoding.UTF8);
            Dictionary<Country, Dictionary<string, religious>> _items = new Dictionary<Country, Dictionary<string, religious>>();
            foreach (var item in lines.Skip(1))
            {

                var cols = item.Split('|');
                var language = cols[(int)gevc5010_religious_events_calendar.language];
                var country = GetCountryFromLanguage(language);

                if (!_items.TryGetValue(country, out Dictionary<string, religious> list))
                    _items.Add(country, (list = new Dictionary<string, religious>()));

                var event_name = cols[(int)gevc5010_religious_events_calendar.event_name];
                if (!list.TryGetValue(event_name, out religious _religious))
                    list.Add(event_name, _religious = new religious() { Country = country, DayName = event_name, Language = GetLanguage(language) });

                _religious.Tags.Add(cols[(int)gevc5010_religious_events_calendar.event_category]);
                _religious.Tags.Add(cols[(int)gevc5010_religious_events_calendar.event_family]);

                var dt = cols[(int)gevc5010_religious_events_calendar.dt].Split('-');
                _religious.Dates.Add(new DateTime(int.Parse(dt[0]), int.Parse(dt[1]), int.Parse(dt[2])));

            }

            foreach (var item1 in _items)
                foreach (var item2 in item1.Value)
                {
                    List<DateTime> _i = new List<DateTime>();
                    var dte = item2.Value.Dates.First();
                    foreach (var item3 in item2.Value.Dates.Skip(1))
                        if (dte.Month == item3.Month && dte.Day == item3.Day)
                            _i.Add(item3);
                    foreach (var item in _i)
                        item2.Value.Dates.Remove(item);
                    item2.Value.IsFix = item2.Value.Dates.Count == 1;
                }

            var l2 = _items.Values.ToList();
            var l1 = _items.Values.ToList();

            foreach (var taggedDay1 in l1)
            {
                foreach (var tag1 in taggedDay1.Values)
                {

                    var d1 = tag1.Dates;

                    foreach (var taggedDay2 in l2)
                    {
                        foreach (var tag2 in taggedDay2.Values)
                        {
                            var d2 = tag2.Dates;
                            if (Match(d1, d2))
                            {
                                if (!tag1.Translations.ContainsKey(tag2.Language))
                                {
                                    var name = new NameConfiguration() { Language = tag2.Language, Name = tag2.DayName };
                                    tag1.Translations.Add(tag2.Language, name);
                                }
                                else
                                {

                                }
                            }

                        }
                    }

                }
            }

            return _items;

        }



        private bool Match(HashSet<DateTime> d1, HashSet<DateTime> d2)
        {

            foreach (var item1 in d1)
                if (!d2.Contains(item1))
                    return false;

            return true;

        }


        private static Language GetLanguage(string language)
        {
            switch (language)
            {
                case "english":
                    return Language.English;
                case "swedish":
                    return Language.Swedish;
                case "german":
                    return Language.German;
                case "dutch":
                    return Language.Dutch;
                case "danish":
                    return Language.Danish;
                case "norwegian":
                    return Language.Norwgian;
                case "french":
                    return Language.French;
                case "lithuanian":
                    return Language.Lithuanian;
                case "latvian":
                    return Language.Latvian;
                case "spanish":
                    return Language.Spanish;
                case "portuguese":
                    return Language.Portuguese;
                case "slovenian":
                    return Language.Slovenian;
                case "croatian":
                    return Language.Croatian;
                case "polish":
                    return Language.Polish;
                case "estonian":
                    return Language.Estonian;
                case "finnish":
                    return Language.Finnish;
                case "slovak":
                    return Language.Slovak;
                case "czech":
                    return Language.Czech;
                case "hungarian":
                    return Language.Hungarian;
                default:
                    return Language.Undefined;
            }

        }

        private static Country GetCountryFromLanguage(string language)
        {
            switch (language)
            {
                case "english":
                    return Country.United_Kingdom;
                case "swedish":
                    return Country.Sweden;
                case "german":
                    return Country.Germany;
                case "dutch":
                    return Country.Netherlands;
                case "danish":
                    return Country.Denmark;
                case "norwegian":
                    return Country.Norway;
                case "french":
                    return Country.France;
                case "lithuanian":
                    return Country.Lithuania;
                case "latvian":
                    return Country.Latvia;
                case "spanish":
                    return Country.Spain;
                case "portuguese":
                    return Country.Portugal;
                case "slovenian":
                    return Country.Slovenia;
                case "croatian":
                    return Country.Croatia;
                case "polish":
                    return Country.Poland;
                case "estonian":
                    return Country.Estonia;
                case "finnish":
                    return Country.Finland;
                case "slovak":
                    return Country.Slovakia;
                case "czech":
                    return Country.Czechia;
                case "hungarian":
                    return Country.Hungary;
                default:
                    return Country.Undefined;
            }

        }

        private class religious
        {

            public religious()
            {
                Tags = new HashSet<string>();
                Dates = new HashSet<DateTime>();
                Translations = new Dictionary<Language, NameConfiguration>();
            }

            public Country Country { get; internal set; }
            public string DayName { get; internal set; }
            public Language Language { get; internal set; }
            public HashSet<string> Tags { get; }
            public HashSet<DateTime> Dates { get; }
            public Dictionary<Language, NameConfiguration> Translations { get; }
            public bool IsFix { get; internal set; }
        }

    }
    /*

case "en":
case "sv":
case "de":
case "nl":
case "da":
case "no":
case "fr":
case "lt":
case "lv":
case "es":
case "pt":
case "sl":
case "hr":
case "pl":
case "et":
case "fi":
case "sk":
case "cs":
case "hu":
*/

    public enum gevc5020_bank_holidays_events_calendar
    {
        language_cd, language, event_category, event_sub_category, dt_id, dt, event_id, event_family, event_name, event_name_id, is_fixedate, gadm1id, gadm1, ageoid, gadm2, gadm3, is_national_legal, is_national_traditional, is_local_legal, is_local_traditional, s_fid, s_dtupd
    }

    public enum gevc5010_religious_events_calendar
    {
        language_cd, language, event_category, event_sub_category, dt_id, dt, event_id, event_family, event_name, event_name_id, is_fixedate, is_hindu_event, is_islamic_event, is_christian_event, is_orthodox_event, is_hebrew_event, s_fid, s_dtupd
    }
}
