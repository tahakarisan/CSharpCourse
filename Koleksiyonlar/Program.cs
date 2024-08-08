using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "Emre", "Taha", "Emir" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);


            List<string> isimler2 = new List<string>() { "Emre", "Taha", "Emir" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);

        }
    }
}
