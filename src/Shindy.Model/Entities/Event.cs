using System;
using System.Collections.Generic;

namespace Shindy.Core.Entities
{
    public class Event
    {
        public Event()
        {
            Attendees = new List<Attendee>();
            EventSessions = new List<EventSession>();
            EventSponsors = new List<EventSponsor>();
            Giveaways = new List<Giveaway>();
            OrgEvents = new List<OrgEvent>();
        }

        public int EventID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? LocationID { get; set; }
        public string RegistrationURI { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string LastUpdatedUser { get; set; }
        public virtual ICollection<Attendee> Attendees { get; set; }
        public virtual ICollection<EventSession> EventSessions { get; set; }
        public virtual ICollection<EventSponsor> EventSponsors { get; set; }
        public virtual ICollection<Giveaway> Giveaways { get; set; }
        public virtual ICollection<OrgEvent> OrgEvents { get; set; }
        public virtual Location Location { get; set; }
    }
}
