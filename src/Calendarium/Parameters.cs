using System;
using System.Collections.Generic;

//14320
namespace Bb
{
    public class Parameter
    {

        public Parameter()
        {
            Countries = new List<CountryParameter>();
        }

        // public string ServerUrl { get; set; }
    
        public List<CountryParameter> Countries { get; set; }
    
    }

    public class CountryParameter
    {

        public string Name { get; set; }

        public Version OnlineVersion { get; set; }

        public Version LocalVersion { get; set; }

        public bool Included { get; set; }

    }


}

// https://azuresearch-usnc.nuget.org/query?q=Black.Beard.Calendarium.&prerelease=false&semVerLevel=2.0.0&skip=10
// https://dist.nuget.org/win-x86-commandline/latest/nuget.exe
// Black.Beard.Calendarium.France


/*
 
 
            var loader = new ConfigurationLoader(new System.IO.DirectoryInfo(Path.Combine(Environment.CurrentDirectory, "Countries")));

            List<DefaultCountryConfiguration> _list = new List<DefaultCountryConfiguration>();
            if (args.Length > 0)
            {
                var files = File.ReadAllText(Path.Combine(Environment.CurrentDirectory, args[0])).Split('\r');
                foreach (var item in files)
                {
                    DefaultCountryConfiguration[] l = loader.Load(item);
                    _list.AddRange(l);
                }
            }
            else
                _list.AddRange(loader.Load());

            var countries = CalendariumConfiguration.GetCalendarium(_list.ToArray());

            var items = countries.GetNextDates(DateTime.Now, "France");
*/
