using System;

namespace Shindy.Model
{
    public class Location
    {
        public int Id { get; set; }
        public string LocationName { get; set; }
        public string LocationUri { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string MapUri { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public string CreatedUser { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string LastUdatedUser { get; set; }
    }
}
