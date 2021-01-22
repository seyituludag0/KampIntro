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
            isimler.Add("Ezgi");
            isimler.Add("Burak");
            Console.WriteLine(isimler.Count);

            MyList<string> languages = new MyList<string>();
            languages.Add("Seyit");
            languages.Add("Ezgi");
            languages.Add("Burak");
            languages.Add("Emir");
            languages.Add("Taha");
            languages.Add("Ömer");
            Console.WriteLine(languages.Count);

            Console.ReadLine();
        }
    }
}
