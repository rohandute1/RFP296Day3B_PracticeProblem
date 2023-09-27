using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3B_Practice_Problem
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // Default Constructor
        public Person()
        {
            Name = "Ganesh";
            Age = 30;
        }

        // Parameterized Constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Copy Constructor
        public Person(Person otherPerson)
        {
            Name = otherPerson.Name;
            Age = otherPerson.Age;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}
