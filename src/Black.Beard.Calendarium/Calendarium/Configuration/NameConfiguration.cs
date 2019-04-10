using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel;

namespace Bb.Calendarium.Configuration
{
    public class NameConfiguration
    {

        [JsonRequired]
        [Description("Specify a translated name of the current day")]
        public string Name { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonRequired]
        [Description("Specify a language for the translation")]
        public Language Language { get; set; }

    }
}