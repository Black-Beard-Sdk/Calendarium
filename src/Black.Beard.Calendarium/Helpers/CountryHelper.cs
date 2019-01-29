namespace Bb.Calendarium.Configuration
{

    public static class CountryHelper
    {

        public static (string, string, CalendarEnum[]) GetInfos(Country country)
        {

            switch (country)
            {
                case Country.Trinidad_and_Tobago: return ("English (Trinidad and Tobago)", "en-TT", new CalendarEnum[] { CalendarEnum.Gregorian, CalendarEnum.Gregorian });
                case Country.Congo_Democratic_Republic_of : return ("French Congo (DRC)", "fr-CD", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Vietnam : return ("Vietnamese", "vi", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Brunei: return ("Korean (Korea)", "ko-KR", new CalendarEnum[] { CalendarEnum.Gregorian, CalendarEnum.Korean, CalendarEnum.Gregorian });
                case Country.Korea: return ("Korean (Korea)", "ko-KR", new CalendarEnum[] { CalendarEnum.Gregorian, CalendarEnum.Korean, CalendarEnum.Gregorian });
                case Country.Algeria: return ("Algeria", "ar-DZ", new CalendarEnum[] { CalendarEnum.Gregorian, CalendarEnum.Hijri, CalendarEnum.UmAlQura });
                case Country.Russia: return ("Russian", "ru", new CalendarEnum[] { CalendarEnum.Gregorian, CalendarEnum.Hijri });
                case Country.South_Africa: return ("Afrikaans (South Africa)", "af-ZA", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Armenia: return ("Amharic", "am", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Argentina: return ("Arabic", "ar", new CalendarEnum[] { CalendarEnum.UmAlQura, CalendarEnum.Hijri, CalendarEnum.Gregorian });
                case Country.United_Arab_Emirates: return ("Arabic (United Arab Emirates)", "ar-AE", new CalendarEnum[] { CalendarEnum.Gregorian, CalendarEnum.UmAlQura, CalendarEnum.Hijri });
                case Country.Bahrain: return ("Arabic (Bahrain)", "ar-BH", new CalendarEnum[] { CalendarEnum.Gregorian, CalendarEnum.UmAlQura, CalendarEnum.Hijri });
                case Country.Egypt: return ("Arabic (Egypt)", "ar-EG", new CalendarEnum[] { CalendarEnum.Gregorian, CalendarEnum.UmAlQura, CalendarEnum.Hijri });
                case Country.Israel: return ("Arabic (Israel)", "ar-IL", new CalendarEnum[] { CalendarEnum.Gregorian, CalendarEnum.Hebrew, CalendarEnum.Hijri, CalendarEnum.UmAlQura });
                case Country.Iraq: return ("Arabic (Iraq)", "ar-IQ", new CalendarEnum[] { CalendarEnum.Gregorian, CalendarEnum.UmAlQura, CalendarEnum.Hijri });
                case Country.Jordan: return ("Arabic (Jordan)", "ar-JO", new CalendarEnum[] { CalendarEnum.Gregorian, CalendarEnum.UmAlQura, CalendarEnum.Hijri });
                case Country.Kuwait: return ("Arabic (Kuwait)", "ar-KW", new CalendarEnum[] { CalendarEnum.Gregorian, CalendarEnum.Hijri, CalendarEnum.UmAlQura });
                case Country.Lebanon: return ("Arabic (Lebanon)", "ar-LB", new CalendarEnum[] { CalendarEnum.Gregorian, CalendarEnum.UmAlQura, CalendarEnum.Hijri });
                case Country.Morocco: return ("Arabic (Morocco)", "ar-MA", new CalendarEnum[] { CalendarEnum.Gregorian, CalendarEnum.Hijri, CalendarEnum.UmAlQura });
                case Country.Oman: return ("Arabic (Oman)", "ar-OM", new CalendarEnum[] { CalendarEnum.Gregorian, CalendarEnum.Hijri, CalendarEnum.UmAlQura });
                case Country.Qatar: return ("Arabic (Qatar)", "ar-QA", new CalendarEnum[] { CalendarEnum.Gregorian, CalendarEnum.UmAlQura, CalendarEnum.Hijri });
                case Country.Saudi_Arabia: return ("Arabic (Saudi Arabia)", "ar-SA", new CalendarEnum[] { CalendarEnum.UmAlQura, CalendarEnum.Hijri, CalendarEnum.Gregorian });
                case Country.Syria: return ("Arabic (Syria)", "ar-SY", new CalendarEnum[] { CalendarEnum.Gregorian, CalendarEnum.UmAlQura, CalendarEnum.Hijri });
                case Country.Tunisia: return ("Arabic (Tunisia)", "ar-TN", new CalendarEnum[] { CalendarEnum.Gregorian, CalendarEnum.Hijri, CalendarEnum.UmAlQura });
                case Country.Yemen: return ("Arabic (Yemen)", "ar-YE", new CalendarEnum[] { CalendarEnum.Gregorian, CalendarEnum.UmAlQura, CalendarEnum.Hijri });
                case Country.Chile: return ("Mapudungun (Chile)", "arn-CL", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.India: return ("Assamese (India)", "as-IN", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Spain: return ("Asturian (Spain)", "ast-ES", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Azerbaijan: return ("Azerbaijani", "az", new CalendarEnum[] { CalendarEnum.Gregorian, CalendarEnum.Hijri });
                case Country.Bosnia_and_Herzegovina: return ("Bashkir", "ba", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Belgium: return ("Belarusian", "be", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Belarus: return ("Belarusian (Belarus)", "be-BY", new CalendarEnum[] { CalendarEnum.Gregorian }); ;
                case Country.Bulgaria: return ("Bulgarian", "bg", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Nigeria: return ("Edo (Nigeria)", "bin-NG", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Bolivia: return ("Tibetan", "bo", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.China: return ("Tibetan (China)", "bo-CN", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Brazil : return ("Portuguese (Brazil)", "pt-BR", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.France: return ("France", "fr-FR", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Canada: return ("Canada", "ca", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Andorra: return ("Catalan (Andorra)", "ca-AD", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Undefined: return ("Valencian (Spain)", "ca-ES-valencia", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Italy: return ("Italy", "it-IT", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.United_States: return ("United States", "en-US", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Colombia : return ("Spanish (Colombia)", "CO", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Czechia: return ("Czech (Czechia)", "cs-CZ", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Cyprus: return ("Cyprus", "cy", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.United_Kingdom: return ("United Kingdom", "en-GB", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Denmark: return ("Danish (Denmark)", "da-DK", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Kenya: return ("Kenya", "KE", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Germany: return ("German", "de", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Austria: return ("Austria", "at", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Switzerland: return ("German (Switzerland)", "de-CH", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Liechtenstein: return ("German (Liechtenstein)", "de-LI", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Luxembourg: return ("German (Luxembourg)", "de-LU", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Estonia: return ("Estonian (Estonia)", "et-EE", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Greece: return ("Greek (Greece)", "el-GR", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Australia: return ("English (Australia)", "en-AU", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Finland: return ("English (Finland)", "en-FI", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Hong_Kong_S_A_R: return ("English (Hong Kong SAR)", "en-HK", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Ireland: return ("English (Ireland)", "en-IE", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Jamaica: return ("English (Jamaica)", "en-JM", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Macao_S_A_R: return ("English (Macao SAR)", "en-MO", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Malta: return ("English (Malta)", "en-MT", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Malaysia: return ("English (Malaysia)", "en-MY", new CalendarEnum[] { CalendarEnum.Gregorian, CalendarEnum.Hijri });
                case Country.Netherlands: return ("English (Netherlands)", "en-NL", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.New_Zealand: return ("English (New Zealand)", "en-NZ", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Philippines: return ("English (Philippines)", "en-PH", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Pakistan: return ("English (Pakistan)", "en-PK", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Puerto_Rico: return ("English (Puerto Rico)", "en-PR", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Sweden: return ("English (Sweden)", "en-SE", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Singapore: return ("English (Singapore)", "en-SG", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Slovenia: return ("English (Slovenia)", "en-SI", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Costa_Rica: return ("Spanish (Costa Rica)", "es-CR", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Dominican_Republic: return ("Spanish (Dominican Republic)", "es-DO", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Ecuador: return ("Spanish (Ecuador)", "es-EC", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Equatorial_Guinea: return ("Spanish (Equatorial Guinea)", "es-GQ", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Guatemala: return ("Spanish (Guatemala)", "es-GT", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Honduras: return ("Spanish (Honduras)", "es-HN", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Mexico: return ("Spanish (Mexico)", "es-MX", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Nicaragua: return ("Spanish (Nicaragua)", "es-NI", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Panama: return ("Spanish (Panama)", "es-PA", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Peru: return ("Spanish (Peru)", "es-PE", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Paraguay: return ("Spanish (Paraguay)", "es-PY", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.El_Salvador: return ("Spanish (El Salvador)", "es-SV", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Uruguay: return ("Spanish (Uruguay)", "es-UY", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Venezuela: return ("Spanish (Venezuela)", "es-VE", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Iran: return ("Persian (Iran)", "fa-IR", new CalendarEnum[] { CalendarEnum.Persian, CalendarEnum.Gregorian, CalendarEnum.Hijri });
                case Country.Monaco: return ("French (Monaco)", "fr-MC", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Croatia: return ("Croatian", "hr", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Hungary: return ("Hungarian", "hu", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Iceland: return ("Icelandic", "is", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.San_Marino: return ("Italian (San Marino)", "it-SM", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Holy_See_Vatican_City: return ("Italian (Vatican City)", "it-VA", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Japan: return ("Japanese (Japan)", "ja-JP", new CalendarEnum[] { CalendarEnum.Gregorian, CalendarEnum.Japanese });
                case Country.Georgia: return ("Georgian (Georgia)", "ka-GE", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Kazakhstan: return ("Kazakh (Kazakhstan)", "kk-KZ", new CalendarEnum[] { CalendarEnum.Gregorian, CalendarEnum.Hijri });
                case Country.Angola: return ("Lingala (Angola)", "ln-AO", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Lithuania: return ("Lithuanian", "lt", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Latvia: return ("Latvian", "lv", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Macedonia_FYRO: return ("Macedonian", "mk", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Norway: return ("Norwegian Bokmål (Norway)", "nb-NO", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Poland: return ("Polish", "pl", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Portugal: return ("Portuguese", "pt", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Romania: return ("Romanian", "ro", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Moldova: return ("Romanian (Moldova)", "ro-MD", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Ukraine: return ("Russian (Ukraine)", "ru-UA", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Slovakia: return ("Slovak", "sk", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Albania: return ("Albanian (Albania)", "sq-AL", new CalendarEnum[] { CalendarEnum.Gregorian, CalendarEnum.Hijri });
                case Country.Montenegro: return ("Serbian (Cyrillic, Montenegro)", "sr-Cyrl-ME", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Serbia: return ("Serbian (Cyrillic, Serbia)", "sr-Cyrl-RS", new CalendarEnum[] { CalendarEnum.Gregorian });
                case Country.Thailand: return ("Thai", "th", new CalendarEnum[] { CalendarEnum.ThaiBuddhist, CalendarEnum.Gregorian });
                case Country.Turkey: return ("Turkish", "tr", new CalendarEnum[] { CalendarEnum.Gregorian, CalendarEnum.Hijri });

                default:
                    if (System.Diagnostics.Debugger.IsAttached)
                        System.Diagnostics.Debugger.Break();
                    return ("", "", new CalendarEnum[] { });
            }




        }

        public static Country GetCountryFromIso2(this string self)
        {

            switch (self.ToUpper())
            {

                //case "AF": return Country.Afghanistan;
                //case "AX": return Country.Aland_Islands;
                case "AL": return Country.Albania;
                case "DZ": return Country.Algeria;
                //case "AS": return Country.American_Samoa;
                case "AD": return Country.Andorra;
                case "AO": return Country.Angola;
                //case "AI": return Country.Anguilla;
                //case "AQ": return Country.Antarctica;
                //case "AG": return Country.Antigua_and_Barbuda;
                case "AR": return Country.Argentina;
                case "AM": return Country.Armenia;
                //case "AW": return Country.Aruba;
                case "AU": return Country.Australia;
                case "AT": return Country.Austria;
                case "AZ": return Country.Azerbaijan;
                //case "BS": return Country.Bahamas;
                case "BH": return Country.Bahrain;
                //case "BD": return Country.Bangladesh;
                //case "BB": return Country.Barbados;
                case "BY": return Country.Belarus;
                case "BE": return Country.Belgium;
                //case "BZ": return Country.Belize;
                //case "BJ": return Country.Benin;
                //case "BM": return Country.Bermuda;
                //case "BT": return Country.Bhutan;
                case "BO": return Country.Bolivia;
                case "BA": return Country.Bosnia_and_Herzegovina;
                //case "BW": return Country.Botswana;
                //case "BV": return Country.Bouvet_Island;
                case "BR": return Country.Brazil;
                //case "VG": return Country.British_Virgin_Islands;
                //case "IO": return Country.British_Indian_Ocean_Territory;
                //case "BN": return Country.Brunei_Darussalam;
                case "BG": return Country.Bulgaria;
                //case "BF": return Country.Burkina_Faso;
                //case "BI": return Country.Burundi;
                //case "KH": return Country.Cambodia;
                //case "CM": return Country.Cameroon;
                case "CA": return Country.Canada;
                //case "CV": return Country.Cape_Verde;
                //case "KY": return Country.Cayman_Islands;
                //case "CF": return Country.Central_African_Republic;
                //case "TD": return Country.Chad;
                case "CL": return Country.Chile;
                case "CN": return Country.China;
                case "HK": return Country.Hong_Kong_S_A_R;
                case "MO": return Country.Macao_S_A_R;
                //case "CX": return Country.Christmas_Island;
                //case "CC": return Country.Cocos_Keeling_Islands;
                case "CO": return Country.Colombia;
                //case "KM": return Country.Comoros;
                //case "CG": return Country.Congo(Brazzaville);
                case "CD": return Country.Congo_Democratic_Republic_of;     // , (Kinshasa);
                //case "CK": return Country.Cook_Islands;
                case "CR": return Country.Costa_Rica;
                //case "CI": return Country.Cote_d_Ivoire;
                case "HR": return Country.Croatia;
                //case "CU": return Country.Cuba;
                case "CY": return Country.Cyprus;
                case "CZ": return Country.Czechia;
                case "DK": return Country.Denmark;
                //case "DJ": return Country.Djibouti;
                //case "DM": return Country.Dominica;
                case "DO": return Country.Dominican_Republic;
                case "EC": return Country.Ecuador;
                case "EG": return Country.Egypt;
                case "SV": return Country.El_Salvador;
                case "GQ": return Country.Equatorial_Guinea;
                //case "ER": return Country.Eritrea;
                case "EE": return Country.Estonia;
                //case "ET": return Country.Ethiopia;
                //case "FK": return Country.Falkland_Islands; // (Malvinas)
                //case "FO": return Country.Faroe_Islands;
                //case "FJ": return Country.Fiji;
                case "FI": return Country.Finland;
                case "FR": return Country.France;
                //case "GF": return Country.French Guiana;
                //case "PF": return Country.French Polynesia;
                //case "TF": return Country.French Southern Territories;
                //case "GA": return Country.Gabon;
                //case "GM": return Country.Gambia;
                case "GE": return Country.Georgia;
                case "DE": return Country.Germany;
                //case "GH": return Country.Ghana;
                //case "GI": return Country.Gibraltar;
                case "GR": return Country.Greece;
                //case "GL": return Country.Greenland;
                //case "GD": return Country.Grenada;
                //case "GP": return Country.Guadeloupe;
                //case "GU": return Country.Guam;
                case "GT": return Country.Guatemala;
                //case "GG": return Country.Guernsey;
                case "GN": return Country.Equatorial_Guinea;
                //case "GW": return Country.Bissau_Guinea;
                //case "GY": return Country.Guyana;
                //case "HT": return Country.Haiti;
                //case "HM": return Country.Heard_and_Mcdonald_Islands;
                case "VA": return Country.Holy_See_Vatican_City;
                case "HN": return Country.Honduras;
                case "HU": return Country.Hungary;
                case "IS": return Country.Iceland;
                case "IN": return Country.India;
                //case "ID": return Country.Indonesia;
                case "IR": return Country.Iran;
                case "IQ": return Country.Iraq;
                case "IE": return Country.Ireland;
                //case "IM": return Country.Isle_of_Man;
                case "IL": return Country.Israel;
                case "IT": return Country.Italy;
                case "JM": return Country.Jamaica;
                case "JP": return Country.Japan;
                //case "JE": return Country.Jersey;
                case "JO": return Country.Jordan;
                case "KZ": return Country.Kazakhstan;
                case "KE": return Country.Kenya;
                //case "KI": return Country.Kiribati;
                //case "KP": return Country.Korea_North;
                //case "KR": return Country.Korea_South;
                case "KW": return Country.Kuwait;
                //case "KG": return Country.Kyrgyzstan;
                //case "LA": return Country.Lao_PDR;
                case "LV": return Country.Latvia;
                case "LB": return Country.Lebanon;
                //case "LS": return Country.Lesotho;
                //case "LR": return Country.Liberia;
                //case "LY": return Country.Libya;
                case "LI": return Country.Liechtenstein;
                case "LT": return Country.Lithuania;
                case "LU": return Country.Luxembourg;
                case "MK": return Country.Macedonia_FYRO;
                //case "MG": return Country.Madagascar;
                //case "MW": return Country.Malawi;
                case "MY": return Country.Malaysia;
                //case "MV": return Country.Maldives;
                //case "ML": return Country.Mali;
                case "MT": return Country.Malta;
                //case "MH": return Country.Marshall_Islands;
                //case "MQ": return Country.Martinique;
                //case "MR": return Country.Mauritania;
                //case "MU": return Country.Mauritius;
                //case "YT": return Country.Mayotte;
                case "MX": return Country.Mexico;
                //case "FM": return Country.Micronesia;
                case "MD": return Country.Moldova;
                case "MC": return Country.Monaco;
                //case "MN": return Country.Mongolia;
                case "ME": return Country.Montenegro;
                //case "MS": return Country.Montserrat;
                case "MA": return Country.Morocco;
                //case "MZ": return Country.Mozambique;
                //case "MM": return Country.Myanmar;
                //case "NA": return Country.Namibia;
                //case "NR": return Country.Nauru;
                //case "NP": return Country.Nepal;
                case "NL": return Country.Netherlands;
                //case "AN": return Country.Netherlands_Antilles;
                //case "NC": return Country.New_Caledonia;
                case "NZ": return Country.New_Zealand;
                case "NI": return Country.Nicaragua;
                //case "NE": return Country.Niger;
                case "NG": return Country.Nigeria;
                //case "NU": return Country.Niue;
                //case "NF": return Country.Norfolk_Island;
                //case "MP": return Country.Northern_Mariana_Islands;
                case "NO": return Country.Norway;
                case "OM": return Country.Oman;
                case "PK": return Country.Pakistan;
                //case "PW": return Country.Palau;
                //case "PS": return Country.Palestinian_Territory;
                case "PA": return Country.Panama;
                //case "PG": return Country.Papua_New_Guinea;
                case "PY": return Country.Paraguay;
                case "PE": return Country.Peru;
                case "PH": return Country.Philippines;
                //case "PN": return Country.Pitcairn;
                case "PL": return Country.Poland;
                case "PT": return Country.Portugal;
                case "PR": return Country.Puerto_Rico;
                case "QA": return Country.Qatar;
                //case "RE": return Country.Reunion;
                case "RO": return Country.Romania;
                case "RU": return Country.Russia;
                //case "RW": return Country.Rwanda;
                //case "BL": return Country.Saint_Barthélemy;
                //case "SH": return Country.Saint_Helena;
                //case "KN": return Country.Saint_Kitts_and_Nevis;
                //case "LC": return Country.Saint_Lucia;
                //case "MF": return Country.Saint_Martin;
                //case "PM": return Country.Saint_Pierre_and_Miquelon;
                //case "VC": return Country.Saint_Vincent_and_Grenadines;
                //case "WS": return Country.Samoa;
                case "SM": return Country.San_Marino;
                //case "ST": return Country.Sao_Tome_and_Principe;
                case "SA": return Country.Saudi_Arabia;
                //case "SN": return Country.Senegal;
                case "RS": return Country.Serbia;
                //case "SC": return Country.Seychelles;
                //case "SL": return Country.Sierra_Leone;
                case "SG": return Country.Singapore;
                case "SK": return Country.Slovakia;
                case "SI": return Country.Slovenia;
                //case "SB": return Country.Solomon_Islands;
                //case "SO": return Country.Somalia;
                case "ZA": return Country.South_Africa;
                //case "GS": return Country.South_Georgia_and_the_South_Sandwich_Islands;
                //case "SS": return Country.South_Sudan;
                case "ES": return Country.Spain;
                //case "LK": return Country.Sri_Lanka;
                //case "SD": return Country.Sudan;
                //case "SR": return Country.Suriname;
                //case "SJ": return Country.Svalbard_and_Jan_Mayen_Islands;
                //case "SZ": return Country.Swaziland;
                case "SE": return Country.Sweden;
                case "CH": return Country.Switzerland;
                case "SY": return Country.Syria;
                //case "TW": return Country.Taiwan;
                //case "TJ": return Country.Tajikistan;
                //case "TZ": return Country.Tanzania;
                case "TH": return Country.Thailand;
                //case "TL": return Country.Timor;
                //case "TG": return Country.Togo;
                //case "TK": return Country.Tokelau;
                //case "TO": return Country.Tonga;
                case "TT": return Country.Trinidad_and_Tobago;
                case "TN": return Country.Tunisia;
                case "TR": return Country.Turkey;
                //case "TM": return Country.Turkmenistan;
                //case "TC": return Country.Turks_and_Caicos_Islands;
                //case "TV": return Country.Tuvalu;
                //case "UG": return Country.Uganda;
                case "UA": return Country.Ukraine;
                case "AE": return Country.United_Arab_Emirates;
                case "GB": return Country.United_Kingdom;
                case "US": return Country.United_States;
                //case "UM": return Country.US_Minor_Outlying_Islands;
                case "UY": return Country.Uruguay;
                //case "UZ": return Country.Uzbekistan;
                //case "VU": return Country.Vanuatu;
                case "VE": return Country.Venezuela;
                case "VN": return Country.Vietnam;
                //case "VI": return Country.Virgin_Islands_US;
                //case "WF": return Country.Wallis_and_Futuna_Islands;
                //case "EH": return Country.Western_Sahara;
                case "YE": return Country.Yemen;
                //case "ZM": return Country.Zambia;
                //case "ZW": return Country.Zimbabwe;

                default:
                    return Country.Undefined;

            }

        }

    }

}




//case ??? : return ("Invariant Language (Invariant Country)", "", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Afar", "aa", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Afar (Djibouti)", "aa-DJ", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("Afar (Eritrea)", "aa-ER", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("Afar (Ethiopia)", "aa-ET", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Afrikaans", "af", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Afrikaans (Namibia)", "af-NA", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Afrikaans (South Africa)", "af-ZA", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Aghem", "agq", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Aghem (Cameroon)", "agq-CM", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Akan", "ak", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Akan (Ghana)", "ak-GH", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Amharic", "am", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Amharic (Ethiopia)", "am-ET", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Arabic", "ar", new CalendarEnum[] { CalendarEnum.UmAlQura,CalendarEnum.Hijri,CalendarEnum.Gregorian,CalendarEnum.Gregorian,CalendarEnum.Gregorian,CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("Arabic (World)", "ar-001", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Arabic (United Arab Emirates)", "ar-AE", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.UmAlQura,CalendarEnum.Hijri,CalendarEnum.Gregorian,CalendarEnum.Gregorian,CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("Arabic (Bahrain)", "ar-BH", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.UmAlQura,CalendarEnum.Hijri,CalendarEnum.Gregorian,CalendarEnum.Gregorian,CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("Arabic (Djibouti)", "ar-DJ", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("Arabic (Algeria)", "ar-DZ", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura,CalendarEnum.Gregorian,CalendarEnum.Gregorian,CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("Arabic (Egypt)", "ar-EG", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.UmAlQura,CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.Gregorian,CalendarEnum.Gregorian,CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("Arabic (Eritrea)", "ar-ER", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("Arabic (Israel)", "ar-IL", new CalendarEnum[] { CalendarEnum.Gregorian,HebrewCalendar,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("Arabic (Iraq)", "ar-IQ", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.UmAlQura,CalendarEnum.Hijri,CalendarEnum.Gregorian,CalendarEnum.Gregorian,CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("Arabic (Jordan)", "ar-JO", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.UmAlQura,CalendarEnum.Hijri,CalendarEnum.Gregorian,CalendarEnum.Gregorian,CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("Arabic (Comoros)", "ar-KM", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("Arabic (Kuwait)", "ar-KW", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura,CalendarEnum.Gregorian,CalendarEnum.Gregorian,CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("Arabic (Lebanon)", "ar-LB", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.UmAlQura,CalendarEnum.Hijri,CalendarEnum.Gregorian,CalendarEnum.Gregorian,CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("Arabic (Libya)", "ar-LY", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura,CalendarEnum.Gregorian,CalendarEnum.Gregorian,CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("Arabic (Morocco)", "ar-MA", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura,CalendarEnum.Gregorian,CalendarEnum.Gregorian,CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("Arabic (Mauritania)", "ar-MR", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("Arabic (Oman)", "ar-OM", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura,CalendarEnum.Gregorian,CalendarEnum.Gregorian,CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("Arabic (Palestinian Authority)", "ar-PS", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("Arabic (Qatar)", "ar-QA", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.UmAlQura,CalendarEnum.Hijri,CalendarEnum.Gregorian,CalendarEnum.Gregorian,CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("Arabic (Saudi Arabia)", "ar-SA", new CalendarEnum[] { CalendarEnum.UmAlQura,CalendarEnum.Hijri,CalendarEnum.Gregorian,CalendarEnum.Gregorian,CalendarEnum.Gregorian,CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("Arabic (Sudan)", "ar-SD", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("Arabic (Somalia)", "ar-SO", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Arabic (South Sudan)", "ar-SS", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Arabic (Syria)", "ar-SY", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.UmAlQura,CalendarEnum.Hijri,CalendarEnum.Gregorian,CalendarEnum.Gregorian,CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("Arabic (Chad)", "ar-TD", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("Arabic (Tunisia)", "ar-TN", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura,CalendarEnum.Gregorian,CalendarEnum.Gregorian,CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("Arabic (Yemen)", "ar-YE", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.UmAlQura,CalendarEnum.Hijri,CalendarEnum.Gregorian,CalendarEnum.Gregorian,CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("Mapudungun", "arn", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Mapudungun (Chile)", "arn-CL", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Assamese", "as", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Assamese (India)", "as-IN", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Asu", "asa", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Asu (Tanzania)", "asa-TZ", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Asturian", "ast", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Asturian (Spain)", "ast-ES", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Azerbaijani", "az", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Azerbaijani (Cyrillic)", "az-Cyrl", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Azerbaijani (Cyrillic, Azerbaijan)", "az-Cyrl-AZ", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Azerbaijani (Latin)", "az-Latn", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Azerbaijani (Latin, Azerbaijan)", "az-Latn-AZ", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Bashkir", "ba", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Bashkir (Russia)", "ba-RU", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Basaa", "bas", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Basaa (Cameroon)", "bas-CM", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Belarusian", "be", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Belarusian (Belarus)", "be-BY", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Bemba", "bem", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Bemba (Zambia)", "bem-ZM", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Bena", "bez", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Bena (Tanzania)", "bez-TZ", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Bulgarian", "bg", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Bulgarian (Bulgaria)", "bg-BG", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Edo", "bin", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("Edo (Nigeria)", "bin-NG", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("Bamanankan", "bm", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Bamanankan (Latin)", "bm-Latn", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Bamanankan (Latin, Mali)", "bm-Latn-ML", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Bangla", "bn", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Bangla (Bangladesh)", "bn-BD", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Bangla (India)", "bn-IN", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Tibetan", "bo", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Tibetan (China)", "bo-CN", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Tibetan (India)", "bo-IN", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Breton", "br", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Breton (France)", "br-FR", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Bodo", "brx", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Bodo (India)", "brx-IN", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Bosnian", "bs", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Bosnian (Cyrillic)", "bs-Cyrl", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Bosnian (Cyrillic, Bosnia and Herzegovina)", "bs-Cyrl-BA", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Bosnian (Latin)", "bs-Latn", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Bosnian (Latin, Bosnia and Herzegovina)", "bs-Latn-BA", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Blin", "byn", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("Blin (Eritrea)", "byn-ER", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("Catalan", "ca", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Catalan (Andorra)", "ca-AD", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Catalan (Catalan)", "ca-ES", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Valencian (Spain)", "ca-ES-valencia", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Catalan (France)", "ca-FR", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Catalan (Italy)", "ca-IT", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Chechen", "ce", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Chechen (Russia)", "ce-RU", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Chiga", "cgg", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Chiga (Uganda)", "cgg-UG", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Cherokee", "chr", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Cherokee", "chr-Cher", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Cherokee (Cherokee, United States)", "chr-Cher-US", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Corsican", "co", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Corsican (France)", "co-FR", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Czech", "cs", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Czech (Czechia)", "cs-CZ", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Church Slavic", "cu", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Church Slavic (Russia)", "cu-RU", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Welsh", "cy", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Welsh (United Kingdom)", "cy-GB", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Danish", "da", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Danish (Denmark)", "da-DK", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Danish (Greenland)", "da-GL", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Taita", "dav", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Taita (Kenya)", "dav-KE", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("German", "de", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("German (Austria)", "de-AT", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("German (Belgium)", "de-BE", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("German (Switzerland)", "de-CH", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("German (Germany)", "de-DE", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("German (Italy)", "de-IT", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("German (Liechtenstein)", "de-LI", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("German (Luxembourg)", "de-LU", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Zarma", "dje", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Zarma (Niger)", "dje-NE", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Lower Sorbian", "dsb", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Lower Sorbian (Germany)", "dsb-DE", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Duala", "dua", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Duala (Cameroon)", "dua-CM", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Divehi", "dv", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Divehi (Maldives)", "dv-MV", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Jola-Fonyi", "dyo", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Jola-Fonyi (Senegal)", "dyo-SN", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Dzongkha", "dz", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Dzongkha (Bhutan)", "dz-BT", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Embu", "ebu", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Embu (Kenya)", "ebu-KE", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Ewe", "ee", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Ewe (Ghana)", "ee-GH", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Ewe (Togo)", "ee-TG", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Greek", "el", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Greek (Cyprus)", "el-CY", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Greek (Greece)", "el-GR", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("English", "en", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (World)", "en-001", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Caribbean)", "en-029", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Europe)", "en-150", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Antigua and Barbuda)", "en-AG", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Anguilla)", "en-AI", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (American Samoa)", "en-AS", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Austria)", "en-AT", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Australia)", "en-AU", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Barbados)", "en-BB", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Belgium)", "en-BE", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Burundi)", "en-BI", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Bermuda)", "en-BM", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Bahamas)", "en-BS", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Botswana)", "en-BW", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Belize)", "en-BZ", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Canada)", "en-CA", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Cocos (Keeling) Islands)", "en-CC", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Switzerland)", "en-CH", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Cook Islands)", "en-CK", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Cameroon)", "en-CM", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Christmas Island)", "en-CX", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Cyprus)", "en-CY", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Germany)", "en-DE", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Denmark)", "en-DK", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Dominica)", "en-DM", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Eritrea)", "en-ER", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("English (Finland)", "en-FI", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Fiji)", "en-FJ", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Falkland Islands)", "en-FK", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Micronesia)", "en-FM", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (United Kingdom)", "en-GB", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Grenada)", "en-GD", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Guernsey)", "en-GG", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Ghana)", "en-GH", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Gibraltar)", "en-GI", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Gambia)", "en-GM", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Guam)", "en-GU", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Guyana)", "en-GY", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Hong Kong SAR)", "en-HK", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Indonesia)", "en-ID", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Ireland)", "en-IE", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Israel)", "en-IL", new CalendarEnum[] { CalendarEnum.Gregorian,HebrewCalendar,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("English (Isle of Man)", "en-IM", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (India)", "en-IN", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (British Indian Ocean Territory)", "en-IO", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Jersey)", "en-JE", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Jamaica)", "en-JM", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Kenya)", "en-KE", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Kiribati)", "en-KI", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Saint Kitts and Nevis)", "en-KN", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Cayman Islands)", "en-KY", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Saint Lucia)", "en-LC", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Liberia)", "en-LR", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Lesotho)", "en-LS", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Madagascar)", "en-MG", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Marshall Islands)", "en-MH", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Macao SAR)", "en-MO", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Northern Mariana Islands)", "en-MP", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Montserrat)", "en-MS", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Malta)", "en-MT", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Mauritius)", "en-MU", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Malawi)", "en-MW", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Malaysia)", "en-MY", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("English (Namibia)", "en-NA", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Norfolk Island)", "en-NF", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Nigeria)", "en-NG", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Netherlands)", "en-NL", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Nauru)", "en-NR", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Niue)", "en-NU", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (New Zealand)", "en-NZ", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Papua New Guinea)", "en-PG", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Philippines)", "en-PH", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Pakistan)", "en-PK", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Pitcairn Islands)", "en-PN", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Puerto Rico)", "en-PR", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Palau)", "en-PW", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Rwanda)", "en-RW", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Solomon Islands)", "en-SB", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Seychelles)", "en-SC", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Sudan)", "en-SD", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("English (Sweden)", "en-SE", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Singapore)", "en-SG", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (St Helena, Ascension, Tristan da Cunha)", "en-SH", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Slovenia)", "en-SI", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Sierra Leone)", "en-SL", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (South Sudan)", "en-SS", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Sint Maarten)", "en-SX", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Swaziland)", "en-SZ", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Turks and Caicos Islands)", "en-TC", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Tokelau)", "en-TK", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Tonga)", "en-TO", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Trinidad and Tobago)", "en-TT", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Tuvalu)", "en-TV", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Tanzania)", "en-TZ", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Uganda)", "en-UG", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (U.S. Outlying Islands)", "en-UM", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (United States)", "en-US", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Saint Vincent and the Grenadines)", "en-VC", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (British Virgin Islands)", "en-VG", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (U.S. Virgin Islands)", "en-VI", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Vanuatu)", "en-VU", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Samoa)", "en-WS", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (South Africa)", "en-ZA", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Zambia)", "en-ZM", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("English (Zimbabwe)", "en-ZW", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Esperanto", "eo", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Esperanto (World)", "eo-001", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Spanish", "es", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Spanish (Latin America)", "es-419", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Spanish (Argentina)", "es-AR", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Spanish (Bolivia)", "es-BO", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Spanish (Brazil)", "es-BR", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Spanish (Belize)", "es-BZ", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Spanish (Chile)", "es-CL", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Spanish (Colombia)", "es-CO", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Spanish (Costa Rica)", "es-CR", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Spanish (Cuba)", "es-CU", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Spanish (Dominican Republic)", "es-DO", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Spanish (Ecuador)", "es-EC", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Spanish (Spain, International Sort)", "es-ES", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Spanish (Equatorial Guinea)", "es-GQ", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Spanish (Guatemala)", "es-GT", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Spanish (Honduras)", "es-HN", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Spanish (Mexico)", "es-MX", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Spanish (Nicaragua)", "es-NI", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Spanish (Panama)", "es-PA", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Spanish (Peru)", "es-PE", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Spanish (Philippines)", "es-PH", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Spanish (Puerto Rico)", "es-PR", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Spanish (Paraguay)", "es-PY", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Spanish (El Salvador)", "es-SV", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Spanish (United States)", "es-US", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("Spanish (Uruguay)", "es-UY", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Spanish (Venezuela)", "es-VE", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Estonian", "et", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Estonian (Estonia)", "et-EE", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Basque", "eu", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Basque (Basque)", "eu-ES", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Ewondo", "ewo", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Ewondo (Cameroon)", "ewo-CM", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Persian", "fa", new CalendarEnum[] { PersianCalendar,CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.Gregorian,CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("Persian (Iran)", "fa-IR", new CalendarEnum[] { PersianCalendar,CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.Gregorian,CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("Fulah", "ff", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Fulah (Cameroon)", "ff-CM", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Fulah (Guinea)", "ff-GN", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Fulah", "ff-Latn", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Fulah (Latin, Senegal)", "ff-Latn-SN", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Fulah (Mauritania)", "ff-MR", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("Fulah (Nigeria)", "ff-NG", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Finnish", "fi", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Finnish (Finland)", "fi-FI", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Filipino", "fil", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Filipino (Philippines)", "fil-PH", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Faroese", "fo", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Faroese (Denmark)", "fo-DK", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Faroese (Faroe Islands)", "fo-FO", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("French", "fr", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("French (Caribbean)", "fr-029", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("French (Belgium)", "fr-BE", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("French (Burkina Faso)", "fr-BF", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("French (Burundi)", "fr-BI", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("French (Benin)", "fr-BJ", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("French (Saint Barthélemy)", "fr-BL", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("French (Canada)", "fr-CA", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("French Congo (DRC)", "fr-CD", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("French (Central African Republic)", "fr-CF", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("French (Congo)", "fr-CG", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("French (Switzerland)", "fr-CH", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("French (Côte d’Ivoire)", "fr-CI", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("French (Cameroon)", "fr-CM", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("French (Djibouti)", "fr-DJ", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("French (Algeria)", "fr-DZ", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("French (France)", "fr-FR", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("French (Gabon)", "fr-GA", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("French (French Guiana)", "fr-GF", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("French (Guinea)", "fr-GN", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("French (Guadeloupe)", "fr-GP", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("French (Equatorial Guinea)", "fr-GQ", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("French (Haiti)", "fr-HT", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("French (Comoros)", "fr-KM", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("French (Luxembourg)", "fr-LU", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("French (Morocco)", "fr-MA", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("French (Monaco)", "fr-MC", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("French (Saint Martin)", "fr-MF", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("French (Madagascar)", "fr-MG", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("French (Mali)", "fr-ML", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("French (Martinique)", "fr-MQ", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("French (Mauritania)", "fr-MR", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("French (Mauritius)", "fr-MU", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("French (New Caledonia)", "fr-NC", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("French (Niger)", "fr-NE", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("French (French Polynesia)", "fr-PF", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("French (Saint Pierre and Miquelon)", "fr-PM", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("French (Réunion)", "fr-RE", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("French (Rwanda)", "fr-RW", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("French (Seychelles)", "fr-SC", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("French (Senegal)", "fr-SN", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("French (Syria)", "fr-SY", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("French (Chad)", "fr-TD", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("French (Togo)", "fr-TG", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("French (Tunisia)", "fr-TN", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("French (Vanuatu)", "fr-VU", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("French (Wallis and Futuna)", "fr-WF", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("French (Mayotte)", "fr-YT", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Friulian", "fur", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Friulian (Italy)", "fur-IT", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Western Frisian", "fy", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Western Frisian (Netherlands)", "fy-NL", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Irish", "ga", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Irish (Ireland)", "ga-IE", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Scottish Gaelic", "gd", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Scottish Gaelic (United Kingdom)", "gd-GB", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Galician", "gl", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Galician (Galician)", "gl-ES", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Guarani", "gn", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Guarani (Paraguay)", "gn-PY", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Swiss German", "gsw", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Swiss German (Switzerland)", "gsw-CH", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Alsatian (France)", "gsw-FR", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Swiss German (Liechtenstein)", "gsw-LI", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Gujarati", "gu", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Gujarati (India)", "gu-IN", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Gusii", "guz", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Gusii (Kenya)", "guz-KE", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Manx", "gv", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Manx (Isle of Man)", "gv-IM", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Hausa", "ha", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Hausa (Latin)", "ha-Latn", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Hausa (Latin, Ghana)", "ha-Latn-GH", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Hausa (Latin, Niger)", "ha-Latn-NE", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Hausa (Latin, Nigeria)", "ha-Latn-NG", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Hawaiian", "haw", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Hawaiian (United States)", "haw-US", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Hebrew", "he", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hebrew} )
//case ??? : return ("Hebrew (Israel)", "he-IL", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hebrew} )
//case ??? : return ("Hindi", "hi", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Hindi (India)", "hi-IN", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Croatian", "hr", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Croatian (Bosnia and Herzegovina)", "hr-BA", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Croatian (Croatia)", "hr-HR", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Upper Sorbian", "hsb", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Upper Sorbian (Germany)", "hsb-DE", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Hungarian", "hu", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Hungarian (Hungary)", "hu-HU", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Armenian", "hy", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Armenian (Armenia)", "hy-AM", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Interlingua", "ia", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Interlingua (World)", "ia-001", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Interlingua (France)", "ia-FR", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Ibibio", "ibb", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("Ibibio (Nigeria)", "ibb-NG", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("Indonesian", "id", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Indonesian (Indonesia)", "id-ID", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Igbo", "ig", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Igbo (Nigeria)", "ig-NG", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Yi", "ii", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Yi (China)", "ii-CN", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Icelandic", "is", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Icelandic (Iceland)", "is-IS", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Italian", "it", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Italian (Switzerland)", "it-CH", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Italian (Italy)", "it-IT", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Italian (San Marino)", "it-SM", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Italian (Vatican City)", "it-VA", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Inuktitut", "iu", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Inuktitut (Syllabics)", "iu-Cans", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Inuktitut (Syllabics, Canada)", "iu-Cans-CA", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Inuktitut (Latin)", "iu-Latn", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Inuktitut (Latin, Canada)", "iu-Latn-CA", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Japanese", "ja", new CalendarEnum[] { CalendarEnum.Gregorian,JapaneseCalendar,CalendarEnum.Gregorian } )
//case ??? : return ("Japanese (Japan)", "ja-JP", new CalendarEnum[] { CalendarEnum.Gregorian,JapaneseCalendar,CalendarEnum.Gregorian } )
//case ??? : return ("Ngomba", "jgo", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Ngomba (Cameroon)", "jgo-CM", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Machame", "jmc", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Machame (Tanzania)", "jmc-TZ", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Javanese", "jv", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Javanese (Javanese)", "jv-Java", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Javanese (Javanese, Indonesia)", "jv-Java-ID", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Javanese", "jv-Latn", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Javanese (Indonesia)", "jv-Latn-ID", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Georgian", "ka", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Georgian (Georgia)", "ka-GE", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Kabyle", "kab", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("Kabyle (Algeria)", "kab-DZ", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("Kamba", "kam", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Kamba (Kenya)", "kam-KE", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Makonde", "kde", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Makonde (Tanzania)", "kde-TZ", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Kabuverdianu", "kea", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Kabuverdianu (Cabo Verde)", "kea-CV", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Koyra Chiini", "khq", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Koyra Chiini (Mali)", "khq-ML", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Kikuyu", "ki", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Kikuyu (Kenya)", "ki-KE", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Kazakh", "kk", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Kazakh (Kazakhstan)", "kk-KZ", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Kako", "kkj", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Kako (Cameroon)", "kkj-CM", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Greenlandic", "kl", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Greenlandic (Greenland)", "kl-GL", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Kalenjin", "kln", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Kalenjin (Kenya)", "kln-KE", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Khmer", "km", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("Khmer (Cambodia)", "km-KH", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("Kannada", "kn", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Kannada (India)", "kn-IN", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Korean", "ko", new CalendarEnum[] { CalendarEnum.Gregorian,KoreanCalendar,CalendarEnum.Gregorian } )
//case ??? : return ("Korean (North Korea)", "ko-KP", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Korean (Korea)", "ko-KR", new CalendarEnum[] { CalendarEnum.Gregorian,KoreanCalendar,CalendarEnum.Gregorian } )
//case ??? : return ("Konkani", "kok", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Konkani (India)", "kok-IN", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Kanuri", "kr", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("Kanuri (Nigeria)", "kr-NG", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("Kashmiri", "ks", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Kashmiri (Perso-Arabic)", "ks-Arab", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Kashmiri (Perso-Arabic)", "ks-Arab-IN", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Kashmiri (Devanagari)", "ks-Deva", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("Kashmiri (Devanagari)", "ks-Deva-IN", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("Shambala", "ksb", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Shambala (Tanzania)", "ksb-TZ", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Bafia", "ksf", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Bafia (Cameroon)", "ksf-CM", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Colognian", "ksh", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Colognian (Germany)", "ksh-DE", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Central Kurdish", "ku", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.Persian } )
//case ??? : return ("Central Kurdish", "ku-Arab", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.Persian } )
//case ??? : return ("Central Kurdish (Iraq)", "ku-Arab-IQ", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.Persian } )
//case ??? : return ("Kurdish (Perso-Arabic, Iran)", "ku-Arab-IR", new CalendarEnum[] { PersianCalendar,CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("Cornish", "kw", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Cornish (United Kingdom)", "kw-GB", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Kyrgyz", "ky", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Kyrgyz (Kyrgyzstan)", "ky-KG", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Latin", "la", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("Latin (World)", "la-001", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("Langi", "lag", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Langi (Tanzania)", "lag-TZ", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Luxembourgish", "lb", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Luxembourgish (Luxembourg)", "lb-LU", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Ganda", "lg", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Ganda (Uganda)", "lg-UG", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Lakota", "lkt", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Lakota (United States)", "lkt-US", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Lingala", "ln", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Lingala (Angola)", "ln-AO", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Lingala (Congo DRC)", "ln-CD", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Lingala (Central African Republic)", "ln-CF", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Lingala (Congo)", "ln-CG", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Lao", "lo", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Lao (Laos)", "lo-LA", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Northern Luri", "lrc", new CalendarEnum[] { PersianCalendar,CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("Northern Luri (Iraq)", "lrc-IQ", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("Northern Luri (Iran)", "lrc-IR", new CalendarEnum[] { PersianCalendar,CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("Lithuanian", "lt", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Lithuanian (Lithuania)", "lt-LT", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Luba-Katanga", "lu", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Luba-Katanga (Congo DRC)", "lu-CD", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Luo", "luo", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Luo (Kenya)", "luo-KE", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Luyia", "luy", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Luyia (Kenya)", "luy-KE", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Latvian", "lv", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Latvian (Latvia)", "lv-LV", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Masai", "mas", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Masai (Kenya)", "mas-KE", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Masai (Tanzania)", "mas-TZ", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Meru", "mer", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Meru (Kenya)", "mer-KE", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Morisyen", "mfe", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Morisyen (Mauritius)", "mfe-MU", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Malagasy", "mg", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Malagasy (Madagascar)", "mg-MG", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Makhuwa-Meetto", "mgh", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Makhuwa-Meetto (Mozambique)", "mgh-MZ", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Metaʼ", "mgo", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Metaʼ (Cameroon)", "mgo-CM", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Maori", "mi", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Maori (New Zealand)", "mi-NZ", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Macedonian", "mk", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Macedonian (Macedonia, FYRO)", "mk-MK", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Malayalam", "ml", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Malayalam (India)", "ml-IN", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Mongolian", "mn", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Mongolian", "mn-Cyrl", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Mongolian (Mongolia)", "mn-MN", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Mongolian (Traditional Mongolian)", "mn-Mong", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Mongolian (Traditional Mongolian, China)", "mn-Mong-CN", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Mongolian (Traditional Mongolian, Mongolia)", "mn-Mong-MN", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Manipuri", "mni", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("Manipuri (India)", "mni-IN", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("Mohawk", "moh", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Mohawk (Mohawk)", "moh-CA", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Marathi", "mr", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Marathi (India)", "mr-IN", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Malay", "ms", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Malay (Brunei)", "ms-BN", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Malay (Malaysia)", "ms-MY", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Malay (Singapore)", "ms-SG", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Maltese", "mt", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Maltese (Malta)", "mt-MT", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Mundang", "mua", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Mundang (Cameroon)", "mua-CM", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Burmese", "my", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Burmese (Myanmar)", "my-MM", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Mazanderani", "mzn", new CalendarEnum[] { PersianCalendar,CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("Mazanderani (Iran)", "mzn-IR", new CalendarEnum[] { PersianCalendar,CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("Nama", "naq", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Nama (Namibia)", "naq-NA", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Norwegian Bokmål", "nb", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Norwegian Bokmål (Norway)", "nb-NO", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Norwegian Bokmål (Svalbard and Jan Mayen)", "nb-SJ", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("North Ndebele", "nd", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("North Ndebele (Zimbabwe)", "nd-ZW", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Low German", "nds", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Low German (Germany)", "nds-DE", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Low German (Netherlands)", "nds-NL", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Nepali", "ne", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Nepali (India)", "ne-IN", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Nepali (Nepal)", "ne-NP", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Dutch", "nl", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Dutch (Aruba)", "nl-AW", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Dutch (Belgium)", "nl-BE", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Dutch (Bonaire, Sint Eustatius and Saba)", "nl-BQ", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Dutch (Curaçao)", "nl-CW", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Dutch (Netherlands)", "nl-NL", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Dutch (Suriname)", "nl-SR", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Dutch (Sint Maarten)", "nl-SX", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Kwasio", "nmg", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Kwasio (Cameroon)", "nmg-CM", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Norwegian Nynorsk", "nn", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Norwegian Nynorsk (Norway)", "nn-NO", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Ngiemboon", "nnh", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Ngiemboon (Cameroon)", "nnh-CM", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Norwegian", "no", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("N'ko", "nqo", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("N'ko (Guinea)", "nqo-GN", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("South Ndebele", "nr", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("South Ndebele (South Africa)", "nr-ZA", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Sesotho sa Leboa", "nso", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Sesotho sa Leboa (South Africa)", "nso-ZA", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Nuer", "nus", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Nuer (South Sudan)", "nus-SS", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Nyankole", "nyn", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Nyankole (Uganda)", "nyn-UG", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Occitan", "oc", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Occitan (France)", "oc-FR", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Oromo", "om", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Oromo (Ethiopia)", "om-ET", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Oromo (Kenya)", "om-KE", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Odia", "or", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Odia (India)", "or-IN", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Ossetic", "os", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Ossetic (Georgia)", "os-GE", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Ossetic (Russia)", "os-RU", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Punjabi", "pa", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Punjabi", "pa-Arab", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Punjabi (Pakistan)", "pa-Arab-PK", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Punjabi", "pa-Guru", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Punjabi (India)", "pa-IN", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Papiamento", "pap", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("Papiamento (Caribbean)", "pap-029", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("Polish", "pl", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Polish (Poland)", "pl-PL", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Prussian", "prg", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Prussian (World)", "prg-001", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Dari", "prs", new CalendarEnum[] { PersianCalendar,CalendarEnum.Hijri,CalendarEnum.Gregorian } )
//case ??? : return ("Dari (Afghanistan)", "prs-AF", new CalendarEnum[] { PersianCalendar,CalendarEnum.Hijri,CalendarEnum.Gregorian } )
//case ??? : return ("Pashto", "ps", new CalendarEnum[] { PersianCalendar,CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("Pashto (Afghanistan)", "ps-AF", new CalendarEnum[] { PersianCalendar,CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("Portuguese", "pt", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Portuguese (Angola)", "pt-AO", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Portuguese (Brazil)", "pt-BR", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Portuguese (Switzerland)", "pt-CH", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Portuguese (Cabo Verde)", "pt-CV", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Portuguese (Equatorial Guinea)", "pt-GQ", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Portuguese (Guinea-Bissau)", "pt-GW", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Portuguese (Luxembourg)", "pt-LU", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Portuguese (Macao SAR)", "pt-MO", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Portuguese (Mozambique)", "pt-MZ", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Portuguese (Portugal)", "pt-PT", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Portuguese (São Tomé and Príncipe)", "pt-ST", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Portuguese (Timor-Leste)", "pt-TL", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("K'iche'", "quc", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("K'iche'", "quc-Latn", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("K'iche' (Guatemala)", "quc-Latn-GT", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Quechua", "quz", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Quechua (Bolivia)", "quz-BO", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Quichua (Ecuador)", "quz-EC", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("Quechua (Peru)", "quz-PE", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Romansh", "rm", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Romansh (Switzerland)", "rm-CH", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Rundi", "rn", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Rundi (Burundi)", "rn-BI", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Romanian", "ro", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Romanian (Moldova)", "ro-MD", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Romanian (Romania)", "ro-RO", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Rombo", "rof", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Rombo (Tanzania)", "rof-TZ", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Russian", "ru", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Russian (Belarus)", "ru-BY", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Russian (Kyrgyzstan)", "ru-KG", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Russian (Kazakhstan)", "ru-KZ", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Russian (Moldova)", "ru-MD", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Russian (Russia)", "ru-RU", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Russian (Ukraine)", "ru-UA", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Kinyarwanda", "rw", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Kinyarwanda (Rwanda)", "rw-RW", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Rwa", "rwk", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Rwa (Tanzania)", "rwk-TZ", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Sanskrit", "sa", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Sanskrit (India)", "sa-IN", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Sakha", "sah", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Sakha (Russia)", "sah-RU", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Samburu", "saq", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Samburu (Kenya)", "saq-KE", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Sangu", "sbp", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Sangu (Tanzania)", "sbp-TZ", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Sindhi", "sd", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Sindhi", "sd-Arab", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Sindhi (Pakistan)", "sd-Arab-PK", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Sindhi (Devanagari)", "sd-Deva", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("Sindhi (Devanagari, India)", "sd-Deva-IN", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian } )
//case ??? : return ("Northern Sami", "se", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Sami, Northern (Finland)", "se-FI", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Sami, Northern (Norway)", "se-NO", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Sami, Northern (Sweden)", "se-SE", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Sena", "seh", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Sena (Mozambique)", "seh-MZ", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Koyraboro Senni", "ses", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Koyraboro Senni (Mali)", "ses-ML", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Sango", "sg", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Sango (Central African Republic)", "sg-CF", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Tachelhit", "shi", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("Tachelhit (Latin)", "shi-Latn", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("Tachelhit (Latin, Morocco)", "shi-Latn-MA", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("Tachelhit (Tifinagh)", "shi-Tfng", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("Tachelhit (Tifinagh, Morocco)", "shi-Tfng-MA", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("Sinhala", "si", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Sinhala (Sri Lanka)", "si-LK", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Slovak", "sk", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Slovak (Slovakia)", "sk-SK", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Slovenian", "sl", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Slovenian (Slovenia)", "sl-SI", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Sami (Southern)", "sma", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Sami, Southern (Norway)", "sma-NO", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Sami, Southern (Sweden)", "sma-SE", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Sami (Lule)", "smj", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Sami, Lule (Norway)", "smj-NO", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Sami, Lule (Sweden)", "smj-SE", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Sami (Inari)", "smn", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Sami, Inari (Finland)", "smn-FI", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Sami (Skolt)", "sms", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Sami, Skolt (Finland)", "sms-FI", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Shona", "sn", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Shona (Latin)", "sn-Latn", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Shona (Latin, Zimbabwe)", "sn-Latn-ZW", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Somali", "so", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Somali (Djibouti)", "so-DJ", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("Somali (Ethiopia)", "so-ET", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Somali (Kenya)", "so-KE", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Somali (Somalia)", "so-SO", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Albanian", "sq", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Albanian (Albania)", "sq-AL", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Albanian (Macedonia, FYRO)", "sq-MK", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Albanian (Kosovo)", "sq-XK", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Serbian", "sr", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Serbian (Cyrillic)", "sr-Cyrl", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Serbian (Cyrillic, Bosnia and Herzegovina)", "sr-Cyrl-BA", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Serbian (Cyrillic, Montenegro)", "sr-Cyrl-ME", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Serbian (Cyrillic, Serbia)", "sr-Cyrl-RS", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Serbian (Cyrillic, Kosovo)", "sr-Cyrl-XK", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Serbian (Latin)", "sr-Latn", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Serbian (Latin, Bosnia and Herzegovina)", "sr-Latn-BA", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Serbian (Latin, Montenegro)", "sr-Latn-ME", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Serbian (Latin, Serbia)", "sr-Latn-RS", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Serbian (Latin, Kosovo)", "sr-Latn-XK", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("siSwati", "ss", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("siSwati (Swaziland)", "ss-SZ", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("siSwati (South Africa)", "ss-ZA", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Saho", "ssy", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("Saho (Eritrea)", "ssy-ER", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("Sesotho", "st", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Sesotho (Lesotho)", "st-LS", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Sesotho (South Africa)", "st-ZA", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Swedish", "sv", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Swedish (Åland Islands)", "sv-AX", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Swedish (Finland)", "sv-FI", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Swedish (Sweden)", "sv-SE", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Kiswahili", "sw", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Kiswahili (Congo DRC)", "sw-CD", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Kiswahili (Kenya)", "sw-KE", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Kiswahili (Tanzania)", "sw-TZ", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Kiswahili (Uganda)", "sw-UG", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Syriac", "syr", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Syriac (Syria)", "syr-SY", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Tamil", "ta", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Tamil (India)", "ta-IN", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Tamil (Sri Lanka)", "ta-LK", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Tamil (Malaysia)", "ta-MY", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Tamil (Singapore)", "ta-SG", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Telugu", "te", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Telugu (India)", "te-IN", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Teso", "teo", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Teso (Kenya)", "teo-KE", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Teso (Uganda)", "teo-UG", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Tajik", "tg", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Tajik (Cyrillic)", "tg-Cyrl", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Tajik (Cyrillic, Tajikistan)", "tg-Cyrl-TJ", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Thai", "th", new CalendarEnum[] { ThaiBuddhistCalendar,CalendarEnum.Gregorian } )
//case ??? : return ("Thai (Thailand)", "th-TH", new CalendarEnum[] { ThaiBuddhistCalendar,CalendarEnum.Gregorian } )
//case ??? : return ("Tigrinya", "ti", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("Tigrinya (Eritrea)", "ti-ER", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("Tigrinya (Ethiopia)", "ti-ET", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Tigre", "tig", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("Tigre (Eritrea)", "tig-ER", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("Turkmen", "tk", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Turkmen (Turkmenistan)", "tk-TM", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Setswana", "tn", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Setswana (Botswana)", "tn-BW", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Setswana (South Africa)", "tn-ZA", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Tongan", "to", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Tongan (Tonga)", "to-TO", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Turkish", "tr", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Turkish (Cyprus)", "tr-CY", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Turkish (Turkey)", "tr-TR", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Tsonga", "ts", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Xitsonga (South Africa)", "ts-ZA", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Tatar", "tt", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Tatar (Russia)", "tt-RU", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Tasawaq", "twq", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Tasawaq (Niger)", "twq-NE", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Central Atlas Tamazight", "tzm", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Central Atlas Tamazight (Arabic)", "tzm-Arab", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("Central Atlas Tamazight (Arabic, Morocco)", "tzm-Arab-MA", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("Central Atlas Tamazight (Latin)", "tzm-Latn", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Central Atlas Tamazight (Latin, Algeria)", "tzm-Latn-DZ", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Central Atlas Tamazight (Latin, Morocco)", "tzm-Latn-MA", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("Central Atlas Tamazight (Tifinagh)", "tzm-Tfng", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Central Atlas Tamazight (Tifinagh, Morocco)", "tzm-Tfng-MA", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Uyghur", "ug", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Uyghur (China)", "ug-CN", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Ukrainian", "uk", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Ukrainian (Ukraine)", "uk-UA", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Urdu", "ur", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Urdu (India)", "ur-IN", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Urdu (Pakistan)", "ur-PK", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Uzbek", "uz", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Uzbek (Perso-Arabic)", "uz-Arab", new CalendarEnum[] { PersianCalendar,CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("Uzbek (Perso-Arabic, Afghanistan)", "uz-Arab-AF", new CalendarEnum[] { PersianCalendar,CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("Uzbek (Cyrillic)", "uz-Cyrl", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Uzbek (Cyrillic, Uzbekistan)", "uz-Cyrl-UZ", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Uzbek (Latin)", "uz-Latn", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Uzbek (Latin, Uzbekistan)", "uz-Latn-UZ", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Vai", "vai", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Vai (Latin)", "vai-Latn", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Vai (Latin, Liberia)", "vai-Latn-LR", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Vai (Vai)", "vai-Vaii", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Vai (Vai, Liberia)", "vai-Vaii-LR", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Venda", "ve", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Venda (South Africa)", "ve-ZA", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Vietnamese", "vi", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Vietnamese (Vietnam)", "vi-VN", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Volapük", "vo", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Volapük (World)", "vo-001", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Vunjo", "vun", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Vunjo (Tanzania)", "vun-TZ", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Walser", "wae", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Walser (Switzerland)", "wae-CH", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Wolaytta", "wal", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Wolaytta (Ethiopia)", "wal-ET", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Wolof", "wo", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Wolof (Senegal)", "wo-SN", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("isiXhosa", "xh", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("isiXhosa (South Africa)", "xh-ZA", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Soga", "xog", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Soga (Uganda)", "xog-UG", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Yangben", "yav", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Yangben (Cameroon)", "yav-CM", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Yiddish", "yi", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Yiddish (World)", "yi-001", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Yoruba", "yo", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Yoruba (Benin)", "yo-BJ", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Yoruba (Nigeria)", "yo-NG", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri } )
//case ??? : return ("Standard Moroccan Tamazight", "zgh", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("Standard Moroccan Tamazight (Tifinagh)", "zgh-Tfng", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("Standard Moroccan Tamazight (Tifinagh, Morocco)", "zgh-Tfng-MA", new CalendarEnum[] { CalendarEnum.Gregorian,CalendarEnum.Hijri,CalendarEnum.UmAlQura } )
//case ??? : return ("Chinese", "zh", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Chinese (Simplified, China)", "zh-CN", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Chinese (Simplified)", "zh-Hans", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Chinese (Simplified Han, Hong Kong SAR)", "zh-Hans-HK", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Chinese (Simplified Han, Macao SAR)", "zh-Hans-MO", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Chinese (Traditional)", "zh-Hant", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Chinese (Traditional, Hong Kong SAR)", "zh-HK", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Chinese (Traditional, Macao SAR)", "zh-MO", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Chinese (Simplified, Singapore)", "zh-SG", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("Chinese (Traditional, Taiwan)", "zh-TW", new CalendarEnum[] { CalendarEnum.Gregorian,TaiwanCalendar,CalendarEnum.Gregorian } )
//case ??? : return ("isiZulu", "zu", new CalendarEnum[] { CalendarEnum.Gregorian } )
//case ??? : return ("isiZulu (South Africa)", "zu-ZA", new CalendarEnum[] { CalendarEnum.Gregorian } )
