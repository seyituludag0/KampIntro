using System;
using System.Collections.Generic;
using System.Text;

namespace ReferenceTypes
{
    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
