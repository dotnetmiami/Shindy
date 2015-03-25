using System;
using System.Collections.Generic;

namespace Shindy.Model
{
    public class Person
    {
        public Person()
        {
            Attendees = new List<Attendee>();
            Giveaways = new List<Giveaway>();
            Members = new List<Member>();
            Speakers = new List<Speaker>();
        }

        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EMail { get; set; }
        public string MemberURI { get; set; }
        public string TwitterName { get; set; }
        public string LinkedinURI { get; set; }
        public string Bio { get; set; }
        public string PhotoURI { get; set; }
        public string Zip { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string LastUpdatedUser { get; set; }
        public virtual ICollection<Attendee> Attendees { get; set; }
        public virtual ICollection<Giveaway> Giveaways { get; set; }
        public virtual ICollection<Member> Members { get; set; }
        public virtual ICollection<Speaker> Speakers { get; set; }
    }
}
