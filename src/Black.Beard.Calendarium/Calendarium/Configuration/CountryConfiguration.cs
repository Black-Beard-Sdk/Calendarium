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
            return Path.Combine(dir.FullName, $"date_{Country}.json");
        }

        public override string Country { get; set; }

        public List<RegionConfiguration> Regions { get; set; }

        [Description("Specify a base defaultCountry. you can specify many with comma")]
        public string Defaults { get; set; }

        [Description("Specify an url for describe country days")]
        public string Url { get; set; }

        public override string ToString()
        {
            return Country;
        }


        //public static StringBuilder SerializeSchema()
        //{
        //    return SchemaHelper.GenerateSchemaForClass(typeof(CountryConfiguration));
        //}

    }

}
