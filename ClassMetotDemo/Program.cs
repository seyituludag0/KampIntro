using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------Bankamıza Hoşgeldiniz---------------");
            anaMenu:
            Console.WriteLine("\n" + "Müşteri eklemek için 1'e basın" + "\n" + "Müşteri silmek için 2'ye basın" + "\n" + "Mevcut müşterileri listelemek için 3'e basın" + "\n" + "Çıkmak için 0'a basın");




            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Seyit";
            customer1.Surname = "Uludağ";
            customer1.Credit = 50000;

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Burak";
            customer2.Surname = "Tağıl";
            customer2.Credit = 100000;

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Name = "Hakan";
            customer3.Surname = "Bulut";
            customer3.Credit = 5000;

            Customer[] customers = new Customer[]
            {
                customer1,customer2,customer3
            };

            CustomerManager customerManager = new CustomerManager();

            int operation = Convert.ToInt32(Console.ReadLine());

            if (operation == 1)
            {
                customerManager.Add(customer1);
                customerManager.Add(customer2);
                customerManager.Add(customer3);
                Console.WriteLine("\n" + "Ana menüye dönmek için 9'u tuşlayınız.");
                int menuCevap = Convert.ToInt32(Console.ReadLine());
                if (menuCevap == 9)
                {
                    Console.Clear();
                    goto anaMenu;
                }
            }

            if (operation == 2)
            {
                customerManager.Delete(customer1);
                customerManager.Delete(customer2);
                customerManager.Delete(customer3);
                Console.WriteLine("\n" + "Ana menüye dönmek için 9'u tuşlayınız.");
                int menuCevap = Convert.ToInt32(Console.ReadLine());
                if (menuCevap == 9)
                {
                    Console.Clear();
                    goto anaMenu;
                }
            }

            if (operation == 3)
            {
                customerManager.GetCustomer(customers);
                Console.WriteLine("\n" + "Ana menüye dönmek için 9'u tuşlayınız.");
                int menuCevap = Convert.ToInt32(Console.ReadLine());
                if (menuCevap == 9)
                {
                    Console.Clear();
                    goto anaMenu;
                }
            }

            else if (operation > 3)
            {
                Console.WriteLine("GEÇERSİZ TUŞLAMA!!!");
            }

            else if (operation == 0)
            {
                Environment.Exit(0);
            }



            Console.ReadLine();
        }
    }
}