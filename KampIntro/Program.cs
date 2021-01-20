using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoriler";

            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;

            double dolarDun = 7.85;
            double dolarBugun = 7.85;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }

            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }

            else
            {
                Console.WriteLine("Değişmedi");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarlar Butonu");
            }

            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);




            Console.ReadLine();
        }
    }
}