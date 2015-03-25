using System;
using System.Collections.Generic;

namespace Shindy.Model
{
    public class Location
    {
        public Location()
        {
            Events = new List<Event>();
        }

        public int LocationID { get; set; }
        public string LocationName { get; set; }
        public string LocationURI { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string MapURI { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string LastUpdatedUser { get; set; }
        public virtual ICollection<Event> Events { get; set; }
    }
}
