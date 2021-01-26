using CoffeeManagementSystem.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using CoffeeManagementSystem.Entities;

namespace CoffeeManagementSystem.Concrete
{
    public class NeroCustomerManager:BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public NeroCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                Console.WriteLine("Not a valid person");
                //throw new Exception("Not a valid person");
            }
        }
    }
}
