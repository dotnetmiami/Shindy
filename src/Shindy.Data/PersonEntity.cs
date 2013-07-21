using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shindy.Data
{
    public class PersonEntity
    {
        private IPersonRepository _repository;
        public PersonEntity(IPersonRepository repository)
        {
            _repository = repository;
        }

        public int PersonID { get; internal set; }

        private string _firstName;
        public string FirstName {
            get
            {
                return _firstName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException();
                }
                _firstName = value;
            }
        }

        private string _lastName;
        public string LastName {
            get
            {
                return _lastName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException();
                }
                _lastName = value;
            }
        }

        public string Email { get; set; }

        public string MemberURI { get; set; }

        public string TwitterName {get; set;}

        public string LinkedinURI { get; set; }

        public string Bio { get; set; }

        public string PhotoURI {get; set;}

        public string Zip { get; set; }

        public void Persist()
        {
            if (PersonID <= 0)
            {
                _repository.Create(this);
            }
            else
            {
                _repository.Update(this);
            }
        }
    }
}
