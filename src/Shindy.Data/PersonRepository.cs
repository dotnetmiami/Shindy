using System;
using System.Collections.Generic;
using Shindy.Model;

namespace Shindy.Data
{
    public class PersonRepository : IRepository<Person>
    {
        public void Update(Person entity)
        {
            throw new NotImplementedException();
        }

        public Person GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Delete(Person entity)
        {
            throw new NotImplementedException();
        }
    }
}
