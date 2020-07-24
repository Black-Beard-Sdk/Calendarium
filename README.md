# Calendarium [![Build status](https://ci.appveyor.com/api/projects/status/r58r4d3rl4o60ohj?svg=true)](https://ci.appveyor.com/project/gaelgael5/calendarium-0v0lc)
manage referential of computed date. Every country are managed by a configuration file in json format. A console application can generate computed date, for using out of custom development. you can download all releases of the github relaser folder

[Here] : https://github.com/Black-Beard-Sdk/Calendarium/releases

``` powershell
# return the list of all configurations available by nuget package. make a search on nuget.org of all packages matches with "black.Beard.Calendarium.*"
PS D:\Calen\bin> .\Calendarium config list

available countries parameters:
┌────────────────────────────────────────┬────────────────────────────────────────┐
│  Name          : France                │  Name          : Costa_Rica            │
│  OnlineVersion : 1.0.82                │  OnlineVersion : 1.0.82                │
│  Included      : False                 │  Included      : False                 │
├────────────────────────────────────────┼────────────────────────────────────────┤
│  Name          : Peru                  │  Name          : Croatia               │
│  OnlineVersion : 1.0.82                │  OnlineVersion : 1.0.82                │
│  Included      : False                 │  Included      : False                 │
├────────────────────────────────────────┼────────────────────────────────────────┤
│  Name          : Russia                │  Name          : Andorra               │
│  OnlineVersion : 1.0.82                │  OnlineVersion : 1.0.82                │
│  Included      : False                 │  Included      : False                 │
├────────────────────────────────────────┼────────────────────────────────────────┤
...

# add a new country in local configuration.
PS D:\Calen\bin> .\Calendarium config add france
France updating in the version 1.0.83
Download
Uncompress
Save
available countries parameters:
┌─────────────────────────┐
│  Name          : France │
│  OnlineVersion : 1.0.83 │
│  Included      : True   │
└─────────────────────────┘

# generate all dates for country france for one year from begining of current year. all dates are writed in a file nammed output.csv note that if you dont specify the country, all countries included in the configurations will be generated.
PS D:\Calen\bin> .\Calendarium compute output.csv 1 france
configuration France is loaded
computed dates:
┌────────────────────────────────┬────────────────────────────────┐
│  Date     : 01/11/2020         │  Date     : 12/04/2020         │
│  Observed : 01/11/2020         │  Observed : 12/04/2020         │
│  DateEnd  : null               │  DateEnd  : null               │
│  Free     : True               │  Free     : True               │
│  Name     : All Saints' Day    │  Name     : Easter Sunday      │
│  Culture  : fr-FR              │  Culture  : fr-FR              │
│  Country  : France             │  Country  : France             │
│  Region   :                    │  Region   :                    │
├────────────────────────────────┼────────────────────────────────┤
│  Date     : 11/11/2020         │  Date     : 31/05/2020         │
│  Observed : 11/11/2020         │  Observed : 31/05/2020         │
│  DateEnd  : null               │  DateEnd  : null               │
│  Free     : True               │  Free     : True               │
│  Name     : Armistice Day 1918 │  Name     : Pentecost          │
│  Culture  : fr-FR              │  Culture  : fr-FR              │
│  Country  : France             │  Country  : France             │
│  Region   :                    │  Region   :                    │
├────────────────────────────────┼────────────────────────────────┤
│  Date     : 01/01/2020         │  Date     : 01/01/2021         │
│  Observed : 01/01/2020         │  Observed : 01/01/2021         │
│  DateEnd  : null               │  DateEnd  : null               │
│  Free     : True               │  Free     : True               │
│  Name     : New Year's Day     │  Name     : New Year's Day     │
│  Culture  : fr-FR              │  Culture  : fr-FR              │
│  Country  : France             │  Country  : France             │
│  Region   :                    │  Region   :                    │
├────────────────────────────────┼────────────────────────────────┤
│  Date     : 08/05/2020         │  Date     : 08/05/2021         │
│  Observed : 08/05/2020         │  Observed : 08/05/2021         │
│  DateEnd  : null               │  DateEnd  : null               │
│  Free     : True               │  Free     : True               │
│  Name     : Victory Day        │  Name     : Victory Day        │
│  Culture  : fr-FR              │  Culture  : fr-FR              │
│  Country  : France             │  Country  : France             │
│  Region   :                    │  Region   :                    │
├────────────────────────────────┼────────────────────────────────┤
│  Date     : 01/05/2020         │  Date     : 01/05/2021         │
│  Observed : 01/05/2020         │  Observed : 01/05/2021         │
│  DateEnd  : null               │  DateEnd  : null               │
│  Free     : True               │  Free     : True               │
│  Name     : Labor Day          │  Name     : Labor Day          │
│  Culture  : fr-FR              │  Culture  : fr-FR              │
│  Country  : France             │  Country  : France             │
│  Region   :                    │  Region   :                    │
├────────────────────────────────┼────────────────────────────────┤
│  Date     : 14/07/2020         │  Date     : 14/07/2021         │
│  Observed : 14/07/2020         │  Observed : 14/07/2021         │
│  DateEnd  : null               │  DateEnd  : null               │
│  Free     : True               │  Free     : True               │
│  Name     : Bastille Day       │  Name     : Bastille Day       │
│  Culture  : fr-FR              │  Culture  : fr-FR              │
│  Country  : France             │  Country  : France             │
│  Region   :                    │  Region   :                    │
├────────────────────────────────┼────────────────────────────────┤
│  Date     : 21/05/2020         │  Date     : 13/05/2021         │
│  Observed : 21/05/2020         │  Observed : 13/05/2021         │
│  DateEnd  : null               │  DateEnd  : null               │
│  Free     : True               │  Free     : True               │
│  Name     : Ascension          │  Name     : Ascension          │
│  Culture  : fr-FR              │  Culture  : fr-FR              │
│  Country  : France             │  Country  : France             │
│  Region   :                    │  Region   :                    │
├────────────────────────────────┼────────────────────────────────┤
│  Date     : 15/08/2020         │  Date     : 05/04/2021         │
│  Observed : 15/08/2020         │  Observed : 05/04/2021         │
│  DateEnd  : null               │  DateEnd  : null               │
│  Free     : True               │  Free     : True               │
│  Name     : Assumption         │  Name     : Easter Monday      │
│  Culture  : fr-FR              │  Culture  : fr-FR              │
│  Country  : France             │  Country  : France             │
│  Region   :                    │  Region   :                    │
├────────────────────────────────┼────────────────────────────────┤
│  Date     : 25/12/2020         │  Date     : 24/05/2021         │
│  Observed : 25/12/2020         │  Observed : 24/05/2021         │
│  DateEnd  : null               │  DateEnd  : null               │
│  Free     : True               │  Free     : True               │
│  Name     : Christmas Day      │  Name     : Pentecost Monday   │
│  Culture  : fr-FR              │  Culture  : fr-FR              │
│  Country  : France             │  Country  : France             │
│  Region   :                    │  Region   :                    │
├────────────────────────────────┼────────────────────────────────┤
│  Date     : 13/04/2020         │  Date     : 02/04/2021         │
│  Observed : 13/04/2020         │  Observed : 02/04/2021         │
│  DateEnd  : null               │  DateEnd  : null               │
│  Free     : True               │  Free     : True               │
│  Name     : Easter Monday      │  Name     : Good Friday        │
│  Culture  : fr-FR              │  Culture  : fr-FR              │
│  Country  : France             │  Country  : France             │
│  Region   :                    │  Region   :                    │
├────────────────────────────────┼────────────────────────────────┤
│  Date     : 01/06/2020         │  Date     : 04/04/2021         │
│  Observed : 01/06/2020         │  Observed : 04/04/2021         │
│  DateEnd  : null               │  DateEnd  : null               │
│  Free     : True               │  Free     : True               │
│  Name     : Pentecost Monday   │  Name     : Easter Sunday      │
│  Culture  : fr-FR              │  Culture  : fr-FR              │
│  Country  : France             │  Country  : France             │
│  Region   :                    │  Region   :                    │
├────────────────────────────────┼────────────────────────────────┤
│  Date     : 10/04/2020         │  Date     : 23/05/2021         │
│  Observed : 10/04/2020         │  Observed : 23/05/2021         │
│  DateEnd  : null               │  DateEnd  : null               │
│  Free     : True               │  Free     : True               │
│  Name     : Good Friday        │  Name     : Pentecost          │
│  Culture  : fr-FR              │  Culture  : fr-FR              │
│  Country  : France             │  Country  : France             │
│  Region   :                    │  Region   :                    │
└────────────────────────────────┴────────────────────────────────┘

PS D:\Calen\bin> 
```



