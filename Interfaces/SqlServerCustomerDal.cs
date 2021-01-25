using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class SqlServerCustomerDal:ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Added");
        }

        public void Update()
        {
            Console.WriteLine("Sql Updated");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Deleted");
        }
    }
}
