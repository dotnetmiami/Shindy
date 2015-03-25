using System;
using System.Collections.Generic;

namespace Shindy.Model
{
    public class Organization
    {
        public Organization()
        {
            Members = new List<Member>();
            OrgEvents = new List<OrgEvent>();
        }

        public int OrgID { get; set; }
        public string OrgName { get; set; }
        public string OrgDescription { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string LastUpdatedUser { get; set; }
        public virtual ICollection<Member> Members { get; set; }
        public virtual ICollection<OrgEvent> OrgEvents { get; set; }
    }
}
