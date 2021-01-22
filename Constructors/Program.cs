using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() {Id = 1, FirstName = "Seyit", SurName = "Uludağ", City = "İstanbul"};

            Customer customer3 = new Customer();
            customer3.FirstName = "Engin";
            customer3.SurName = "Demiroğ";

            Customer customer2 = new Customer(2, "Ezgi", "Candemir", "İstanbul");
            Console.WriteLine(customer2.FirstName);










            Console.ReadLine();
        }
    }
}
