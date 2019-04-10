# Calendarium [![Build status](https://ci.appveyor.com/api/projects/status/r58r4d3rl4o60ohj?svg=true)](https://ci.appveyor.com/project/gaelgael5/calendarium-0v0lc)
manage referential of computed date

## Use
```CSharp
// Load all configuration files in a specific folder
var dir = new System.IO.DirectoryInfo(Path.Combine(Environment.CurrentDirectory, "Configuration/Countries"));
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

## Managed countries
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