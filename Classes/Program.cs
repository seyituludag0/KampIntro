using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            customerManager.Add();
            customerManager.Update();
            
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Firstname= "Seyit";
            customer1.LastName = "Uludağ";
            customer1.City = "İstanbul";


            Customer customer2 = new Customer
            {
                Id = 1,
                Firstname = "Eren",
                LastName = "Uludağ",
                City = "İstanbul",
            };

            Console.WriteLine(customer2.Firstname);

            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Customer Added");
        }
        public void Update()
        {
            Console.WriteLine("Customer Updated");
        }
    }
    class ProductManager
    {
        public void Add()
        {
            Console.WriteLine("Product Added");
        }
        public void Update()
        {
            Console.WriteLine("Product Updated");
        }
    }
}
