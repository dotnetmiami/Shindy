using System;

namespace Shindy.Core.Entities
{
    public class EventSponsor
    {
        public int EventSponsorID { get; set; }
        public int EventID { get; set; }
        public int SponsorID { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedUser { get; set; }
        public virtual Event Event { get; set; }
        public virtual Sponsor Sponsor { get; set; }
    }
}
