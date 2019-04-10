using System.Collections.Generic;

namespace Bb.Calendarium.Configuration.Countries
{

    public partial class Datas
    {

        public static CountryConfiguration Germany()
        {

            var country = new CountryConfiguration()
            {

                Country = Country.Germany,
                Culture = "de-DE",
                Defaults = "Christian",
                Url = "https://publicholidays.de",
                Periods = new List<PeriodConfiguration>()
                {

                    new PeriodConfiguration() { Name = "Reformation Day", RuleDate = "10-31", Free = true,
                        Translations = new List<NameConfiguration>() {
                        } },

                    new PeriodConfiguration() { Name = "Epiphany", RuleDate = "1-6", Free = true,
                        Translations = new List<NameConfiguration>() {
                        } },

                    new PeriodConfiguration() { Name = "Day of German Unity", RuleDate = "10-3", Free = true,
                        Translations = new List<NameConfiguration>() {
                        } },

                    // first wednesday before 23 Nov.
                    new PeriodConfiguration() { Name = "Day of Prayer and Repentance", RuleDate = "(11-23) << Wednesdays", Free = true,
                        Translations = new List<NameConfiguration>() {
                        } },

                    new PeriodConfiguration() { Name = "New Year's Day", RuleDate = "1-1", Free = true,
                        Translations = new List<NameConfiguration>() {
                            new NameConfiguration() { Language =  Language.French, Name = "Jour de l'an" },
                        } },

                    new PeriodConfiguration() { Name = "Labor Day", RuleDate = "5-1", Free = true,
                        Translations = new List<NameConfiguration>() {
                            new NameConfiguration() { Language =  Language.French, Name = "Fête du travail" },
                        } },

                    new PeriodConfiguration() { Name = "Christmas Eve", RuleDate = "12-24", Free = true, Translations = new List<NameConfiguration>() {
                                new NameConfiguration() { Name = "Reveillon de Noël", Language =  Language.French },
                            } },

                    new PeriodConfiguration() { Name = "Christmas 2nd Day", RuleDate = "12-26", Free = true, Translations = new List<NameConfiguration>() {
                                new NameConfiguration() { Name = "St étienne", Language =  Language.French },
                            } },

                    new PeriodConfiguration() { Name = "Sylvester", RuleDate = "12-31", Free = true, Translations = new List<NameConfiguration>() {
                                new NameConfiguration() { Name = "St sylvestre", Language =  Language.French },
                                new NameConfiguration() { Name = "Sylvester", Language =  Language.German },
                            } },

                    //  It is celebrated on the Thursday that is 60 days after Easter Sunday and 10 days after Pentecost
                    new PeriodConfiguration() { Name = "Corpus Christi", RuleDate = "[EASTER] + 59", Free = true,
                        Translations = new List<NameConfiguration>() {
                            new NameConfiguration() { Language = Language.French, Name = "Fête-Dieu" },
                        } },

                },

                Regions = new List<RegionConfiguration>()
                {

                    //new RegionConfiguration()
                    //{
                    //    Key = "67",
                    //    Periods = new List<PeriodConfiguration>()
                    //    {


                    //    }
                    //},

                }

            };
            return country;
        }

    }

}



//[PRAYER_AND_REPENTANCE] -> ast Wednesday before November 23 and 11 days before the start of Advent

// Premier mercredi apres mask : (11-23) >> Wednesday
// Premier mercredi avant mask : (11-23) << Wednesday
