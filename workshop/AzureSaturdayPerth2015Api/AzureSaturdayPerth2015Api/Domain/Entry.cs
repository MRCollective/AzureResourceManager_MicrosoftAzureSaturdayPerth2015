namespace AzureSaturdayPerth2015Api.Domain
{
    public class Entry
    {
        public string Id { get; private set; }

        protected Entry() {}

        public Entry(string id)
        {
            Id = id;
        }
    }
}