using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
               new Category { CategoryId=1,CategoryName="Bilgisayar"},
               new Category { CategoryId=2,CategoryName="Telefon"}
            };
            List<Product> products = new List<Product>
            {
                new Product { ProductId=1,ProductName="Casper Laptop",Description="32gb Ram",CategoryId=1,UnitStock=5,Price=35000},
                new Product { ProductId=2,ProductName="Asus Laptop",Description="32gb Ram",CategoryId=1,UnitStock=6,Price=40000},
                new Product { ProductId=3,ProductName="Hp Laptop",Description="16gb Ram",CategoryId=1,UnitStock=7,Price=30000},
                new Product { ProductId=4,ProductName="Samsung Telefon",Description="6gb Ram",CategoryId=2,UnitStock=8,Price=20000},
                new Product { ProductId=5,ProductName="Apple Telefon",Description="6gb Ram",CategoryId=2,UnitStock=9,Price=40000}
            };
            //AnyTest(products);
            //var result2 = products.Find(p => p.CategoryId ==1);
            //Console.WriteLine(result2.ProductName);
            //ÜrünListele(products);
            //Klasik(products);
            var result = from p in products
                         join c in categories
                         on p.CategoryId equals c.CategoryId
                         select new ProductDto { Price = p.Price, ProductId = p.ProductId, ProductName = p.ProductName, CategoryName = c.CategoryName };
            foreach (var productDto in result)
            {
                Console.WriteLine("{0}-----{1}",productDto.ProductName,productDto.CategoryName);
            }

            Console.ReadLine();
        }

        private static void Klasik(List<Product> products)
        {
            var result = from p in products
                         where p.Price == 35000
                         select new ProductDto { ProductName = p.ProductName, ProductId = p.ProductId, Price = p.Price };
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);
            }
        }

        private static void ÜrünListele(List<Product> products)
        {
            var result = products.Where(p => p.ProductName.Contains("Laptop")).OrderByDescending(p => p.Price).ThenBy(p => p.ProductName);
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);
            }
        }

        private static void AnyTest(List<Product> products)
        {
            var result = products.Any(p => p.ProductName == "Acer Laptop");
            Console.WriteLine(result);
        }
    }
    class ProductDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string CategoryName { get; set; }

    }
    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int UnitStock { get; set; }
    }
    class Category
    {
        public int CategoryId { get; set; }
        public string  CategoryName { get; set; }
    }
}
