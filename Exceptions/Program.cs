using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Find();
            
            try
            {
                Record();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            Console.ReadLine();
        }

        private static void Record()
        {
            string[] customers = new string[3] { "TAHA", "EMRE", "EMİR" };
            if (!customers.Contains("Ahmet"))
            {
                throw new RecordNotFoundException("Record not found");
            }
            else
            {
                Console.Write("Record Found");
            }
            
        }

        private static void Find()
        {
            try
            {
                string[] students = new string[3] { "TAHA", "EMRE", "EMİR" };
                students[3] = "Ahmet";
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception");
            }
            Console.ReadLine();
        }
    }
}