using System.Collections.Generic;

namespace Bb.Calendarium.Configuration
{
    public class RegionConfiguration
    {

        public RegionConfiguration()
        {
            Periods = new List<PeriodConfiguration>();
        }

        public string Key { get; set; }

        public List<PeriodConfiguration> Periods { get; set; }
        public string From { get; internal set; }
    }

}
