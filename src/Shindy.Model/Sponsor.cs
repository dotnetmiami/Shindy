using System;
using System.Collections.Generic;

namespace Shindy.Model
{
    public class Sponsor
    {
        public Sponsor()
        {
            EventSponsors = new List<EventSponsor>();
            Giveaways = new List<Giveaway>();
        }

        public int SponsorID { get; set; }
        public string SponsorName { get; set; }
        public string SponsorURI { get; set; }
        public string ImageURI { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string LastUpdatedUser { get; set; }
        public virtual ICollection<EventSponsor> EventSponsors { get; set; }
        public virtual ICollection<Giveaway> Giveaways { get; set; }
    }
}
