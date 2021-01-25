using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
