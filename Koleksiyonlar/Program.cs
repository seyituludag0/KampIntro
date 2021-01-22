using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Engin","Murat","Kerem","Halil"};
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);



            List<string> languages = new List<string>{ "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(languages[0]);
            Console.WriteLine(languages[1]);
            Console.WriteLine(languages[2]);
            Console.WriteLine(languages[3]);
            languages.Add("İlker");
            Console.WriteLine(languages[4]);
            Console.WriteLine(languages[0]);
            Console.ReadLine();

        }
    }
}
