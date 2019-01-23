using System.Collections.Generic;
using System.IO;

namespace Bb.Calendarium.Configuration
{

    public class ConfigurationLoader
    {

        public ConfigurationLoader(DirectoryInfo dir)
        {
            _dir = dir;
        }

        /// <summary>
        /// Load specified country by name
        /// </summary>
        /// <param name="countryNames"></param>
        /// <returns></returns>
        public DefaultCountryConfiguration[] Load(params string[] countryNames)
        {
            List<DefaultCountryConfiguration> _list = new List<DefaultCountryConfiguration>();
            foreach (var countryName in countryNames)
            {
                var file = countryName.EndsWith(".json") ? countryName : countryName + ".json";
                var f = new FileInfo(Path.Combine(_dir.FullName, file));
                if (!f.Exists)
                        f = new FileInfo(Path.Combine(_dir.FullName, "date_" + file));

                if (!f.Exists)
                    throw new FileNotFoundException(f.FullName);
                _list.Add(Load(f));
            }
            return _list.ToArray();
        }

        public DefaultCountryConfiguration[] Load()
        {
            List<DefaultCountryConfiguration> _list = new List<DefaultCountryConfiguration>();
            foreach (var item in _dir.GetFiles("*.json"))
                if (item.Name != "_schema.CountryConfiguration.json" && item.Name != "_schema.DefaultCountryConfiguration.json")
                    _list.Add(Load(item));
            return _list.ToArray(); ;
        }

        public DefaultCountryConfiguration Load(FileInfo file)
        {
            return DefaultCountryConfiguration.Load(file);
        }

        private readonly DirectoryInfo _dir;

    }

}
