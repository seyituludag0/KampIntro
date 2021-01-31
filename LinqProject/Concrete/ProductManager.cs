using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqProject.Abstract;
using LinqProject.Entities;

namespace LinqProject.Concrete
{
    class ProductManager : IProductDal
    {
        public List<Product> GetProducts(List<Product> products)
        {
            Console.WriteLine("-----------Algoritmik----------");

            foreach (var product in products)
            {
                if (product.UnitPrice > 500 && product.UnitsInStock > 3)
                {
                    Console.WriteLine("Product Name: " + product.ProductName);
                }
            }
            Console.WriteLine("\n" + "-----------Linq----------");

            var result = products.Where(p=>p.UnitPrice>500 && p.UnitsInStock>3);
            foreach (var product in result)
            {
                Console.WriteLine("Product Name: " + product.ProductName + "Unit Price: " + product.UnitPrice + " Stock: " + product.UnitsInStock);
            }


             
            return products;
        }
    }
}
