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
            languages.Add("C#");
            languages.Add("Java");
            languages.Add("Javascript");
            languages.Add("Php");
            languages.Add("Python");
            languages.Add("Swift");
            Console.WriteLine(languages.Count);

            Console.ReadLine();
        }
    }
}
