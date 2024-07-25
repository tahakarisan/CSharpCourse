using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertitance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[1]
            {
                new Student{FirstName="Taha", LastName= "Karışan", SchoolNumber=10}
            };
  
            foreach (var student in students)
            {
                Console.WriteLine(student.FirstName);
                Console.WriteLine(student.LastName);
                Console.WriteLine(student.SchoolNumber);               
                
            }
            Person[] persons = new Person[2]
            {
                new Student{FirstName="Taha",SchoolNumber=10},
                new Customer{FirstName="Ömer"}

            };
            foreach (Person person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
            Console.ReadKey();
        }
        
        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
        class Student : Person
        {
            public int SchoolNumber { get; set; }
        }
        class Customer : Person
        {

        }
    }
}
