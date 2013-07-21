using System;
using Simple.Data;
using Simple.Data.Ado;

namespace Shindy.Data
{
    public class PersonDataRepository: IPersonRepository
    {
        public void Create(PersonEntity person)
        {
            var db = Database.Opener.OpenConnection(RepositorySettings.ConnectionString);

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

            person.PersonID = simplePerson.Person_ID;
        }

        public PersonEntity Retreive(int personId)
        {
            var db = Database.Opener.OpenConnection(RepositorySettings.ConnectionString);

            var person = db.Persons.FindByPerson_ID(personId);

            PersonEntity dbEntity = null;
            if (person != null)
            {
                dbEntity =  new PersonEntity(this)
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

            return dbEntity;
        }

        public void Update(PersonEntity person)
        {
            if(person == null)
                throw new ArgumentNullException("person");

            if(person.PersonID <= 0)
                throw new InvalidOperationException("Invalid PersonID. ");
            
            var db = Database.Opener.OpenConnection(RepositorySettings.ConnectionString);

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

        public void Delete(PersonEntity person)
        {
            if (person == null)
                throw new ArgumentNullException("person");

            if (person.PersonID <= 0)
                throw new InvalidOperationException("Invalid PersonID. ");

            var db = Database.Opener.OpenConnection(RepositorySettings.ConnectionString);

            db.Persons.DeleteByPerson_ID(person.PersonID);

            person.PersonID = 0;
        }
    }
}
