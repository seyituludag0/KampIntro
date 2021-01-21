using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MyList<string> isimler = new MyList<string>();
            isimler.Add("Seyit");


            Console.ReadLine();
        }
    }
}
