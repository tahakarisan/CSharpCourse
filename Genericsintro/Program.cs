using System;

namespace Genericsintro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Taha");
            isimler.Add("Emre");
            Console.WriteLine(isimler.Length);
            Console.ReadLine();
           
        }
    }
}
