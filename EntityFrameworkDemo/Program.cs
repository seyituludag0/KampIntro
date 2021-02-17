using System;
using System.Linq;
using EntityFrameworkDemo.Concrete.EntityFramework;

namespace EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetAll();
            GetProductByCategory(2);

            Console.ReadLine();
        }

        private static void GetAll()
        {
            NorthwindContext context = new NorthwindContext();

            foreach (var product in context.Products)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void GetProductByCategory(int categoryId)
        {
            NorthwindContext context = new NorthwindContext();
            var result = context.Products.Where(p => p.CategoryId == categoryId);

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
