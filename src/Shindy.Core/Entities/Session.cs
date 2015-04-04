using System;
using System.Collections.Generic;

namespace Shindy.Core.Entities
{
    public class Session
    {
        public Session()
        {
            EventSessions = new List<EventSession>();
            Speakers = new List<Speaker>();
        }

        public int SessionID { get; set; }
        public string Title { get; set; }
        public string Abstract { get; set; }
        public int SessionTypeID { get; set; }
        public string DemoUri { get; set; }
        public string PresentationUri { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedUser { get; set; }
        public virtual ICollection<EventSession> EventSessions { get; set; }
        public virtual ICollection<Speaker> Speakers { get; set; }
        public virtual SessionType SessionType { get; set; }
    }
}
