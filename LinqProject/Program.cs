using System;
using System.Collections.Generic;
using System.Linq;
using LinqProject.Concrete;
using LinqProject.Entities;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId = 1, CategoryName = "Bilgisayar"},
                new Category{CategoryId = 2, CategoryName = "Telefon"}
            };

            List<Product> products = new List<Product>
            {
                new Product{ProductId = 1, ProductName = "Acer Laptop", CategoryId = 1, QuantityPerUnit = "8 GB RAM" , UnitPrice = 10000,UnitsInStock = 1500},
                new Product{ProductId = 2, ProductName = "Asus Laptop", CategoryId = 1, QuantityPerUnit = "16 GB RAM" ,UnitPrice = 18000,UnitsInStock = 1500 },
                new Product{ProductId = 3, ProductName = "Hp Laptop", CategoryId = 2, QuantityPerUnit = "6 GB RAM" ,UnitPrice = 18000,UnitsInStock = 5900 },
                new Product{ProductId = 4, ProductName = "Xiaomi Note 8", CategoryId = 2, QuantityPerUnit = "3 GB RAM" , UnitPrice = 2000,UnitsInStock = 10000},
                new Product{ProductId = 5, ProductName = "iPhone 12", CategoryId = 1, QuantityPerUnit = "16 GB RAM" , UnitPrice = 15000,UnitsInStock = 2},
            };
            ProductManager productManager = new ProductManager();
            productManager.GetProducts(products);

            //var result = products.Any(p => p.ProductName == "iPhone 12");
            //Console.WriteLine(result);

            //var result1 = products.Find(p => p.ProductId == 1);
            //Console.WriteLine(result1.ProductName);

            //var result2 = products.FindAll(p => p.ProductName.Contains("book"));
            //Console.WriteLine(result2.Count);
            // Yukardan aşağı
            //var result3 = products.Where(p=>p.ProductName.Contains("top")).OrderByDescending(p=>p.UnitPrice
            //).ThenByDescending(p=>p.ProductName);
            //foreach (var product in result3)
            //{
            //    Console.WriteLine(product.ProductName + "\t" + product.UnitPrice);
            //}



            //var result4 = from p in products
            //              where p.UnitPrice > 6000
            //              //ascending= en azdan en çoğa göre          //descending= en çoktan en aza göre
            //              orderby p.UnitPrice descending, p.ProductName ascending
            //              select new ProductDto { ProductId = p.ProductId, ProductName = p.ProductName, UnitPrice = p.UnitPrice };

            //foreach (var product in result4)
            //{
            //    Console.WriteLine(product.ProductName + "\t" + product.UnitPrice);
            //}

            var result5 = from p in products
                join c in categories
                    on p.CategoryId equals c.CategoryId
                    where p.UnitPrice>5000
                orderby p.UnitPrice descending 
                select new ProductDto {ProductId = p.ProductId, ProductName = p.ProductName, CategoryName = c.CategoryName, UnitPrice = p.UnitPrice};

            foreach (var productDto in result5)
            {
                //Console.WriteLine("Product Id: " + productDto.ProductId + " Product Name: " + productDto.ProductName + " CategoryName: " + productDto.CategoryName + " Unit Price: " + productDto.UnitPrice);
                Console.WriteLine("{0} --- {1}---- {2}", productDto.ProductName, productDto.CategoryName, productDto.UnitPrice);
            }

            Console.ReadLine();
        }
    }
}
