using System;

namespace Shindy.Core.Entities
{
    public class EventSession
    {
        public int EventSessionID { get; set; }
        public int EventID { get; set; }
        public int SessionID { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedUser { get; set; }
        public virtual Event Event { get; set; }
        public virtual Session Session { get; set; }
    }
}