**Sample of csv output**

```datas
Name;StartDate;EndDate;ObservedDate;Country;Culture;Free;Calendar
All Saints' Day;01/11/2020 00:00:00;;01/11/2020;France;fr-FR;true;Gregorian
Armistice Day 1918;11/11/2020 00:00:00;;11/11/2020;France;fr-FR;true;Gregorian
New Year's Day;01/01/2020 00:00:00;;01/01/2020;France;fr-FR;true;Gregorian
Victory Day;08/05/2020 00:00:00;;08/05/2020;France;fr-FR;true;Gregorian
Labor Day;01/05/2020 00:00:00;;01/05/2020;France;fr-FR;true;Gregorian
Bastille Day;14/07/2020 00:00:00;;14/07/2020;France;fr-FR;true;Gregorian
Ascension;21/05/2020 00:00:00;;21/05/2020;France;fr-FR;true;Gregorian
Assumption;15/08/2020 00:00:00;;15/08/2020;France;fr-FR;true;Gregorian
Christmas Day;25/12/2020 00:00:00;;25/12/2020;France;fr-FR;true;Gregorian
Easter Monday;13/04/2020 00:00:00;;13/04/2020;France;fr-FR;true;Gregorian
Pentecost Monday;01/06/2020 00:00:00;;01/06/2020;France;fr-FR;true;Gregorian
Good Friday;10/04/2020 00:00:00;;10/04/2020;France;fr-FR;true;Gregorian
Easter Sunday;12/04/2020 00:00:00;;12/04/2020;France;fr-FR;true;Gregorian
Pentecost;31/05/2020 00:00:00;;31/05/2020;France;fr-FR;true;Gregorian
New Year's Day;01/01/2021 00:00:00;;01/01/2021;France;fr-FR;true;Gregorian
Victory Day;08/05/2021 00:00:00;;08/05/2021;France;fr-FR;true;Gregorian
Labor Day;01/05/2021 00:00:00;;01/05/2021;France;fr-FR;true;Gregorian
Bastille Day;14/07/2021 00:00:00;;14/07/2021;France;fr-FR;true;Gregorian
Ascension;13/05/2021 00:00:00;;13/05/2021;France;fr-FR;true;Gregorian
Easter Monday;05/04/2021 00:00:00;;05/04/2021;France;fr-FR;true;Gregorian
Pentecost Monday;24/05/2021 00:00:00;;24/05/2021;France;fr-FR;true;Gregorian
Good Friday;02/04/2021 00:00:00;;02/04/2021;France;fr-FR;true;Gregorian
Easter Sunday;04/04/2021 00:00:00;;04/04/2021;France;fr-FR;true;Gregorian
Pentecost;23/05/2021 00:00:00;;23/05/2021;France;fr-FR;true;Gregorian

```



