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
            Person person = new Person("Donald", "Duck");
            person.Email = "donald.duck@disney.com";

            //Act
            person.Persist();

            //Assert
            Assert.True(person.PersonID > 0);
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
            test.CreatePerson();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
