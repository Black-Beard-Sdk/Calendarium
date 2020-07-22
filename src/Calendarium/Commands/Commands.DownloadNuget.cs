using Bb.Helpers;
using Bb.Http;
using Bb.Validations;
using Microsoft.Extensions.CommandLineUtils;
using System;
using System.Runtime.CompilerServices;

namespace Bb.Commands
{
    public static partial class Commands
    {

        public static CommandLineApplication CommandDownloadNuget(this CommandLineApplication app)
        {

            var cmd = app.Command("download", config =>
            {

                config.Description = "Download nuget at " + Constants.urlNuget;
                config.HelpOption(HelpFlag);

                var validator = new GroupArgument(config, false);

                config.OnExecute(() =>
                {

                    if (validator.Evaluate() > 0)
                        return 2;

                    var uri = new Uri(Constants.urlNuget);
                    BbClientHttp cli = new BbClientHttp(uri);


                    try
                    {
                        if (Constants.NugetFile.Exists)
                        {
                            Output.WriteLine("remove current version of nuget.exe in " + Constants.NugetFile.Directory.FullName);
                            Constants.NugetFile.Delete();
                        }
                    }
                    catch (Exception ex1)
                    {
                        throw new Exception("failed to remove current version of nuget.exe", ex1);
                    }

                    try
                    {
                        Output.WriteLine("download lastest version of nuget.exe in " + Constants.NugetFile.Directory.FullName);
                        BbClientHttp.DownloadAsync(uri, Constants.NugetFile.FullName).Wait();
                    }
                    catch (Exception ex2)
                    {
                        throw new Exception("failed to to downlod nuget.exe", ex2);
                    }

                    Output.WriteLine("download successfull");

                    Result = Constants.NugetFile;

                    return 0;

                });
            });

            return app;

        }

    }

}
