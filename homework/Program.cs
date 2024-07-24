using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager 
            {
              Color = "White",
              Price = 2130,
              Name =  "Nike Air Force N190537",
              Description =  "Orijinal Nike beyaz sneakers ayakkabı,iade yoktur"
           
            };
            Console.WriteLine("Name: "+productManager.Name);
            Console.WriteLine("Color: "+productManager.Color);
            Console.WriteLine("Price: "+ productManager.Price);
            Console.WriteLine("Description: "+productManager.Description);

            Console.ReadLine();
        }

    }
    class ProductManager
    {
        public int Price { get; set; }
        public string Color { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
    
}
