using System;
using System.Collections.Generic;
using System.Text;
using CoffeeManagementSystem.Abstract;
using CoffeeManagementSystem.Entities;

namespace CoffeeManagementSystem.Concrete
{
    public class CustomerCheckManager:ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return false;
        }
    }
}
