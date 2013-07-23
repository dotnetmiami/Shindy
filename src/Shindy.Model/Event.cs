using System;

namespace Shindy.Model
{
    public class Event
    {
        public int EventId { get; set; }
        public string Title { get; set; }
        public string Descripition { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? LocationId { get; set; }
        public string RegistrationUri { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string LastUpdatedUser { get; set; }
    }
}
