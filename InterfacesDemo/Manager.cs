using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    internal class Manager
    {
    }
    interface IWorker
    {
        void Eat();
        void Work();
        void EarnMoney();
    }
    class Robot : IWorker
    {
        public void EarnMoney()
        {
            Console.WriteLine("Robot doesn't earn money");
        }

        public void Eat()
        {
            Console.WriteLine("Robot doesn't eat food");
        }

        public void Work()
        {
            Console.WriteLine("Robot always work");
        }
    }

    class Employee : IWorker
    {
        public void EarnMoney()
        {
            Console.WriteLine("Employee earns little money");
        }

        public void Eat()
        {
            Console.WriteLine("Employee eat food");
        }

        public void Work()
        {
            Console.WriteLine("Employee works hard");
        }
    }

    class Employer : IWorker
    {
        public void EarnMoney()
        {
            Console.WriteLine("Employer earns a lot of money");
        }

        public void Eat()
        {
            Console.WriteLine("Employer eat food");
        }

        public void Work()
        {
            Console.WriteLine("Employer doesn't work");
        }
    }
    class WorkerManager
    {
        public void Eat(IWorker worker)
        {
            worker.Eat();
        }
        public void EarnMoney(IWorker worker)
        {
            worker.EarnMoney();
        }
        public void Work(IWorker worker)
        {
            worker.Work();
        }
    }
}
