using System;
using System.Diagnostics;

//14320
namespace Bb
{
    public class Output
    {



        private static bool _debug;

        public static bool DebugModeActivated => _debug;

        internal static void Write(string message, params object[] args)
        {
            Write(string.Format(message, args));
        }

        internal static void WriteLine(string message, params object[] args)
        {
            WriteLine(string.Format(message, args));
        }

        internal static void WriteLine()
        {
            WriteLine(string.Empty);
        }

        internal static void ErrorWriteLine(string message, params object[] args)
        {
            ErrorWriteLine(string.Format(message));
        }

        internal static void ErrorWriteLine()
        {
            ErrorWriteLine(string.Empty);
        }

        internal static void WriteLine(string message)
        {

            if (_debug)
                Debug.WriteLine(message, TraceLevel.Info);

            else
                Console.WriteLine(message);

        }

        internal static void Write(string message)
        {

            if (_debug)
                Debug.Write(message);

            else
                Console.Write(message);

        }


        internal static void ErrorWriteLine(string message)
        {

            if (_debug)
                Debug.WriteLine(message, TraceLevel.Error);

            else
            {
                var c = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Error.WriteLine(message);
                Console.ForegroundColor = c;
                Console.Error.Flush();
            }

        }

        internal static void Flush()
        {
            if (_debug)
            {
                Debug.Flush();
            }
            else
            {
                Console.Out.Flush();
                Console.Error.Flush();
            }
        }

        public static void SetModeDebug()
        {
            _debug = true;
        }

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
