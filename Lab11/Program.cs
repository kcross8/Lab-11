using System;
using System.Collections.Generic;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            Student one = new Student("Davos", "1639", "Cool", 1944, 200.00) { };
            Student two = new Student("Stannis", "1423", "Not Cool", 1931, 205.50) { };
            Student three = new Student("Mel", "631", "Red", 1953, 195.00) { };
            Staff four = new Staff("Arya", "444", "Winter School", 899.00) { };
            Staff five = new Staff("Bran", "213", "Tree School", 833.00) { };
            
            List<Person> People = new List<Person>();
            People.Add(one);
            People.Add(two);
            People.Add(three);
            People.Add(four);
            People.Add(five);

            foreach (Person people in People)
            {
                string hello = people.ToString();
                Console.WriteLine(hello);
            }
        }
    }
}
