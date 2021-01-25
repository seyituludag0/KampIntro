using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer{FirstName = "Seyit"},
                new Person{FirstName = "Ali"},
                new Student{FirstName = "Faruk"}
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }


            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Departman { get; set; }
    }
}
