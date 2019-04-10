using Bb.Calendarium.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Bb.Calendarium
{
    public class EventDate
    {

        public EventDate()
        {
            Translations = new List<NameConfiguration>();
        }

        public Date Date { get; internal set; }

        public Date Observed { get; internal set; }

        public Date DateEnd { get; internal set; }

        public bool Free { get; internal set; }

        public string Name { get; internal set; }

        public List<NameConfiguration> Translations { get; }

        public string Culture { get; internal set; }

        public string Country { get; internal set; }

        public string Region { get; internal set; }

        public Calendar CalendarUsedToBuild { get; internal set; }
        
        public override string ToString()
        {
            return Date.ToString("d", CultureInfo.GetCultureInfo(Culture));
        }

        internal EventDate Clone()
        {

            var e = new EventDate()
            {
                CalendarUsedToBuild = this.CalendarUsedToBuild,
                Country = this.Country,
                Culture = this.Culture,
                Date = (Date)this.Date.Clone(),
                Free = this.Free,
                Name = this.Name,
                Region = this.Region,
                Observed = this.Observed,
            };

            e.Translations.AddRange(this.Translations);
            return e;

        }

    }

}