## Use by code

all sdk is available in a single livrary in a package nuget.

```powershell
PM> Install-Package Black.Beard.Calendarium -Version 1.0.83
```



```CSharp
// Load all configuration files in a specific folder
var dir = new System.IO.DirectoryInfo(Path.Combine(Environment.CurrentDirectory, "Configuration/Countries"));

// Load all configurations of the specified folder
var loader = new ConfigurationLoader(dir).Load();

// Initialize
var cal = CalendariumConfiguration.GetCalendarium
(
    loader
);

// Get all dates for country france
int year = DateTime.Now.Year;
var dates = cal.GetDates(year, "France");

```
the result date is converter in current thread culture calendar

## All managed countries available by nuget package
+ France
+ Germany
+ Luxembourg
+ Belgium
+ Andorra
+ Austria
+ Portugal
+ Croatia
+ San_Marino
+ Malta
+ Estonia
+ Ecuador
+ Italy
+ India
+ Czechia
+ Nicaragua
+ Peru
+ Slovakia
+ Slovenia
+ Holy_See_Vatican_City
+ Armenia
+ Monaco
+ Russia
+ El_Salvador
+ Costa_Rica
+ Saudi_Arabia
+ Algeria
---

# Configuration

you can create or tune a configuration. You can use intelisense for help you.

