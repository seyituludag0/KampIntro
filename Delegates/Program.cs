using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MyDelegate();
    public delegate void MyDelegate2(string text);
    public delegate int MyDelegate3(int number1, int number2);
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManger customerManger = new CustomerManger();
            //customerManger.SendMessage();
            //customerManger.ShowAllert();

            MyDelegate myDelegate = customerManger.SendMessage;
            myDelegate += customerManger.ShowAlert;
            myDelegate -= customerManger.SendMessage;
            myDelegate();


            MyDelegate2 myDelegate2 = customerManger.SendMessage2;
            myDelegate2 += customerManger.SendMessage2;
            myDelegate2("Hello");


            Matematik matematik = new Matematik();

            MyDelegate3 myDelegate3 = matematik.Topla;
            var result =  myDelegate3(2, 3);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }

    public class CustomerManger
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello");
        }
        public void ShowAlert()
        {
            Console.WriteLine("Be careful!");
        }

        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }
        public void ShowAlert2(string alert)
        {
            Console.WriteLine(alert);
        }   
    }

    public class Matematik
    {
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }
}
