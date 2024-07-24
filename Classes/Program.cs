using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                City = "İstanbul",
                TC = 1223214234242,
                FirstName = "Taha",
                LastName = "Karışan"
            };
            Console.WriteLine("Fatura Bilgileri");
            Console.WriteLine("Adı: " + customer.FirstName);
            Console.WriteLine("Soyadı: " + customer.LastName);
            Console.WriteLine("Adres: " + customer.City);
            Console.WriteLine("TC: {0} ", customer.TC);
            if (customer.TC <= 0)
            {
                Console.WriteLine("TC: {0}", 1111111111);
            }
            else
            {
                Console.WriteLine("TC: {0}", customer.TC);
            }
            Console.WriteLine("----------------------------");


            ProductManager productManager = new ProductManager();
            productManager.ProductDelete();
            productManager.ProductAdd();
            CustomerManager customerManager = new CustomerManager();
            customerManager.CustomerDelete();
            customerManager.CustomerAdd();
            //Customer customer = new Customer
            //{
            //    City = "İstanbul",
            //    TC = 18209388312,
            //    FirstName = "Ömer",
            //    LastName = "Karışan"
            //};
            //Console.WriteLine(customer.FirstName);

            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
