using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MySql mySql = new MySql();
            mySql.Update();
            SqlServer sqlServer = new SqlServer();
            sqlServer.Update();
            Console.ReadLine();
        }

        class Database
        {
            public void Add()
            {
                Console.WriteLine("Added by default");

            }
            public virtual void Update()
            {
                Console.WriteLine("Updated by default");
            }
        }
        class SqlServer : Database
        {
            public override void Update()
            {
                Console.WriteLine("Updated by SqlServer");
            }
        }

        class MySql : Database
        {

        }
    }
}
