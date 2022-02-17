using System;

namespace Web_1001_DB_Models
{
    public class Podcast
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Uri Url { get; set; }

        public string Description { get; set; }
    }
}
