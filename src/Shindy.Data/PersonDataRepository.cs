using Simple.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;
using System.Configuration;
using Simple.Data.Ado;

namespace Shindy.Data
{
    public class PersonDataRepository: IPersonRepository
    {
        internal readonly static string ConnectionString = ConfigurationManager.ConnectionStrings["Shindy.Data"].ToString();

        public PersonEntity Load(int personId)
        {
            var db = Database.Opener.OpenConnection(ConnectionString);

            var person = db.Persons.FindByPerson_ID(personId);

            return new PersonEntity(this)
            {
                FirstName = person.First_Name,
                LastName = person.Last_Name,
                PersonID = person.Person_ID,
                Email = person.EMail,
                MemberURI = person.Member_URI,
                TwitterName = person.Twitter_Name,
                LinkedinURI = person.Linkedin_URI,
                Bio = person.Bio,
                PhotoURI = person.Photo_URI,
                Zip = person.Zip
            };
        }

        public void Update(PersonEntity person)
        {
            var db = Database.Opener.OpenConnection(ConnectionString);

            db.Persons.UpdateByPerson_ID(
                Person_ID: person.PersonID,
                First_Name: person.FirstName,
                Last_Name: person.LastName,
                EMail: person.Email,
                Member_URI: person.MemberURI,
                Twitter_Name: person.TwitterName,
                Linkedin_URI: person.LinkedinURI,
                Bio: person.Bio,
                Photo_URI: person.PhotoURI,
                Zip: person.Zip
            );
        }

        public int Create(PersonEntity person)
        {
            var db = Database.Opener.OpenConnection(ConnectionString);

            var simplePerson = db.Persons.Insert(
                First_Name: person.FirstName,
                Last_Name: person.LastName,
                EMail: person.Email,
                Member_URI: person.MemberURI,
                Twitter_Name: person.TwitterName,
                Linkedin_URI: person.LinkedinURI,
                Bio: person.Bio,
                Photo_URI: person.PhotoURI,
                Zip: person.Zip
                );

            return simplePerson.Person_ID;
        }
    }
}