[json xsd ]: https://github.com/Black-Beard-Sdk/Calendarium/blob/master/src/Black.Beard.Calendarium/Countries/_schema.CountryConfiguration.json

**Country** will by used by key for match with the country. 

**Calendar** specify the calendar by default for the configuration file. the calendar can be tuned in the period

**Periods** is an array of rule. 

​	**Name** is in english.

​	**Free** is true/false if the day is worked or not.

​	**Tags** is an array of string tag.

​	**Culture** code is a key  

[doc microsoft]: https://docs.microsoft.com/fr-fr/dotnet/api/system.globalization.cultureinfo?view=netcore-3.1

​	**RuleDate** contains the rule for building the date

​	**RuleObserved** contains the rule for building the observed date. for any countries the observed date is the free day different of the holiday calculated.

​	**RuleRuration** contains the rule for building the duration festivity. sometime the festivity can during any day like carnaval.

​	**YearFrom** specifiy the first year when the festivity iwas created.



```json
{
  "$schema": "/_schema.CountryConfiguration.json",
  "Country": "Poland",
  "Regions": [],
  "Periods": [
    {
      "Name": "Fat Thursday",
      "RuleDate": "([EASTER]) - 51",
      "RuleObserved": null,
      "RuleDuration": null,
      "Free": false,
      "Translations": [ {"Language":"French", "Name":"Mardi gras" } ],
      "Tags": [],
      "YearFrom": 2014
    }
  ],
  "Culture": "pl",
  "Calendar": "Gregorian"
}
```



**Language** is an enumeration

- Undefined
- French
- German
- English
- Dutch
- Italian
- Estonian
- Latvian
- Lithuanian
- Spanish
- Romania
- Slovak
- Slovenian
- Croatian
- Czech
- Polish
- Hungarian
- Portuguese
- Russian
- Finnish
- Norwgian
- Danish
- Swedish



**Calendar** is an enumeration

- Default
- Gregorian
- Hebrew
- UmAlQura
- Hijri
- Japanese
- JapaneseLunisolar
- Julian
- Korean
- KoreanLunisolar
- Persian
- Taiwan
- TaiwanLunisolar
- ThaiBuddhist

# Rules

### lexer

