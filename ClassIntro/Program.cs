using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmeni = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;


            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmeni = "Kerem";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmeni = "Berkay";
            kurs3.IzlenmeOrani = 80;


            Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmeni + " " + kurs1.IzlenmeOrani);
            Console.ReadLine();
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmeni { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}