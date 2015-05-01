using System;

namespace AzureSaturdayPerth2015Api.Domain
{
    public class Entry
    {
        public string Id { get; private set; }
        public DateTimeOffset DateAdded { get; private set; }

        protected Entry() {}

        public Entry(string id)
        {
            Id = id;
            DateAdded = DateTimeOffset.UtcNow;
        }
    }
}