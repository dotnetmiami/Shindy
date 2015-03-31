using System;

namespace Shindy.Core.Entities
{
    public class Member
    {
        public int MemberID { get; set; }
        public int OrgID { get; set; }
        public int PersonID { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedUser { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual Person Person { get; set; }
    }
}
