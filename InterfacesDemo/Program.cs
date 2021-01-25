using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(), 
                new Robot(), 
                new Worker()
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[2]
            {
                new Manager(), 
                new Worker()
            };

            foreach (var eat in eats)
            {
                eat.Eat();
            }


            Console.ReadLine();
        }
    }

    interface IWorker
    {
        void Work();
    }
    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }

    class Manager:IWorker,IEat,ISalary
    {
        public void Work()
        {
            Console.WriteLine("Manager work");
        }

        public void Eat()
        {
            Console.WriteLine("Manager Eat");
        }

        public void GetSalary()
        {
            Console.WriteLine("Manager Get Salary");
        }
    }

    class Worker:IWorker,IEat,ISalary
    {
        public void Work()
        {
            Console.WriteLine("Worker work");
        }

        public void Eat()
        {
            Console.WriteLine("Worker Eat");
        }

        public void GetSalary()
        {
            Console.WriteLine("Worker Get Salary");
        }
    }

    class Robot:IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot Work");
        }
    }
}
