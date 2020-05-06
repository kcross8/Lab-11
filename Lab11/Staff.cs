using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11
{
    class Staff : Person
    {
        public string School { get; set; }
        public double Pay { get; set; }

        public Staff(string Name, string Address, string School, double Pay) : base(Name, Address)
        {
            this.School = School;
            this.Pay = Pay;
        }
        public Staff() { }

        public override string ToString()
        {
            string print = $"{Name}, {Address}, {School}, {Pay}";
            return print;
        }
    }
}
