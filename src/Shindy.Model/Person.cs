using System;

namespace Shindy.Model
{
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string MemberUri { get; set; }
        public string Twitter { get; set; }
        public string LinkedIn { get; set; }
        public string Bio { get; set; }
        public string PhotoUri { get; set; }
        public string Zip { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public string LastUpdatedUser { get; set; }
        public DateTime LastUpdatedDate { get; set; }
    }
}