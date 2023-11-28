using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList1
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void ToString()
        {
            Console.Write("Name: " + Name+" ");
            Console.WriteLine("Age: " + Age);
        }
    }
}
