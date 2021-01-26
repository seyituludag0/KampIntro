using System;
using System.Collections.Generic;
using System.Text;
using CoffeeManagementSystem.Entities;

namespace CoffeeManagementSystem.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
