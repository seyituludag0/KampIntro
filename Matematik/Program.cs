using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Math Operation!");

            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(1, 99);

            Console.ReadLine();
        }
    }
}