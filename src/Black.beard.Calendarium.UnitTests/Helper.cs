using Bb.Calendarium.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Bb.Calendarium.UnitTests
{

    public static class Helper
    {

        public static readonly Dictionary<Country, List<Referential>> Referential;
        public static readonly Dictionary<Country, List<(string, string)>> Todo;
        private static readonly HashSet<string> _h;

        static Helper()
        {
            Helper.Referential = GetReferential();
            Helper._h = new HashSet<string>();
        }

        public static string GetA(string key)
        {

            switch (key.Trim('"').Trim())
            {

                case "Easter Monday":
                    return "more easter monday";

                case "Assumption":
                    return "assumption";

                case "Accession Day":
                    return "ascension";

                case "Pentecost":
                    return "pentecost";

                case "Pentecost Monday":
                case "Easter Monday Catholic":
                    return "monday pentecost more";

                case "Easter Sunday":
                case "Easter Catholic":
                case "Easter Day":
                case "Easter Day Catholic":
                case "Easter Gregorian":
                    return "easter";

                case "All Saints' Day":
                    return "all saints";

                case "Easter Tuesday":
                case "Whit Monday":
                case "Whit Sunday":
                case "Bastille Day":
                case "23rd of July Revolution Day":
                case "25th of January Revolution Day":
                case "All Souls' Day":
                case "Alponja":
                case "Anexión de Guanacaste":
                case "Anniversary of St. Agatha and Liberation of San Marino":
                case "Anniversary of the Arengo":
                case "Anniversary of the Battle of Pichincha":
                case "Anniversary of the Battle of Puebla":
                case "Anniversary of the Election of Pope Francis":
                case "Anniversary of the Foundation of San Marino":
                case "Anniversary of the May Revolution":
                case "Anniversary of the Shiite Uprising":
                case "Anzac Day":
                case "Aquino Day":
                case "Arafat":
                case "Arafat Day":
                case "Arbaeen":
                case "Armed Forces Day":
                case "Armenian Rememberance Day":
                case "Armistice Day":
                case "Armistice Day 1918":
                case "Army Day":
                case "Army's Day":
                case "Ascension":
                case "Ashoora":
                case "Ashoora 2nd Day":
                case "Ashoora Eve":
                case "Ashura":
                case "Atatürk Memorial & Youth and Sports Day":
                case "August Revolution Commemoration Day":
                case "Australia Day":
                case "Autumn Begins":
                case "Autumn Equinox":
                case "Autumnal Equinox Day":
                case "Awal Muharam":
                case "Bank Holiday":
                case "Battle of Angamos":
                case "Battle of Boyacá":
                case "Battle of Carabobo":
                case "Battle of Las Piedras":
                case "Battle of San Jacinto":
                case "Battle of the Boyne N. Ireland":
                case "Birth of Gral. José Gervasio Artigas":
                case "Birth of Mary":
                case "Birthday of Dr. José Celso Barbosa":
                case "Birthday of Imam Ali":
                case "Birthday of Imam Mahdi":
                case "Birthday of Luis Muñoz Marín":
                case "Bonifacio Day":
                case "Boquerón Battle Day":
                case "Boxing Day":
                case "Bulgarian Army Day St. George's Day":
                case "Canada Day":
                case "Candlemas":
                case "Capital City Day":
                case "Capital Liberation Day":
                case "Carnival":
                case "Carnival 2nd Day":
                case "Chaco Armistice Day":
                case "Chakri Day":
                case "Cheng Ming Festival":
                case "Children's Day":
                case "Children's Day - Eorininal":
                case "Ching Ming Festival":
                case "Christmas":
                case "Christmas 2nd Day":
                case "Christmas and Family Day":
                case "Christmas Catholic":
                case "Christmas Coptic":
                case "Christmas Day":
                case "Christmas Day - Armenian Orthodox":
                case "Christmas Day - Seongtanjeol":
                case "Christmas Day - Western":
                case "Christmas Day Catholic":
                case "Christmas Eve":
                case "Christmas Eve Orthodox":
                case "Christmas Holiday":
                case "Christmas Orthodox":
                case "Christmas Western":
                case "Chulalongkorn Day":
                case "Cold Dews":
                case "Colón Day":
                case "Columbus Day":
                case "Commemoration Day":
                case "Commemoration of General Don Martín Miguel de Güemes":
                case "Commemoration of Green March":
                case "Commemoration of Wadi Al-Dahab":
                case "Constitution Day":
                case "Constitution Day - Jeheonjeol":
                case "Corpus Christi":
                case "Croatian Uprising Day":
                case "Culture Day":
                case "Czech Statehood Day St. Wenceslas Day":
                case "Czechoslovak Independence Day":
                case "Day After Ascension":
                case "Day after New Year's Day":
                case "Day After New Year's Day Quebec":
                case "Day of Action for Tolerance and Respect among People":
                case "Day of Freedom and Democracy":
                case "Day of German Unity":
                case "Day of Goodwill":
                case "Day of Heroes":
                case "Day of Indigenous Resistance":
                case "Day of National Sovereignty":
                case "Day of Prayer and Repentance":
                case "Day of Reconciliation":
                case "Day of Remembrance":
                case "Day of Remembrance for Truth and Justice":
                case "Day of Respect to Cultural Diversity":
                case "Day of the Cultures":
                case "Day of the Establishment of the Slovak Republic":
                case "Day of the Holy Innocents":
                case "Day of the Innocents":
                case "Day of the Leaders of the Bulgarian National Revival":
                case "Day of the Macedonian Revolution":
                case "Day of the Martyrs":
                case "Day of the National Unity":
                case "Day of the President's Report":
                case "Day of the Race":
                case "Day of the Revolution":
                case "Day of the Union of Bulgaria":
                case "Day of the Veterans":
                case "Day of Valor":
                case "Declaration of Independence Day":
                case "Defender of the Fatherland Day":
                case "Defenders of Freedom Day":
                case "Defenders of Ukraine Day":
                case "Demise of Prophet Mohammed":
                case "Democracy and National Solidarity Day":
                case "Democracy Day":
                case "Discovery of Puerto Rico":
                case "Dormition":
                case "Eid al Adha":
                case "Eid al Adha 2nd day":
                case "Eid al Adha 2nd Day":
                case "Eid al Adha 3rd day":
                case "Eid al Adha 3rd Day":
                case "Eid al Adha 4th day":
                case "Eid al Adha 4th Day":
                case "Eid al Adha 5th day":
                case "Eid al Adha 5th Day":
                case "Eid al Adha Observed":
                case "Eid al Fitr":
                case "Eid al Fitr 2nd day":
                case "Eid al Fitr 2nd Day":
                case "Eid al Fitr 3rd day":
                case "Eid al Fitr 3rd Day":
                case "Eid al Fitr 4th day":
                case "Eid al Fitr 5th day":
                case "Eid al Isra' Wal Mi'raj":
                case "Eid Al Isra' Wal Mi'raj":
                case "Eid Norooz":
                case "Eid-e-Fitr":
                case "Eid-e-Fitr 2nd Day":
                case "Eid-e-Ghadir":
                case "Eid-e-Ghorban":
                case "Emancipation Day":
                case "Emperor's Birthday":
                case "Enthronement":
                case "Ephiphany Coptic":
                case "Epiphany":
                case "Europe Day":
                case "Evacuation Day":
                case "Expedition of the 33":
                case "Father's Day":
                case "Feast of Our Lady of Victories":
                case "Feast of Saint Joseph":
                case "Feast of Saint Paul's Shipwreck":
                case "Feast of Saints Peter and Paul":
                case "Feast of the Annunciation":
                case "Feast of the Immaculate Conception":
                case "Feast of the Transfiguration":
                case "Fiestas Patronales":
                case "First Republic Day":
                case "First week-day after Christmas Day":
                case "Flag Day":
                case "Foundation Day":
                case "Foundation of Quito Day":
                case "Foundation of the Communist Party of Vietnam":
                case "Founding of Asunción":
                case "Freedom and Democracy Day":
                case "Freedom Day":
                case "Gandhi Jayanti":
                case "General Framework Agreement Day Republika Srpska":
                case "General Francisco Moranzán's Birthday":
                case "Glorifying Mother of God":
                case "Good Friday":
                case "Good Friday Catholic":
                case "Grain Buds":
                case "Grain in Ear":
                case "Grain Rain":
                case "Grand Duc's Birthday National Day":
                case "Grandfather's Day":
                case "Grandmother's Day":
                case "Great Cold":
                case "Great Heat":
                case "Greek Cypriot National Day":
                case "Greek Independence Day":
                case "Greek National Day":
                case "Greenery Day":
                case "Groundhog Day":
                case "Gurban Bayram":
                case "Gurban Bayram 2nd Day":
                case "H.M. The King Rama IX's Memorial Day":
                case "H.M. The King Rama X's Birthday Anniversary":
                case "H.M. the Queen's Birthday":
                case "H.M. the Sultan's Birthday":
                case "Halloween":
                case "Hangul Day - Hangeulnal":
                case "Hari Raya Aidil Adha":
                case "Hari Raya Aidil Fitri":
                case "Hari Raya Aidil Fitri 2nd Day":
                case "Hari Raya Aidilfitri":
                case "Hari Raya Aidilfitri 2nd Day":
                case "Hari Raya Haji":
                case "Hari Raya Haji 2nd Day":
                case "Hari Raya Puasa":
                case "Heavy Snow":
                case "Heritage Day":
                case "Heroes' Day":
                case "Hijri New Year":
                case "Hoar-Frost Falls":
                case "Holy Saturday":
                case "Holy Thursday":
                case "Holy Wednesday":
                case "Homeland Thanksgiving Day":
                case "Hong Kong SAR Establishment Day":
                case "Human Rights Day":
                case "Immaculate Conception":
                case "Independence Day":
                case "Independence Day 2nd Day":
                case "Independence Day Bosnia and Herzegovina":
                case "Independence Movement Day - Samiljeol":
                case "Independence of Cuenca":
                case "Independence of Guayaquil":
                case "Independence Restoration Day":
                case "Indian Arrival Day":
                case "Indigenous Resistance Day":
                case "Insects Awaken":
                case "International Holocaust Remembrance Day":
                case "International Labour Day":
                case "International Women's Day":
                case "International Workers' Day":
                case "Investiture of the Captains-Regent":
                case "Iranian New Year":
                case "Iranian New Year 2nd Day":
                case "Iranian New Year 3rd Day":
                case "Iranian New Year 4th Day":
                case "Isra' Mi'raj":
                case "Jamhuri Day":
                case "John Huss Day":
                case "Juan Pablo Duarte Day":
                case "Juan Santamaría":
                case "Kazakhstan People's Unity Day":
                case "King's Day":
                case "King's Feast":
                case "Kupala Night":
                case "Kurban ayt":
                case "Labor and Solidarity Day":
                case "Labor Day":
                case "Labor Day 2nd Day":
                case "Labor Thanksgiving Day":
                case "Labour Day":
                case "Lady of Altagracia":
                case "Lady of Mercedes":
                case "Lailat al-Ma'raj":
                case "Lateran Treaty Day":
                case "Liberation Day":
                case "Liberation Day - Gwangbokjeol":
                case "Liberation Day-Reunification Day":
                case "Liberation of Monaco":
                case "Liberation War Day":
                case "Light Snow":
                case "Los Santos Uprising Day":
                case "Macao Special Administrative Region Establishment Day":
                case "Madaraka Day":
                case "Malaysia Day":
                case "Manifesto of Independence":
                case "Martisor":
                case "Martyrdom of Fatima Zahra":
                case "Martyrdom of Imam Ali":
                case "Martyrdom of Imam Reza":
                case "Martyrdom of Imam Sadeq":
                case "Martyrs' Day":
                case "Martyr's Day":
                case "Mashujaa Heroes' Day":
                case "Maundy Thursday":
                case "May Day":
                case "May Day Eve":
                case "Memorial Day":
                case "Memorial Day - Hyeonchung-il":
                case "Memorial Day for the Martyrs of Arad":
                case "Memorial Day Newfoundland and Labrador":
                case "Midsummer Day":
                case "Midsummer Eve":
                case "Mission of Prophet Mohammed":
                case "Mother Theresa Day":
                case "Motherland Defender's Day":
                case "Mothers' Day":
                case "Mother's Day":
                case "Mountain Day":
                case "National Aboriginal Day Northwest Territories":
                case "National Day":
                case "National Day 2nd Day":
                case "National Day 3rd Day":
                case "National Day of Black Awareness":
                case "National Day of Mourning":
                case "National Day of the People's Republic of China":
                case "National Day of the People's Republic of China 2nd Day":
                case "National Defense Day":
                case "National Father's Day":
                case "National Flag Day":
                case "National Foundation Day":
                case "National Founding Day - Gaecheonjeol":
                case "National Heroes' Day":
                case "National Holiday":
                case "National Language Day":
                case "National Resistance Day":
                case "National Salvation Day":
                case "National Sovereignty and Children's Day":
                case "National Unity Day":
                case "National Youth Day":
                case "Nativity of Mary":
                case "Nativity of the Theotokos":
                case "Nature Day":
                case "Nauryz Meyrami":
                case "Naval Glories Day":
                case "Nevruz":
                case "New Year's 2nd Day":
                case "New Year's Day":
                case "New Year's Day - Sinjeong":
                case "New Year's Day 2nd Day":
                case "New Year's Day 2nd Day Scotland":
                case "New Year's Eve":
                case "New Year's Holiday":
                case "New Year's Holiday Week":
                case "New Year's Orthodox":
                case "Novruz Bayram":
                case "Nunavut Day Nunavut":
                case "Nuzul al-Quraan":
                case "October Revolution":
                case "October Revolution Day":
                case "Orthodox New Year":
                case "Our Lady of Aparecida":
                case "Our Lady of Guadalupe":
                case "Our Lady of Meritxell":
                case "Our Lady of Mount Carmel":
                case "Our Lady of the Angels":
                case "Panamerican Day":
                case "Parents' Day":
                case "Party's Day":
                case "Peace Day":
                case "People Power Day":
                case "Pesach":
                case "President Ho Chi Minh's Birthday":
                case "President's Day":
                case "Prophet Mohammed's Birthday":
                case "Prophet Mohammed's Birthday 2nd Day":
                case "Prophet Mohammed's Birthday Shia":
                case "Prophet Mohammed's Birthday Sunni":
                case "Quebec National Day - St. John the Baptist Day Quebec":
                case "Ramazan":
                case "Ramazan 2nd Day":
                case "Reformation Day":
                case "Re-Independence Day":
                case "Remembrance Day":
                case "Renaissance Day":
                case "Republic Day":
                case "Republic Day Eve":
                case "Resistance and Liberation Day":
                case "Restoration Day":
                case "Restoration of Independence of the Republic of Latvia Day":
                case "Reunion Day":
                case "Revolution and Youth Day":
                case "Revolution Day":
                case "Revolution of the King and the People":
                case "Rizal Day":
                case "Rose of Lima Day":
                case "Russia Day":
                case "Saint George":
                case "Saint Joseph the Worker":
                case "Saint Joseph's Day":
                case "Saint Paul's Day":
                case "Sainte-Dévote":
                case "Sandinista Revolution Anniversary":
                case "Separation Day":
                case "September Revolution":
                case "Serbian New Year":
                case "Sette Giugno":
                case "Shab-e-Miraj":
                case "Shōwa Day":
                case "Simón Bolivar Day":
                case "Símon Bolívar Day":
                case "Sinai Liberation Day":
                case "Slight Cold":
                case "Slight Heat":
                case "Slovak National Uprising":
                case "Solemnity of Mary Mother of God":
                case "Solidarity of Azerbaijanis":
                case "Songkran Festival":
                case "Songkran Festival Observed":
                case "Sovereignty Day of Montenegro":
                case "Sovereignty Day of Montenegro 2nd Day":
                case "Sovereignty Day of Serbia":
                case "Spring and Labor Day":
                case "Spring Begins":
                case "Spritual Baptist Day":
                case "St. Andrew":
                case "St. Andrew's Day":
                case "St. Andrew's Day Scotland":
                case "St. Berchtold":
                case "St. Carlos Borromeo":
                case "St. Clement of Ohrid":
                case "St. Cyril and St. Methodius":
                case "St. Cyril and St. Methodius Day Education & Culture Day":
                case "St. Demetrius' Day":
                case "St. Elijah's Day":
                case "St. George":
                case "St. George's Day":
                case "St. John":
                case "St. John the Baptist":
                case "St. Joseph":
                case "St. Joseph's Day":
                case "St. Lucia":
                case "St. Maron":
                case "St. Nicholas":
                case "St. Nicholas' Eve":
                case "St. Patrick's Day":
                case "St. Patrick's Day N. Ireland":
                case "St. Peter and St. Paul":
                case "St. Peter's Day":
                case "St. Sava":
                case "St. Stephen's Day":
                case "St. Vitus":
                case "St. Vitus's Day":
                case "Start of Ramadan":
                case "State Day":
                case "Statehood Day":
                case "Statehood Day Bosnia and Herzegovina":
                case "Stopping the Heat":
                case "Sukkot":
                case "Sultan's Birthday":
                case "Summer Begins":
                case "Summer Day":
                case "Summer Solstice":
                case "Svetickhovloba":
                case "Sylvester":
                case "Tasua":
                case "Tax Day":
                case "Teacher's Day":
                case "The Rains":
                case "The Yang di-Pertuan Agong's Birthday":
                case "Three Kings Day":
                case "Three Kings Eve":
                case "Tiradentes Day":
                case "Tomb Sweeping Day Ching Ming Festival":
                case "Twelfth Night":
                case "Union Day of Belarus and Russia":
                case "Valentine's Day":
                case "Vernal Equinox":
                case "Vernal Equinox Day":
                case "Veteran's Day":
                case "Victory and Peace Day":
                case "Victory Day":
                case "Victory Day Republika Srpska":
                case "Vietnamese Family Day":
                case "Vietnamese Women's Day":
                case "Vigil of Assumption":
                case "Virgin Mary":
                case "Virgin Mary of the Seven Sorrows":
                case "Virgin of Caacupé":
                case "Virgin of Suyapa":
                case "Waitangi Day":
                case "Walpurgis Night":
                case "Western Christmas":
                case "White Dews":
                case "Winter Begins":
                case "Winter Solstice":
                case "Women's Day":
                case "Worker's Day":
                case "Year End Bank Holiday":
                case "Yennayer":
                case "Yizhak Rabin Memorial Day":
                case "Yom Hashoah":
                case "Yom Kippur":
                case "Yom Yerushalaim":
                case "Youth Day":

                    return "orthodox christmas";
                    return "orthodox easter";
                    return "orthodox holy friday";
                    return "orthodox pentecost";
                    return "monday to orthodox whit";

                    return "ashura";
                    return "assumption";
                    return "christmas";
                    return "diwali";
                    return "epiphany";
                    return "fast tisha b'av";
                    return "fasten 17. tammuz";
                    return "fasten gedalia";
                    return "fasten taanit esther";
                    return "feast of the breaking ( eid ul-fitr)";
                    return "feast of the candlemas";
                    return "friday saint";
                    return "hanukkah # 1";
                    return "hanukkah # 2";
                    return "hanukkah # 3";
                    return "hanukkah # 4";
                    return "hanukkah # 5";
                    return "hanukkah # 6";
                    return "hanukkah # 7";
                    return "hanukkah # 8";
                    return "jom kippur";
                    return "lailat al miraj";
                    return "laylat ul bara'ah";
                    return "mawlid";
                    return "monday fat orthodox";

                    return "new year islamic";
                    return "night of destiny ( laylat al-qadr)";

                    return "pesach #1";
                    return "pesach #2";
                    return "pesach chol hamoed #1";
                    return "pesach chol hamoed #2";
                    return "pesach chol hamoed #3";
                    return "pesach chol hamoed #4";
                    return "purim";
                    return "ramadan";
                    return "rosh hashana #1";
                    return "rosh hashana #2";
                    return "schmin azeret";
                    return "shavuot";
                    return "simchat tora";
                    return "standby of christmas";
                    return "sukkot #1";
                    return "sukkot #2";
                    return "sukkot chol hamoed #1";
                    return "sukkot chol hamoed #2";
                    return "sukkot chol hamoed #3";
                    return "sukkot chol hamoed #4";
                    return "sukkot chol hamoed #5";

                default:
                    break;
            }

            return string.Empty;

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

                case "easter monday orthodox":
                    return "[ORTHODOX_EASTER] + 1";

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

                case "christmas holiday orthodox":
                case "christmas day - armenian orthodox observed":
                    return "";

                case "good friday orthodox":
                    return "[ORTHODOX_EASTER] - 2";

                case "good friday":
                case "good friday catholic":
                    return "([EASTER]) - 2";

                case "holy saturday":
                    return "([EASTER]) - 1";

                case "easter day orthodox":
                case "easter orthodox":
                    return "[ORTHODOX_EASTER]";

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

        private static Dictionary<Country, List<Referential>> GetReferential()
        {

            List<Referential> _lObserved;
            List<Referential> _l2;

            var txt = Resource1.OUTLOOK.Split('\r');

            Dictionary<Country, List<Referential>> _dic = new Dictionary<Country, List<Referential>>();
            List<Referential> _list = null;

            foreach (var item in txt)
            {

                var t = item.Trim();
                if (!string.IsNullOrEmpty(t))
                {
                    if (t.StartsWith("["))
                    {

                        if (_list != null)
                        {
                            _lObserved = _list.Where(c => c.Observed).ToList();
                            _l2 = _list.Where(c => !c.Observed).ToList();
                            foreach (var item2 in _lObserved)
                            {
                                var ds = _l2.Where(c => c.DayName.ToLower().Replace("day", "").Trim() == item2.DayName.ToLower().Replace("day", "").Trim()).ToList();
                                ds = ds.Where(c => item2.Date.Substring(0, 4) == c.Date.Substring(0, 4)).ToList();
                                if (ds.Count > 1)
                                {

                                }
                                var d = ds.FirstOrDefault();
                                if (d != null)
                                    d.ObservedDate = item2;

                                else
                                {
                                    var r = new Referential()
                                    {
                                        Date = item2.Date,
                                        DayName = item2.DayName,
                                        ObservedDate = item2,
                                        Reconstitued = true,
                                    };
                                    _list.Add(r);
                                }

                                _list.Remove(item2);
                            }
                        }

                        var label = t.Substring(1, t.IndexOf(']') - 1);
                        label = label
                            .Replace(" ", "_")
                            .Replace(".", "_")

                            .Replace("(", "")
                            .Replace(")", "")
                            .Trim('_')
                            .Trim()
                            ;

                        _list = new List<Referential>();

                        if (Enum.TryParse<Country>(label, out Country value))
                            _dic.Add(value, _list);

                        //if (value == Country.Bahrain)
                        //{

                        //}

                    }
                    else
                    {
                        var u = t.Split(',');

                        var day = u[0].Trim();
                        if (day.ToLower().EndsWith(" observed"))
                        {
                            day = day.Substring(0, day.Length - "observed".Length).Trim();
                            _list.Add(new Referential() { DayName = day, Date = u[1].Trim(), Observed = true, });
                        }
                        else
                            _list.Add(new Referential() { DayName = day, Date = u[1].Trim() });
                    }
                }

            }

            _lObserved = _list.Where(c => c.Observed).ToList();
            _l2 = _list.Where(c => !c.Observed).ToList();
            foreach (var item2 in _lObserved)
            {
                var d = _l2.FirstOrDefault(c => c.DayName.ToLower().Replace("day", "").Trim() == item2.DayName.ToLower().Replace("day", "").Trim() && item2.Date.Substring(0, 4) == c.Date.Substring(0, 4));
                if (d != null)
                    d.ObservedDate = item2;
                else
                {
                    var r = new Referential()
                    {
                        Date = item2.Date,
                        DayName = item2.DayName,
                        ObservedDate = item2,
                        Reconstitued = true,
                    };
                    _list.Add(r);
                }
                _list.Remove(item2);
            }
            return _dic;

        }



    }
    public class Referential
    {
        public string DayName { get; internal set; }
        public string Date { get; internal set; }
        public bool Observed { get; internal set; }
        public DateTime Date2 { get; internal set; }
        public Referential ObservedDate { get; internal set; }
        public bool Reconstitued { get; internal set; }

        public override string ToString()
        {
            return $"{DayName} : {Date} : Observed = {Observed}";
        }

    }

}
