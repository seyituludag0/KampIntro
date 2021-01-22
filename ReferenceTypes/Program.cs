using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            //int sayi1 = 10;
            //int sayi2 = 20;

            //sayi1 = sayi2;
            //sayi2 = 100;

            //Console.WriteLine("Sayi1: " + sayi1);


            Person person1 = new Person(); // 101
            Person person2 = new Person(); // 102
            person1.FirstName = "Seyit";
            person2 = person1;
            person1.FirstName = "Emre";

            //Console.WriteLine(person2.FirstName);


            Customer customer = new Customer();
            customer.FirstName = "Miya";
            customer.CreditCardNumber = "13456789";

            Employee employee = new Employee();
            employee.FirstName = "Veli";


            Person person3 = customer;
            customer.FirstName = "Ömer";

            //Console.WriteLine(((Customer) person3).CreditCardNumber);

            //Console.WriteLine(person3.FirstName);

            PersonManager personManager = new PersonManager();
            personManager.Add(employee);

            Console.ReadLine();
        }
    }
}
