using System;

namespace Shindy.Model
{
    public class OrgEvent
    {
        public int OrgEventID { get; set; }
        public int OrgID { get; set; }
        public int EventID { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string LastUpdatedUser { get; set; }
        public virtual Event Event { get; set; }
        public virtual Organization Organization { get; set; }
    }
}
