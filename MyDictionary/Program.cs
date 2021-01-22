using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello MyDictionary!" + "\n");

            MyDictionary<int,string> languages = new MyDictionary<int, string>();
            languages.Add(1,"C#");
            languages.Add(2,"Java");
            languages.Add(3,"Python");
            languages.Add(4, "Javascript");

            foreach (var key in languages.Keys)
            {
                Console.WriteLine("Key: " + key);
            }

            foreach (var value in languages.Values)
            {
                Console.WriteLine("Value: " + value);
            }


            Console.ReadLine();
        }
    }
}
