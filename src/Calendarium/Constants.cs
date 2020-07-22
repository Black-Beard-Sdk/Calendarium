//14320
using System.IO;
using System.Reflection;

namespace Bb
{
    public static class Constants
    {

        static Constants()
        {

            RootCommand = Path.GetFileNameWithoutExtension( Assembly.GetEntryAssembly().GetName().Name);
            RootPath = new System.IO.FileInfo(System.Reflection.Assembly.GetEntryAssembly().Location).Directory;

            RootPathConfig = new DirectoryInfo(Path.Combine(Constants.RootPath.FullName, "Configs"));
            if (!RootPathConfig.Exists)
                RootPathConfig.Create();

            Name = System.AppDomain.CurrentDomain + " " + ShortVersion;

        }


        public static readonly string Name;
        public const string ShortVersion = "v1";
        public const string LongVersion = "version 1";

        public const string ProgramHelpDescription = "";
        public const string ExtendedHelpText = "";

        public const string urlNuget = @"https://dist.nuget.org/win-x86-commandline/latest/nuget.exe";
        public static string RootCommand;

        public static DirectoryInfo RootPath { get; }
        public static DirectoryInfo RootPathConfig { get; }

        public const int LargeBufferSize = 100 * (1024 * 1000);

    }

}



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
