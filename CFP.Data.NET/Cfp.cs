using System;

namespace CFP.Data.NET
{
    public class Cfp
    {
        /// <summary>Unique ID of the event this CFP is for.</summary>
        public Guid EventId { get; set; }

        /// <summary>Url of the CFP</summary>
        public Uri Url { get; set; }
    }
}
