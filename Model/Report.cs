using System;

namespace News_Web_API.Model
{
    public class Report
    {
        public int Id { get; set; }

        public string NewsHeadline { get; set; }

        public string Detail { get; set; }

        public DateTime Published { get; set; }

    }
}
