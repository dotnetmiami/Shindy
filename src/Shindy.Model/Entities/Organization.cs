using System;
using System.Collections.Generic;

namespace Shindy.Core.Entities
{
    public class Organization
    {
        public Organization()
        {
            Members = new List<Member>();
            OrgEvents = new List<OrgEvent>();
        }

        public int OrgID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string OrgUri { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedUser { get; set; }
        public virtual ICollection<Member> Members { get; set; }
        public virtual ICollection<OrgEvent> OrgEvents { get; set; }
    }
}
