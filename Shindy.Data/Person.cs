﻿using Simple.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simple.Data.Ado;
using System.Dynamic;
using System.Configuration;

namespace Shindy.Data
{
    public class Person
    {
        internal readonly static string ConnectionString = ConfigurationManager.ConnectionStrings["Shindy.Data"].ToString();

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public int PersonID { get; private set; }

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
                Create();
            }
            else
            {
                Update();
            }            
        }

        public static Person Load(int personId)
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Create()
        {
            var db = Database.Opener.OpenConnection(ConnectionString);

            var person = db.Persons.Insert(
                First_Name: FirstName,
                Last_Name: LastName,
                EMail: Email,
                Member_URI: MemberURI,
                Twitter_Name: TwitterName,
                Linkedin_URI: LinkedinURI,
                Bio: Bio,
                Photo_URI: PhotoURI,
                Zip: Zip
                );

            PersonID = person.Person_ID;
        }
    }
}
