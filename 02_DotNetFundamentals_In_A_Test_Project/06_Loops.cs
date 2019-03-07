using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_DotNetFundamentals_In_A_Test_Project
{
    [TestClass]
    public class _06_Loops
    {
        [TestMethod]
        public void Inception()
        {
            string greeting = "Mele Kalikimaka";

            //1 Starting Point
            //2 While true, keep looping
            //3 What to do after each loop

            //for //1       //2               //3
            for (int i = 1; i <= greeting.Length; i++)
            {
                Console.WriteLine(i);
            }

            string mountain = "Mauna Kea";

            for(int i = 1; i<=mountain.Length; i++)
            {
                Console.WriteLine(i);
            }

            //1 Collection being worked on 
            //2 Name of the current type that is being looked at in the collection
            //3 Current type in the collection
            //4 in keyword to show what the item is contained in
            
            //foreach //3 //2  //4 //1
            foreach (char letter in mountain)
            {
                Console.WriteLine($"{letter}");
            }

            int input = 1;
            while(input != 5)
            {
                Console.WriteLine(input);
                input++;
            }
        }

        public void Loop_Example()
        {
            //Do this example with the calculator
            string response = "n";
            while (response != "y")
            {
                Console.WriteLine("What's your name?");
                string name = Console.ReadLine();
                Console.WriteLine($"Hello {name}.");

                Console.WriteLine("Do you want to keep your name? (y/n)");
                response = "n";
            }
        }
    }
}
