using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11
{
    class Student : Person
    {
        public string Program { get; set; }
        public int Year { get; set; }
        public double Fee { get; set; }

        public Student(string Name, string Address, string Program, int Year, double Fee) : base(Name, Address)
        {
            this.Program = Program;
            this.Year = Year;
            this.Fee = Fee;
        }
        public Student() { }

        public override string ToString()
        {
            string print = $"{Name}, {Address}, {Program}, {Year}, {Fee}";
            return print;
        }
    }
}
