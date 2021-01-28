using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager emlakKrediManager = new EmlakKrediManager();
            //emlakKrediManager.Hesapla();

            IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();


            List<ILoggerService> loggers = new List<ILoggerService>()
            {
                new DatabaseLoggerManager() , new SmsLoggerManager()
            };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKrediManager(), loggers);


            List<IKrediManager> krediler = new List<IKrediManager>() { emlakKrediManager, konutKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);


            Console.ReadLine();
        }
    }
}
