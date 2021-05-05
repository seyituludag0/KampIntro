using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Events.Entities;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Product hardDisk = new Product(50);
            hardDisk.Name = "Hard Disk";

            Product gsm = new Product(50);
            hardDisk.Name = "GSM";
            hardDisk.StockControlEvent += HardDisk_StockControlEvent;

            for (int i = 0; i < 10; i++)
            {
                hardDisk.Sell(10);
                gsm.Sell(10);
                Console.ReadLine();
            }
            



            Console.ReadLine();
        }

        private static void HardDisk_StockControlEvent()
        {
            Console.WriteLine("Gsm about to finish");
        }
    }
    

}
