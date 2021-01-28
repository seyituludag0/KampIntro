using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabaseLoggerManager:ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına kaydedildi");
        }
    }
}
