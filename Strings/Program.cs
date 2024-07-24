using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Taha(); 
            string sentence = "My name is Taha";
            var result = sentence.Length;
            var result2 = sentence.IndexOf("name");
            var result3 = sentence.Insert(3, "Hello ");
            var result4 = sentence.Remove(3,4);
            var result5 = sentence.ToUpper();
            var result6 = sentence.Trim();
            bool result7 = sentence.StartsWith("M");
            var result8 = sentence.Substring(4,5);
            var result9 = sentence.Replace("name","adım");
            Console.WriteLine(result9);
            Console.ReadLine();
        }
        private static void Taha()
        {
            string city = "Istanbul";
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "Ankara";
            Console.WriteLine("{0}{1}", city, city2);
        }
    }
}
