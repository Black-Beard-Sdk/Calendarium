using Bb.Calendarium.Configuration;
using System;
using System.Collections.Generic;
using System.IO;

//14320
namespace Calendarium
{
    internal class Program
    {

        private static void Main(string[] args)
        {


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

            var items = countries.GetNextDates(DateTime.Now, Country.France);

        }

    }



}
