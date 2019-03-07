using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
            string hello = "Hello";

            Console.WriteLine(hello + " World!");
            Console.ReadKey();
            //Challenge: Create two string variables one for first name, and one for last name. Using a interpolation write them to the console.
            string firstName = "Kenn";
            string lastName = "Pascascio";

            Console.WriteLine($"{hello} {firstName} {lastName}");
            Console.ReadKey();

            //Concatenation
            string greeting = hello + " " + firstName + " " + lastName;
            Console.WriteLine(greeting);
            Console.ReadKey();

            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();
            Console.WriteLine($"{hello}, {firstName} {lastName}. You are {age}");

            //Console.WriteLine("Hello, what is your first name?");
            //string firstName = Console.ReadLine();

            //Console.WriteLine("What is your last name?");
            //string lastName = Console.ReadLine();

            //Console.WriteLine("What is your age?");
            //int age = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Hello,{firstName} {lastName}, you are a {age}.");

            //Console.WriteLine("Hello " + firstName + " " + lastName + " " + age);
            //Console.ReadLine();
        }
    }
}
