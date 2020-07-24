using Bb.Commands;
using Bb.Helpers;
using Microsoft.Extensions.CommandLineUtils;
using System;
using System.Security.Authentication;

namespace Bb
{

    /*   
        config list
        config add france
        config refresh
        compute output.csv 1 france
     */

    public partial class Program
    {

        public static int ExitCode { get; private set; }

        public static void Main(string[] args)
        {

            CommandLineApplication app = null;
            try
            {

                app = new CommandLineApplication()
                    .Initialize()
                    .CommandCountries()
                    .CommandCompute()
                ;

                if (Output.DebugModeActivated)
                    Output.WriteLine(string.Join(' ', args));

                int result = app.Execute(args);

                if (result == 0)
                    Helper.Save();

                else if (result == 1)
                    app.ShowHelp();

                Output.Flush();

                Environment.ExitCode = Program.ExitCode = result;

            }
            catch (System.FormatException e2)
            {
                FormatException(app, e2);
            }
            catch (AuthenticationException)
            {
                AuthorizeException();
            }
            //catch (ExpiratedTokenException)
            //{
            //    ExpirationException();
            //}
            catch (AggregateException e4)
            {
                foreach (var item in e4.InnerExceptions)
                {
                    if (item is AuthenticationException)
                        AuthorizeException();
                    else
                        Exception(item);
                }
            }
            catch (Exception e)
            {
                Exception(e);
            }

        }

        private static void Exception(Exception e)
        {
            Output.ErrorWriteLine(e.Message);
            Output.ErrorWriteLine(e.StackTrace);
            Output.Flush();

            if (e.HResult > 0)
                Environment.ExitCode = Program.ExitCode = e.HResult;

            Environment.ExitCode = Program.ExitCode = 1;
        }

        private static void ExpirationException()
        {
            Output.ErrorWriteLine("token expirated. please considere must be authenticated for access on the server.");
            Output.Flush();
            Environment.ExitCode = Program.ExitCode = 1;
        }

        private static void AuthorizeException()
        {
            Output.ErrorWriteLine("Not authenticated or not enough right to access this feature");
            Output.Flush();
            Environment.ExitCode = Program.ExitCode = 1;
        }

        private static void FormatException(CommandLineApplication app, FormatException e2)
        {
            Output.ErrorWriteLine(e2.Message);
            Output.Flush();
            app.ShowHelp();
            Environment.ExitCode = Program.ExitCode = 2;
        }

    }

}