```antlr
lexer grammar CalendariumLexer;

YEAR :      'YEAR';
MONTH :     'MONTH';
DAY :       'DAY';
DAYWEEK :   'DAYWEEK';

MONDAY :    'MONDAY';
TUESDAY	 :  'TUESDAY';
WEDNESDAY : 'WEDNESDAY';
THURSDAY :  'THURSDAY';
FRIDAY :    'FRIDAY';
SATURDAY :  'SATURDAY';
SUNDAY :    'SUNDAY';


// and a superfluous subtoken typecasting of the "QUOTE"
CHAR_STRING:  '\'' (~('\'' | '\r' | '\n') | '\'\'')+ '\'';

// SQL_SPECIAL_CHAR was split into single rules
LEFT_PAREN :            '(';
LEFT_BRACKET :          '[';
RIGHT_PAREN :           ')';
RIGHT_BRACKET :         ']';
COLON :                 ':';
SEMICOLON :             ';';
COMMA :                 ',';
PLUS :                  '+';
MINUS :                 '-';
TIME :                  '*';
DOT :                   '.';
DIVID :                 '\\';
NOT :                   '!';
EQUAL :                 '=';
MODULO :                '%';
POWER :                 '^';
NOT_EQUAL :             '!=';
GREATER :               '>';
GREATER_OR_EQUAL :      '>=';
LESS :                  '<';
LESS_OR_EQUAL :         '<=';
XOR :                   '||';
OR :                    '|';
AND :                   '&';
ANDALSO :               '&&';
SLASH :                 '\\';
INTEROGATION :          '?';

SPACES: [ \t\r\n]+ -> skip;
    
// Rule #504 <SIMPLE_LETTER> - simple_latin _letter was generalised into SIMPLE_LETTER
//  Unicode is yet to be implemented - see NSF0
fragment
SIMPLE_LETTER
    : [A-Za-z]
    ;

NUMBER
    : [0-9]+
    ;

// Rule #097 <COMMENT>
SINGLE_LINE_COMMENT: '--' ~('\r' | '\n')* EOF               -> channel(HIDDEN);
MULTI_LINE_COMMENT:  '/*' .*? '*/'                          -> channel(HIDDEN);
    
fragment
SPACE: [ \t];

REGULAR_ID: SIMPLE_LETTER (SIMPLE_LETTER | '$' | '_' | '#' | [0-9])*;

```

### Parser

```antlr
parser grammar CalendariumParser;

options { 
    // memoize=True;
    tokenVocab=CalendariumLexer; 
    }

script :
      expression
    | INTEROGATION expression_bool COLON expression
    ;

expression_bool
    :  dayweek (OR dayweek)?
    |  LEFT_PAREN expression_bool RIGHT_PAREN
    ;

expression :
      rule expression?
    | LEFT_PAREN expression RIGHT_PAREN expression?
    // | NOT expression expression?
    | operation expression
    ;

operation : 
      PLUS | MINUS 
    // | TIME | DIVID
    // | MODULO
    // | EQUAL | NOT_EQUAL
    // | GREATER | GREATER_OR_EQUAL | LESS | LESS_OR_EQUAL
    // | AND | ANDALSO | OR | XOR
    // | (PLUS PLUS)
    | (GREATER GREATER)
    | (LESS LESS)
    ;

rule : 
      mask
    | LEFT_BRACKET identifier RIGHT_BRACKET
    | TIME? dayweek
    | NUMBER
    ;

mask : 
    month=NUMBER MINUS day=NUMBER
    ;

dayweek : MONDAY | TUESDAY | WEDNESDAY | THURSDAY | FRIDAY | SATURDAY | SUNDAY;

identifier : REGULAR_ID;
```

Keys for internal computings

- EASTER
- ORTHODOX_EASTER

### Samplers rule date

```json
# mask : build christmas all 25 december
"RuleDate" : "12-25"

# mask : build Eid all 12 of 10 th month in hijri calendar. the date is converted in current local calendar
"RuleDate" : "12-10"
"Calendar" : "Hijri"

# mask : build easter
"RuleDate" : "[EASTER]"

# mask : build Ascension 40 days after Easter
"RuleDate" : "([EASTER]) + 39"

# mask : build Day of Prayer and Repentance (germany holiday). first westerday before 23 november.
"RuleDate" : "((11-23) - 1) << Wednesday"

```

