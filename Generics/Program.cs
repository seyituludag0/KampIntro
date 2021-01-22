using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {


            MyList<int> sayilar = new MyList<int>();
            sayilar.Add(1);
            sayilar.Add(2);
            sayilar.Add(3);
            sayilar.Add(4);
            sayilar.Add(5);
            sayilar.Add(6);
            sayilar.Add(7);
            sayilar.Add(8);
            sayilar.Add(9);
            sayilar.Add(10);

            Console.WriteLine("Sayilar1[] Count: " + sayilar.Count);
























            //List<string> sehirler = new List<string>();
            //sehirler.Add("İstanbul");
            //sehirler.Add("İstanbul");
            //sehirler.Add("İstanbul");
            //sehirler.Add("İstanbul");
            //sehirler.Add("İstanbul");
            //sehirler.Add("İstanbul");
            //Console.WriteLine(sehirler.Count);


            //MyList<string> sehirler2 = new MyList<string>();
            //sehirler2.Add("Ankara");
            //sehirler2.Add("Ankara");
            //sehirler2.Add("Ankara");
            //sehirler2.Add("Ankara");
            //sehirler2.Add("Ankara");
            //Console.WriteLine(sehirler2.Count);


            //Dictionary<int,string> diller = new Dictionary<int, string>();
            //diller.Add(1,"C#");
            //diller.Add(2, "Java");
            //diller.Add(3, "Python");
            //diller.Add(4, "Javascript");
            //diller.Add(5, "Php");

            //Console.WriteLine(diller[2]);


            Console.ReadLine();
        }
    }
}
