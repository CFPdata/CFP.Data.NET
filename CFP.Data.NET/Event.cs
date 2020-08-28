using CFP.Data.NET.Enums;

using System;

namespace CFP.Data.NET
{
    public class Event
    {
        /// <summary>Unique ID identifying the event.</summary>
        public Guid Id { get; set; }

        /// <summary>Name of the event</summary>
        public string Name { get; set; }

        /// <summary>Description of the event</summary>
        public string Description { get; set; }

        /// <summary>Start date of the event in <see cref="DateTimeOffset"/>.</summary>
        public DateTimeOffset StartDate { get; set; }

        /// <summary>End date of the event in <see cref="DateTimeOffset"/>.</summary>
        public DateTimeOffset EndDate { get; set; }

        /// <summary>Time zone of the event.</summary>
        public TimeZoneInfo TimeZone { get; set; }

        /// <summary>Type of the event.</summary>
        public EventType Type { get; set; }

        /// <summary>Uri of the event.</summary>
        public Uri Url { get; set; }
    }
}
