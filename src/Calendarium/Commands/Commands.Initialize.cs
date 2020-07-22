using Bb.Helpers;
using Microsoft.Extensions.CommandLineUtils;
using System.Collections.Generic;
using System.Text;

namespace Bb.Commands
{
    public static partial class Commands
    {

        static Commands()
        {

            // Command._access = "('" + string.Join("','", Enum.GetNames(typeof(AccessModuleEnum))) + "')";

        }


        /// <summary>
        /// Initializes the specified application.
        /// </summary>
        /// <param name="app">The application.</param>
        /// <returns></returns>
        public static CommandLineApplication Initialize(this CommandLineApplication app)
        {

            Helper.Load();

            AnsiConsole.GetError(true);

            app.HelpOption(HelpFlag);
            app.VersionOption(VersionFlag, Constants.ShortVersion, Constants.LongVersion);

            app.Name = Constants.Name;
            app.Description = Constants.ProgramHelpDescription;
            app.ExtendedHelpText = Constants.ExtendedHelpText;

            return app;

        }

        public static object Result { get; internal set; }

        public const string HelpFlag = "-? |-h |--help";
        public const string VersionFlag = "-v |--version";
        public static string _access;


    }

}
