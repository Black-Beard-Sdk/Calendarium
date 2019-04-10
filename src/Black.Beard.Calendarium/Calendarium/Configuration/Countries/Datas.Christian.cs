using System.Collections.Generic;

namespace Bb.Calendarium.Configuration.Countries
{

    public partial class Datas
    {

        public static DefaultCountryConfiguration Christian()
        {

            var country = new DefaultCountryConfiguration()
            {
                Name = "Christian",
                Culture = "fr-FR",
                Calendar = CalendarEnum.Gregorian,
                Periods = new List<PeriodConfiguration>()
                {

                    // all sunday
                    new PeriodConfiguration() { Name = "Sunday", RuleDate = "* SUNDAY", Free = true,
                        Translations = new List<NameConfiguration>()
                        {
                            new NameConfiguration() { Language = Language.French, Name = "Dimanche" }
                        } },

                    new PeriodConfiguration() { Name = "All Saints' Day", RuleDate = "11-1", Free = true,
                        Translations = new List<NameConfiguration>() {
                            new NameConfiguration() { Language = Language.French, Name = "Toussaints" },
                        } },

                    new PeriodConfiguration() { Name = "Easter Sunday", RuleDate = "[EASTER]", Free = true,
                        Translations = new List<NameConfiguration>() {
                            new NameConfiguration() { Language = Language.French, Name = "Pâques" },
                        } },

                    new PeriodConfiguration() { Name = "Easter Monday", RuleDate = "[EASTER] + 1", Free = true,
                        Translations = new List<NameConfiguration>() {
                            new NameConfiguration() { Language = Language.French, Name = "Lundi de Pâques" },
                        } },

                    new PeriodConfiguration() { Name = "Pentecost", RuleDate = "[EASTER] + 49", Free = true,
                        Translations = new List<NameConfiguration>() {
                            new NameConfiguration() { Language = Language.French, Name = "Dimande de pentcôte" },
                        } },

                    new PeriodConfiguration() { Name = "Pentecost Monday", RuleDate = "[EASTER] + 50", Free = true,
                        Translations = new List<NameConfiguration>() {
                            new NameConfiguration() { Language = Language.French, Name = "Lundi de pencôte" },
                        } },

                    new PeriodConfiguration() { Name = "Ascension", RuleDate = "[EASTER] + 39", Free = true,
                        Translations = new List<NameConfiguration>() {
                            new NameConfiguration() { Language = Language.French, Name = "Ascension" },
                        } },

                    new PeriodConfiguration() { Name = "Assumption", RuleDate = "8-15", Free = true,
                        Translations = new List<NameConfiguration>() {
                            new NameConfiguration() { Language = Language.French, Name = "Assumption de Marie" },
                        } },

                    new PeriodConfiguration() { Name = "Christmas Day", RuleDate = "12-25", Free = true,
                        Translations = new List<NameConfiguration>() {
                            new NameConfiguration() { Language = Language.French, Name = "Noël" },
                        } },

                    new PeriodConfiguration() { Name = "Good Friday", RuleDate = "[EASTER] - 2",
                        Translations = new List<NameConfiguration>() {
                            new NameConfiguration() { Language = Language.French , Name = "Vendredi saint" },
                        } },

                }

            };
            return country;
        }

    }

}
