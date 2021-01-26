using CoffeeManagementSystem.Abstract;
using System;
using CoffeeManagementSystem.Adapters;
using CoffeeManagementSystem.Concrete;
using CoffeeManagementSystem.Entities;

namespace CoffeeManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer
            {
                Id = 1,
                FirstName = "Seyit",
                LastName = "ULUDAĞ",
                DateOfBirth = new DateTime(2001, 07, 03),
                NationalityId = "14563325589"
            });

            Console.ReadLine();
        }

    }
}
