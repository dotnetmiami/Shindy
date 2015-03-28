using System;

namespace Shindy.Core.Entities
{
    public class Attendee
    {
        public int AttendeeID { get; set; }
        public int EventID { get; set; }
        public int PersonID { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string LastUpdatedUser { get; set; }
        public virtual Event Event { get; set; }
        public virtual Person Person { get; set; }
    }
}
