using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Customer
    {
        private string _firstName;
        private long _tc;

        public long TC
        {
            get
            {
                if (_tc == 0)
                {
                    return 111;
                }
                return _tc;
            }
            set
            {
                _tc = value;
            }
        }
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                if (value.Length <= 0)
                {
                    Console.WriteLine("FirstName değeri boştur");
                }
                _firstName = value;
            }
        }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
