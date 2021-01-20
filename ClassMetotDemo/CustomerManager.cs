using System;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void GetCustomer(Customer[] customer)
        {
            foreach (Customer customers in customer)
            {
                Console.Write("\n" + "Müşteri Adı Soyadı: " + customers.Name + " " + customers.Surname + " Kredi: " + customers.Credit + "\n");
            }
        }
        public void Add(Customer customer)
        {
            Console.Write( "\n" + "Müşteri Adı Soyadı: " + customer.Name + " " + customer.Surname + " Kredi: " + customer.Credit + "\n" + customer.Id + " Id' li müşteri eklendi." + "\n");
        }

        public void Delete(Customer customer)
        {
            Console.Write("\n" + customer.Id + " Id' li müşteri silindi." + "\n");
        }

    }
}


