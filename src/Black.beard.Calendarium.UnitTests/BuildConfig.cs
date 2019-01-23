using Bb.Calendarium.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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

                bool clean = true;

                StringBuilder sb = new StringBuilder(2000);

                var infos = CountryHelper.GetInfos(countryItem.Key);

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

                Dictionary<string, Dictionary<string, List<string>>> _doc = new Dictionary<string, Dictionary<string, List<string>>>();
                foreach (var date in countryItem.Value)
                {

                    if (!_doc.TryGetValue(date.Item1, out Dictionary<string, List<string>> _dic))
                        _doc.Add(date.Item1, _dic = new Dictionary<string, List<string>>());

                    var u3 = date.Item2.Split('-');

                    string rule = $"{int.Parse(u3[u3.Length - 2])}-{int.Parse(u3[u3.Length - 1])}";

                    if (!_dic.TryGetValue(rule, out List<string> years))
                        _dic.Add(rule, new List<string>() { int.Parse(u3[0]).ToString() });
                    else
                        years.Add(int.Parse(u3[0]).ToString());

                }

                foreach (var day in _doc)
                {

                    var _h = new HashSet<string>();

                    foreach (var rule in day.Value)
                    {
                        if (rule.Value.Count > 5)
                        {

                            var p = new PeriodConfiguration(day.Key, true, rule.Key)
                            {
                                CultureInfo = CultureInfo.GetCultureInfo(infos.Item2),
                            };

                            config.Periods.Add(p);

                            if (int.Parse(rule.Value[0]) < 2000)
                                p.Calendar = CalendarEnum.Hijri;

                        }
                        else
                        {
                            var _rule = Helper.GetRule(day.Key);
                            if (string.IsNullOrEmpty(_rule))
                            {
                                clean = false;
                                sb.AppendLine($"// Date : {day.Key}, {rule.Key}, {string.Join(',', rule.Value)}");
                            }
                            else if (_rule == "<<NotImplemented>>") { }
                            else
                            {
                                if (_h.Add(day.Key + " - " + _rule))
                                {
                                    var p = new PeriodConfiguration(day.Key, true, _rule)
                                    {
                                        CultureInfo = CultureInfo.GetCultureInfo(infos.Item2),
                                    };

                                    config.Periods.Add(p);
                                }
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
    }
}
