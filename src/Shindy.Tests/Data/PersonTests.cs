using Shindy.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Shindy.Tests.Data
{
    public class PersonTests
    {
        [Fact]
        public void CreatePerson()
        {
            //Arrange
            IPersonRepository repository = new PersonDataRepository();
            PersonEntity person = new PersonEntity(repository);
            person.FirstName = "Donald";
            person.LastName = "Duck";
            person.Email = "donald.duck@disney.com";

            //Act
            repository.Create(person);

            //Assert
            Assert.True(person.PersonID > 0);
        }

        [Fact]
        public void RetreivePerson()
        {
            //Arrange
            IPersonRepository repository = new PersonDataRepository();

            //Act
            PersonEntity person = repository.Retreive(100);

            //Assert
            Assert.True(person != null);
        }

        [Fact]
        public void UpdatePerson()
        {
            //Arrange
            IPersonRepository repository = new PersonDataRepository();
            PersonEntity person = repository.Retreive(100);

            person.Email = "patrick.timothee@gmail.com";

            //Act
            repository.Update(person);

            //Assert
            Assert.True(person.PersonID > 0);
        }

        [Fact]
        public void DeletePerson()
        {
            //Arrange
            IPersonRepository repository = new PersonDataRepository();
            PersonEntity person = new PersonEntity(repository);
            person.FirstName = "Delete";
            person.LastName = "Me";
            person.Email = "delete.me@gone.com";

            //Act
            repository.Create(person);
            repository.Delete(person);

            //Assert
            Assert.True(person.PersonID <= 0);
        }
    }

    //Please excuse my ignorance. I have never used Xunit before
    //and do not know how to run this "fact". I switched the project type
    //to console and use the below to test my code (Patrick)
    public class Program
    {
        public static void Main(string[] args)
        {
            PersonTests test = new PersonTests();
            //test.CreatePerson();
            //test.RetreivePerson();
            //test.UpdatePerson();
            //test.DeletePerson();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
