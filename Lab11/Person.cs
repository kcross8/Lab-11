using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11
{
    class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public Person(string Name, string Address)
        {
            this.Name = Name;
            this.Address = Address;
        }
        public Person() { }

        public override string ToString()
        {
            string print = $"{Name}, {Address}";
            return print;
        }
    }
}
