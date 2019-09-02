using System;
using System.Collections.Generic;
using System.Text;

namespace Democode
{
    public class Person
    {
        public Person(DateTime dateOfBirth)
        {
            DateOfBirth = dateOfBirth;
        }

        public DateTime DateOfBirth { get; set; }

    }
}
