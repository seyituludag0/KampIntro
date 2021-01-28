using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Seyit
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Seyit";
            musteri1.Soyadi = "Uludağ";
            musteri1.TcNo = "1234565";

            //Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "123456";
            musteri2.VergiNo = "12352254";
            musteri2.SirketAdi = "Kodlama.io";


            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);


            Console.ReadLine();
        }
    }
}
