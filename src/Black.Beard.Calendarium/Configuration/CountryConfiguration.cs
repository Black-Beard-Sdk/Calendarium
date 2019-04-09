using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;

namespace Bb.Calendarium.Configuration
{

    public class CountryConfiguration : DefaultCountryConfiguration
    {

        public CountryConfiguration()
        {
            Regions = new List<RegionConfiguration>();
        }

        public override string GetFilname(DirectoryInfo dir)
        {
            return Path.Combine(dir.FullName, $"date_{Name}.json");
        }

        [JsonIgnore]
        public override string Name { get => Country.ToString(); set => Country = Enum.Parse<Country>(value); }

        [JsonRequired]
        [JsonConverter(typeof(StringEnumConverter))]
        [Description("Specify a country")]
        public Country Country { get; set; }

        public List<RegionConfiguration> Regions { get; set; }

        [Description("Specify a base defaultCountry. you can specify many with comma")]
        public string Defaults { get; set; }

        [Description("Specify an url for describe country days")]
        public string Url { get; set; }

        public override string ToString()
        {
            return Country.ToString();
        }


        //public static StringBuilder SerializeSchema()
        //{
        //    return SchemaHelper.GenerateSchemaForClass(typeof(CountryConfiguration));
        //}

    }

}
