using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[3]
            {
                new Product{Id=1, CategoryId=10 , Name="Ayakkabı", Price=1000 },
                new Product{Id=2, CategoryId=9 , Name="Tshirt", Price=350 },
                new Product{Id=3, CategoryId=8 , Name="Saat", Price=1200 },
            };

            foreach (var product in products)
            {
                Console.WriteLine("ID: " + product.Id + "||" + "CATEGORYID: " + product.CategoryId + "||" + "NAME: " + product.Name + "||" + "PRICE: " + product.Price);
                Console.WriteLine("------------------------------------------------------------------------------|");
            }
            //for (int i = 0; i < products.Length; i++)
            //{
            //    Console.WriteLine("Name: " + products[i].Name + "||" + "Id: " + products[i].Id + "||" + "Price: " + products[i].Price + "||" + "CategoryId " + products[i].CategoryId);
            //    Console.WriteLine("-------------------------------------");
            //}
            Console.ReadLine();
        }
    }
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }

        public int Price { get; set; }

    }
}
