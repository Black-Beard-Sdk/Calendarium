using Bb.Calendarium.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Bb.Calendarium.UnitTests
{

    public static class Helper
    {

        public static readonly Dictionary<Country, List<(string, string)>> Referential;
        public static readonly Dictionary<Country, List<(string, string)>> Todo;
        private static readonly HashSet<string> _h;

        static Helper()
        {
            Helper.Referential = GetReferential();
            Helper.Todo = GetToDo();
            Helper._h = new HashSet<string>();
        }

        private static Dictionary<Country, List<(string, string)>> GetToDo()
        {
            var txt = Resource1.ToDo.Split('\r');

            Dictionary<Country, List<(string, string)>> _dic = new Dictionary<Country, List<(string, string)>>();
            List<(string, string)> _list = null;

            foreach (var item in txt)
            {
                var t = item.Trim();
                if (!string.IsNullOrEmpty(t))
                {
                    if (t.StartsWith("["))
                    {
                        var label = t.Substring(1, t.IndexOf(']') - 1);
                        label = label
                            .Replace(" ", "_")
                            .Replace(".", "_")

                            .Replace("(", "")
                            .Replace(")", "")
                            .Trim('_')
                            .Trim()
                            ;

                        _list = new List<(string, string)>();

                        if (Enum.TryParse<Country>(label, out Country value))
                            _dic.Add(value, _list);

                    }
                    else
                    {
                        var u = t.Split(',');

                        var value = u.Length >= 2
                            ? u[1].Trim()
                            : GetRule(u[0]);

                        _list.Add((u[0].Trim(), value));
                    }
                }
                else
                    _list = null;

            }

            return _dic;

        }

        public static string GetRule(string label)
        {

            switch (label.ToLower())
            {

                case "san martín national patriot day":
                    return "";

                //case "eid al adha":
                //case "eid al adha 2nd day":
                //case "eid al fitr":
                //case "eid al fitr 2nd day":

                case "international women's day":
                    return "";
                case "valentine's":
                    return "";
                case "may day":
                    return "";
                case "vigil of assumption":
                    return "";

                case "new year's day bridge":
                    return "<<NotImplemented>>";

                case "hijri new year":
                    return "";
                case "chinese new year's eve":
                    return "";



                case "labor day":
                    return "5-1";

                case "day after new year's day":
                    return "1-2";

                case "new year's day":
                    return "1-1";

                case "new year's eve":
                    return "12-31";

                case "carnival":
                    return "([EASTER]) - 48";

                case "carnival 2nd day":
                    return "([EASTER]) - 49"; 

                case "easter monday catholic":
                case "easter monday":
                    return "([EASTER]) + 1";

                case "easter tuesday":
                    return "([EASTER]) - 5";

                case "holy wednesday":
                    return "([EASTER]) - 4";

                case "maundy thursday":
                case "holy thursday":
                    return "([EASTER]) - 3";

                case "good friday":
                case "good friday catholic":
                    return "([EASTER]) - 2";

                case "holy saturday":
                    return "([EASTER]) - 1";

                case "easter day catholic":
                case "easter catholic":
                case "easter gregorian":
                case "easter sunday":
                case "easter day":
                case "easter":
                    return $"[EASTER]";

                case "ascension":
                    return "([EASTER]) + 39";

                case "day after ascension":
                    return "([EASTER]) + 40";

                case "whit sunday":
                case "pentecost":
                    return "([EASTER]) + 49";

                case "whit monday":
                case "pentecost monday":
                    return "([EASTER]) + 50";

                case "trinity sunday": // In Western Christianity Trinity Sunday always falls on the first Sunday after Pentecost.
                    return "([EASTER]) + 56";

                case "corpus christi":  // // Corpus Christi is a Christian feast celebrated every year on the Thursday after Trinity Sunday
                    return "([EASTER]) + 60";

                case "assumption":
                    return "8-15";

                case "all saints' day":
                    return "11-1";

                case "christmas eve":
                    return "12-24";

                case "christmas day":
                case "christmas":
                    return "12-25";

                case "second week-day after christmas day":
                    return "";

                case "first week-day after christmas day":
                    return "";

                case "good friday orthodox":
                case "easter orthodox":
                case "easter monday orthodox":
                    return "";

                case "carnival tuesday":
                case "commemoration day":
                case "revolution day":
                case "day of remembrance for truth and justice bridge":
                case "day of the veterans bridge":
                case "labor day bridge":
                case "flag day bridge":
                case "independence day bridge":
                case "immaculate conception bridge":
                case "bicentenary of the argentine flag":
                case "day of respect to cultural diversity public holiday":
                case "day of national sovereignty public holiday":
                case "labour day":
                case "mother's day":
                case "queen's birthday except queensland and western australia":
                case "father's day":
                case "christmas bank holiday":
                case "boxing day bank holiday":
                case "queen's birthday queensland":
                case "queen's birthday western australia":
                case "christmas holiday":
                case "ash wednesday":
                case "liberation day bridge":
                case "bridge bulgarian army day st. george's day":
                case "bridge st. cyril and st. methodius day education & culture day":
                case "day of the union of bulgaria bridge":
                case "day of the leaders of the bulgarian national revival bridge":
                case "family day many provinces":
                case "thanksgiving day":
                case "victoria day many provinces":
                case "st. patrick's day newfoundland and labrador":
                case "orangemen's day newfoundland and labrador":
                case "st. george's day newfoundland and labrador":
                case "civic holiday many provinces":
                case "heritage day alberta":
                case "british columbia day british columbia":
                case "louis riel day manitoba":
                case "new brunswick day new brunswick":
                case "discovery day newfoundland and labrador":
                case "natal day nova scotia and pei":
                case "discovery day yukon":
                case "day after new year's day quebec":
                case "islander day prince edward island":
                case "heritage day yukon":
                case "national patriots' day quebec":
                case "st. peter and st. paul":
                case "columbus day":
                case "bank holiday":
                case "reformation day":
                case "epiphany":
                case "sacred heart of jesus":
                case "st. joseph":
                case "palm sunday":
                case "independence of cartagena":
                case "prayer day":
                case "easter day coptic":
                case "sham el-nessim":
                case "midsummer day":
                case "midsummer eve":
                case "day of prayer and repentance":
                case "ash monday":
                case "holy ghost's day":
                case "buddha's birthday":
                case "chinese new year":
                case "chinese new year 2nd day":
                case "chung yeung festival":
                case "the day following the chinese mid-autumn festival":
                case "tuen ng festival":
                case "chinese new year 3rd day":
                case "chinese new year 4th day":
                case "children's day":
                case "first day of summer":
                case "commerce day":
                case "pesach":
                case "june bank holiday":
                case "october bank holiday":
                case "may bank holiday":
                case "august bank holiday":
                case "new year's bank holiday":
                case "st. stephen's day bank holiday":
                case "st. patrick's day bank holiday":
                case "autumnal equinox day":
                case "coming of age day":
                case "people's day":
                case "new year's day 3rd day":
                case "new year's day 4th day":
                case "health sport's day":
                case "marine day":
                case "independence day 3rd day":
                case "independence day 4th day":
                case "buddha's birthday - seokgatansin-il":
                case "harvest moon festival - chuseok":
                case "harvest moon festival - chuseok 3rd day":
                case "harvest moon festival - chuseok actual holiday":
                case "lunar new year's day - seol":
                case "lunar new year's day - seol 3rd day":
                case "lunar new year's day - seol actual holiday":
                case "national assembly election day":
                case "presidential election day":
                case "restoration of independence of the republic of latvia public holiday":
                case "independence day public holiday":
                case "easter day - western":
                case "easter day - eastern":
                case "good friday - western":
                case "good friday - eastern":
                case "easter monday - western":
                case "easter monday - eastern":
                case "shrove tuesday":
                case "pancake day":
                case "epiphany bank holiday":
                case "saint clement of ohrid bank holiday":
                case "eid al fitr bank holiday":
                case "eid al fitr":
                case "wesak day":
                case "the yang di-pertuan agong's birthday":
                case "deepavali":
                case "anniversary of the mexican revolution":
                case "benito juarez's birthday":
                case "anniversary of the constitution":
                case "transmission of the federal executive power":
                case "general election":
                case "prince's day":
                case "queen's birthday":
                case "king's day":
                case "year end bank holiday":
                case "national heroes day":
                case "black saturday":
                case "fat thursday":
                case "birthday of eugenio maría de hostos":
                case "birthday of josé de diego":
                case "birthday of don luis muñoz rivera":
                case "martin luther king day":
                case "memorial day":
                case "presidents' day":
                case "tax day":
                case "administrative professionals day":
                case "day after thanksgiving day":
                case "vote election's day":
                case "national sports day":
                case "new year's holiday":
                case "labor day holiday":
                case "vesak day":
                case "youth day":
                case "teacher's day":
                case "hari raya haji holiday":
                case "family day":
                case "all hallows' eve":
                case "whitsun eve":
                case "federal day of prayer":
                case "asalaha bucha day":
                case "coronation day":
                case "khao phansa buddhist lent day":
                case "makha bucha day":
                case "visakha bucha day":
                case "loy kratong day":
                case "ok phansa end of buddhist lent":
                case "kurban bayramı":
                case "kurban bayramı 2nd day":
                case "kurban bayramı 3rd day":
                case "kurban bayramı 4th day":
                case "ramazan bayramı":
                case "ramazan bayramı 2nd day":
                case "ramazan bayramı 3rd day":
                case "labor day 2nd day":
                case "new year's day holiday":
                case "christmas holiday orthodox":
                case "late summer holiday":
                case "may day bank holiday":
                case "spring bank holiday":
                case "august bank holiday scotland":
                case "election day":
                case "battle of las piedras":
                case "expedition of the 33":
                case "day of the race":
                case "bank holiday holy week":
                case "ascension bank holiday":
                case "corpus christi bank holiday":
                case "st. peter and st. paul bank holiday":
                case "assumption bank holiday":
                case "all saints' day bank holiday":
                case "immaculate conception bank holiday":
                case "holy week":
                case "yom haatzmaut":
                case "yom hashoah":
                case "yom hazikaron":
                case "yom yerushalaim":
                case "slight cold":
                case "great cold":
                case "spring begins":
                case "the rains":
                case "insects awaken":
                case "vernal equinox":
                case "grain rain":
                case "summer begins":
                case "grain buds":
                case "summer solstice":
                case "slight heat":
                case "autumn begins":
                case "stopping the heat":
                case "white dews":
                case "autumn equinox":
                case "hoar-frost falls":
                case "winter begins":
                case "dragon boat festival":
                case "chinese mid-autumn festival":
                case "lantern festival":
                case "double ninth festival":
                case "hungry ghost festival":
                case "nevruz":
                case "novruz bayram":
                case "easter day orthodox":
                case "day of the national emblem and flag of belarus":
                    return null;


                case "new year's day observed":
                case "australia day observed":
                case "anzac day observed":
                case "hijri new year observed":
                case "prophet mohammed's birthday observed":
                case "national holiday observed":
                case "accession day observed":
                case "ashoora observed":
                case "eid al fitr observed":
                case "labour day observed":
                case "eid al adha observed":
                case "arafat day observed":
                case "labor day observed":
                case "observed nunavut day nunavut":
                case "observed quebec national day - st. john the baptist day quebec":
                case "emperor's birthday observed":
                case "greenery day observed":
                case "hong kong sar establishment day observed":
                case "national day observed":
                case "national foundation day observed":
                case "respect for the aged day":
                case "vernal equinox day observed":
                case "labor thanksgiving day observed":
                case "constitution day observed":
                case "shōwa day observed":
                case "children's day observed":
                case "culture day observed":
                case "autumnal equinox observed":
                case "international women's day observed":
                case "kazakhstan people's unity day observed":
                case "victory day observed":
                case "capital city day observed":
                case "defender of the fatherland day observed":
                case "liberation day observed":
                case "christmas day - armenian orthodox observed":
                case "saint maron observed":
                case "feast of the annunciation observed":
                case "resistance and liberation day observed":
                case "assumption observed":
                case "independence day observed":
                case "christmas day observed":
                case "eid al isra' wal mi'raj observed":
                case "day of the macedonian revolution observed":
                case "st. cyril and st. methodius observed":
                case "republic day observed":
                case "dormition observed":
                case "revolution day observed":
                case "christmas observed":
                case "renaissance day observed":
                case "sultan's birthday observed":
                case "veteran's day observed":
                case "motherland defender's day observed":
                case "spring and labor day observed":
                case "russia day observed":
                case "day of the national unity observed":
                case "sovereignty day of serbia observed":
                case "human rights day observed":
                case "freedom day observed":
                case "worker's day observed":
                case "youth day observed":
                case "women's day observed":
                case "heritage day observed":
                case "day of reconciliation observed":
                case "day of goodwill observed":
                case "makha bucha day observed":
                case "chakri day observed":
                case "coronation day observed":
                case "visakha bucha day observed":
                case "asalaha bucha day observed":
                case "chulalongkorn day observed":
                case "national father's day observed":
                case "khao phansa buddhist lent day observed":
                case "h.m. the queen's birthday observed":
                case "battle of the boyne n. ireland observed":
                case "new year's day 2nd day scotland observed":
                case "st. patrick's day n. ireland observed":
                case "st. andrew's day scotland observed":
                case "christmas holiday observed":
                case "peace day observed":
                case "national heroes' day observed":
                case "all souls' day observed":
                case "national day of mourning observed":
                case "national salvation day observed":
                case "armed forces day observed":
                case "national flag day observed":
                    return "";

                default:
                    if (Helper._h.Add(label.ToLower()))
                    {
                        Trace.WriteLine($"case \"{label.ToLower()}\":");
                        //if (System.Diagnostics.Debugger.IsAttached)
                        //    System.Diagnostics.Debugger.Break();
                    }
                    return "";
            }

        }

        private static Dictionary<Country, List<(string, string)>> GetReferential()
        {
            var txt = Resource1.OUTLOOK.Split('\r');

            Dictionary<Country, List<(string, string)>> _dic = new Dictionary<Country, List<(string, string)>>();
            List<(string, string)> _list = null;

            foreach (var item in txt)
            {
                var t = item.Trim();
                if (!string.IsNullOrEmpty(t))
                {
                    if (t.StartsWith("["))
                    {
                        var label = t.Substring(1, t.IndexOf(']') - 1);
                        label = label
                            .Replace(" ", "_")
                            .Replace(".", "_")

                            .Replace("(", "")
                            .Replace(")", "")
                            .Trim('_')
                            .Trim()
                            ;

                        _list = new List<(string, string)>();

                        if (Enum.TryParse<Country>(label, out Country value))
                            _dic.Add(value, _list);

                    }
                    else
                    {
                        var u = t.Split(',');

                        _list.Add((u[0].Trim(), u[1].Trim()));
                    }
                }
                else
                    _list = null;

            }

            return _dic;

        }


    }
}
