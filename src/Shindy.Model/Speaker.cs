using System;

namespace Shindy.Model
{
    public class Speaker
    {
        public int SessionPersonID { get; set; }
        public int SessionID { get; set; }
        public int PersonID { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string LastUpdatedUser { get; set; }
        public virtual Person Person { get; set; }
        public virtual Session Session { get; set; }
    }
}
