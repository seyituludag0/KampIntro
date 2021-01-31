using System;
using System.Collections.Generic;
using System.Text;
using LinqProject.Entities;

namespace LinqProject.Abstract
{
    interface IProductDal
    {
        List<Product> GetProducts(List<Product> products);
    }
}
