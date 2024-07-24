using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InterfaceIntro();
            //demo();
            //customermanager customermanager = new customermanager();
            //customermanager.add(new sqlserverdal());
            ICustomerDal[] customerDals = new ICustomerDal[1]
            {
                new SqlServerDal(),
                
            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
            Console.ReadLine();
        }

        private static void demo()
        {
            ICustomerDal customerDal = new SqlServerDal();
            customerDal.Add();
        }

        private static void InterfaceIntro()
        {
            PersonManager manager = new PersonManager();

            Student student = new Student
            {
                Id = 1,
                FirstName = "Taha",
                LastName = "Karışan",
                Tc = 12345678910

            };
            Customer customer = new Customer
            {
                Id = 2,
                FirstName = "Mahmut",
                LastName = "Karışan",
                Tc = 131415161718
            };
            manager.Add(student);
            manager.Add(customer);
        }

        interface IPerson
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }
            long Tc { get; set; }
        }
        class Customer : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public long Tc { get; set; }
        }
        class Student : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public long Tc { get; set; }
        }
        class PersonManager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName);
            }
        }

    }
}
