using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    public class SmsLoggerManager:ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("SMS yollandı");
        }
    }
}
