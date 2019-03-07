using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_DotNetFundamentals_In_A_Test_Project
{
    [TestClass]
    public class _05_Switches_And_Enums
    {
        [TestMethod]
        public void Switches()
        {
            int intput = 2;

            switch (intput)
            {
                case 1:
                    Console.WriteLine("case 1");
                    break;
                case 2:
                    Console.WriteLine("case 2");
                    break;
                default:
                    Console.WriteLine("Same as da else");
                    break;
            }

            string input = "yes";

            switch (input)
            {
                case "yes":
                    Console.WriteLine("Hello");
                    break;
                case "no":
                    Console.WriteLine("GoodBye");
                    break;
            }
        }

        public enum GenderType
        {
            Male, Female, Other, bird, spam
        }

        [TestMethod]
        public void Switching_Through_AEnum()
        {
            int intput = 2;
            switch (intput)
            {
                case 1:
                    Console.WriteLine(GenderType.Female);
                    break;
                case 2:
                    Console.WriteLine(GenderType.Other);
                    break;
                case 0:
                    Console.WriteLine(GenderType.Male);
                    break;
            }

            GenderType gender = GenderType.Other;
            switch (gender)
            {
                case GenderType.Male:
                    Console.WriteLine("Lunch was good, I want more");
                    if(intput == 2)
                    {
                        Console.WriteLine(2+2);
                    }
                    break;
                case GenderType.Female:
                    Console.WriteLine("I am full");
                    break;
                default:
                case GenderType.Other:
                    Console.WriteLine(2);
                    break;
            }
        }

        //2. Write a switch case that asks the user if they are wearing clothes or some other question
        [TestMethod]
        public void SwitchChallenge()
        {
            string input = "y";
            switch (input)
            {
                case "y":
                    Console.WriteLine("Thank you");
                    break;
                case "n":
                    Console.WriteLine("Put something on");
                    break;
                default:
                    Console.WriteLine("What are you wearing");
                    break;
            }
        }
    }
}
