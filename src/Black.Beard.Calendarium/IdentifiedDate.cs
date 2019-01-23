using Bb.Calendarium.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Bb.Calendarium
{

    public class IdentifiedDate
    {

        public IdentifiedDate()
        {
            Events = new List<EventDate>();
        }

        public DateTime Date { get; internal set; }

        public List<EventDate> Events { get; }

        public override string ToString()
        {
            string label = Date.ToString("d", CultureInfo.CurrentCulture);

            if (Events.Count > 0)
                label += " : " + Events[0].Name;

            return label;
        }

        public IdentifiedDate Clone()
        {

            var clone = new IdentifiedDate()
            {
                Date = this.Date,
            };

            clone.Events.AddRange(this.Events.Select(c => c.Clone()));

            return clone;
        }

        internal void Merge(IdentifiedDate value)
        {

            var dic = this.Events.ToDictionary(c => (c.Date, c.Country, c.Region, c.Name));

            foreach (EventDate edate in value.Events)
            {
                var k = (edate.Date, edate.Country, edate.Region, edate.Name);
                if (!dic.ContainsKey(k))
                {
                    var cc = edate.Clone();
                    this.Events.Add(cc);
                    dic.Add(k, cc);
                }

            }

        }

    }

    public class EventDate
    {

        public EventDate()
        {
            Translations = new List<NameConfiguration>();
        }

        public DateTime Date { get; internal set; }

        public DateTime Observed { get; internal set; }

        public DateTime DateEnd { get; internal set; }

        public bool Free { get; internal set; }

        public string Name { get; internal set; }

        public List<NameConfiguration> Translations { get; }

        public string Culture { get; internal set; }

        public Country Country { get; internal set; }

        public string Region { get; internal set; }
        public Calendar Calendar { get; internal set; }

        public override string ToString()
        {
            return Date.ToString("d", CultureInfo.GetCultureInfo(Culture));
        }

        internal EventDate Clone()
        {

            var e = new EventDate()
            {
                Calendar = this.Calendar,
                Country = this.Country,
                Culture = this.Culture,
                Date = this.Date,
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
