using System;
using System.Collections.Generic;
using System.Text;

namespace MyCSharp
{
    public class Person
    {
        string firstName;
        string lastName;
        DateTime birthDate;
        string country;

        public Person()
        {
            firstName = "Unknown";
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public DateTime DateOfBirth { get; set; }
        public string Country { get; set; }


    }
}
