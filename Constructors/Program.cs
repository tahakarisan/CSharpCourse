using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(30);
            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());
            employeeManager.Add();
            customerManager.List();
            Console.ReadLine();
        }

        class CustomerManager
        {
            private int _count; 
            public CustomerManager(int count)
            {
                    _count = count;
            }
            public void List()
            {
                Console.WriteLine("Listed {0} items ",_count);
            }
        }
        interface ILogger
        {
            void Log();
        }
        class DatabaseLogger : ILogger
        {
            public void Log()
            {
               Console.WriteLine("Logged to database");
            }
        }
        class FileLogger : ILogger
        {
            public void Log()
            {
                Console.WriteLine("Logged to file");
            }
        }
        class EmployeeManager
        {
            private ILogger _logger;
            public EmployeeManager(ILogger logger)
            {
                _logger = logger;
            }
            public void Prepare(ILogger logger)
            {
                _logger = logger;
            }
            public void Add()
            {
                _logger.Log();
                Console.WriteLine("Added!");
            }

        }
        class BaseClass
        {

        }
        class MyClass
        {

        }

    }
}
