using System.Collections.Generic;

namespace Bb.Calendarium.Configuration.Countries
{

    public partial class Datas
    {

        public static CountryConfiguration France()
        {

            var country = new CountryConfiguration()
            {

                Country = Country.France,
                Culture = "fr-FR",
                Defaults = "Christian",
                Url = "https://www.joursferies.fr/",
                Periods = new List<PeriodConfiguration>()
                {

                    new PeriodConfiguration() { Name = "Armistice Day 1918", RuleDate = "11-11", Free = true,
                        Translations = new List<NameConfiguration>()
                        {
                            new NameConfiguration() { Language =  Language.English, Name = "Armistice Day 1918" },
                        } },

                    new PeriodConfiguration() { Name = "New Year's Day", RuleDate = "1-1", Free = true,
                        Translations = new List<NameConfiguration>() {
                            new NameConfiguration() { Language =  Language.English, Name = "New year's Day" },
                        } },

                    new PeriodConfiguration() { Name = "Victory Day", RuleDate = "5-8", Free = true,
                        Translations = new List<NameConfiguration>() {
                            new NameConfiguration() { Language =  Language.English, Name = "Victory Day" },
                        } },

                    new PeriodConfiguration() { Name = "Labor Day", RuleDate = "5-1", Free = true,
                        Translations = new List<NameConfiguration>() {
                            new NameConfiguration() { Language =  Language.English, Name = "Labor Day" },
                        } },

                    new PeriodConfiguration() { Name = "Bastille Day", RuleDate = "7-14", Free = true,
                        Translations = new List<NameConfiguration>() {
                            new NameConfiguration() { Language =  Language.English, Name = "Bastille Day" },
                        },
                    },

                },

                Regions = new List<RegionConfiguration>()
                {
                    new RegionConfiguration()
                    {
                        Key = "67",
                        Periods = new List<PeriodConfiguration>()
                        {

                            new PeriodConfiguration() { Name = "Christmas Eve", RuleDate = "12-24", Free = true, Translations = new List<NameConfiguration>() {
                                new NameConfiguration() { Name = "Reveillon de Noël", Language =  Language.French },
                            } },

                            new PeriodConfiguration() { Name = "Christmas 2nd Day", RuleDate = "12-26", Free = true, Translations = new List<NameConfiguration>() {
                                new NameConfiguration() { Name = "St étienne", Language =  Language.French },
                            } },

                            new PeriodConfiguration() { Name = "New Year's Eve", RuleDate = "12-31", Free = true, Translations = new List<NameConfiguration>() {
                                new NameConfiguration() { Name = "St sylvestre", Language =  Language.French },
                            } },

                        }
                    },

                    new RegionConfiguration()
                    {
                        Key  = "68",
                        From = "67",
                        Periods = new List<PeriodConfiguration>()
                        {

                        }
                    },
                    //new RegionConfiguration()
                    //{
                    //    ZipCodes = "973",   // Guyane
                    //    Periods = new List<PeriodConfiguration>()
                    //    {

                    //        new PeriodConfiguration() { Name = "", Rule = "?/?", Relative = 0, Free = true,
                    //            Translations = new List<NameConfiguration>() { new NameConfiguration() { Name = "Abolition de l'esclavage", Language =  Language.English } } },
                          
                    //    }
                    //},

                    //new RegionConfiguration()
                    //{
                    //    ZipCodes = "972",   // Martinique
                    //    Periods = new List<PeriodConfiguration>()
                    //    {

                    //        new PeriodConfiguration() { Name = "", Rule = "?/?", Relative = 0, Free = true,
                    //            Translations = new List<NameConfiguration>() { new NameConfiguration() { Name = "Abolition de l'esclavage", Language =  Language.English } } },

                    //    }
                    //},

                }

            };
            return country;
        }

    }

}
