using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;


namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyat = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Çilek";
            urun2.Fiyat = 10;
            urun2.Aciklama = "Çilek gibi çilek";


            Urun[] urunler = new Urun[] { urun1, urun2 };
            foreach (Urun urun in urunler)
            {
                Console.WriteLine("Ürün Adi: " + urun.Adi + " " + "Ürün Fiyatı: " + urun.Fiyat + " " + "Ürün Açıklaması: " + urun.Aciklama);
                Console.WriteLine("----------------------------");
            }

            Console.WriteLine("------------------Metotlar--------------------------------");


            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            Console.WriteLine();
            sepetManager.Ekle2("Karpuz ", 80, 100);
            sepetManager.Ekle2("Muz ", 20, 500);





            // C# Dersleri 24: Challenge : Ref Keyword İle Çalışmak Videosu
            //  ------------------------------------------------------------




            int number1 = 20;
            int number2 = 100;

            var result = Add3(out number1, number2);

            Console.WriteLine(result);
            Console.WriteLine(number1);




            static int Add3(out int number1, int number2)
            {
                number1 = 50;
                return number1 + number2;
            }



            Console.WriteLine(Add4(1, 2, 3, 4, 5, 6, 7, 8, 9));
           


            static int Add4(params int[] numbers)
            {
                return numbers.Sum();
            }


            Console.ReadLine();
        }

    }
}
