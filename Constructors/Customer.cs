using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    class Customer
    {
        public Customer()
        {

        }
        public Customer(int id, string firstName, string surName, string city)
        {
            Id = id;
            FirstName = firstName;
            SurName = surName;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string City { get; set; }
        
    }
}
