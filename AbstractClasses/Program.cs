using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)//override abstract ve virtuallar içn kullanılır virtual ve abstract bir şeyin özelleşmesini sağlar
        {
            Database database = new SqlServer();
            Database database2 = new Oracle();
            database.Add();
            database2.Add();                                   
            database.Update();
            database2.Update();
            Console.ReadLine();
        }

        abstract class Database
        {
            public virtual void Add()
            {
                Console.WriteLine("Added by default");
            }
            public abstract void Update();
          

        }
        class SqlServer:Database
        {
            public override void Update()
            {
                Console.WriteLine("Updated by SqlServeR");
            }
        }
        class Oracle : Database
        {
            public override void Add()
            {
                Console.WriteLine("Added by Oracle");
            }
            public override void Update()
            {
                Console.WriteLine("Updated by Oracle");
            }
        }
    }

}
