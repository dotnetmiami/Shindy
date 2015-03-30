using System;

namespace Shindy.Core.Entities
{
    public class Giveaway
    {
        public int GiveawayID { get; set; }
        public string GiveawayName { get; set; }
        public string Description { get; set; }
        public int? EventID { get; set; }
        public int? SponsorID { get; set; }
        public int? PersonID { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string LastUpdatedUser { get; set; }
        public virtual Event Event { get; set; }
        public virtual Person Person { get; set; }
        public virtual Sponsor Sponsor { get; set; }
    }
}
