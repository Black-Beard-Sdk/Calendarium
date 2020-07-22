using Bb.Calendarium;
using Bb.Calendarium.Configuration;
using Bb.Helpers;
using Bb.Http;
using Bb.Printings;
using Bb.Validations;
using Microsoft.Extensions.CommandLineUtils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Bb.Commands
{
    public static partial class Commands
    {

        public static CommandLineApplication CommandCompute(this CommandLineApplication app)
        {

            var cmd = app.Command("compute", (Action<CommandLineApplication>)(config1 =>
            {

                config1.Description = "compute country";
                config1.HelpOption(HelpFlag);

                var validator = new GroupArgument(config1, false);

                var outputName = validator.Argument("outputName",
                    "name of the output csv file"
                    , ValidatorExtension.EvaluateRequired
                );

                var countYear = validator.Argument("CountYears",
                   "count of years must be computed. (this argument is required)"
                   , ValidatorExtension.EvaluateShort
               );

                var countryName = validator.Argument("CountryName",
                    "name of the country must be computed. (if this argument is missing all config will be computed)"
                    , ValidatorExtension.EvaluateCountryName
                );
                countryName.MultipleValues = true;



                //var countYear = validator.Option("",
                //   "count of years must be computed. (1 year by default)"
                //   , Va



                config1.OnExecute((Func<int>)(() =>
                {

                    if (validator.Evaluate() > 0)
                        return 2;

                    // Resolve arguments
                    var Namecountries = countryName.Values.Select(c => c.ToLower()).ToList();
                    string file = outputName.Value;
                    var d = Path.Combine(Directory.GetCurrentDirectory(), outputName.Value);
                    short cYear = 1;
                    if (short.TryParse((string)countYear.Value.ToString(), out short cc))
                        cYear = cc;

                    // Initialisation parameters
                    var loader = new ConfigurationLoader(Constants.RootPathConfig);
                    List<CountryParameter> countriesToCompute = BuildListOfCountriesMustBeComputed(Namecountries);
                    List<DefaultCountryConfiguration> _list = LoadConfigurations(countriesToCompute, loader);
                    var _countries = CalendariumConfiguration.GetCalendarium(_list.ToArray());

                    // Init file
                    if (File.Exists(d))
                        File.Delete(d);
                    var t = "Name;StartDate;EndDate;ObservedDate;Country;Culture;Free;Calendar";
                    File.AppendAllLines(d, new string[] { t });

                    List<EventDate> dates = new List<EventDate>();
                    foreach (var countryToCompute in countriesToCompute)
                    {

                        if (countryToCompute.OnlineVersion != countryToCompute.LocalVersion)
                            Output.WriteLine($"{countryToCompute.Name} is not up to date");

                        var items = _countries.GetNextDates(DateTime.Now, countryToCompute.Name, cYear * 365);

                        foreach (var item in items)
                            foreach (var item2 in item.Value.Events)
                            {
                                dates.Add(item2);

                                var dateEnd = item2.DateEnd?.ToString() ?? string.Empty;
                                var dateObserved = item2.Observed?.ToString() ?? string.Empty;

                                var y = $"{item2.Name};{item.Value.Date};{dateEnd};{dateObserved};{item2.Country};{item2.Culture};{item2.Free.ToString().ToLower()};{item2.CalendarUsedToBuild.ToString().Split('.')[2].Replace("Calendar", "")}";
                                File.AppendAllLines(d, new string[] { y });

                            }

                    }

                    dates.ConvertList(
                             "computed dates"
                            , c => c.Name
                            , c => c.Country
                            , c => c.Culture
                            , c => c.Date
                            , c => c.DateEnd
                            , c => c.Observed
                            , c => c.Free
                            , c => c.Region
                            )
                        .PrintList()
                        ;

                    return 0;

                }));

            }));

            return app;

        }

        private static List<CountryParameter> BuildListOfCountriesMustBeComputed(List<string> Namecountries)
        {
            List<CountryParameter> c = new List<CountryParameter>(Helper.Parameters.Countries.Count);
            if (Namecountries.Count > 0)
            {
                foreach (var item in Namecountries)
                {
                    var it = Helper.Parameters.Countries.FirstOrDefault(c => c.Name.ToLower() == item);
                    if (it == null)
                        Output.ErrorWriteLine($"{item} missing in the available countries configurations");
                    else
                        c.Add(it);
                }
            }
            else
            {
                foreach (var item in Helper.Parameters.Countries.Where(c => c.Included))
                    c.Add(item);
            }

            return c;
        }

        private static List<DefaultCountryConfiguration> LoadConfigurations(List<CountryParameter> countries, ConfigurationLoader loader)
        {
            List<DefaultCountryConfiguration> _list = new List<DefaultCountryConfiguration>();
            foreach (var item in countries)
            {
                var file = new FileInfo(Path.Combine(Constants.RootPathConfig.FullName, item.Name) + ".json");
                if (file.Exists)
                {
                    Output.WriteLine($"configuration {item.Name} is loaded");
                    _list.Add(loader.Load(file));
                }
            }

            return _list;
        }
    }

}
