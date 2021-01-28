using System;
using GameProject.Concrete;
using GameProject.Entities;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer
            {
                Id = 1, FirstName = "SEYIT", LastName = "ULUDAĞ", IdentityNumber = 12345678910, BirthYear = 2001
            };

            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(gamer);

            Console.ReadLine();
        }
    }
}
