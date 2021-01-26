using CoffeeManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeManagementSystem.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
