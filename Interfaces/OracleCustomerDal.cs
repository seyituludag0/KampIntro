using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class OracleCustomerDal:ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Updated");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted");
        }
    }
}
