using Bb.Helpers;
using Bb.Http;
using Bb.Printings;
using Bb.Validations;
using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;
using Microsoft.Extensions.CommandLineUtils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Bb.Commands
{
    public static partial class Commands
    {

        public static CommandLineApplication CommandCountries(this CommandLineApplication app)
        {

            var cmd = app.Command("config", config1 =>
            {

                config1.Description = "manage country's configuration";
                config1.HelpOption(HelpFlag);

                var cmd2 = config1.Command("list", config2 =>
                {

                    config2.Description = "return the list of available countries";
                    config2.HelpOption(HelpFlag);

                    var validator = new GroupArgument(config2, false);

                    config2.OnExecute(() =>
                    {

                        if (validator.Evaluate() > 0)
                            return 2;

                        try
                        {
                            DownloadCountryList();
                            Output.WriteLine("list successfull downloaded");
                        }
                        catch (Exception)
                        {
                            Output.WriteLine("Fail to resolve remote list of configuration. Working with local list");
                            throw;
                        }


                        ConvertToDatatable.ConvertList<CountryParameter>(Helper.Parameters.Countries
                            , "available countries parameters"
                            , c => c.Name
                            , c => c.Included
                            , c => c.OnlineVersion
                            , c => c.OnlineVersion
                            )
                        .PrintList()
                        ;

                        return 0;

                    });

                });

                var cmd3 = config1.Command("add", config2 =>
                {

                    config2.Description = "add a new country in the local configuration";
                    config2.HelpOption(HelpFlag);

                    var validator = new GroupArgument(config2, false);

                    var countryName = validator.Argument("CountryName",
                        "name of the country must be added in the configuration. (this argument is required)"
                        , ValidatorExtension.EvaluateRequired
                        , ValidatorExtension.EvaluateCountryName
                        );

                    config2.OnExecute(() =>
                    {

                        if (Helper.Parameters.Countries.Count == 0)
                        {
                            GetDictionnaryCountry();
                            Output.WriteLine("list successfull downloaded");
                        }

                        if (validator.Evaluate() > 0)
                            return 2;

                        var country = countryName.Value.ToLower();
                        var _country = Helper.Parameters.Countries.FirstOrDefault(c => c.Name.ToLower() == country);
                        _country.Included = true;


                        var rootPath = GetTempFolder();
                        RefreshConfigCountry(_country, rootPath);
                        rootPath.DeleteDirectoryTree();

                        
                        ConvertToDatatable.ConvertList<CountryParameter>(Helper.Parameters.Countries.Where(c => c.Included)
                            , "available countries parameters"
                            , c => c.Name
                            , c => c.Included
                            , c => c.OnlineVersion
                            , c => c.OnlineVersion
                            )
                        .PrintList()
                        ;

                        return 0;

                    });

                });

                var cmd4 = config1.Command("refresh", config2 =>
                {

                    config2.Description = "refresh list of country's configuration";
                    config2.HelpOption(HelpFlag);

                    var validator = new GroupArgument(config2, false);

                    var countryName = validator.Argument("CountryName",
                        "name of the country must be added in the configuration. (when argument is missing, all configuration are refreshed)"
                        //, ValidatorExtension.
                        );

                    config2.OnExecute(() =>
                    {

                        if (validator.Evaluate() > 0)
                            return 2;

                        var rootPath = GetTempFolder();

                        foreach (var item in Helper.Parameters.Countries.Where(c => c.Included))
                        {

                            if (item.LocalVersion != null && item.LocalVersion == item.OnlineVersion)
                            {
                                var target = new FileInfo(Path.Combine(Constants.RootPathConfig.FullName, item.Name) + ".json");
                                if (target.Exists)
                                {
                                    Output.WriteLine($"{item.Name} up to date in the version {item.LocalVersion}");
                                    continue;
                                }
                            }

                            RefreshConfigCountry(item, rootPath);

                        }


                        Output.WriteLine($"Clean");
                        rootPath.DeleteDirectoryTree();

                        Output.WriteLine("successfull updated");

                        return 0;

                    });

                });

            });

            return app;

        }

        public static DirectoryInfo GetTempFolder()
        {

            DirectoryInfo rootPath = new DirectoryInfo(Path.Combine(Constants.RootPath.FullName, "tmp"));
            if (rootPath.Exists)
                rootPath.DeleteDirectoryTree();
            rootPath.Create();

            return rootPath;

        }

        public static void RefreshConfigCountry(CountryParameter item, DirectoryInfo rootPathTemp)
        {


            Output.WriteLine($"{item.Name} updating in the version {item.OnlineVersion}");

            // Download
            Output.WriteLine($"Download");
            string filename = Path.Combine(rootPathTemp.FullName, string.Format(@"Black.Beard.Calendarium.{0}.zip", item.Name));
            var task = BbClientHttp.DownloadAsync(string.Format(@"https://www.nuget.org/api/v2/package/Black.Beard.Calendarium.{0}/{1}", item.Name, item.OnlineVersion), filename);
            task.Wait();


            // Unzip
            Output.WriteLine($"Uncompress");
            var dir = rootPathTemp.CreateSubdirectory(string.Format(@"Black.Beard.Calendarium.{0}", item.Name));
            FileInfo f = new FileInfo(filename);
            f.UnzipFromFile(dir.FullName);


            // copy configurations
            Output.WriteLine($"Save");
            DirectoryInfo p = new DirectoryInfo(Path.Combine(dir.FullName, @"content\Configuration\Countries"));
            var file = p.GetFiles("*.json").FirstOrDefault();
            var target = new FileInfo(Path.Combine(Constants.RootPathConfig.FullName, item.Name) + ".json");
            if (target.Exists)
                target.Delete();
            file.CopyTo(target.FullName);

            item.LocalVersion = item.OnlineVersion;

        }

        private static void DownloadCountryList()
        {
            Dictionary<string, CountryParameter> dic = GetDictionnaryCountry();

            BbClientHttp client = new BbClientHttp(new Uri(@"https://azuresearch-usnc.nuget.org"));
            var items = client.Get<JObject>(string.Format(@"https://azuresearch-usnc.nuget.org/query?q=Black.Beard.Calendarium.&prerelease=false&semVerLevel=2.0.0&skip={0}&take=50", 0));
            items.Wait();

            var totalHits = items.Result["totalHits"];
            var count = int.Parse(totalHits.ToString());

            var array = items.Result["data"] as JArray;
            AddCountries(dic, array);

            for (int i = 50; i < count; i = i + 50)
            {
                items = client.Get<JObject>(string.Format(@"https://azuresearch-usnc.nuget.org/query?q=Black.Beard.Calendarium.&prerelease=false&semVerLevel=2.0.0&skip={0}&take=50", i));
                items.Wait();
                array = items.Result["data"] as JArray;
                AddCountries(dic, array);
            }
        }

        private static void AddCountries(Dictionary<string, CountryParameter> dic, JArray array)
        {
            foreach (var item in array)
            {

                var txt = item["id"].ToString();
                if (txt.StartsWith("Black.Beard.Calendarium."))
                {
                    var ids = txt.Split('.');
                    var version = item["version"].ToString();
                    var id = ids[ids.Length - 1];
                    if (dic.TryGetValue(id, out CountryParameter country))
                        country.OnlineVersion = new Version(version);

                    else
                        country = new CountryParameter()
                        {
                            Name = id,
                            OnlineVersion = new Version(version),
                        };

                    Helper.Parameters.Countries.Add(country);


                }
            }
        }

        private static Dictionary<string, CountryParameter> GetDictionnaryCountry()
        {

            var dic = new Dictionary<string, CountryParameter>(Helper.Parameters.Countries.Count * 2);
            foreach (var item in Helper.Parameters.Countries)
                if (!dic.ContainsKey(item.Name))
                    dic.Add(item.Name, item);

            Helper.Parameters.Countries.Clear();

            return dic;
        }
    }

}
