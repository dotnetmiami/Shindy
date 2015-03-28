using System;
using System.Collections.Generic;

namespace Shindy.Core.Entities
{
    public class SessionType
    {
        public SessionType()
        {
            Sessions = new List<Session>();
        }

        public int SessionTypeID { get; set; }
        public string SessionTypeName { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string LastUpdatedUser { get; set; }
        public virtual ICollection<Session> Sessions { get; set; }
    }
}
