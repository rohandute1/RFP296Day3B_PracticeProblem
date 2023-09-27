using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3B_Practice_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Day 3B Practice Problems");
            bool continueExecution = true;
            while (continueExecution)
            {
                Console.WriteLine("Please choose any one of the following program:");
                Console.WriteLine("1.Types of Constructor\n2.Interface Concept");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        // Using the default constructor
                        Person person1 = new Person();
                        Console.WriteLine("Default Constructor:");
                        person1.Display();

                        // Using the parameterized constructor
                        Person person2 = new Person("Ram", 25);
                        Console.WriteLine("\nParameterized Constructor:");
                        person2.Display();

                        // Using the copy constructor
                        Person person3 = new Person(person2);
                        Console.WriteLine("\nCopy Constructor:");
                        person3.Display();
                        break;

                    case 2:
                        Circle circle = new Circle(5);
                        Rectangle rectangle = new Rectangle(4, 6);

                        Console.WriteLine($"Circle - Area: {circle.CalculateArea()}, Perimeter: {circle.CalculatePerimeter()}");
                        Console.WriteLine($"Rectangle - Area: {rectangle.CalculateArea()}, Perimeter: {rectangle.CalculatePerimeter()}");
                        break;

                    default:
                        Console.WriteLine("Invalid option, Please select a valid program.");
                        break;
                }

                Console.WriteLine("Do you want to continue?(yes or no)");
                string userInput = Console.ReadLine().ToLower();
                if (userInput != "yes")
                {
                    continueExecution = false;
                }
            }

            Console.ReadLine();
        }
    }
}
