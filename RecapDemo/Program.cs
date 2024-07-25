using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new FileLogger();
            ILogger logger2 = new JSONLogger();
            ILogger logger3 = new DatabaseLogger();

            logger.Add();
            logger2.Add();
            logger3.Add();
            Console.ReadLine();
            Console.ReadLine();
        }

    }
    interface ILogger
    {
        void Add();
    }
    class FileLogger : ILogger
    {
        public void Add()
        {
            Console.WriteLine("Added to file");
        }
    }

    class JSONLogger : ILogger
    {
        public void Add()
        {
            Console.WriteLine("Added to json");
        }
    }
    class DatabaseLogger : ILogger
    {
        public void Add()
        {
            Console.WriteLine("Added to Database");
        }
    }
}
