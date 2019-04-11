using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Text;

namespace Bb.Calendarium.Configuration
{
    public class DefaultCountryConfiguration
    {

        public DefaultCountryConfiguration()
        {
            Periods = new List<PeriodConfiguration>();
            _settings = new JsonSerializerSettings()
            {
                DefaultValueHandling = DefaultValueHandling.Ignore,
                Formatting = Formatting.Indented,
            };

        }

        public void Save(DirectoryInfo dir, StringBuilder sb = null)
        {

            if (sb == null)
                sb = Serialize();

            if (!dir.Exists)
                dir.Create();

            string filename = GetFilname(dir);

            if (File.Exists(filename))
                File.Delete(filename);

            File.AppendAllText(filename, sb.ToString());

        }

        /// <summary>
        /// Serializes <see cref="CountryConfiguration"/>.
        /// </summary>
        /// <param name="sb">The sb.</param>
        /// <returns></returns>
        public StringBuilder Serialize(StringBuilder sb = null)
        {

            if (sb == null)
                sb = new StringBuilder(2000);

            var txt = JsonConvert.SerializeObject(this, _settings);

            var token = JObject.Parse(txt);

            if (this is CountryConfiguration)
                token.AddFirst(new JProperty("$schema", new JValue(@"/_schema.CountryConfiguration.json")));
            else
                token.AddFirst(new JProperty("$schema", new JValue(@"/_schema.DefaultCountryConfiguration.json")));

            sb.Append(token.ToString());

            // _schema.CountryConfiguration.json
            // _schema.DefaultCountryConfiguration.json
            return sb;
        }

        /// <summary>
        /// Deserializes the payload in <see cref="CountryConfiguration"/>.
        /// </summary>
        /// <param name="sb">The sb.</param>
        /// <returns></returns>
        public static DefaultCountryConfiguration Load(StringBuilder sb, bool defaultConfiguration)
        {

            var instance = defaultConfiguration
                ? JsonConvert.DeserializeObject<DefaultCountryConfiguration>(sb.ToString())
                : JsonConvert.DeserializeObject<CountryConfiguration>(sb.ToString()
                );

            return instance;

        }

        public static DefaultCountryConfiguration Load(FileInfo file)
        {

            if (!file.Exists)
                throw new FileNotFoundException(file.FullName);

            var defaultConfiguration = file.Name.ToLower().EndsWith("default.json");

            using (var f = file.OpenText())
            {
                var sb = new StringBuilder(f.ReadToEnd());
                var result =  Load(sb, defaultConfiguration);
                result.ConfigurationFile = file.FullName;
                return result;

            }

        }

        public virtual string GetFilname(DirectoryInfo dir)
        {
            return Path.Combine(dir.FullName, $"date_{Country}.Default.json");
        }

        [Description("Name of the country")]
        [JsonRequired]
        public virtual string Country { get; set; }

        public List<PeriodConfiguration> Periods { get; set; }

        [Description("Code culture info ex: fr-FR. Please see CultureInfo dot net documentation")]
        [JsonRequired]
        public string Culture { get; set; }

        [Description("Specify calendar contains in the culture")]
        [JsonConverter(typeof(StringEnumConverter))]
        public CalendarEnum Calendar { get; set; }

        public string ConfigurationFile { get; private set; }

        public CultureInfo GetCulture()
        {
            return CultureInfo.GetCultureInfo(Culture);
        }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return Country.ToString();
        }

        //public static StringBuilder SerializeSchema()
        //{
        //    return SchemaHelper.GenerateSchemaForClass(typeof(DefaultCountryConfiguration));
        //}

        private readonly JsonSerializerSettings _settings;

    }

}
