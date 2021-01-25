using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Customer
    {
        public int Id { get; set; }
        public string _firstName;

        public string Firstname
        {
            get { return "Mrs." +_firstName;}
            set { _firstName = value; }
        }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
