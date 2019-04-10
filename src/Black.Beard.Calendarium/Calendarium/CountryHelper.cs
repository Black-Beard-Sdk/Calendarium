using Bb.Calendarium.Configuration;

namespace Bb.Calendarium
{

    public static class CountryHelper
    {

        public static (string, string, CalendarEnum[]) GetInfos(string country)
        {

            switch (country)
            {
                case "Trinidad_and_Tobago": return ("English (Trinidad and Tobago)", "en-TT", new CalendarEnum[] { CalendarEnum.Gregorian, CalendarEnum.Gregorian });
                case "Congo_Democratic_Republic_of ": return ("French Congo (DRC)", "fr-CD", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Vietnam ": return ("Vietnamese", "vi", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Brunei": return ("Korean (Korea)", "ko-KR", new CalendarEnum[] { CalendarEnum.Gregorian, CalendarEnum.Korean, CalendarEnum.Gregorian });
                case "Korea": return ("Korean (Korea)", "ko-KR", new CalendarEnum[] { CalendarEnum.Gregorian, CalendarEnum.Korean, CalendarEnum.Gregorian });
                case "Algeria": return ("Algeria", "ar-DZ", new CalendarEnum[] { CalendarEnum.Gregorian, CalendarEnum.Hijri, CalendarEnum.UmAlQura });
                case "Russia": return ("Russian", "ru", new CalendarEnum[] { CalendarEnum.Gregorian, CalendarEnum.Hijri });
                case "South_Africa": return ("Afrikaans (South Africa)", "af-ZA", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Armenia": return ("Amharic", "am", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Argentina": return ("Arabic", "ar", new CalendarEnum[] { CalendarEnum.UmAlQura, CalendarEnum.Hijri, CalendarEnum.Gregorian });
                case "United_Arab_Emirates": return ("Arabic (United Arab Emirates)", "ar-AE", new CalendarEnum[] { CalendarEnum.Gregorian, CalendarEnum.UmAlQura, CalendarEnum.Hijri });
                case "Bahrain": return ("Arabic (Bahrain)", "ar-BH", new CalendarEnum[] { CalendarEnum.Gregorian, CalendarEnum.UmAlQura, CalendarEnum.Hijri });
                case "Egypt": return ("Arabic (Egypt)", "ar-EG", new CalendarEnum[] { CalendarEnum.Gregorian, CalendarEnum.UmAlQura, CalendarEnum.Hijri });
                case "Israel": return ("Arabic (Israel)", "ar-IL", new CalendarEnum[] { CalendarEnum.Gregorian, CalendarEnum.Hebrew, CalendarEnum.Hijri, CalendarEnum.UmAlQura });
                case "Iraq": return ("Arabic (Iraq)", "ar-IQ", new CalendarEnum[] { CalendarEnum.Gregorian, CalendarEnum.UmAlQura, CalendarEnum.Hijri });
                case "Jordan": return ("Arabic (Jordan)", "ar-JO", new CalendarEnum[] { CalendarEnum.Gregorian, CalendarEnum.UmAlQura, CalendarEnum.Hijri });
                case "Kuwait": return ("Arabic (Kuwait)", "ar-KW", new CalendarEnum[] { CalendarEnum.Gregorian, CalendarEnum.Hijri, CalendarEnum.UmAlQura });
                case "Lebanon": return ("Arabic (Lebanon)", "ar-LB", new CalendarEnum[] { CalendarEnum.Gregorian, CalendarEnum.UmAlQura, CalendarEnum.Hijri });
                case "Morocco": return ("Arabic (Morocco)", "ar-MA", new CalendarEnum[] { CalendarEnum.Gregorian, CalendarEnum.Hijri, CalendarEnum.UmAlQura });
                case "Oman": return ("Arabic (Oman)", "ar-OM", new CalendarEnum[] { CalendarEnum.Gregorian, CalendarEnum.Hijri, CalendarEnum.UmAlQura });
                case "Qatar": return ("Arabic (Qatar)", "ar-QA", new CalendarEnum[] { CalendarEnum.Gregorian, CalendarEnum.UmAlQura, CalendarEnum.Hijri });
                case "Saudi_Arabia": return ("Arabic (Saudi Arabia)", "ar-SA", new CalendarEnum[] { CalendarEnum.UmAlQura, CalendarEnum.Hijri, CalendarEnum.Gregorian });
                case "Syria": return ("Arabic (Syria)", "ar-SY", new CalendarEnum[] { CalendarEnum.Gregorian, CalendarEnum.UmAlQura, CalendarEnum.Hijri });
                case "Tunisia": return ("Arabic (Tunisia)", "ar-TN", new CalendarEnum[] { CalendarEnum.Gregorian, CalendarEnum.Hijri, CalendarEnum.UmAlQura });
                case "Yemen": return ("Arabic (Yemen)", "ar-YE", new CalendarEnum[] { CalendarEnum.Gregorian, CalendarEnum.UmAlQura, CalendarEnum.Hijri });
                case "Chile": return ("Mapudungun (Chile)", "arn-CL", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "India": return ("Assamese (India)", "as-IN", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Spain": return ("Asturian (Spain)", "ast-ES", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Azerbaijan": return ("Azerbaijani", "az", new CalendarEnum[] { CalendarEnum.Gregorian, CalendarEnum.Hijri });
                case "Bosnia_and_Herzegovina": return ("Bashkir", "ba", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Belgium": return ("Belarusian", "be", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Belarus": return ("Belarusian (Belarus)", "be-BY", new CalendarEnum[] { CalendarEnum.Gregorian }); ;
                case "Bulgaria": return ("Bulgarian", "bg", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Nigeria": return ("Edo (Nigeria)", "bin-NG", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Bolivia": return ("Tibetan", "bo", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "China": return ("Tibetan (China)", "bo-CN", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Brazil ": return ("Portuguese (Brazil)", "pt-BR", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "France": return ("France", "fr-FR", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Canada": return ("Canada", "ca", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Andorra": return ("Catalan (Andorra)", "ca-AD", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Undefined": return ("Valencian (Spain)", "ca-ES-valencia", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Italy": return ("Italy", "it-IT", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "United_States": return ("United States", "en-US", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Colombia ": return ("Spanish (Colombia)", "CO", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Czechia": return ("Czech (Czechia)", "cs-CZ", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Cyprus": return ("Cyprus", "cy", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "United_Kingdom": return ("United Kingdom", "en-GB", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Denmark": return ("Danish (Denmark)", "da-DK", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Kenya": return ("Kenya", "KE", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Germany": return ("German", "de", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Austria": return ("Austria", "at", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Switzerland": return ("German (Switzerland)", "de-CH", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Liechtenstein": return ("German (Liechtenstein)", "de-LI", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Luxembourg": return ("German (Luxembourg)", "de-LU", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Estonia": return ("Estonian (Estonia)", "et-EE", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Greece": return ("Greek (Greece)", "el-GR", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Australia": return ("English (Australia)", "en-AU", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Finland": return ("English (Finland)", "en-FI", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Hong_Kong_S_A_R": return ("English (Hong Kong SAR)", "en-HK", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Ireland": return ("English (Ireland)", "en-IE", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Jamaica": return ("English (Jamaica)", "en-JM", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Macao_S_A_R": return ("English (Macao SAR)", "en-MO", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Malta": return ("English (Malta)", "en-MT", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Malaysia": return ("English (Malaysia)", "en-MY", new CalendarEnum[] { CalendarEnum.Gregorian, CalendarEnum.Hijri });
                case "Netherlands": return ("English (Netherlands)", "en-NL", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "New_Zealand": return ("English (New Zealand)", "en-NZ", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Philippines": return ("English (Philippines)", "en-PH", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Pakistan": return ("English (Pakistan)", "en-PK", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Puerto_Rico": return ("English (Puerto Rico)", "en-PR", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Sweden": return ("English (Sweden)", "en-SE", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Singapore": return ("English (Singapore)", "en-SG", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Slovenia": return ("English (Slovenia)", "en-SI", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Costa_Rica": return ("Spanish (Costa Rica)", "es-CR", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Dominican_Republic": return ("Spanish (Dominican Republic)", "es-DO", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Ecuador": return ("Spanish (Ecuador)", "es-EC", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Equatorial_Guinea": return ("Spanish (Equatorial Guinea)", "es-GQ", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Guatemala": return ("Spanish (Guatemala)", "es-GT", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Honduras": return ("Spanish (Honduras)", "es-HN", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Mexico": return ("Spanish (Mexico)", "es-MX", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Nicaragua": return ("Spanish (Nicaragua)", "es-NI", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Panama": return ("Spanish (Panama)", "es-PA", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Peru": return ("Spanish (Peru)", "es-PE", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Paraguay": return ("Spanish (Paraguay)", "es-PY", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "El_Salvador": return ("Spanish (El Salvador)", "es-SV", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Uruguay": return ("Spanish (Uruguay)", "es-UY", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Venezuela": return ("Spanish (Venezuela)", "es-VE", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Iran": return ("Persian (Iran)", "fa-IR", new CalendarEnum[] { CalendarEnum.Persian, CalendarEnum.Gregorian, CalendarEnum.Hijri });
                case "Monaco": return ("French (Monaco)", "fr-MC", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Croatia": return ("Croatian", "hr", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Hungary": return ("Hungarian", "hu", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Iceland": return ("Icelandic", "is", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "San_Marino": return ("Italian (San Marino)", "it-SM", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Holy_See_Vatican_City": return ("Italian (Vatican City)", "it-VA", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Japan": return ("Japanese (Japan)", "ja-JP", new CalendarEnum[] { CalendarEnum.Gregorian, CalendarEnum.Japanese });
                case "Georgia": return ("Georgian (Georgia)", "ka-GE", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Kazakhstan": return ("Kazakh (Kazakhstan)", "kk-KZ", new CalendarEnum[] { CalendarEnum.Gregorian, CalendarEnum.Hijri });
                case "Angola": return ("Lingala (Angola)", "ln-AO", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Lithuania": return ("Lithuanian", "lt", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Latvia": return ("Latvian", "lv", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Macedonia_FYRO": return ("Macedonian", "mk", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Norway": return ("Norwegian Bokmål (Norway)", "nb-NO", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Poland": return ("Polish", "pl", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Portugal": return ("Portuguese", "pt", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Romania": return ("Romanian", "ro", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Moldova": return ("Romanian (Moldova)", "ro-MD", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Ukraine": return ("Russian (Ukraine)", "ru-UA", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Slovakia": return ("Slovak", "sk", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Albania": return ("Albanian (Albania)", "sq-AL", new CalendarEnum[] { CalendarEnum.Gregorian, CalendarEnum.Hijri });
                case "Montenegro": return ("Serbian (Cyrillic, Montenegro)", "sr-Cyrl-ME", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Serbia": return ("Serbian (Cyrillic, Serbia)", "sr-Cyrl-RS", new CalendarEnum[] { CalendarEnum.Gregorian });
                case "Thailand": return ("Thai", "th", new CalendarEnum[] { CalendarEnum.ThaiBuddhist, CalendarEnum.Gregorian });
                case "Turkey": return ("Turkish", "tr", new CalendarEnum[] { CalendarEnum.Gregorian, CalendarEnum.Hijri });

                default:
                    if (System.Diagnostics.Debugger.IsAttached)
                        System.Diagnostics.Debugger.Break();
                    return ("", "", new CalendarEnum[] { });
            }




        }

        public static string GetCountryFromIso2(this string self)
        {

            switch (self.ToUpper())
            {

                //case "AF": return "Afghanistan";
                //case "AX": return "Aland_Islands";
                case "AL": return "Albania";
                case "DZ": return "Algeria";
                //case "AS": return "American_Samoa";
                case "AD": return "Andorra";
                case "AO": return "Angola";
                //case "AI": return "Anguilla";
                //case "AQ": return "Antarctica";
                //case "AG": return "Antigua_and_Barbuda";
                case "AR": return "Argentina";
                case "AM": return "Armenia";
                //case "AW": return "Aruba";
                case "AU": return "Australia";
                case "AT": return "Austria";
                case "AZ": return "Azerbaijan";
                //case "BS": return "Bahamas";
                case "BH": return "Bahrain";
                //case "BD": return "Bangladesh";
                //case "BB": return "Barbados";
                case "BY": return "Belarus";
                case "BE": return "Belgium";
                //case "BZ": return "Belize";
                //case "BJ": return "Benin";
                //case "BM": return "Bermuda";
                //case "BT": return "Bhutan";
                case "BO": return "Bolivia";
                case "BA": return "Bosnia_and_Herzegovina";
                //case "BW": return "Botswana";
                //case "BV": return "Bouvet_Island";
                case "BR": return "Brazil";
                //case "VG": return "British_Virgin_Islands";
                //case "IO": return "British_Indian_Ocean_Territory";
                //case "BN": return "Brunei_Darussalam";
                case "BG": return "Bulgaria";
                //case "BF": return "Burkina_Faso";
                //case "BI": return "Burundi";
                //case "KH": return "Cambodia";
                //case "CM": return "Cameroon";
                case "CA": return "Canada";
                //case "CV": return "Cape_Verde";
                //case "KY": return "Cayman_Islands";
                //case "CF": return "Central_African_Republic";
                //case "TD": return "Chad";
                case "CL": return "Chile";
                case "CN": return "China";
                case "HK": return "Hong_Kong_S_A_R";
                case "MO": return "Macao_S_A_R";
                //case "CX": return "Christmas_Island";
                //case "CC": return "Cocos_Keeling_Islands";
                case "CO": return "Colombia";
                //case "KM": return "Comoros";
                //case "CG": return "Congo(Brazzaville)";
                case "CD": return "Congo_Democratic_Republic_of";     // , (Kinshasa)";
                //case "CK": return "Cook_Islands";
                case "CR": return "Costa_Rica";
                //case "CI": return "Cote_d_Ivoire";
                case "HR": return "Croatia";
                //case "CU": return "Cuba";
                case "CY": return "Cyprus";
                case "CZ": return "Czechia";
                case "DK": return "Denmark";
                //case "DJ": return "Djibouti";
                //case "DM": return "Dominica";
                case "DO": return "Dominican_Republic";
                case "EC": return "Ecuador";
                case "EG": return "Egypt";
                case "SV": return "El_Salvador";
                case "GQ": return "Equatorial_Guinea";
                //case "ER": return "Eritrea";
                case "EE": return "Estonia";
                //case "ET": return "Ethiopia";
                //case "FK": return "Falkland_Islands"; // (Malvinas)
                //case "FO": return "Faroe_Islands";
                //case "FJ": return "Fiji";
                case "FI": return "Finland";
                case "FR": return "France";
                //case "GF": return "French Guiana";
                //case "PF": return "French Polynesia";
                //case "TF": return "French Southern Territories";
                //case "GA": return "Gabon";
                //case "GM": return "Gambia";
                case "GE": return "Georgia";
                case "DE": return "Germany";
                //case "GH": return "Ghana";
                //case "GI": return "Gibraltar";
                case "GR": return "Greece";
                //case "GL": return "Greenland";
                //case "GD": return "Grenada";
                //case "GP": return "Guadeloupe";
                //case "GU": return "Guam";
                case "GT": return "Guatemala";
                //case "GG": return "Guernsey";
                case "GN": return "Equatorial_Guinea";
                //case "GW": return "Bissau_Guinea";
                //case "GY": return "Guyana";
                //case "HT": return "Haiti";
                //case "HM": return "Heard_and_Mcdonald_Islands";
                case "VA": return "Holy_See_Vatican_City";
                case "HN": return "Honduras";
                case "HU": return "Hungary";
                case "IS": return "Iceland";
                case "IN": return "India";
                //case "ID": return "Indonesia";
                case "IR": return "Iran";
                case "IQ": return "Iraq";
                case "IE": return "Ireland";
                //case "IM": return "Isle_of_Man";
                case "IL": return "Israel";
                case "IT": return "Italy";
                case "JM": return "Jamaica";
                case "JP": return "Japan";
                //case "JE": return "Jersey";
                case "JO": return "Jordan";
                case "KZ": return "Kazakhstan";
                case "KE": return "Kenya";
                //case "KI": return "Kiribati";
                //case "KP": return "Korea_North";
                //case "KR": return "Korea_South";
                case "KW": return "Kuwait";
                //case "KG": return "Kyrgyzstan";
                //case "LA": return "Lao_PDR";
                case "LV": return "Latvia";
                case "LB": return "Lebanon";
                //case "LS": return "Lesotho";
                //case "LR": return "Liberia";
                //case "LY": return "Libya";
                case "LI": return "Liechtenstein";
                case "LT": return "Lithuania";
                case "LU": return "Luxembourg";
                case "MK": return "Macedonia_FYRO";
                //case "MG": return "Madagascar";
                //case "MW": return "Malawi";
                case "MY": return "Malaysia";
                //case "MV": return "Maldives";
                //case "ML": return "Mali";
                case "MT": return "Malta";
                //case "MH": return "Marshall_Islands";
                //case "MQ": return "Martinique";
                //case "MR": return "Mauritania";
                //case "MU": return "Mauritius";
                //case "YT": return "Mayotte";
                case "MX": return "Mexico";
                //case "FM": return "Micronesia";
                case "MD": return "Moldova";
                case "MC": return "Monaco";
                //case "MN": return "Mongolia";
                case "ME": return "Montenegro";
                //case "MS": return "Montserrat";
                case "MA": return "Morocco";
                //case "MZ": return "Mozambique";
                //case "MM": return "Myanmar";
                //case "NA": return "Namibia";
                //case "NR": return "Nauru";
                //case "NP": return "Nepal";
                case "NL": return "Netherlands";
                //case "AN": return "Netherlands_Antilles";
                //case "NC": return "New_Caledonia";
                case "NZ": return "New_Zealand";
                case "NI": return "Nicaragua";
                //case "NE": return "Niger";
                case "NG": return "Nigeria";
                //case "NU": return "Niue";
                //case "NF": return "Norfolk_Island";
                //case "MP": return "Northern_Mariana_Islands";
                case "NO": return "Norway";
                case "OM": return "Oman";
                case "PK": return "Pakistan";
                //case "PW": return "Palau";
                //case "PS": return "Palestinian_Territory";
                case "PA": return "Panama";
                //case "PG": return "Papua_New_Guinea";
                case "PY": return "Paraguay";
                case "PE": return "Peru";
                case "PH": return "Philippines";
                //case "PN": return "Pitcairn";
                case "PL": return "Poland";
                case "PT": return "Portugal";
                case "PR": return "Puerto_Rico";
                case "QA": return "Qatar";
                //case "RE": return "Reunion";
                case "RO": return "Romania";
                case "RU": return "Russia";
                //case "RW": return "Rwanda";
                //case "BL": return "Saint_Barthélemy";
                //case "SH": return "Saint_Helena";
                //case "KN": return "Saint_Kitts_and_Nevis";
                //case "LC": return "Saint_Lucia";
                //case "MF": return "Saint_Martin";
                //case "PM": return "Saint_Pierre_and_Miquelon";
                //case "VC": return "Saint_Vincent_and_Grenadines";
                //case "WS": return "Samoa";
                case "SM": return "San_Marino";
                //case "ST": return "Sao_Tome_and_Principe";
                case "SA": return "Saudi_Arabia";
                //case "SN": return "Senegal";
                case "RS": return "Serbia";
                //case "SC": return "Seychelles";
                //case "SL": return "Sierra_Leone";
                case "SG": return "Singapore";
                case "SK": return "Slovakia";
                case "SI": return "Slovenia";
                //case "SB": return "Solomon_Islands";
                //case "SO": return "Somalia";
                case "ZA": return "South_Africa";
                //case "GS": return "South_Georgia_and_the_South_Sandwich_Islands";
                //case "SS": return "South_Sudan";
                case "ES": return "Spain";
                //case "LK": return "Sri_Lanka";
                //case "SD": return "Sudan";
                //case "SR": return "Suriname";
                //case "SJ": return "Svalbard_and_Jan_Mayen_Islands";
                //case "SZ": return "Swaziland";
                case "SE": return "Sweden";
                case "CH": return "Switzerland";
                case "SY": return "Syria";
                //case "TW": return "Taiwan";
                //case "TJ": return "Tajikistan";
                //case "TZ": return "Tanzania";
                case "TH": return "Thailand";
                //case "TL": return "Timor";
                //case "TG": return "Togo";
                //case "TK": return "Tokelau";
                //case "TO": return "Tonga";
                case "TT": return "Trinidad_and_Tobago";
                case "TN": return "Tunisia";
                case "TR": return "Turkey";
                //case "TM": return "Turkmenistan";
                //case "TC": return "Turks_and_Caicos_Islands";
                //case "TV": return "Tuvalu";
                //case "UG": return "Uganda";
                case "UA": return "Ukraine";
                case "AE": return "United_Arab_Emirates";
                case "GB": return "United_Kingdom";
                case "US": return "United_States";
                //case "UM": return "US_Minor_Outlying_Islands";
                case "UY": return "Uruguay";
                //case "UZ": return "Uzbekistan";
                //case "VU": return "Vanuatu";
                case "VE": return "Venezuela";
                case "VN": return "Vietnam";
                //case "VI": return "Virgin_Islands_US";
                //case "WF": return "Wallis_and_Futuna_Islands";
                //case "EH": return "Western_Sahara";
                case "YE": return "Yemen";
                //case "ZM": return "Zambia";
                //case "ZW": return "Zimbabwe";

                default:
                    return "Undefined";

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
