using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shindy.Data
{
    public interface IPersonRepository
    {
        PersonEntity Retreive(int id);

        void Create(PersonEntity person);

        void Update(PersonEntity person);

        void Delete(PersonEntity person);
    }
}
