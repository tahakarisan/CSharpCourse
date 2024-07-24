using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WorkerManager workerManager = new WorkerManager();
            workerManager.EarnMoney(new Employee());
            workerManager.EarnMoney(new Employer());
            workerManager.EarnMoney(new Robot());
            //IWorker worker = new Employee();
            //IWorker worker2 = new Employer();
            //IWorker worker3 = new Robot();

            //worker.Eat();
            //worker2.Eat();
            //worker3.Eat(); 
            Console.ReadLine();
        }

    }
}
