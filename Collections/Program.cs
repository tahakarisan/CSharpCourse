using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CityList();
            //List();
            Dictionary<string,string> dictionary = new Dictionary<string,string>();
            dictionary.Add("chair", "sandalye");
            dictionary.Add("table", "masa");
            dictionary.Add("book", "kitap");
            Console.WriteLine(dictionary["table"]);
            Console.WriteLine("--------------------");
            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Value);
                Console.WriteLine("--------------------");
            }
            Console.ReadLine();
        }

        private static void List()
        {
            List<Customer> customers = new List<Customer>();

            customers.Add(new Customer { Id = 1, Name = "Taha" });
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Name);
            }
            var customer1 = new Customer
            {
                Id = 1,
                Name = "Emre"
            };
            customers.Add(customer1);
            customers.Add(customer1);
            customers.Add(customer1);
            customers.Add(customer1);
            customers.AddRange(new Customer[2]);
            {
                new Customer { Id = 8, Name = "Fatih" };
                new Customer { Id = 9, Name = "Emir" };
            }
            customers.Remove(customer1);
            customers.Remove(customer1);
            customers.Remove(customer1);
            customers.Remove(customer1);
            customers.Remove(customer1);
            Console.WriteLine(customers.Count);
            Console.WriteLine(customers.Contains(new Customer()));
        }

        private static void CityList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            Console.ReadLine();
        }
    }
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}