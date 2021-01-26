using System;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer
            {
                Id = 1,
                FirstName = "Seyit",
                LastName = "Uludağ",
                DateOfBirth = new DateTime(2001, 07, 03),
                NationalityId = "25638845200"
            });


            Console.ReadLine();
        }
    }
}
