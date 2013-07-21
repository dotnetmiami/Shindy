using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shindy.Data
{
    public class EventEntity
    {
        public EventEntity()
        {

        }

        public EventEntity(LocationEntity location)
        {
            Location = location;
        }

        public int EventID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public LocationEntity Location { get; set; }

        public string RegistrationURI { get; set; }

        public void AddSpeaker(PersonEntity person)
        {
            throw new NotImplementedException();
        }

        public void RemoveSpeaker(PersonEntity person)
        {
            throw new NotImplementedException();
        }

        public void ChangeSpeaker(PersonEntity person)
        {
            throw new NotImplementedException();
        }
    }
}
