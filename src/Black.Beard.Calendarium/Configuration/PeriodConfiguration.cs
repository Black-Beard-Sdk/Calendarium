using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;

namespace Bb.Calendarium.Configuration
{

    public class PeriodConfiguration
    {


        public PeriodConfiguration()
        {
            Translations = new List<NameConfiguration>();
            Tags = new List<string>();
        }

        public PeriodConfiguration(string name, bool free, string ruleDate) : this()
        {
            Name = name;
            RuleDate = ruleDate;
            Free = free;
            //this.Translations.Add(new NameConfiguration() { Language = Language.English, Name = name });

        }

        /// <summary>
        /// specify a year where the rule start
        /// </summary>
        public int? YearStart { get; set; }

        /// <summary>
        /// specify a year where the rule end
        /// </summary>
        public int? YearEnd { get; set; }


        [Description("Specify the name of the day")]
        [JsonRequired]
        public string Name { get; set; }

        [JsonRequired]
        [Description("Specify a rule for compute the date")]
        public string RuleDate { get; set; }

        [Description("Specify a rule for compute the observed day different of the ruleDate")]
        public string RuleObserved { get; set; }

        [Description("Specify a rule if the event duration is more of one day")]
        public string RuleDuration { get; set; }

        [Description("Specify a day not worked")]
        public bool Free { get; set; }

        public List<NameConfiguration> Translations { get; set; }

        public List<string> Tags { get; set; }

        [JsonIgnore]
        public Func<int, DateTime[]> RuleFunction { get; internal set; }

        [JsonIgnore]
        public Func<DateTime, DateTime> RuleObservedFunction { get; internal set; }

        [JsonIgnore]
        public Func<DateTime, DateTime> RuleDurationFunction { get; internal set; }

        [JsonIgnore]
        public CultureInfo CultureInfo { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public CalendarEnum Calendar { get; set; }

        [JsonIgnore]
        public Calendar CalendarInstance => Calendar == CalendarEnum.Default ? CultureInfo.Calendar : CultureInfo.OptionalCalendars.First(c => c.GetType().Name == Calendar.ToString() + "Calendar");

        public override string ToString()
        {
            return Name;
        }

        public PeriodConfiguration Clone()
        {

            var period = new PeriodConfiguration()
            {
                Name = Name,
                //RuleDate = RuleDate,
                //RuleObserved = RuleObserved,
                //RuleDuration = RuleDuration,
                Free = Free,
                RuleFunction = RuleFunction,
                RuleObservedFunction = RuleObservedFunction,
                RuleDurationFunction = RuleDurationFunction,
                CultureInfo = CultureInfo,
                Calendar = Calendar,
            };

            period.Tags.AddRange(Tags);
            period.Translations.AddRange(Translations);

            return period;
        }

    }

}
