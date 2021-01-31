using System;
using System.Collections.Generic;
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
                new Product{ProductId = 1, ProductName = "Hp Work Notebook", CategoryId = 1, QuantityPerUnit = "8 GB RAM" ,UnitsInStock = 1500, UnitPrice = 500},
                new Product{ProductId = 2, ProductName = "Hp Game Notebook", CategoryId = 1, QuantityPerUnit = "16 GB RAM" ,UnitsInStock = 1500, UnitPrice = 15000},
                new Product{ProductId = 3, ProductName = "Xiaomi Note 9 Pro", CategoryId = 2, QuantityPerUnit = "6 GB RAM" ,UnitsInStock = 5900, UnitPrice = 3000},
                new Product{ProductId = 4, ProductName = "Xiaomi Note 8", CategoryId = 2, QuantityPerUnit = "3 GB RAM" ,UnitsInStock = 10000, UnitPrice = 2000},
                new Product{ProductId = 5, ProductName = "iPhone 12", CategoryId = 1, QuantityPerUnit = "16 GB RAM" ,UnitsInStock = 2, UnitPrice = 15000},
            };

            ProductManager productManager = new ProductManager();
            productManager.GetProducts(products);

            Console.ReadLine();
        }
    }
}
